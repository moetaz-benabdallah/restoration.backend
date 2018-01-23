using System;
using System.Collections.Generic;
using System.Text;
using Cedro.Restoration.Data.Models;
using Cedro.Restoration.Repo.Infrastructure;

namespace Cedro.Restoration.Service.Services
{

    public class MenuService : IMenuService
    {

        private IRepository<Menu> menuRepository;

        public MenuService(IRepository<Menu> menuRepository)
        {
            this.menuRepository = menuRepository;
        }

        public void DeleteMenu(int id)
        {
            var menu = menuRepository.Get(id);
            menuRepository.Delete(menu);
        }

        public Menu GetMenu(int id)
        {
            return menuRepository.Get(id);
        }

        public IEnumerable<Menu> GetMenus()
        {
            return menuRepository.GetAll();
        }

        public void InsertMenu(Menu menu)
        {
            menuRepository.Insert(menu);
        }

        public void UpdateMenu(Menu menu)
        {
            menuRepository.Update(menu);
        }
    }
}
