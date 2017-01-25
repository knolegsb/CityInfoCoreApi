using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CityInfoCoreApi.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        [HttpGet()]
        public JsonResult GetCities()
        {
            //return new JsonResult(new List<object>()
            //{
            //    new { Id = 1, Name="New York City"},
            //    new { Id = 2, Name="Antwerp"}
            //});

            return new JsonResult(CitiesDataStore.Current.Cities);
        }
    }
}
