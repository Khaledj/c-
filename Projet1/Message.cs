using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
   public class Message
    {
        private IDateTime datetoreturn;
       
        private int d1 = 9;
        private int d2 = 13;
        private int d3 = 18;

        
        //public Message (int v1, int v2, int v3)
        //{
           // this.d1 = v1;
            //this.d2 = v2;
            //this.d3 = v3;
        //}

        public Message()
            :this(new RealDateTime())
        {
          
        }
       public Message(IDateTime date)
        {
            datetoreturn = date;
        }

        public string GetHelloMessage()
        {
            //DayOfWeek jour = DateTime.Now.DayOfWeek;
            DayOfWeek jour = datetoreturn.Date.DayOfWeek;
            //int date = DateTime.Now.Hour;
            int date = datetoreturn.Date.Hour;
            string message = "";
            if ((jour == DayOfWeek.Monday || jour == DayOfWeek.Tuesday || jour == DayOfWeek.Wednesday || jour == DayOfWeek.Thursday || jour == DayOfWeek.Friday) && (date >= this.d1 && date < this.d2))
            {
               message = "Bonjour " + Environment.UserName;
            }
            else if ((jour == DayOfWeek.Monday || jour == DayOfWeek.Tuesday || jour == DayOfWeek.Wednesday || jour == DayOfWeek.Thursday || jour == DayOfWeek.Friday) && (date >= this.d2 && date < this.d3))
            {
              message ="Bon après-midi " + Environment.UserName;
            }
            else if (( (jour == DayOfWeek.Monday && date>=this.d3) || jour == DayOfWeek.Tuesday || jour == DayOfWeek.Wednesday || jour == DayOfWeek.Thursday) && (date >= this.d3 || date < this.d1))
            {
                message ="Bonsoir " + Environment.UserName;
            }
            else if ((jour == DayOfWeek.Saturday || jour == DayOfWeek.Sunday) || (jour == DayOfWeek.Friday && date >= this.d3) || (jour == DayOfWeek.Monday && date < this.d1))
            {
                message = "Bon week-end " + Environment.UserName;
            }
            return message;

        }
    }
}
