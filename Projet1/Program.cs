using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Program
    {
        private static string mot;

        static void Main(string[] args)
        {
            do
            {
                Message message = new Message(new RealDateTime());
                Console.WriteLine(message.GetHelloMessage());
                mot = Console.ReadLine();
            } while (mot != "exit");

           

        }
    }
}
