namespace WebScraper
{
    using System.Collections.Generic;

    public sealed class WebPageRepository
    {
        private static readonly object sunLock = new object();

        private static volatile WebPageRepository webPageRepository;

        private Queue<string> addresses;

        private WebPageRepository()
        {
            this.addresses = new Queue<string>();
            this.Seed();
        }

        public bool IsEmpty
        {
            get
            {
                return this.addresses.Count == 0;
            }
        }

        public static WebPageRepository Instance
        {
            get
            {
                if (webPageRepository == null)
                {
                    lock (sunLock)
                    {
                        if (webPageRepository == null)
                        {
                            webPageRepository = new WebPageRepository();
                        }
                    }
                }

                return webPageRepository;
            }
        }

        public void Add(string address)
        {
            this.addresses.Enqueue(address);
        }

        public string Remove()
        {
            return this.addresses.Dequeue();
        }

        private void Seed()
        {
            this.addresses.Enqueue("https://softuni.bg/");
            this.addresses.Enqueue("http://stackoverflow.com/");
            this.addresses.Enqueue("https://www.youtube.com/");
            this.addresses.Enqueue("https://www.google.bg/");
        }
    }
}
