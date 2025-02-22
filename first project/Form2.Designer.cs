namespace first_project
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.data1 = new System.Windows.Forms.DataGridView();
            this.mm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mm6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.find = new System.Windows.Forms.Button();
            this.mm5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.mm4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.addData = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPhone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mm3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.male = new System.Windows.Forms.RadioButton();
            this.fmale = new System.Windows.Forms.RadioButton();
            this.mm = new System.Windows.Forms.ComboBox();
            this.GO = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // data1
            // 
            this.data1.BackgroundColor = System.Drawing.Color.White;
            this.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mm1,
            this.m2,
            this.m3,
            this.m4,
            this.m5,
            this.m6,
            this.Column1});
            this.data1.Location = new System.Drawing.Point(-8, 375);
            this.data1.Name = "data1";
            this.data1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.data1.RowHeadersWidth = 51;
            this.data1.RowTemplate.Height = 26;
            this.data1.Size = new System.Drawing.Size(817, 116);
            this.data1.TabIndex = 20;
            // 
            // mm1
            // 
            this.mm1.HeaderText = "الرقم الجامعي";
            this.mm1.MinimumWidth = 6;
            this.mm1.Name = "mm1";
            this.mm1.Width = 125;
            // 
            // m2
            // 
            this.m2.HeaderText = "اسم الطالب";
            this.m2.MinimumWidth = 6;
            this.m2.Name = "m2";
            this.m2.Width = 125;
            // 
            // m3
            // 
            this.m3.HeaderText = "التخصص";
            this.m3.MinimumWidth = 6;
            this.m3.Name = "m3";
            this.m3.Width = 125;
            // 
            // m4
            // 
            this.m4.HeaderText = "رقم الهاتف";
            this.m4.MinimumWidth = 6;
            this.m4.Name = "m4";
            this.m4.Width = 125;
            // 
            // m5
            // 
            this.m5.HeaderText = "العمر";
            this.m5.MinimumWidth = 6;
            this.m5.Name = "m5";
            this.m5.Width = 125;
            // 
            // m6
            // 
            this.m6.HeaderText = "المحافظة";
            this.m6.MinimumWidth = 6;
            this.m6.Name = "m6";
            this.m6.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "الجنس";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // mm6
            // 
            this.mm6.HeaderText = "المحافظة";
            this.mm6.MinimumWidth = 6;
            this.mm6.Name = "mm6";
            this.mm6.Width = 125;
            // 
            // find
            // 
            this.find.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.find.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find.Image = ((System.Drawing.Image)(resources.GetObject("find.Image")));
            this.find.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.find.Location = new System.Drawing.Point(36, 291);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(116, 45);
            this.find.TabIndex = 19;
            this.find.Text = "بحث";
            this.find.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.find.UseVisualStyleBackColor = false;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // mm5
            // 
            this.mm5.HeaderText = "العمر";
            this.mm5.MinimumWidth = 6;
            this.mm5.Name = "mm5";
            this.mm5.Width = 125;
            // 
            // mm2
            // 
            this.mm2.HeaderText = "اسم الطالب";
            this.mm2.MinimumWidth = 6;
            this.mm2.Name = "mm2";
            this.mm2.Width = 125;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(244, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 45);
            this.button3.TabIndex = 18;
            this.button3.Text = "حذف";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // mm4
            // 
            this.mm4.HeaderText = "رقم الهاتف";
            this.mm4.MinimumWidth = 6;
            this.mm4.Name = "mm4";
            this.mm4.Width = 125;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(433, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "تعديل";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addData
            // 
            this.addData.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addData.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addData.Image = ((System.Drawing.Image)(resources.GetObject("addData.Image")));
            this.addData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addData.Location = new System.Drawing.Point(600, 291);
            this.addData.Name = "addData";
            this.addData.Size = new System.Drawing.Size(128, 45);
            this.addData.TabIndex = 16;
            this.addData.Text = "أضافة";
            this.addData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addData.UseVisualStyleBackColor = false;
            this.addData.Click += new System.EventHandler(this.addData_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(215, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "المحافظة";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(704, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "التخصص";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "رقم الهاتف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "العمر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(680, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم الطالب";
            // 
            // numPhone
            // 
            this.numPhone.Location = new System.Drawing.Point(25, 66);
            this.numPhone.Name = "numPhone";
            this.numPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numPhone.Size = new System.Drawing.Size(153, 24);
            this.numPhone.TabIndex = 7;
            this.toolTip1.SetToolTip(this.numPhone, "يجب ان لا يقل رقم الهاتف عن تسعة ارقام  ");
            this.numPhone.TextChanged += new System.EventHandler(this.numPhone_TextChanged);
            this.numPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numPhone_KeyPress);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(341, 109);
            this.name.Name = "name";
            this.name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name.Size = new System.Drawing.Size(314, 24);
            this.name.TabIndex = 3;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(25, 113);
            this.age.Name = "age";
            this.age.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.age.Size = new System.Drawing.Size(153, 24);
            this.age.TabIndex = 9;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(424, 65);
            this.id.Name = "id";
            this.id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.id.Size = new System.Drawing.Size(231, 24);
            this.id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(661, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "الرقم الجامعي";
            // 
            // mm3
            // 
            this.mm3.HeaderText = "التخصص";
            this.mm3.MinimumWidth = 6;
            this.mm3.Name = "mm3";
            this.mm3.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "الجنس";
            // 
            // cbxCity
            // 
            this.cbxCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Items.AddRange(new object[] {
            "أمانة العاصمة",
            "صنعاء",
            "تعز",
            "مأرب",
            "عدن",
            "ذمار",
            "إب",
            "ريمة",
            "الضالع",
            "حجه",
            "لحج",
            "صعدة",
            "البيضاء",
            "شبوة",
            "ابين",
            "حضرموت",
            "المهرة",
            "سقطرى",
            "الحديدة",
            "عمران",
            "المحويت",
            "الجوف"});
            this.cbxCity.Location = new System.Drawing.Point(25, 165);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxCity.Size = new System.Drawing.Size(153, 24);
            this.cbxCity.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(895, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(138, 248);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 21);
            this.male.TabIndex = 13;
            this.male.TabStop = true;
            this.male.Text = "ذكر";
            this.male.UseVisualStyleBackColor = true;
            // 
            // fmale
            // 
            this.fmale.AutoSize = true;
            this.fmale.Location = new System.Drawing.Point(36, 248);
            this.fmale.Name = "fmale";
            this.fmale.Size = new System.Drawing.Size(55, 21);
            this.fmale.TabIndex = 14;
            this.fmale.TabStop = true;
            this.fmale.Text = "انثى";
            this.fmale.UseVisualStyleBackColor = true;
            // 
            // mm
            // 
            this.mm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.mm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.mm.FormattingEnabled = true;
            this.mm.Items.AddRange(new object[] {
            "علوم حاسوب",
            "IT",
            "امن سبراني",
            "نظم معلومات"});
            this.mm.Location = new System.Drawing.Point(424, 175);
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(236, 24);
            this.mm.TabIndex = 6;
            // 
            // GO
            // 
            this.GO.BackColor = System.Drawing.Color.SteelBlue;
            this.GO.Font = new System.Drawing.Font("Wide Latin", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GO.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.GO.Location = new System.Drawing.Point(-6, 3);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(158, 47);
            this.GO.TabIndex = 44;
            this.GO.Text = "للرجوع";
            this.GO.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.GO.UseVisualStyleBackColor = false;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(812, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.fmale);
            this.Controls.Add(this.male);
            this.Controls.Add(this.cbxCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.data1);
            this.Controls.Add(this.find);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numPhone);
            this.Controls.Add(this.name);
            this.Controls.Add(this.age);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2;
        private System.Windows.Forms.DataGridViewTextBoxColumn m3;
        private System.Windows.Forms.DataGridViewTextBoxColumn m4;
        private System.Windows.Forms.DataGridViewTextBoxColumn m5;
        private System.Windows.Forms.DataGridViewTextBoxColumn m6;
        private System.Windows.Forms.DataGridViewTextBoxColumn mm6;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.DataGridViewTextBoxColumn mm5;
        private System.Windows.Forms.DataGridViewTextBoxColumn mm2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn mm4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numPhone;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mm3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton fmale;
        private System.Windows.Forms.ComboBox mm;
        private System.Windows.Forms.Button GO;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}