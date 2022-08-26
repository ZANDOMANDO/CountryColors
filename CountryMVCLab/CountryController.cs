using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryMVCLab
{
    public class CountryController
    {
        public List<Country> CountryDb { get; set; } = new List<Country>()
        {
            new Country("Colombia",
                "South America",
                new List<string> {"Yellow", "Blue", "Red" }),
            new Country("Mexico",
                "North America",
                new List<string> {"Green", "White", "Red" }),
            new Country("USA",
                "North America",
                new List<string> {"Red", "White", "Blue" }),
             new Country("Spain",
                "Europe",
                new List<string> {"Red", "Yellow", "Red" }),
              new Country("Brazil",
                "South America",
                new List<string> {"Green", "Yellow", "Blue","Green" }),
                  new Country("Belize",
                "Central America",
                new List<string> {"Red", "Blue", "Red" })
        };

        public void CountryAction(Country c)
        {
            var country = new CountryView(c);
            country.Display();
            
        }

        public void WelcomeAction()
        {
            //int selection = GetSelection();

            bool loopChoice = true;

            while (loopChoice)
            {
                var country = new CountryListView(CountryDb);

                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:\n");
                country.Display();
                Console.WriteLine(); //Line spacing
                int selection = int.Parse(Console.ReadLine());

                CountryAction(CountryDb[selection - 1]);
                ConsoleColor currentBackground = Console.BackgroundColor;

                Console.WriteLine("\nWould you like to learn about another country? (y/n)");
                string loopInput = Console.ReadLine().ToLower();

                if (loopInput == "y")
                {
                    loopChoice = true;
                    Console.Clear();
                }
                else if (loopInput == "n")
                {
                    Console.WriteLine("\nAdios!");
                    loopChoice = false;
                }
                else
                {
                    Console.WriteLine("\nNot a valid choice! Starting over anyway...");
                    Thread.Sleep(2500);
                    Console.Clear();
                    loopChoice= true;
                }
            }
            
        }

 
    }
}
