using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Range<T>where T: IComparable, INumber<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T Min ,T Max)
        {
            if (Max.CompareTo(Min) == 1)
            {
                this.Min = Min;
                this.Max = Max;
            }
            else {
                Console.WriteLine("Max must be more than min");
                
            }
        }

        public bool IsInRange(T value) {
            return (value.CompareTo(Min)==1 && value.CompareTo(Max) == -1)||
              (value.CompareTo(Min) == 0 || value.CompareTo(Max) == 0);
        
        }
        public T IsInRange()
        {
            return Max-Min;

        }
    }
}
