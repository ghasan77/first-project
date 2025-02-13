using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                if (string.IsNullOrWhiteSpace(username.Text) && string.IsNullOrWhiteSpace(password.Text))
                    MessageBox.Show("يجب ادخال اسم المستخدم و كلمة المرور اولاً");
                else if (string.IsNullOrWhiteSpace(username.Text))
                    MessageBox.Show(" يجب ادخال اسم المستخدم اولاً");
                else
                {

                    MessageBox.Show("يجب ادخال كلمة المرور اولاً");
                }
            }

            else if (username.Text == "عاصم" && password.Text == "1")
            {
                MessageBox.Show("تم تسجيل الدخول", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 fmr = new Form3();
                fmr.SetUserName(username.Text);
                this.Hide();
                fmr.ShowDialog();
                this.Close();

            }


            //*  MessageBox.Show("تم تسجيل الدخول", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            else
                MessageBox.Show("قد يكون اسم المستخدم او كلمة المرور خطأ ", "خطأ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                    password.PasswordChar = '\0';
            }else
            {
                password.PasswordChar = '*';
            }
        }

       
    }
}
