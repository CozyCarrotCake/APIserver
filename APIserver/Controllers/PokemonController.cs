using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIserver.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        public static List<Pokemon> pokeman = new List<Pokemon>()
        {
            new Pokemon() {Name = "Ekans", Strength = 27},
            new Pokemon() {Name = "Bulbasaur", Strength = 30},
            new Pokemon() {Name = "Sandshrew", Strength = 1000}
        };





        [HttpGet] //get-metod
        public ActionResult<Pokemon> MyPerfectGet()
        {

            /*Pokemon p = new Pokemon();
            p.Name = "Ekans";
            p.Strength = 27;*/


            return Ok(pokeman);
        }

        [HttpPost] //gör de till en post-metod
        public ActionResult AddNewPokemon(Pokemon newPokemon)
        {
            pokeman.Add(newPokemon);
            Console.WriteLine("Added " + newPokemon.Name);

            return Created("", newPokemon);



        }



    }
}




