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
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer Menu";
            summerMenu.AddMenuItem("Salmon", "Fresh Norweigan Salmon with Sandefjord butter.", 25.50);
            summerMenu.AddMenuItem("Taco", "All Norweigans eat taco on Fridays", 10);
            summerMenu.HospitalDirections = "Right around the corner";


            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code.";
            outsideDrinks.AddMenuItem("Virgin Cuba Libre", "A classic", 10);
            outsideDrinks.AddMenuItem("Screwdriver", "Makes you hammered.", 15);


            Order hungryGuestOrder = new Order();

            

           
        }
    }
}
