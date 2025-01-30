using System.Collections;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. 
            //Range<int> range = new Range<int>(10, 12);
            //Console.WriteLine($"{range.IsInRange(122)},{range.IsInRange()}");
            #endregion
            #region 2
            ArrayList array = new ArrayList();
            //array.Add(1);
            //array.Add(2);
            //array.Add("ssas");
            //Reverse(ref array);
            //foreach (object o in array)
            //    Console.WriteLine(o);
            #endregion
            #region 3
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);    
            //list.Add(3);    
            //list.Add(4);
            //list.Add(5);
            //list.Add(6);
            //List<int> l2 = Even(list);
            //foreach (int i in l2) 
            //    Console.WriteLine(i);
            #endregion
            #region 4
            FixedSizeList<int> list = new FixedSizeList<int>(2);
            //list.Add(4);
            //list.Add(2);
            //list.Add(5);
            //Console.WriteLine( list.GetValue(1));
            #endregion
            #region 5
            string s = "ahmed ahm";
            Dictionary<char,int> d = new Dictionary<char,int>();
            foreach (char c in s)
                if (!d.ContainsKey(c))
                {
                    d.Add(c, 0);
                }
                else 
                {
                    d[c] += 1;
                }
            foreach (var item in d)
            {
                if (item.Value == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
            #endregion


        }
        static public List<int> Even(List<int> list) {
            List<int> EvenList = new List<int>();
            foreach (int item in list)
            {
                if(item%2==0)
                { EvenList.Add(item); } 

            }
            return EvenList;

        }
        static public ArrayList Reverse(ref ArrayList  array)
        {
            object[] obj = new object[array.Count];
            array.CopyTo(obj);
            array.Clear();
            for (int i = obj.Length - 1; i >= 0; i--)
            {
                array.Add(obj[i]);
            }
            return array;
        }
    }
}
