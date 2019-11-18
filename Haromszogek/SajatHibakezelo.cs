using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszogek
{
    class SajatHibakezelo : Exception
    {
        public SajatHibakezelo(string hibaszoveg) : base(hibaszoveg) { }
    }
}
