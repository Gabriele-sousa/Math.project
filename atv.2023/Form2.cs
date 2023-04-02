using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv._2023
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double litros, x, result;

            litros = Convert.ToDouble(txtlitros.Text);
            x = Convert.ToChar(txtalc);

            if (x == 'G')
            {
                if (litros <= 20)
                    result = ((litros / 5.50) * 4 / 100);

                else
                    result = ((litros / 5.50) * 6 / 100);
            }
            else if (x == 'A')
            {
                if (litros <= 20)
                    result = ((litros / 4.90) * 3 / 100);
                else
                    result = ((litros / 4.90) * 5 / 100);
            }

            txtresult.Text = result.ToString();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtlitros.Clear();
            txtalc.Clear();
            txtresult.Clear();

            txtlitros.Focus();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }
    }
}
