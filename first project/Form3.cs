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
    public partial class Form3 : Form
    {
        public Form3()
        {
            
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetUserName(string userName)
        {
            full_name.Text = userName;  
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

    }
}
