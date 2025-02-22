using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.CodeDom;
using System.Security.Cryptography;
namespace first_project
{
    public partial class Form4 : System.Windows.Forms.Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void addus_Click(object sender, EventArgs e)
        {

            StreamReader usChek = new StreamReader("useres.txt");
            string Chek;
            Chek = usChek.ReadToEnd();
            usChek.Close(); //يجب الاغلاق بعد التشييك



            if (userNameNew.Text == "" || passNew.Text == "" || confirmPass.Text == "")
            {
                if (userNameNew.Text == "")
                {
                    MessageBox.Show("ادخل اسم المستخدم ");

                    userNameNew.Focus();
                }

                else if (passNew.Text == "")
                {
                    MessageBox.Show("ادخل كلمة المرور الجديدة");
                    passNew.Focus();
                }
                else
                {
                    MessageBox.Show("يرجى ادخال كلمة مرور التاكيد");
                    confirmPass.Focus();
                }
            }
            else if (confirmPass.Text != passNew.Text)
            {
                MessageBox.Show("تأكيد كلمة المرور خطأ");
                confirmPass.Focus();
                confirmPass.SelectAll();
            }
            else if (Chek.Contains(userNameNew.Text + ";"))
            {

                MessageBox.Show("اسم المستخدم مضاف سابقا اسم ادخال اسم مستخددم جديد");
                userNameNew.Focus();
                userNameNew.SelectAll();

            }

            else
            {
                StreamWriter us = new StreamWriter("useres.txt", true);
                string usre = userNameNew.Text + ";" + passNew.Text + ";";
                us.WriteLine(usre);
                us.Close();
                foreach (Control c in this.Controls)
                {

                    if (c is TextBox || c is ComboBox)
                    {
                        c.Text = "";
                        userNameNew.Focus();
                    
                    }

                }
                MessageBox.Show("تم اضافة البيانات بنجاح");
            }
        }
    }
}
        
   

   
        
    

