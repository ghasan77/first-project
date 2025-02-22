namespace first_project
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.full_name = new System.Windows.Forms.Label();
            this.mangeUseres = new System.Windows.Forms.Button();
            this.studentes = new System.Windows.Forms.Button();
            this.N_USER = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.الادواتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculator = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.full_name);
            this.panel1.Controls.Add(this.mangeUseres);
            this.panel1.Controls.Add(this.studentes);
            this.panel1.Controls.Add(this.N_USER);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(596, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 450);
            this.panel1.TabIndex = 0;
            // 
            // full_name
            // 
            this.full_name.AutoSize = true;
            this.full_name.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.full_name.Location = new System.Drawing.Point(88, 135);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(34, 17);
            this.full_name.TabIndex = 5;
            this.full_name.Text = "user";
            this.full_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.full_name.Click += new System.EventHandler(this.full_name_Click);
            // 
            // mangeUseres
            // 
            this.mangeUseres.Location = new System.Drawing.Point(32, 274);
            this.mangeUseres.Name = "mangeUseres";
            this.mangeUseres.Size = new System.Drawing.Size(160, 30);
            this.mangeUseres.TabIndex = 3;
            this.mangeUseres.Text = "ادارة المستخدمين";
            this.mangeUseres.UseVisualStyleBackColor = true;
            this.mangeUseres.Click += new System.EventHandler(this.mangeUseres_Click);
            // 
            // studentes
            // 
            this.studentes.Location = new System.Drawing.Point(32, 209);
            this.studentes.Name = "studentes";
            this.studentes.Size = new System.Drawing.Size(160, 35);
            this.studentes.TabIndex = 2;
            this.studentes.Text = "ادارة بيانات الطلاب";
            this.studentes.UseVisualStyleBackColor = true;
            this.studentes.Click += new System.EventHandler(this.studentes_Click);
            // 
            // N_USER
            // 
            this.N_USER.AutoSize = true;
            this.N_USER.Location = new System.Drawing.Point(159, 135);
            this.N_USER.Name = "N_USER";
            this.N_USER.Size = new System.Drawing.Size(0, 17);
            this.N_USER.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(32, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 110);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 75);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(596, 71);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الادواتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(596, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // الادواتToolStripMenuItem
            // 
            this.الادواتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculator});
            this.الادواتToolStripMenuItem.Name = "الادواتToolStripMenuItem";
            this.الادواتToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.الادواتToolStripMenuItem.Text = "الادوات";
            // 
            // calculator
            // 
            this.calculator.Name = "calculator";
            this.calculator.Size = new System.Drawing.Size(224, 26);
            this.calculator.Text = "الآلة الحاسبة";
            this.calculator.Click += new System.EventHandler(this.calculator_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button mangeUseres;
        private System.Windows.Forms.Button studentes;
        private System.Windows.Forms.Label N_USER;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label full_name;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الادواتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculator;
    }
}