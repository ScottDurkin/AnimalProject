using AnimalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnimalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        [HttpGet]
        public IActionResult Dogs()
        {
            List<DogObj> dogs = new List<DogObj>
            {
                new DogObj
                {
                    Name = "Buddy",
                    Breed = "Golden Retriever",
                    Age = 3,
                    Color = "Golden",
                    Weight = 70.5,
                    IsFriendly = true
                },
                new DogObj
                {
                    Name = "Max",
                    Breed = "Labrador Retriever",
                    Age = 2,
                    Color = "Black",
                    Weight = 65.0,
                    IsFriendly = true
                },
                new DogObj
                {
                    Name = "Rocky",
                    Breed = "German Shepherd",
                    Age = 4,
                    Color = "Sable",
                    Weight = 80.2,
                    IsFriendly = false
                },
                new DogObj
                {
                    Name = "Lucy",
                    Breed = "Beagle",
                    Age = 5,
                    Color = "Tricolor",
                    Weight = 25.5,
                    IsFriendly = true
                },
                new DogObj
                {
                    Name = "Daisy",
                    Breed = "Dachshund",
                    Age = 2,
                    Color = "Red",
                    Weight = 12.8,
                    IsFriendly = true
                },
                new DogObj
                {
                    Name = "Bailey",
                    Breed = "Poodle",
                    Age = 6,
                    Color = "White",
                    Weight = 45.7,
                    IsFriendly = true
                },
                new DogObj
                {
                    Name = "Rex",
                    Breed = "Bulldog",
                    Age = 4,
                    Color = "Fawn",
                    Weight = 55.0,
                    IsFriendly = false
                },
                new DogObj
                {
                    Name = "Luna",
                    Breed = "Rottweiler",
                    Age = 3,
                    Color = "Black and Tan",
                    Weight = 90.9,
                    IsFriendly = false
                },
                new DogObj
                {
                    Name = "Charlie",
                    Breed = "Boxer",
                    Age = 2,
                    Color = "Brindle",
                    Weight = 70.0,
                    IsFriendly = true
                },
                new DogObj
                {
                    Name = "Molly",
                    Breed = "Yorkshire Terrier",
                    Age = 7,
                    Color = "Blue and Tan",
                    Weight = 5.5,
                    IsFriendly = true
                }
            };
            return new JsonResult(dogs);
        }
    }
}
