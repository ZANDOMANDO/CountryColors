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
            new Country("USA",
                "North America",
                new List<string> {"red", "White", "Blue" })
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

                Console.WriteLine("\nWould you like to learn about another country? (y/n)");
                string loopInput = Console.ReadLine().ToLower();

                if (loopInput == "y")
                {
                    loopChoice = true;
                    Console.Clear();
                }
                else if (loopInput == "n")
                {
                    Console.WriteLine("\nGoodbye!");
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

        //public int GetSelection()
        //{
        //    Console.WriteLine("Which country would you like to view? Enter 1-" + CountryDb.Count());
        //    return int.Parse(Console.ReadLine());
        //}

        //public void Welcome()
        //{
            

        //}
    }
}
