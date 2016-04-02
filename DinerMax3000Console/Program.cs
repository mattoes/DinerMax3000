using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu summerMenu = new Menu();
            summerMenu.Name = "Summer Menu";
            MenuItem salmon = new MenuItem();
            salmon.Title = "Salmon";
            salmon.Description = "Fresh Norweigan Salmon with Sandefjord butter.";
            salmon.price = 25.50;
        }
    }
}
