using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cedro.Restoration.Data.Models;
using Cedro.Restoration.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cedro.Restoration.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/menus")]
    public class MenuController : Controller
    {
        private readonly IMenuService menuService;

        public MenuController(IMenuService menuService)
        {
            this.menuService = menuService;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Menu> Get()
        {
            return menuService.GetMenus().ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Menu Get(int id)
        {
            return menuService.GetMenu(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Menu menu)
        {
            menuService.InsertMenu(menu);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Menu menu)
        {
            menuService.UpdateMenu(menu);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            menuService.DeleteMenu(id);
        }
    }
}
