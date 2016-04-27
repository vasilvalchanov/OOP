using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3PCCataloc
{
    using System.Globalization;
    using System.Threading;

    public class PCCatalogMain
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("bg-BG");

            Component screen1 = new Component("Screen", "13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display", 300);
            Component screen2 = new Component("Some fake screen", 100.66m);

            Component processor1 = new Component("Processor", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)", 332.58m);
            Component processor2 = new Component("Some fake processor", 156.98m);

            Component hdd1 = new Component("HDD", "128GB SSD", 243);
            Component hdd2 = new Component("Some fake HDD", 120);

            Component ram1 = new Component("RAM", "8 GB", 295);
            Component ram2 = new Component("Some fake RAM", 123);

            Computer firstPC = new Computer("Lenovo", new List<Component>() {screen1, processor1, hdd1, ram1});
            Computer secondPC = new Computer("Fake PC", new List<Component>() {screen2, processor2, hdd2, ram2});
            Computer thirdPC = new Computer("PC with mixed parts", new List<Component>() {screen1, processor2, hdd1, ram2});

         IList<Computer> computerCatalog = new List<Computer>() {firstPC, secondPC, thirdPC};

            foreach (var computer in computerCatalog.OrderBy(pr => pr.Price))
            {
                Console.WriteLine(computer);
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}
