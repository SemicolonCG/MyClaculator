using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Claculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {


            double X = double.Parse(xTxt.Text);
            double Y = double.Parse(yTxt.Text);

            double Z = (X * Y);

            resultLbl.Text = Z.ToString();
            xTxt.Clear();
            yTxt.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            double X = double.Parse(xTxt.Text);
            double Y = double.Parse(yTxt.Text);

            double Z = (X + Y);

            resultLbl.Text = Z.ToString();

            xTxt.Clear();
            yTxt.Clear();

        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            double X = 0;
            double Y = 0;

            X = double.Parse(xTxt.Text);
            Y = double.Parse(yTxt.Text);

            double Z = (X - Y);

            resultLbl.Text = Z.ToString();
            xTxt.Clear();
            yTxt.Clear();

        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            double X = double.Parse(xTxt.Text);
            double Y = double.Parse(yTxt.Text);

            double Z = (X / Y);

            resultLbl.Text = Z.ToString();
            xTxt.Clear();
            yTxt.Clear();
        }
    }
}
