using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2EnterNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int counter = 10;
            int start = 1;
            int end = 100;

            while (counter > 0)
            {
                try
                {
                    
                    int num = ReadNumber(start, end);

                    start = num;
                    if (end - start < counter)
                    {
                        start = start - (counter - (end - start));
                        throw new InvalidOperationException(string.Format("Number must be maximum {0}", start));
                    }

                    start = num + 1;
                    counter--;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number");
                    Console.WriteLine("Enter again");
                    
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The entered number must be in range [{0}-{1}]", start, end);
                    Console.WriteLine("Enter again");
                    
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Invalid number");
                    Console.WriteLine("Enter again");

                }
                catch (InvalidOperationException)
                {
                    Console.WriteLine("Number must be maximum {0}", start);
                    Console.WriteLine("Enter again");

                }

            }
        }

        public static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < start || number > end)
            {
                throw new ArgumentOutOfRangeException(string.Format("The entered number must be in range [{0}-{1}]", start, end));
            }

            return number;
        }
    }
}
