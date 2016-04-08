using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinerMax3000.Business.DSDinerMax3000TableAdapters;

namespace DinerMax3000.Business
{
    public class Menu
    {

        //Constructor
        public Menu()
        {
            items = new List<MenuItem>();
        }


        //public static List<Menu> GetAllMenus() 
        //{
        //    MenuTableAdapter taMenu = new MenuTableAdapter();
        //    MenuItemTableAdapter taMenuItem = new MenuItemTableAdapter;
        //    var dtMenu = taMenu.GetData();
        //    List<Menu> allMenus = new List<Menu>();
        //    foreach (DSDinerMax3000.MenuRow menuRow in dtMenu.Rows) 
        //    {
        //        Menu currentMenu = new Menu();
        //        currentMenu.Name = menuRow.Name;
        //        allMenus.Add(currentMenu);

        //        var dtMenuItems = taMenuItem.GetMenuItemsByMenuId(menuRow.MenuId);

        //    }
        //}

        //Method
        public void AddMenuItem(string ProductName, string Description, double Price)
        {
            MenuItem item = new MenuItem();
            item.ProductName = ProductName;
            item.Description = Description;
            item.price = Price;
            items.Add(item);
        }

        //Properties
        public string Name;
        public List<MenuItem> items;
    }
}
