using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1SquareRoot
{
    class SquareRootMain
    {
        static void Main(string[] args)
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentOutOfRangeException)
            {

                Console.WriteLine("Invalid Number");
            }
            catch (ArgumentException)
            {

                Console.WriteLine("Invalid Number");
            }
           catch (FormatException)
            {

                Console.WriteLine("Invalid Number");
            }
            catch (OverflowException)
            {

                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

        }
    }
}
