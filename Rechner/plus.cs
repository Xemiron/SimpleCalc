using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rechner
{
    class plus
    {
        public string setNmbrs(string userIn)
        {

            if (GlobalVars.Instance.ergebnis != 0.0)
            {
                GlobalVars.Instance.ergebnis = GlobalVars.Instance.ergebnis + GlobalVars.Instance.eingabe;
            }

            else 
            {
                GlobalVars.Instance.ergebnis = GlobalVars.Instance.eingabe;
            }

            return Convert.ToString(GlobalVars.Instance.ergebnis);
        }
    }
}
