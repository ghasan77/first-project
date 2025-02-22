using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace first_project
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void n_TextChanged(object sender, EventArgs e)
        {

        }




        // Add the necessary components in your form
        // PictureBox (e.g., pictureBox1)
        // Button (e.g., buttonUpload)

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to choose the image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Limit file types to images

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the image into the PictureBox
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Optional: adjust size
                }
                catch (Exception ex)
                {
                    // In case there's an error loading the image
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
       
        private void studentes_Click(object sender, EventArgs e)
        {
            Form2 fmr = new Form2();
            this.Hide();
            fmr.ShowDialog();
            this.Close();
        }

        private void mangeUseres_Click(object sender, EventArgs e)
        {
            Form4 fmr = new Form4();
            this.Hide();
            fmr.ShowDialog();
            this.Close();

        }

        private void full_name_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void calculator_Click(object sender, EventArgs e)
        {
           Form5 fmr = new Form5();
            this.Hide();
            fmr.ShowDialog();
           //this .Close();
        }

       public void setuser(string username)
        {
            full_name.Text = username;
        }
    }


}
