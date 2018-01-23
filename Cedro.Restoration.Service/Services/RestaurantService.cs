using Cedro.Restoration.Data.Models;
using Cedro.Restoration.Repo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cedro.Restoration.Service.Services
{
    public class RestaurantService : IRestaurantService
    {
        private IRepository<Restaurant> restaurantRepository;
        private IRepository<Menu> menuRepository;

        public RestaurantService(IRepository<Restaurant> restaurantRepository, IRepository<Menu> menuRepository)
        {
            this.restaurantRepository = restaurantRepository;
            this.menuRepository = menuRepository;
        }

        public void DeleteRestaurant(int id)
        {
            var restaurant = restaurantRepository.Get(id);
            restaurantRepository.Delete(restaurant);
        }

        public Restaurant GetRestaurant(int id)
        {
            var restaurant = restaurantRepository.Get(id);
            var menus = menuRepository.GetAll();
            foreach(var menu in menus)
            {
                if(menu.RestaurantId == id)
                {
                    restaurant.Menus.Add(menu);
                }
            }
            return restaurant;
        }

        public IEnumerable<Restaurant> GetRestaurants()
        {
            return restaurantRepository.GetAll();
        }

        public IEnumerable<Restaurant> GetRestaurants(string name)
        {
            return restaurantRepository.GetAll(n => n.Name.ToLower().Contains(name.ToLower()));
        }

        public void InsertRestaurant(Restaurant restaurant)
        {
            restaurantRepository.Insert(restaurant);
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            restaurantRepository.Update(restaurant);
        }
    }
}
