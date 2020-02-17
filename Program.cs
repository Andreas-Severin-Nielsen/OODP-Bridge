using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IUI ui = new UI(new UTIImplementation());
            ui.InformUser("This text is written to user");
            Console.ReadKey();
        }
    }
}
