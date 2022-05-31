using HamsterWars.Server.DataBase;
using HamsterWars.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HamsterWars.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class HamsterGalleryController : ControllerBase
    {
        private readonly HamsterDBContext context;

        public HamsterGalleryController(HamsterDBContext context)
        {
            this.context = context;
        }


        // GET: api/<HamsterController>
        [HttpGet("hamsters")]
        [MapToApiVersion("1.0")]
        public async Task<ActionResult<IEnumerable<Hamster>>> Get()
        {
            List<Hamster> hamsters = await context.Hamsters.ToListAsync();
            if (hamsters.Count > 0)
                return Ok(hamsters);
            else
                return NotFound("No Hamsters Found");
           
               
        }
        [HttpGet("hamsters/random")]
        [MapToApiVersion("1.0")]
        public async Task<ActionResult<Hamster>> GetRandom()
        {
            List<Hamster> hamsters = await context.Hamsters.ToListAsync();
            if (hamsters.Count > 0)
            {
                Random random = new Random();
                return Ok(hamsters[random.Next(0, hamsters.Count())]);
            }
            else return NotFound("No Hamsters Found");
        }

        // GET api/<HamsterController>/5
        [HttpGet("hamsters/{id}")]
        [MapToApiVersion("1.0")]
        public async Task<ActionResult<Hamster>> GetOne(int id)
        {
            try
            {
                Hamster hamster = await context.Hamsters.FindAsync(id);
                if (hamster == null) return NotFound("No Hamster Found!");
                return Ok(hamster);
            }
            catch (Exception ex)
            {
               return BadRequest(ex.Message + "Fann inte objektet");
            }
        }

        // POST api/<HamsterController>
        [HttpPost]
        [MapToApiVersion("1.0")]
        public async Task<ActionResult<List<Hamster>>> AddHamster([FromBody] Hamster hamster)
        {
            try
            {
                context.Add(hamster);
                context.SaveChanges();
                return Created("HamsterGallery", hamster);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + "Somthing Wrong!");
            }
        }

        // PUT api/<HamsterController>/5
        [HttpPut("hamsters/{id}")]
        [MapToApiVersion("1.0")]
        public async Task<ActionResult<List<Hamster>>> UpdateHamster(int Id, [FromBody] Hamster request)
        {
            try
            {
                var findHamster = context.Hamsters.Find(request.Id);
                //var findHamsterA = context.Hamsters.Find(x => x.id == Id);
                if (findHamster == null)
                    return BadRequest("Hamster not found");
                findHamster.Name = request.Name;
                findHamster.Age = request.Age;
                findHamster.Loves = request.Loves;
                findHamster.Games = request.Games;
                findHamster.Wins = request.Wins;
                findHamster.Losses = request.Losses;
                context.Update(findHamster);
                context.SaveChanges();
                return Accepted(request);
            }
            catch(Exception ex)
            {
                return BadRequest("Gick inte att uppdatera!" + ex.Message);
            }
        }

        // DELETE api/<HamsterController>/5
        [HttpDelete("hamsters/{id}")]
        [MapToApiVersion("1.0")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                Hamster hamster = context.Hamsters.Find(id);
                if (hamster != null)
                {
                    context.Hamsters.Remove(hamster);
                    await context.SaveChangesAsync();
                    return Ok();
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
