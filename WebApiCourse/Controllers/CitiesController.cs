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
           return new JsonResult(CitiesDataStore.Current.Cities);
        }
    }
}
