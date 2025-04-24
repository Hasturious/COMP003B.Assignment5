using COMP003B.Assignment5.Data;
using COMP003B.Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZooController : ControllerBase
    {
        //Retrieve aniamls
        [HttpGet]
        public ActionResult<List<ZooAnimal>> GetAllAnimals()
        {
            return Ok(AnimalList.Animals);
        }
        //Get a specific animal
        [HttpGet("{id}")]
        public ActionResult<ZooAnimal> GetAnimalById(int id)
        {
            var animal = AnimalList.Animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
            {
                return NotFound();
            }
            return Ok(animal);
        }
        //Add a new animal to the zoo
        [HttpPost]
        public ActionResult<ZooAnimal> CreateAnimal(ZooAnimal newAnimal)
        {
            AnimalList.Animals.Add(newAnimal);

            return CreatedAtAction(nameof(GetAnimalById), new { id = newAnimal.Id }, newAnimal);
        }

        //Update current animal
        [HttpPut("{id}")]
        public ActionResult UpdateAnimal(int id, ZooAnimal updatedAnimal)
        {
            var existingAnimal = AnimalList.Animals.FirstOrDefault(a => a.Id == id);
            if (existingAnimal == null)
            {
                return NotFound();
            }

            existingAnimal.Name = updatedAnimal.Name;
            existingAnimal.Species = updatedAnimal.Species;
            existingAnimal.Age = updatedAnimal.Age;

            return NoContent();
        }

        //Rest in peace animal
        [HttpDelete("{id}")]
        public ActionResult DeleteAnimal(int id)
        {
            var animal = AnimalList.Animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
            {
                return NotFound();
            }

            AnimalList.Animals.Remove(animal);
            return NoContent();
        }
    }
}
