using HamsterWars.Server.DataBase;
using HamsterWars.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace HamsterWars.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HamsterGalleryController : ControllerBase
    {
        private readonly HamsterDBContext context;

        public HamsterGalleryController(HamsterDBContext context)
        {
            this.context = context;
        }


        // GET: api/<HamsterController>
        [HttpGet("hamsters")]
        
        public IEnumerable<Hamster> Get()
        {
            List<Hamster> hamsters = context.Hamsters.ToList();              
                return hamsters;
           
               
        }
        [HttpGet("hamsters/random")]
        public Hamster GetRandom()
        {
            List<Hamster> hamsters = context.Hamsters.ToList();
            Random random = new Random();           
            return hamsters[random.Next(0, hamsters.Count())];
        }

        // GET api/<HamsterController>/5
        [HttpGet("hamsters/{id}")]
        public Hamster GetOne(int id)
        {
            Hamster hamster = context.Hamsters.Find(id);
            return hamster;
        }

        // POST api/<HamsterController>
        [HttpPost]
        public async Task<ActionResult<List<Hamster>>> AddHamster([FromBody] Hamster hamster)
        {
            context.Add(hamster);
            context.SaveChanges();
            return Ok(hamster);
        }

        // PUT api/<HamsterController>/5
        [HttpPut("hamsters/{id}")]
        public async Task<ActionResult<List<Hamster>>> UpdateHamster(int Id, [FromBody] Hamster request)
        {

            //INTE KLAR
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
             return Ok(request);
        }

        // DELETE api/<HamsterController>/5
        [HttpDelete("hamsters/{id}")]
        public void Delete(int id)
        {
            Hamster hamster = context.Hamsters.Find(id);
            if (hamster != null)
            {
                context.Hamsters.Remove(hamster);
                context.SaveChanges();
            }
        }
    }
}
