namespace first_project
{
    partial class Form4
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
            this.addUser = new System.Windows.Forms.Label();
            this.coum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userNameNew = new System.Windows.Forms.TextBox();
            this.confirmPass = new System.Windows.Forms.TextBox();
            this.passNew = new System.Windows.Forms.TextBox();
            this.addus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUser
            // 
            this.addUser.AutoSize = true;
            this.addUser.Location = new System.Drawing.Point(672, 62);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(101, 17);
            this.addUser.TabIndex = 0;
            this.addUser.Text = "اسم المستخدم";
            // 
            // coum
            // 
            this.coum.AutoSize = true;
            this.coum.Location = new System.Drawing.Point(667, 161);
            this.coum.Name = "coum";
            this.coum.Size = new System.Drawing.Size(106, 17);
            this.coum.TabIndex = 1;
            this.coum.Text = "تأكيد كلمة المرور";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(699, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "كلمة المرور";
            // 
            // userNameNew
            // 
            this.userNameNew.Location = new System.Drawing.Point(375, 62);
            this.userNameNew.Name = "userNameNew";
            this.userNameNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameNew.Size = new System.Drawing.Size(263, 24);
            this.userNameNew.TabIndex = 3;
            this.userNameNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmPass
            // 
            this.confirmPass.Location = new System.Drawing.Point(375, 161);
            this.confirmPass.Name = "confirmPass";
            this.confirmPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirmPass.Size = new System.Drawing.Size(263, 24);
            this.confirmPass.TabIndex = 5;
            this.confirmPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passNew
            // 
            this.passNew.Location = new System.Drawing.Point(375, 113);
            this.passNew.Name = "passNew";
            this.passNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passNew.Size = new System.Drawing.Size(263, 24);
            this.passNew.TabIndex = 4;
            this.passNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addus
            // 
            this.addus.Location = new System.Drawing.Point(675, 259);
            this.addus.Name = "addus";
            this.addus.Size = new System.Drawing.Size(76, 31);
            this.addus.TabIndex = 6;
            this.addus.Text = "إضافة";
            this.addus.UseVisualStyleBackColor = true;
            this.addus.Click += new System.EventHandler(this.addus_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "بحث";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(472, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 31);
            this.button3.TabIndex = 8;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(576, 259);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 31);
            this.button4.TabIndex = 9;
            this.button4.Text = "حفظ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addus);
            this.Controls.Add(this.passNew);
            this.Controls.Add(this.confirmPass);
            this.Controls.Add(this.userNameNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coum);
            this.Controls.Add(this.addUser);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addUser;
        private System.Windows.Forms.Label coum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userNameNew;
        private System.Windows.Forms.TextBox confirmPass;
        private System.Windows.Forms.TextBox passNew;
        private System.Windows.Forms.Button addus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}