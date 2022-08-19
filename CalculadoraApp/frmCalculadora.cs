using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraApp
{
    public partial class frmCalculadora : Form
    {
        string num1 = string.Empty;
        string num2 = string.Empty;
        char funcion;
        double resultado = 0.0;
        string input = string.Empty;    


        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void pbX_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            input += btn1.Text;
            txtDisplay.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            input += btn2.Text;
            txtDisplay.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            input += btn3.Text;
            txtDisplay.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            input += btn4.Text;
            txtDisplay.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            input += btn5.Text;
            txtDisplay.Text += input;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            input += btn6.Text;
            txtDisplay.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            input += btn7.Text;
            txtDisplay.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            input += btn8.Text;
            txtDisplay.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            input += btn9.Text;
            txtDisplay.Text += input;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            input += btn0.Text;
            txtDisplay.Text += input;
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = string.Empty;
            input += btnPunto.Text;
            txtDisplay.Text += input;
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            funcion = '/';
            num1 = input;
            input = string.Empty;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            funcion = '*';
            num1 = input;
            input = string.Empty;
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            funcion = '+';
            num1 = input;
            input = string.Empty;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            funcion = '-';
            num1 = input;
            input = string.Empty;
        }
    }
}
