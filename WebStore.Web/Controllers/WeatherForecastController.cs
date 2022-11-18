using AutoMapper;
using Microsoft.AspNetCore.Mvc; 
using WebStore.Services.Interfaces; 
using WebStore.ViewModels.VM;

namespace WebStore.Web.Controllers;

[ApiController] 
[Produces("application/json")] 
[Route("weatherforecast")] 

public class WeatherForecastController : Controller 
{
        [HttpGet] 
        public IActionResult Get() 
        {
            string JsonData = "{ 'test': 'test' }";
            return Ok(JsonData);
        } 
}