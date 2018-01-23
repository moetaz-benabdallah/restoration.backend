using System;
using System.Collections.Generic;
using System.Text;
using Cedro.Restoration.Data.Models;

namespace Cedro.Restoration.Service.Services
{
    public interface IMenuService
    {
        IEnumerable<Menu> GetMenus();
        Menu GetMenu(int id);
        void InsertMenu(Menu menu);
        void UpdateMenu(Menu menu);
        void DeleteMenu(int id);
    }
}
