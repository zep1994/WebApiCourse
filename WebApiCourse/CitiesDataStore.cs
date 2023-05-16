using WebApiCourse.Models;

namespace WebApiCourse
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore() 
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Test",
                    Description = "Test"
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Test",
                    Description = "Test"
                }
            };
        }
    }
}
