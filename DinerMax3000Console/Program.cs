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
            summerMenu.AddMenuItem("Salmon", "Fresh Norweigan Salmon with Sandefjord butter.", 25.50);
            summerMenu.AddMenuItem("Taco", "All Norweigans eat taco on Fridays", 10);

           
        }
    }
}
