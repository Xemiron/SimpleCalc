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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.txtBoxMain.Focus();
            this.KeyPreview = true;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Oemplus))
            {
                btnPlus.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            addContent con = new addContent();
            calc cl = new calc();
            //--------------------------------

            GlobalVars.Instance.eingabe = Convert.ToDouble(txtBoxMain.Text);

            con.content(txtBoxMain.Text, "plus");

            cl.calculate();

            GlobalVars.Instance.op = "plus";

            lblMain.Text = GlobalVars.Instance.ausgabe;
            txtBoxMain.Text = "";

            txtBoxMain.Focus();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            addContent con = new addContent();
            calc cl = new calc();
            //--------------------------------

            GlobalVars.Instance.eingabe = Convert.ToDouble(txtBoxMain.Text);

            con.content(txtBoxMain.Text, "minus");

            cl.calculate();

            GlobalVars.Instance.op = "minus";

            lblMain.Text = GlobalVars.Instance.ausgabe;
            txtBoxMain.Text = "";

            txtBoxMain.Focus();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            addContent con = new addContent();
            calc cl = new calc();
            //--------------------------------

            GlobalVars.Instance.eingabe = Convert.ToDouble(txtBoxMain.Text);

            con.content(txtBoxMain.Text, "multi");

            cl.calculate();

            GlobalVars.Instance.op = "multi";

            lblMain.Text = GlobalVars.Instance.ausgabe;
            txtBoxMain.Text = "";

            txtBoxMain.Focus();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            addContent con = new addContent();
            calc cl = new calc();
            //--------------------------------

            GlobalVars.Instance.eingabe = Convert.ToDouble(txtBoxMain.Text);

            con.content(txtBoxMain.Text, "div");

            cl.calculate();

            GlobalVars.Instance.op = "div";

            lblMain.Text = GlobalVars.Instance.ausgabe;
            txtBoxMain.Text = "";

            txtBoxMain.Focus();
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

            txtBoxMain.Focus();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            calc cl = new calc();

            GlobalVars.Instance.eingabe = Convert.ToDouble(txtBoxMain.Text);

            cl.calculate();
            
            txtBoxMain.Text = Convert.ToString(GlobalVars.Instance.ergebnis);
            
            GlobalVars.Instance.eingabe = 0.0;
            GlobalVars.Instance.ergebnis = 0.0;
            GlobalVars.Instance.ausgabe = "";

            lblMain.Text = GlobalVars.Instance.ausgabe;
        }
    }
}
