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
            int selection = GetSelection();
            var country = new CountryView(CountryDb[selection -1]);
            country.Display();
        }

        public int GetSelection()
        {
            Console.WriteLine("Which dish would you like to view? Enter 1-" + CountryDb.Count);
            return int.Parse(Console.ReadLine());
        }

        public void Welcome()
        {
            

        }
    }
}
