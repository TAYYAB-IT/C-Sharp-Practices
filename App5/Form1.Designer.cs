namespace App5
{
    partial class Form1
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
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rollno = new System.Windows.Forms.TextBox();
            this.cnic = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.country = new System.Windows.Forms.TextBox();
            this.Roll_No = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lable2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.reception = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(294, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // rollno
            // 
            this.rollno.Location = new System.Drawing.Point(294, 71);
            this.rollno.Name = "rollno";
            this.rollno.Size = new System.Drawing.Size(100, 20);
            this.rollno.TabIndex = 0;
            // 
            // cnic
            // 
            this.cnic.Location = new System.Drawing.Point(294, 115);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(100, 20);
            this.cnic.TabIndex = 0;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(294, 160);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 20);
            this.age.TabIndex = 0;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(294, 207);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 0;
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(294, 248);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(100, 20);
            this.country.TabIndex = 0;
            // 
            // Roll_No
            // 
            this.Roll_No.AutoSize = true;
            this.Roll_No.Location = new System.Drawing.Point(240, 74);
            this.Roll_No.Name = "Roll_No";
            this.Roll_No.Size = new System.Drawing.Size(32, 13);
            this.Roll_No.TabIndex = 1;
            this.Roll_No.Text = "Roll#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CNIC#";
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(240, 163);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(26, 13);
            this.lable2.TabIndex = 1;
            this.lable2.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Country";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reception
            // 
            this.reception.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reception.Location = new System.Drawing.Point(447, 71);
            this.reception.Name = "reception";
            this.reception.ReadOnly = true;
            this.reception.Size = new System.Drawing.Size(309, 266);
            this.reception.TabIndex = 3;
            this.reception.Text = "";
            this.reception.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reception);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Roll_No);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.country);
            this.Controls.Add(this.city);
            this.Controls.Add(this.age);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.rollno);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rollno;
        private System.Windows.Forms.TextBox cnic;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label Roll_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox reception;
    }
}

