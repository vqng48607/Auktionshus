using Auktionhus.Controller;
using Auktionhus.Models;

namespace Auktionhus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            ItemController controller = new ItemController();

            Console.Write("Write your minimuns price:");
            var minimunPrice = Console.ReadLine();
            
            controller.Create();
        }
    }
}