using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rechner
{
    class addContent
    {
        frmMain objFrm = new frmMain();

        public void content(string userIn, string op)  
        {
            op = op.Replace("plus", " + ");
            op = op.Replace("minus", " - ");
            op = op.Replace("multi", " * ");
            op = op.Replace("div", " / ");

            if (GlobalVars.Instance.ausgabe == "")
            {
                GlobalVars.Instance.ausgabe = userIn + op;
            }

            else if (GlobalVars.Instance.ausgabe == Convert.ToString(GlobalVars.Instance.ergebnis))
            {
                GlobalVars.Instance.ausgabe = GlobalVars.Instance.ausgabe + op;
            }

            else
            {
                GlobalVars.Instance.ausgabe = GlobalVars.Instance.ausgabe + userIn + op;
            }
        }
    }
}
