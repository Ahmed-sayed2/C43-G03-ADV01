using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class FixedSizeList<T>
    {

        int Capicity;
        T[] values;
        int Counter=0;
        public FixedSizeList(int capicity)
        {

            Capicity = capicity;
             values = new T[Capicity];
        }
        public void Add(T item)
        {
            if (item != null) {
                if (Counter < Capicity)
                {
                    values[Counter] = item;
                    Counter++;
                }
                else
                    Console.WriteLine("the list is full you can't add another item");

            }
        }
        public T GetValue(int index) {

         
                
                return values[index-1];
            
            
           
                
              
        
        }
    }
}
