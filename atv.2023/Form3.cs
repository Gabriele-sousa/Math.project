using System;
using System.Windows.Forms;

namespace atv._2023
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fm = new Form1();
            fm.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresult.Clear();
        }

        private void btnrepita_Click(object sender, EventArgs e)
        {
            double x, result;

            x = Convert.ToDouble(txtnum.Text);

            int i;

            i = 1;
            do
            {
                result = i * x;
                i++;
            } while (i < 10);

            txtresult.Text = String.Concat(txtresult.Text, " \n\n ", result.ToString());
        }

        private void btnenquanto_Click(object sender, EventArgs e)
        {
            double x, result;

            x = Convert.ToDouble(txtnum.Text);

            int i;

            i = 1;

            while (i <= 10) 
            {
              
                result = i * x;
               
                i++;

                txtresult.Text = String.Concat(txtresult.Text, " \n\n ", result.ToString());
                    }
        }

        private void btnpara_Click(object sender, EventArgs e)
        {
            double x, result;

            x = Convert.ToDouble(txtnum.Text);

            int i;

            for(i = 1; i <= 10;i++)
            {
                result = i * x;
                txtresult.Text = String.Concat(txtresult.Text, " \n\n ", result.ToString());
            }


        }
    }
}
