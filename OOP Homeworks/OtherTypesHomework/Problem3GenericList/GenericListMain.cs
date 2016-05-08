using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3GenericList
{
    class GenericListMain
    {
        static void Main(string[] args)
        {
            try
            {
                var list = new GenericList<int>(4)
                           {
                               1,
                               2,
                               3
                           };

                Console.WriteLine(list);
                list.Add(4);
                Console.WriteLine(list);
                Console.WriteLine(list.Contains(8));
                Console.WriteLine(list.Contains(2));
                Console.WriteLine(list.FindIndexByElementValue(2));
                Console.WriteLine(list.FindIndexByElementValue(6));
                //Console.WriteLine(list.GetElementByIndex(4));
                Console.WriteLine(list.GetElementByIndex(1));
                list.InsertElementAtPosition(1, 11);
                Console.WriteLine(list);
                list.RemoveElementByIndex(1);
                Console.WriteLine(list);
                //list.RemoveElementByIndex(11);
                //list.RemoveElementByIndex(-1);
                Console.WriteLine(list.GetMin());
                Console.WriteLine(list.GetMax());
                //list.Clear();
                //Console.WriteLine(list);
                //Console.WriteLine(list.GetMax());
                Console.WriteLine(list.Version());

            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}
