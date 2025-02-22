using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;


namespace first_project
{
    public partial class Form5 : System.Windows.Forms.Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //globl variables
        string c;
        double x;


        private void button10_Click(object sender, EventArgs e)
        {

        }





     
        private void clear_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }
        private void button9_Click(object sender, EventArgs e)
        {

            Button s = (Button)sender;
            if (result.Text == "0")
                result.Clear();
            result.Text += s.Text.Trim();
            if (result.Text == "." && s.Text == ".")
            {
                result.Text = "0.";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (result.Text != "" && opr.Text != "")
            {
                ras.PerformClick(); 
                 }
            c = b.Text;
            x = Convert.ToDouble(result.Text);
            opr.Text = c;
            result.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }
        private void ras_Click(object sender, EventArgs e)
        {
            switch (c)
            {
                case "+":
                    {
                        double y = Convert.ToDouble(result.Text);
                        result.Text = (x + y).ToString();
                        opr.Text = "";
                        break;
                    }
                case "-":
                    {
                        double y = Convert.ToDouble(result.Text);
                        result.Text = (x - y).ToString();
                        opr.Text = "";
                        break;
                    }
                case "*":
                    {
                        double y = Convert.ToDouble(result.Text);
                        result.Text = (x * y).ToString();
                        opr.Text = "";
                        break;
                    }
                    case "/":
                    {
                        double y = Convert.ToDouble(result.Text);
                        result.Text = (x / y).ToString();
                        opr.Text = "";
                        break;
                    }


            }


        }

        private void result_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {   case '+':
                    {
                        e.Handled = true;
                        button17.PerformClick();
                    }
                    break;
                    
                case '*':
                    {
                        e.Handled = true;
                        button19.PerformClick();
                    }
                    break;
                    
                case '/':
                    {
                        e.Handled = true;
                        button13.PerformClick();
                    }
                    break;
                    
                case '-':
                    {
                        e.Handled = true;
                        button10.PerformClick();
                    }
                    break;
                    case (char)Keys.Enter:
                    {
                        e.Handled = true;
                        ras.PerformClick();
                    }
                    break;
                    case (char)Keys.Back: 
             
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                    e.Handled = false;
                    break;
                    default:
                    e.Handled = true;
                    MessageBox.Show("please enter a number");
                    break;








            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3();
            this.Hide();
            fmr.ShowDialog();
            this.Close();
        }
    }
}
