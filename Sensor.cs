using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvent
{
    internal class Sensor
    {
        public int CurrentTemprature {  get; set; }
        public event EventHandler<TempArgs> SensorChanged;
        public void ChangeTemprature(int Temprature)
        {


            CurrentTemprature = Temprature;

            if (SensorChanged != null)
            {
                SensorChanged.Invoke(this, new TempArgs(CurrentTemprature));
            }

        }
    }
}
