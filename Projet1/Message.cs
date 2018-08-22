using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    class Message
    {
        private int d1;
        private int d2;
        private int d3;

        public Message() { }
        public Message (int v1, int v2, int v3)
        {
            this.d1 = v1;
            this.d2 = v2;
            this.d3 = v3;
        }

        public void GetHelloMessage()
        {
            DayOfWeek jour = DateTime.Now.DayOfWeek;
            int date = DateTime.Now.Hour;
            if ((jour == DayOfWeek.Monday || jour == DayOfWeek.Tuesday || jour == DayOfWeek.Wednesday || jour == DayOfWeek.Thursday || jour == DayOfWeek.Friday) && (date >= this.d1 && date <= this.d2))
            {
                Console.WriteLine("Bonjour " + Environment.UserName);
            }
            else if ((jour == DayOfWeek.Monday || jour == DayOfWeek.Tuesday || jour == DayOfWeek.Wednesday || jour == DayOfWeek.Thursday || jour == DayOfWeek.Friday) && (date > this.d2 && date <= this.d3))
            {
                Console.WriteLine("Bon après-midi " + Environment.UserName);
            }
            else if ((jour == DayOfWeek.Monday || jour == DayOfWeek.Tuesday || jour == DayOfWeek.Wednesday || jour == DayOfWeek.Thursday) && (date > this.d3 || date < this.d1))
            {
                Console.WriteLine("Bonsoir " + Environment.UserName);
            }
            else if ((jour == DayOfWeek.Saturday || jour == DayOfWeek.Sunday) || (jour == DayOfWeek.Friday && date >= this.d3) || (jour == DayOfWeek.Monday && date <= this.d1))
            {
                Console.WriteLine("Bon week-end " + Environment.UserName);
            }

        }
    }
}
