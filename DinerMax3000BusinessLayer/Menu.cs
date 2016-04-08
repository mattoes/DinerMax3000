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


        public static List<Menu> GetAllMenus() 
        {
            MenuTableAdapter taMenu = new MenuTableAdapter();
            var dtMenu = taMenu.GetData();
            List<Menu> allMenus = new List<Menu>();
            foreach(dsDinerMax3000.MenuRow menuRow in )
        }

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
