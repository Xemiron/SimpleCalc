using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rechner
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            addContent con = new addContent();
            Program c = new Program(con);

            plus pl = new plus();
            Program pa = new Program(pl);

            calc cl = new calc();
            Program p = new Program(cl);
            //--------------------------------

            GlobalVars.Instance.eingabe = Convert.ToDouble(txtBoxMain.Text);
            GlobalVars.Instance.op = "plus";

            con.content(txtBoxMain.Text, "plus");
            //pl.setNmbrs(txtBoxMain.Text);
            cl.calculate();

            lblMain.Text = GlobalVars.Instance.ausgabe;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }

        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {
 
        }

        private void btn0_Click(object sender, EventArgs e)
        {

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            GlobalVars.Instance.ausgabe = "";
            GlobalVars.Instance.eingabe = 0.0;
            GlobalVars.Instance.ergebnis = 0.0;

            lblMain.Text = "0";
            txtBoxMain.Text = "0";
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            calc cl = new calc();
            Program p = new Program(cl);

            cl.calculate();

            GlobalVars.Instance.ausgabe = Convert.ToString(GlobalVars.Instance.ergebnis);
            lblMain.Text = GlobalVars.Instance.ausgabe;

            txtBoxMain.Text = Convert.ToString(GlobalVars.Instance.ergebnis);
        }




       
    }
}
