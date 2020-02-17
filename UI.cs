using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Bridge
{
    class UI : IUI // User Interface
    {
        private IUIImplementor uIImplementation;

        public UI(IUIImplementor uIImplementation)
        {
            this.uIImplementation = uIImplementation ?? throw new ArgumentNullException(nameof(uIImplementation));
        }

        public void InformUser(string txt)
        {
            uIImplementation.InformUser(txt);
        }
    }
}
