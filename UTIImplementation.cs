using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Bridge
{
    class UTIImplementation : IUIImplementor // User Text Interface Implementation
    {
        public void InformUser(string txt)
        {
            Console.WriteLine(txt);
        }
    }
}
