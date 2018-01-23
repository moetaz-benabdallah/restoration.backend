using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Cedro.Restoration.Data.Models
{
    public class Menu
    {
        public int Id { get; set; }

        [Required]
        public String Dish { get; set; }

        [Required]
        public float Price { get; set; }

        public int RestaurantId { get; set; }

        [JsonIgnore]
        public virtual Restaurant Restaurant { get; set; }
    }
}
