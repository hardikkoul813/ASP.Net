using CityInfo.API.Models;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        // Singleton Instance
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        // Read-only List to prevent accidental modifications
        public List<CityDto> Cities { get; }

        // Private Constructor (Singleton Pattern)
        private CitiesDataStore()
        {
            Cities = new List<CityDto>
            {
                new CityDto
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park."
                },
                new CityDto
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished."
                },
                new CityDto
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower."
                }
            };
        }
    }
}
