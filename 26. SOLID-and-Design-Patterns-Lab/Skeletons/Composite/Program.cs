namespace DOMBuilder
{
    using System;
    using System.IO;

    using Composite;

    public class Program
    {
        static void Main()
        {
            Element html = new Element(
                "html",
                new Element("head"),
                new Element("body", new Element("section", new Element("h2"), new Element("p"), new Element("span")),  new Element("footer")));

            Console.WriteLine(html.Display(0));
            File.WriteAllText("index.html", html.Display(0));

        }
    }
}
