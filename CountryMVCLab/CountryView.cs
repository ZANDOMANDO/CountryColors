using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountryMVCLab
{
    public class CountryView
    {
        public CountryView(Country displayCountry)
        {
            DisplayCountry = displayCountry;
        }

        public Country DisplayCountry { get; set; }
        public void Display()
        {
            string color = "";
            DisplayCountry.Colors.ForEach(x => color += x +", ");
            color = color.TrimEnd().TrimEnd(',');
            Console.WriteLine("\nName: " + DisplayCountry.Name);
            Console.WriteLine("Continent: " + DisplayCountry.Continent);
            Console.WriteLine("Colors: " + color);

            foreach (String x in DisplayCountry.Colors)
            {


                ConsoleColor consoleColor;
                if (Enum.TryParse<ConsoleColor>(x, out consoleColor))
                {
                    Console.ForegroundColor = consoleColor;
                    Console.WriteLine("/////");

                }
                else
                {
                    Console.WriteLine("You've entered invalid color!");
                }
                ConsoleColor currentBackground = Console.BackgroundColor;

                Console.ForegroundColor = Console.BackgroundColor;


            }







        }

    }
}
