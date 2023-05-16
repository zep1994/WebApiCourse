using Microsoft.AspNetCore.Mvc;

namespace WebApiCourse.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
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
