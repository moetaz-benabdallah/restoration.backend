using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cedro.Restoration.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        public virtual ICollection<Menu> Menus { get; set; }
    }
}
