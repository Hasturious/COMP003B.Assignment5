using COMP003B.Assignment5.Models;

namespace COMP003B.Assignment5.Data
{
    public class AnimalList
    {
        public static List<ZooAnimal> Animals { get; } = new List<ZooAnimal>
        {
            new ZooAnimal
            {
                Id = 1,
                Name = "Rosa",
                Species = "Sea Otter",
                Age = 15
            },
            new ZooAnimal
            {
                Id = 2,
                Name = "Tony",
                Species = "Tiger",
                Age = 8
            },
            new ZooAnimal
            {
                Id = 3,
                Name = "Rasmus",
                Species = "Owl",
                Age = 4
            }
        };
    }
}
