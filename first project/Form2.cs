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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addData_Click(object sender, EventArgs e)
        {
            string input = numPhone.Text;
            
                if (name.Text == "" || id.Text == "" || mm.Text == ""|| numPhone.Text == ""|| input.Length!=9)
            {
                if (name.Text == "" && id.Text == "" && mm.Text == "" && numPhone.Text == "")
                    MessageBox.Show("لا يوجد اي بيانات لإضافتها");
                else if (name.Text == "" && id.Text == "" && mm.Text == "")
                 MessageBox.Show("يجب كتابة اسم الطالب والرقم الجامعي والتخصص اولا "); 
                else if (name.Text == "" && id.Text == "" && numPhone.Text == "")
                    MessageBox.Show("يجب كتابة اسم الطالب والرقم الجامعي ورقم الهاتف اولا");
                else if (name.Text == "" && mm.Text == "" && numPhone.Text == "")
                    MessageBox.Show("يجب كتابة اسم الطالب والتخصص ورقم الهاتف اولا");
                else if (id.Text == "" && mm.Text == "" && numPhone.Text == "")
                    MessageBox.Show("يجب كتابة الرقم الجامعي والتخصص ورقم الهاتف اولا");
                else if (name.Text == "" && mm.Text == "")
                    MessageBox.Show("يجب كتابة اسم الطالب والتخصص اولا");

                else if (name.Text == "" && id.Text == "")
                    MessageBox.Show("يجب كتابة اسم الطالب ,والرقم الجامعي اولا");
                else if (name.Text == "" && numPhone.Text == "")
                    MessageBox.Show("يجب كتابة اسم الطالب ,ورقم الهاتف اولا");
                else if (id.Text == "" && mm.Text == "")
                    MessageBox.Show("يجب كتابة يجب كتابة الرقم الجامعي والتخصص اولا");
                else if (id.Text == "" && numPhone.Text == "")
                    MessageBox.Show(" يجب كتابة الرقم الجامعي ورقم الهاتف اولا");
                else if (mm.Text == "" && numPhone.Text == "")
                    MessageBox.Show("يجب كتابة التخصص ورقم الهاتف اولا");
                else if (name.Text == "")
                    MessageBox.Show("يجب ان لا يكون اسم الطالب فارغاً");
                else if (id.Text == "")
                    MessageBox.Show("يجب ان لا يكون الرقم الجامعي فارغاً");
                else if (mm.Text == "")
                    MessageBox.Show("يجب ان لا يكون التخصص فارغاً");
                else if (numPhone.Text == "")
                    MessageBox.Show("يجب ان لا يكون رقم الهاتف فارغاً");
                else if (input.Length < 9)
                    MessageBox.Show("يجب ان لا يكون رقم الهاتف اقل من 9 ارقام");
                else if (input.Length > 9)
                    MessageBox.Show("يجب ان لا يكون رقم الهاتف اكتر من 9 ارقام");

            }
                else
                MessageBox.Show("تم ترحيل البيانات بنجاح");



        }

        private void numPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void numPhone_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}

