using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4VersionAtribute
{
    class Program
    {
        static void Main(string[] args)
        {
            var versionattr = new VersionAttribute(2, 5);
            Console.WriteLine(versionattr);
        }
    }
}
