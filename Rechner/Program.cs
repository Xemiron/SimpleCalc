using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class GlobalVars
{
    public static readonly GlobalVars Instance = new GlobalVars();

    public string ausgabe = "";
    public string op = "";
    public double eingabe = 0.0;
    public double ergebnis = 0.0;
}


namespace Rechner
{
    class Program
    {

        public Program(calc a)
        {
            a.calculate();
        }

        public Program(addContent con)
        {
            con.content("", "");
        }


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

        }
    }
}
