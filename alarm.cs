using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvent
{
    internal class alarm
    {
       private int AlarmValue {  get; set; }

        public alarm(int AlarmValue)
        {
            this.AlarmValue = AlarmValue;
        }
        public void setAlarmValue(int NewAlarmValue)
        {
            this.AlarmValue = NewAlarmValue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n\t\t\t ===================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\t\t\t  [!]  THE ALARM IS  : ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{AlarmValue} ");
        }

        public void FireAlarm(object sender, TempArgs Temp)
        {
            Alarm(Temp.Temprature);


        }

        private void Alarm(int Temp)
        {
         
                if (Temp < AlarmValue)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\t\t\t\t  LOW TEMPERATURE");
                }
                else if (Temp <= 60)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t\t\t\t  NORMAL TEMPERATURE");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t    WORNG CRITICAL TEMPERATURE...!");
                }

                Console.ResetColor();
           
        }
        
    }
}
