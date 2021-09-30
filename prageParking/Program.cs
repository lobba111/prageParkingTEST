using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace prageParking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parking = new string[100];
            //var parkingstring = new Parking();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("Hi! And Welcome to Prague parking assistance!");
            Console.WriteLine("How can i be of service?");
            Console.WriteLine("1) Park a vehicle");
            Console.WriteLine("2) Relocate vehicles");
            Console.WriteLine("3) Search for a vehicle by registration number");
            Console.WriteLine("Q) Quit");
            Console.WriteLine("Make a selection:");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        ParkVehicle();
                        return true;
                    }
                case "2":
                    {
                        RelocateVehicle();
                        return true;
                    }
                case "3":
                    {
                        SearchVehicle();
                        return true;
                    }
                case "Q":
                    {
                        Console.WriteLine("Thanks for using Prague parking assistance");
                        Console.WriteLine("Have a nice day!");
                        return false;
                    }
                case "q":
                    {
                        Console.WriteLine("Thanks for using Prague parking assistance");
                        Console.WriteLine("Have a nice day!");
                        return false;
                    }
                default:
                    {
                        return true;
                    }
                    
            }
        }

        private static void ParkVehicle()
        {
            
            Console.WriteLine("What type of vehicle do you want to park?");
            string answer = Console.ReadLine().ToLower();
            string car = "car";
            string mc = "mc";
            string mccar = car + mc;
            string regNumberCar;                                                          
            string regNumberMc;
            if (answer == car)
            {
                Console.WriteLine("Skriv in registeringsnummer på ditt fordon");
                regNumberCar = Console.ReadLine();
                int lenght = regNumberCar.Length;
                int compare = 10;
                CompareLenghtOnString(lenght, compare);
                Parking(regNumberCar);
                

            }
            if (answer == mc)
            {
                Console.WriteLine("Skriv in registeringsnummer på ditt fordon");
                regNumberMc = Console.ReadLine();
                int lenght = regNumberMc.Length;
                int compare = 10;
                CompareLenghtOnString(lenght, compare);
                Parking(regNumberMc);

            }
            while (answer != mccar )
            {
                MainMenu();
            }
     
                Console.WriteLine("Har du Parkerat klart?(y/n)");
                string answer1 = Console.ReadLine().ToLower() ;
                string yes = "y";
                string no = "n";
                if(answer1 == yes)
                {
                    MainMenu();
                }
                while (answer1 == no)
                {
                    ParkVehicle();
                break;
                    

                }
                

            
        }

        private static void Parking(string regNumberCar)
        {
            string[] parking = regNumberCar.Split('#');
            //string[] parking = regNumberMc.Split('#');
            //Array.Sort(parking);


        }

        private static void CompareLenghtOnString(int lenght, int compare)
        {
            if (lenght > compare)
            {
                Console.WriteLine("YAAA BLYAT IDIOT TOO MANY CHARACTERS!(max 10 chars)");
            }
        }

        private static void RelocateVehicle()
        {
            throw new NotImplementedException();
        }

        private static void SearchVehicle()
        {
            throw new NotImplementedException();
        }
    }

    /*internal class Parking
    {
        public Parking()
        {
            string[] parking = new string[100];
            
        }
    }*/
}
