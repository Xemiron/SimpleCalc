using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class GlobalVars
{
    public static readonly GlobalVars Instance = new GlobalVars();

    public string ausgabe = "";
    public string zahl1 = "";
    public string zahl2 = "";

}


namespace Rechner
{
    class Program
    {

        public Program(calc a)
        {
            a.calculate();
        }

        public Program(addNmbr nmbr)
        {
            nmbr.addNumber("");
        }

        public Program(plus plus)
        {
            plus.setNmbrs();
        }


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Rechner());

        }
    }
}
