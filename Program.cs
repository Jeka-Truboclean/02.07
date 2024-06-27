using System.Net;

namespace _02._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Now downloading...");
            Thread thread = new Thread(Download);
            thread.Start();

            thread.Join();
            Console.WriteLine("File downloaded!!!");
        }

        private static void Download()
        {
            string url = "https://g.vseigru.net/igra-sonic-adventure.torrent";
            string filename = "SADX.torrent";

            using (WebClient client = new WebClient())
            {
                client.DownloadFile(url, filename);
            }
        }
    }
}
