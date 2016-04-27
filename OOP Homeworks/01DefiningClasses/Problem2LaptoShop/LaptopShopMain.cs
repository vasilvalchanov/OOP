using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2LaptoShop
{
    class LaptopShopMain
    {
        static void Main(string[] args)
        {
            Laptop myLap = new Laptop("Nekav si tam", 999.9999m);
            Console.WriteLine(myLap);
            Console.WriteLine();

            Battery battery = new Battery("Li-Ion", 3.5);
            Laptop peshosLap = new Laptop("G710", "Lenovo", 6, battery, 1111.2345m);
            Console.WriteLine(peshosLap);
            Console.WriteLine();

            Laptop goshosLap = new Laptop(
                "Lenovo Yoga 2 Pro",
                "Lenovo",
                "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                8,
                "Intel HD Graphics 4400",
                "128GB SSD",
                "\"13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display",
                new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5),
                2259.00m);
            Console.WriteLine(goshosLap);
        }
    }
}
