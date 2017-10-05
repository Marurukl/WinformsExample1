using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSecondWinForm
{
    public class Numbers
    {
        public int Number { get; set; }
        public int EndRange { get; set; }
        public int Count { get; set; }
        public int StartRange { get; set; }

        int numberForTheCalculationOfHalfTheNumber = 2;
        public Numbers()
        {
            Number = 1000;
            EndRange = 2000;
            Count = 0;
            StartRange = 1;
        }
        
        public void NumLarger()
        {
            StartRange = Number;
            Number = StartRange + (EndRange - StartRange) / 2;
            Count++;
        }
        public void NumLess()
        {
            EndRange = Number;
            Number = EndRange - (EndRange - StartRange) / 2;
            Count++;
        }

    }
}
