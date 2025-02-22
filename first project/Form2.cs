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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.CodeDom;
using System.Security.Cryptography;

namespace first_project
{
    public partial class Form2 : System.Windows.Forms.Form
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

            try
            {

                StreamReader srChek = new StreamReader("Data.txt");
                string strChek;
                strChek = srChek.ReadToEnd();
                srChek.Close(); //يجب الاغلاق بعد التشييك

                string input = numPhone.Text;

                string s;
                if (male.Checked)
                    s = "`ذكر";
                else s = "انثى";

                if (name.Text.Trim() == "" || id.Text.Trim() == "" || mm.Text.Trim() == "" || numPhone.Text == "" || input.Length != 9 || cbxCity.Text.Trim() == "")
                {
                    if (name.Text.Trim() == "" && id.Text.Trim() == "" && mm.Text.Trim() == "" && numPhone.Text.Trim() == "")
                        MessageBox.Show("لا يوجد اي بيانات لإضافتها");
                    else if (name.Text.Trim() == "" && id.Text.Trim() == "" && mm.Text.Trim() == "")
                        MessageBox.Show("يجب كتابة اسم الطالب والرقم الجامعي والتخصص اولا ");
                    else if (name.Text.Trim() == "" && id.Text.Trim() == "" && numPhone.Text.Trim() == "")
                        MessageBox.Show("يجب كتابة اسم الطالب والرقم الجامعي ورقم الهاتف اولا");
                    else if (name.Text.Trim() == "" && mm.Text.Trim() == "" && numPhone.Text.Trim() == "")
                        MessageBox.Show("يجب كتابة اسم الطالب والتخصص ورقم الهاتف اولا");
                    else if (id.Text.Trim() == "" && mm.Text.Trim() == "" && numPhone.Text.Trim() == "")
                        MessageBox.Show("يجب كتابة الرقم الجامعي والتخصص ورقم الهاتف اولا");
                    else if (name.Text.Trim() == "" && mm.Text.Trim() == "")
                        MessageBox.Show("يجب كتابة اسم الطالب والتخصص اولا");

                    else if (name.Text.Trim() == "" && id.Text.Trim() == "")
                        MessageBox.Show("يجب كتابة اسم الطالب ,والرقم الجامعي اولا");
                    else if (name.Text.Trim() == "" && numPhone.Text.Trim() == "")
                        MessageBox.Show("يجب كتابة اسم الطالب ,ورقم الهاتف اولا");
                    else if (id.Text.Trim() == "" && mm.Text.Trim() == "")
                        MessageBox.Show("يجب كتابة يجب كتابة الرقم الجامعي والتخصص اولا");
                    else if (id.Text.Trim() == "" && numPhone.Text.Trim() == "")
                        MessageBox.Show(" يجب كتابة الرقم الجامعي ورقم الهاتف اولا");
                    else if (mm.Text.Trim() == "" && numPhone.Text.Trim() == "")
                        MessageBox.Show("يجب كتابة التخصص ورقم الهاتف اولا");
                    else if (name.Text.Trim() == "")
                        MessageBox.Show("يجب ان لا يكون اسم الطالب فارغاً");
                    else if (id.Text.Trim() == "")
                        MessageBox.Show("يجب ان لا يكون الرقم الجامعي فارغاً");
                    else if (mm.Text.Trim() == "")
                        MessageBox.Show("يجب ان لا يكون التخصص فارغاً");
                    else if (numPhone.Text.Trim() == "")
                        MessageBox.Show("يجب ان لا يكون رقم الهاتف فارغاً");
                    else if (input.Length < 9)
                    {
                        MessageBox.Show("يجب ان لا يكون رقم الهاتف اقل من 9 ارقام");
                        numPhone.Focus();
                        numPhone.SelectAll();
                    }
                    else if (input.Length > 9)
                    {
                        MessageBox.Show("يجب ان لا يكون رقم الهاتف اكتر من 9 ارقام");
                        numPhone.Focus();
                        numPhone.SelectAll();
                    }
                    else if (cbxCity.Text == "")
                        MessageBox.Show("يجب تحديد المحافظة");
                }
                else if (strChek.Contains(id.Text + ";"))// تحقق من ان الرقم الجامعي غير مكرر
                {
                    MessageBox.Show("الرقم الجامعي موجود سابقا يرجي اعادة ادخال رقم جامعي جديد");
                    id.Focus();
                    id.SelectAll();

                }
                else
                {

                    StreamWriter sw = new StreamWriter("Data.txt", true); //لتخزين البيانات في ملف txt
                    string strStudent = id.Text + ";" + name.Text + ";" + mm.SelectedItem + ";" + numPhone.Text + ";" + age.Text + ";" + cbxCity.SelectedItem + ";" + s;
                    sw.WriteLine(strStudent);
                    sw.Close(); //يجب الاغلاق بعد حفظ البيانات
                    data1.Rows.Add(id.Text, name.Text, mm.Text, numPhone.Text, age.Text, cbxCity.SelectedItem, s);

                    foreach (Control c in this.Controls)
                    {

                        if (c is TextBox || c is ComboBox)
                        {
                            c.Text = "";
                            id.Focus();
                        }
                    }
                    MessageBox.Show("تم اضافة البيانات بنجاح");
                }






            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }




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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e)
        {
            if (id.Text.Trim() != "")
            {
                StreamReader sr = new StreamReader("Data.txt");
                string line = "";
                bool found = false;
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] arrData = line.Split(';');
                        if (arrData[0] == id.Text)
                        {
                            id.Text = arrData[0];
                            name.Text = arrData[1];
                            mm.Text = arrData[2];
                            numPhone.Text = arrData[3];
                            age.Text = arrData[4];
                            cbxCity.Text = arrData[5];
                            if (arrData[6] == "ذكر")
                            { male.Checked = true; }
                            else
                            { fmale.Checked = true; }
                            found = true;
                            break;

                        }

                    }
                } while (line != null);

                sr.Close();
                if (!found)
                {
                    MessageBox.Show("الرقم الجامعي غير موجود!");
                    id.Focus();
                    id.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("يرجى ادخال الرقم الجامعي الذي تريد البحث عنه اولاً ثم حاول مجدداً", "خطأ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                id.Focus();
            }
            }

        private void GO_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3(); // العودة الى الصفحة السابقة
            this.Hide();
            fmr.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
    }

    


