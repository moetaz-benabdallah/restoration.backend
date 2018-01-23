using System.Collections.Generic;
using System.Linq;
using Cedro.Restoration.Data.Models;
using Cedro.Restoration.Service.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Cedro.Restoration.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/restaurants")]
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }

        [HttpGet]
        public List<Restaurant> Get()
        {
            return restaurantService.GetRestaurants().ToList();
        }

        [HttpGet("name/{name}", Name = "GetByName")]
        public List<Restaurant> GetByName(string name)
        {
            return restaurantService.GetRestaurants(name).ToList();
        }

        [HttpGet("{id}", Name = "Get")]
        public Restaurant Get(int id)
        {
            return restaurantService.GetRestaurant(id);
        }
        
        [HttpPost]
        public void Post([FromBody]Restaurant restaurant)
        {
            restaurantService.InsertRestaurant(restaurant);
        }
        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Restaurant restaurant)
        {
            restaurantService.UpdateRestaurant(restaurant);
        }
        
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            restaurantService.DeleteRestaurant(id);
        }
    }
}
