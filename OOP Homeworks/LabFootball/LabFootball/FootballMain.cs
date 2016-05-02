using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFootball
{
    using System.Runtime.InteropServices;

    public class FootballMain
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                try
                {
                    LeagueManager.HandleInput(input);
                }
                catch (InvalidOperationException ex)
                {

                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentOutOfRangeException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
