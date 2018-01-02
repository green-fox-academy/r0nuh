using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    public abstract class StringedInstrument : Instrument
    {
        public int numberOfStrings;

        public override void Play()
        {
            Console.WriteLine($"{name}, a {numberOfStrings}-stringed instrument that {Sound()}s");
        }

        public abstract string Sound();
    }
}
