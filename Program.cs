using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static DelegatesAndEvent.Program;


namespace DelegatesAndEvent
{
    //delegate T del<T> (T x , T y);
    delegate T  delString<T>(T  x , T  y);
    internal class Program
    {

        static void Main(string[] args)
        {

            Sensor sen = new Sensor();
            Display display = new Display();
            alarm alarm = new alarm(20);

            sen.SensorChanged += display.ShowTemprature;
            sen.SensorChanged += alarm.FireAlarm;
            while (true)
            {




                Console.Title = "TEMP MONITOR";



                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($@"
  _______  ______ __  __ _____                                
 |__   __||  ____|  \/  |  __ \                               
    | |   | |__  | \  / | |__) |                              
    | |   |  __| | |\/| |  ___/                               
    | |   | |____| |  | | |      
    |_|   |______|_|  |_|_|      

       TEMPERATURE SENSOR SYSTEM
");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t========================================");
                Console.WriteLine("\t\t\t\t    Welcome       TEMP MONITOR          ");
                Console.WriteLine("\t\t\t\t                                        ");
                Console.WriteLine("\t\t\t\t========================================");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t\t    [01]  Set The Tempreature             ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\t\t\t\t    [02]  Set The Alarm Value (Defulat 20)     ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\t    [03]  Exit             ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t\t=======================================");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t\t\t\t * Plase Choose The Number -> ");
                var Result = Console.ReadLine();
              

                switch (Result)
                {
                        case "1":
                        
                        PrintTempreatureHead("Please enter the temprature value in degrees");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\t\t\t===> ");  var Temp = Console.ReadLine();
                        int Temprature = Convert.ToInt32(Temp);
                        sen.ChangeTemprature(Temprature);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t\t\t ===================================");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n\nPlace Key Enter to Continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                        case "2":
                        PrintTempreatureHead("Please enter the temprature Value For The alarm");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\t\t\t===> "); var alarmValue = Console.ReadLine();

                        int AlarmValue = Convert.ToInt32(alarmValue);
                        alarm.setAlarmValue(AlarmValue);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\t\t\t ===================================");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("\n\nPlace Key Enter to Continue...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                        case "3":
                        Console.Clear();
                        ExitAnimation();
                        return;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(" Worng input, Please Enter Correct Value");
                        break;
                }

            }

            Console.ReadKey();
            Console.ResetColor();
        }

        public static void PrintTempreatureHead(string Message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n");
            Console.WriteLine("\t\t\t=========================================================");
            Console.WriteLine($"\t\t\t  {Message}      ");
            Console.WriteLine("\t\t\t=========================================================");
        }







        static void ExitAnimation()
        {
            Console.CursorVisible = false;

            string[] frames =
            {
@"
                 .----------------.
                /    SOLDIER       \
                \__________________/
                       ||
                  ____/  \____
                 /            \
                /   _      _   \
               |   (o)    (o)   |
               |      ____      |========>
               |    .'    '.    |
                \   \______/   /
                 '.___||______.'
                    / || \
             ______/  ||  \______
            /         ||         \
           /   _______||_______   \
          |   /       ||       \   |
          |  /        ||        \  |
          | /         ||         \ |
          |/          ||          \|
                     /  \
                    /    \
                   /      \
                  /________\
",

@"
                 .----------------.
                /    SOLDIER       \
                \__________________/
                       ||
                  ____/  \____
                 /            \
                /   _      _   \
               |   (o)    (o)   |
               |      ____      |========>
               |    .'    '.    |
                \   \______/   /
                 '.___||______.'
                    / || \
             ______/  ||  \______
            /         ||         \
           /   _______||_______   \
          |   /       ||       \   |
          |  /        ||        \  |
          | /         ||         \ |
          |/          ||          \|
                    / 
                   / 
                  /____
                       \
                        \____
",

@"
                 .----------------.
                /    SOLDIER       \
                \__________________/
                       ||
                  ____/  \____
                 /            \
                /   _      _   \
               |   (o)    (o)   |
               |      ____      |========>
               |    .'    '.    |
                \   \______/   /
                 '.___||______.'
                    / || \
             ______/  ||  \______
            /         ||         \
           /   _______||_______   \
          |   /       ||       \   |
          |  /        ||        \  |
          | /         ||         \ |
          |/          ||          \|
                       \
                        \
                    ____/
                   /
                  /________
",

@"
                 .----------------.
                /    SOLDIER       \
                \__________________/
                       ||
                  ____/  \____
                 /            \
                /   _      _   \
               |   (o)    (o)   |
               |      ____      |========>>> 
               |    .'    '.    |
                \   \______/   /
                 '.___||______.'
                    / || \
             ______/  ||  \______
            /         ||         \
           /   _______||_______   \
          |   /       ||       \   |
          |  /        ||        \  |
          | /         ||         \ |
          |/          ||          \|
                     /  \
                    /    \
                   /      \
                  /________\
"
    };

            // Walking animation
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(frames[i]);
                Thread.Sleep(400);
            }

            // Shooting
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(frames[3]);
                Console.WriteLine("\n              >>> BOOM! <<<");
                Thread.Sleep(300);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(frames[0]);
                Thread.Sleep(200);
            }

            // Ending
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
===========================================

             SYSTEM TERMINATED

===========================================");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"

              TEMP MONITOR

       TEMPERATURE SENSOR SYSTEM

                GOOD BYE!
");

            Thread.Sleep(2000);

            Console.ResetColor();
            Console.CursorVisible = true;
        }


    }



}
