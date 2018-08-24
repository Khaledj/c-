using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    public class RealDateTime : IDateTime
    {
        public DateTime Date
        {
            get { return DateTime.Now; }
        }
    }
}
