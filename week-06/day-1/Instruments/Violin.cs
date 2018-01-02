using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            name = "Violin";
            numberOfStrings = 4;
        }

        public Violin(int numberOfStrings)
        {
            name = "Violin";
            this.numberOfStrings = numberOfStrings;
        }

        public override string Sound()
        {
            return "Screech";
        }
    }
}
