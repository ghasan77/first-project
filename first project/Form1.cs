using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace first_project
{
    public partial class Form1 : System.Windows.Forms.Form
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
            else if (username.Text.Trim() != ""&&password.Text!="")
            {
                StreamReader sr = new StreamReader("useres.txt");

                string line = "";

                bool found1 = false, found2 = false;

                do
                {
                    line = sr.ReadLine();
                    
                    if (line != null)
                    {
                        string[] arruser = line.Split(';');
                        if (arruser[0]==username.Text)
                        {
                            found1 = true;
                            if (arruser[1]==password.Text  )
                            {
                                
                                sr.Close();
                                MessageBox.Show("تم تسجيل الدخول", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form3 fmr = new Form3();
                                this.Hide();
                                fmr.setuser(username.Text);
                                fmr.ShowDialog();
                                this.Close();
                                found2 = true;
                                break;

                            }


                        }
                    }
                } while (line != null);
                sr.Close();

                if (found1)
                {
                    if (!found2)
                    {
                        MessageBox.Show(" كلمة المرور خطأ ", "خطأ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        password.Focus();
                        password.SelectAll();
                    }
                  

                }
                else

                {
                    MessageBox.Show(" اسم المستخدم غير موجود ", "خطأ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    password.Focus();
                    password.SelectAll();
                }
            }


        }


                
                    

            



            

                   

           
                

                


            //else if (username.Text == "1" && password.Text == "1")
            //{
            //    MessageBox.Show("تم تسجيل الدخول", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    Form3 fmr = new Form3();
            //    this.Hide();
            //    fmr.setuser(username.Text);
            //    fmr.ShowDialog();

            //    this.Close();



            //}


            ////*  MessageBox.Show("تم تسجيل الدخول", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            //else
            //{
            //    MessageBox.Show("قد يكون اسم المستخدم او كلمة المرور خطأ ", "خطأ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            //    password.Focus();
            //    password.SelectAll();
            //    {

            //    }
            //}

        

       

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

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
