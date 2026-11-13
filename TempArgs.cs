using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvent
{
    internal class TempArgs:EventArgs
    {
       public int Temprature {  get; set; }

        public TempArgs(int Temprature)
        {
            this.Temprature = Temprature;
        }
    }
}
