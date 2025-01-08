using System.Diagnostics.Eventing.Reader;
using System.DirectoryServices.ActiveDirectory;

namespace projeck_kalku_wisnu
{
    public partial class Form1 : Form
    {
        decimal valueFirst = 0.0m;
        decimal valusecond = 0.0m;
        decimal result = 0.0m; 
        decimal bil1;
        decimal bil2;
        int opr;
        Boolean opr_selesai = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "3";
            }
            else
            {
                txtDisplay1.Text += "3";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "2";
            }
            else
            {
                txtDisplay1.Text += "2";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "4";
            }
            else
            {
                txtDisplay1.Text += "4";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "7";
            }
            else
            {
                txtDisplay1.Text += "7";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "1";
            }
            else
            {
                txtDisplay1.Text += "1";
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {

            bil1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay1.Text = "+";
            txtDisplay1.Text = "";
            opr = 4;
            opr_selesai = true;

        }

        private void button10_Click(object sender, EventArgs e)
        {

            bil1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay1.Text = "-";
            txtDisplay1.Text = "";
            opr = 3;
            opr_selesai = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "5";
            }
            else
            {
                txtDisplay1.Text += "5";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = ",";
            }
            else
            {
                txtDisplay1.Text += ",";
            
        }
    }


        private void button12_Click(object sender, EventArgs e)
        {

            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "0";
            }
            else
            {
                txtDisplay1.Text += "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (opr_selesai == true)
                bil2 = Convert.ToDecimal(txtDisplay1.Text);
            {
                switch (opr)
                {
                    case 1:
                        txtDisplay1.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 2:
                        txtDisplay1.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 3:
                        txtDisplay1.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 4:
                        txtDisplay1.Text = Convert.ToString(bil1 + bil2);
                        break;


                }
                opr_selesai= false;
            }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            bil1 = Convert . ToDecimal(txtDisplay1.Text);
            txtDisplay1.Text = "x";
            txtDisplay1.Text = "";
            opr = 1;
            opr_selesai = true;

        }

        private void button15_Click(object sender, EventArgs e)
        {

            bil1 = Convert.ToDecimal(txtDisplay1.Text);
            txtDisplay1.Text = "/";
            txtDisplay1.Text = "";
            opr = 2;
            opr_selesai = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "6";
            }
            else
            {
                txtDisplay1.Text += "6";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "8";
            }
            else
            {
                txtDisplay1.Text += "8";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (txtDisplay1.Text == "0")
            {
                txtDisplay1.Text = "9";
            }
            else
            {
                txtDisplay1.Text += "9";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = " 0";
            bil1 = 0;
            bil2 = 0;
            txtDisplay1.Text = " ";
        }
    }
}
