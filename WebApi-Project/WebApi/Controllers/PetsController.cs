using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        public static List<Pet> Pets = new List<Pet>()
        {
            new Pet(){ Id = 1, Name = "Bailey", Type = "Dog", Breed = "Dachshund"},
            new Pet() { Id = 2, Name = "Mila", Type = "Cat", Breed = "Cymric"}
        };

        // GET: api/<PetsController>
        [HttpGet]
        public IEnumerable<Pet> Get()
        {
            return Pets;
        }

        // GET api/<PetsController>/5
        [HttpGet("{id}")]
        public Pet Get(int id)
        {
            return Pets.FirstOrDefault(x => x.Id == id);
        }

        // POST api/<PetsController>
        [HttpPost]
        public void Post([FromBody] ViewModelPet vmPet)
        {
            Pet pet = new Pet()
            {
                Id = Pets.Max(x => x.Id) + 1,
                Name = vmPet.Name,
                Type = vmPet.Type,
                Breed = vmPet.Breed
            };
            Pets.Add(pet);
        }

        // PUT api/<PetsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ViewModelPet vmPet)
        {
            Pet oldPet = Pets.FirstOrDefault(x => x.Id == id);
            int petIndex = Pets.IndexOf(oldPet);
            if (oldPet != null)
            {
                oldPet.Breed = vmPet.Breed;
                oldPet.Name = vmPet.Name;
                oldPet.Type = vmPet.Type;

                Pets.Remove(oldPet);
                Pets.Insert(petIndex, oldPet);
            }
        }

        // DELETE api/<PetsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Pet pet = Pets.FirstOrDefault(x => x.Id == id);
            if (pet != null)
            {
                Pets.Remove(pet);
            }
        }
    }
}
