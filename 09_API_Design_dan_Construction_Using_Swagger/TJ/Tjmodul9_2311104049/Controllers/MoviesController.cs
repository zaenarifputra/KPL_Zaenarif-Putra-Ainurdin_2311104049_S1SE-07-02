using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Tjmodul9_2311104049.Controllers;
using Tjmodul9_2311104049.Models;

namespace Tjmodul9_2311104049.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        // Ini harus dideklarasikan sebagai list!
        private static List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                Title = "Dune: Part Two",
                Director = "Denis Villeneuve",
                Stars = new List<string> { "Timothée Chalamet", "Zendaya", "Rebecca Ferguson" },
                Description = "Paul Atreides unites with the Fremen while on a warpath of revenge against the conspirators who destroyed his family. " +
                              "\nFacing a choice between the love of his life and the fate of the universe, he endeavors to prevent a terrible future."
            },
            new Movie
            {
                Title = "Maharaja",
                Director = "Nithilan Saminathan",
                Stars = new List<string> { "Vijay Sethupathi", "Anurag Kashyap", "Mamta Mohandas" },
                Description = "A barber seeks vengeance after his home is burglarized, cryptically telling police his \"lakshmi\" has been taken, \n" +
                              "leaving them uncertain if it's a person or object. His quest to recover the elusive \"lakshmi\" unfolds."
            },
            new Movie
            {
                Title = "Ainda Estou Aqui",
                Director = "Walter Salles",
                Stars = new List<string> { "Fernanda Torres", "Fernanda Montenegro", "Selton Mello" },
                Description = "A woman married to a former politician during the military dictatorship in Brazil is " +
                              "\nforced to reinvent herself and chart a new course for her family after a violent and arbitrary act."
            }
        };

        [HttpGet]
        public ActionResult<List<Movie>> GetAll()
        {
            return Movies;
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> GetById(int id)
        {
            if (id < 0 || id >= Movies.Count)
                return NotFound();
            return Movies[id];
        }

        [HttpPost]
        public ActionResult AddMovie([FromBody] Movie newMovie)
        {
            Movies.Add(newMovie);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteMovie(int id)
        {
            if (id < 0 || id >= Movies.Count)
                return NotFound();

            Movies.RemoveAt(id);
            return Ok();
        }
    }
}