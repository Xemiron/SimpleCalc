using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rechner
{
    class calc
    {
        public void calculate()
        {

            switch (GlobalVars.Instance.op)
            { 
                case "plus":

                    if (GlobalVars.Instance.ergebnis == 0.0)
                    {
                        GlobalVars.Instance.ergebnis = GlobalVars.Instance.eingabe;
                    }

                    else
                    {
                        GlobalVars.Instance.ergebnis = GlobalVars.Instance.ergebnis + GlobalVars.Instance.eingabe;
                    }
                    break;
            
            }
        }
    }
}
