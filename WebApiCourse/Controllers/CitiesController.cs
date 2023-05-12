using Microsoft.AspNetCore.Mvc;

namespace WebApiCourse.Controllers
{
    public class CitiesController : ControllerBase
    {
        public JsonResult GetCities()
        {
           return new JsonResult(
                new List<object>
                {
                    new { id = 1, name = "Tom" },
                    new { id = 2, name = "Jim"}
                });
        }
    }
}
