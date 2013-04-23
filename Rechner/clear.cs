using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rechner
{
    class clear
    {
        frmMain objFr = new frmMain();
        
        public void clearVars()
        {
            GlobalVars.Instance.ausgabe = "";
            GlobalVars.Instance.eingabe = 0.0;
            GlobalVars.Instance.ergebnis = 0.0;

            objFr.lblMain.Text = "0";
            objFr.txtBoxMain.Text = "0";
        }
    } 
}
