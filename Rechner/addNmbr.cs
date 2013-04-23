using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rechner
{
    class addNmbr
    {
        public string addNumber(string eingabe)  
        {
            GlobalVars.Instance.ausgabe = GlobalVars.Instance.ausgabe + eingabe;

            return GlobalVars.Instance.ausgabe;
        }
    }
}
