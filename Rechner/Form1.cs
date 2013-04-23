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
    public partial class Rechner : Form
    {
        public Rechner()
        {
            InitializeComponent();
        }


        private void btnPlus_Click(object sender, EventArgs e)
        {
            plus plus = new plus();
            Program pa = new Program(plus);
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            GlobalVars.Instance.ausgabe = GlobalVars.Instance.ausgabe + "1";
            
            lblMain.Text = GlobalVars.Instance.ausgabe;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            GlobalVars.Instance.ausgabe = GlobalVars.Instance.ausgabe + "2";

            lblMain.Text = GlobalVars.Instance.ausgabe;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            addNmbr nmbr = new addNmbr();
            Program c = new Program(nmbr);

            lblMain.Text = nmbr.addNumber("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            addNmbr nmbr = new addNmbr();
            Program c = new Program(nmbr);

            lblMain.Text = nmbr.addNumber("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            addNmbr nmbr = new addNmbr();
            Program c = new Program(nmbr);

            lblMain.Text = nmbr.addNumber("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            addNmbr nmbr = new addNmbr();
            Program c = new Program(nmbr);

            lblMain.Text = nmbr.addNumber("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            addNmbr nmbr = new addNmbr();
            Program c = new Program(nmbr);

            lblMain.Text = nmbr.addNumber("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            addNmbr nmbr = new addNmbr();
            Program c = new Program(nmbr);

            lblMain.Text = nmbr.addNumber("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            addNmbr nmbr = new addNmbr();
            Program c = new Program(nmbr);

            lblMain.Text = nmbr.addNumber("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            addNmbr nmbr = new addNmbr();
            Program c = new Program(nmbr);

            lblMain.Text = nmbr.addNumber("0");
        }




       
    }
}
