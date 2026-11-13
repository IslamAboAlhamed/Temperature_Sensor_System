using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvent
{
    internal class Display
    {

        public void ShowTemprature(object obj , TempArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\t\t\t ===================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\t\t\t       CURRENT TEMPERATURE : ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{e.Temprature} °C");

        }
    }
}
