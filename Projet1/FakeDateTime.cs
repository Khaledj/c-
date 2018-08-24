using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1
{
    public class FakeDateTime : IDateTime
    {
        public DateTime datetoreturn;

        public FakeDateTime(DateTime dateReturn)
        {
            datetoreturn = dateReturn;
        }

        public DateTime Date
        {
            get { return datetoreturn; }
        }
    }
}
