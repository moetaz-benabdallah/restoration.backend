using Cedro.Restoration.Data.Models;
using System.Collections.Generic;

namespace Cedro.Restoration.Service.Services
{
    public interface IRestaurantService
    {
        IEnumerable<Restaurant> GetRestaurants();
        IEnumerable<Restaurant> GetRestaurants(string name);
        Restaurant GetRestaurant(int id);
        void InsertRestaurant(Restaurant restaurant);
        void UpdateRestaurant(Restaurant restaurant);
        void DeleteRestaurant(int id);
    }
}
