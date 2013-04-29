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
            if (GlobalVars.Instance.ergebnis == 0.0)
            {
                GlobalVars.Instance.ergebnis = GlobalVars.Instance.eingabe;
            }

            else
            {

                switch (GlobalVars.Instance.op)
                {
                    case "plus":
                        GlobalVars.Instance.ergebnis = GlobalVars.Instance.ergebnis + GlobalVars.Instance.eingabe;
                        break;

                    case "minus":
                        GlobalVars.Instance.ergebnis = GlobalVars.Instance.ergebnis - GlobalVars.Instance.eingabe;
                        break;

                    case "multi":
                        GlobalVars.Instance.ergebnis = GlobalVars.Instance.ergebnis * GlobalVars.Instance.eingabe;
                        break;

                    case "div":
                        GlobalVars.Instance.ergebnis = GlobalVars.Instance.ergebnis / GlobalVars.Instance.eingabe;
                        break;
                }
            }
            GlobalVars.Instance.eingabe = 0.0;
        }
    }
}
