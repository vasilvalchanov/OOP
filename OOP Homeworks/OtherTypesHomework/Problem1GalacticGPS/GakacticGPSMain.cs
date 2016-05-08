using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1GalacticGPS
{
    class GakacticGPSMain
    {
        static void Main(string[] args)
        {
            try
            {
                var home = new Location(18.037986, 28.870097, Planet.Earth);
                Console.WriteLine(home);
                var location1 = new Location(81.037986, 128.870097, Planet.Mars);
                Console.WriteLine(location1);
                var location2 = new Location(11.037986, -188.870097, Planet.Venus);
                Console.WriteLine(location2);
            }
            catch (ArgumentOutOfRangeException ex)
            {

                Console.WriteLine(ex.ParamName);
            }
        }
    }
}
