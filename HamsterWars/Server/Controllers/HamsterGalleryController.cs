using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HamsterWars.Server.DataBase;
using HamsterWars.Shared.Models;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace HamsterWars.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HamsterGalleryController : ControllerBase
    {
        private readonly HamsterDBContext context;

        public HamsterGalleryController(HamsterDBContext context)
        {
            this.context = context;
        }


        // GET: api/<HamsterController>
        [HttpGet("/api/hamsters")]
        public IActionResult GetAll()
        {
            Hamster [] hamsters = context.Hamsters.ToArray();
            
            if (hamsters.Length > 0)
            {
                string t = JsonConvert.SerializeObject(hamsters);
                return Ok(t);
            }
            else
                return BadRequest("No Hamsters was found");
        }
        [HttpGet("/hamsters/random")]
        public IEnumerable<string> GetRandom()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<HamsterController>/5
        [HttpGet("/hamsters/{id}")]
        public string GetOne(int id)
        {
            return "value";
        }

        // POST api/<HamsterController>
        [HttpPost]
        public async Task<ActionResult<List<Hamster>>> AddHamster([FromBody] Hamster hamster)
        {
            context.Add(hamster);
            return Ok(hamster);
        }

        // PUT api/<HamsterController>/5
        [HttpPut("/hamsters/{id}")]
        public async Task<ActionResult<List<Hamster>>> UpdateHamster(int Id, [FromBody] Hamster request)
        {

            //INTE KLAR
            var findHamster = context.Hamsters.Find(Id,request);
            //var findHamsterA = context.Hamsters.Find(x => x.id == Id);
            if (findHamster == null)
                return BadRequest("Hamster not found");
            findHamster.Name = request.Name;
            findHamster.Age = request.Age;
            findHamster.Loves = request.Loves;
            findHamster.Games = request.Games;
            findHamster.Wins = request.Wins;
            findHamster.Losses = request.Losses;

             return Ok(request);
        }

        // DELETE api/<HamsterController>/5
        [HttpDelete("/hamsters/{id}")]
        public void Delete(int id)
        {
        }
    }
}
