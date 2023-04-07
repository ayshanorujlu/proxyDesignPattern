using ProxyDesignPattern.Abstracts;
using ProxyDesignPattern.Concretes;

namespace ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBrowser browser = new ProxyBrowser();
            while (true)
            {
                Console.WriteLine("Enter request : ");
                string request = Console.ReadLine();
                browser.GetRequest(request);
            }
        }
    }
}