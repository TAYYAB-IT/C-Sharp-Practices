namespace App2
{
    partial class Calculator
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
            this.result = new System.Windows.Forms.RichTextBox();
            this.operation = new System.Windows.Forms.TextBox();
            this.op1 = new System.Windows.Forms.TextBox();
            this.op2 = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Cursor = System.Windows.Forms.Cursors.No;
            this.result.Location = new System.Drawing.Point(259, 12);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(202, 48);
            this.result.TabIndex = 1;
            this.result.Text = "";
            // 
            // operation
            // 
            this.operation.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operation.ForeColor = System.Drawing.SystemColors.Window;
            this.operation.Location = new System.Drawing.Point(348, 85);
            this.operation.Name = "operation";
            this.operation.ReadOnly = true;
            this.operation.Size = new System.Drawing.Size(24, 24);
            this.operation.TabIndex = 3;
            this.operation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // op1
            // 
            this.op1.Location = new System.Drawing.Point(259, 78);
            this.op1.Multiline = true;
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(83, 32);
            this.op1.TabIndex = 2;
            this.op1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // op2
            // 
            this.op2.Location = new System.Drawing.Point(378, 78);
            this.op2.Multiline = true;
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(83, 32);
            this.op2.TabIndex = 4;
            this.op2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add.Location = new System.Drawing.Point(301, 127);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(41, 28);
            this.add.TabIndex = 5;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sub.Location = new System.Drawing.Point(378, 127);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(41, 28);
            this.sub.TabIndex = 6;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.mul.Location = new System.Drawing.Point(301, 172);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(41, 28);
            this.mul.TabIndex = 7;
            this.mul.Text = "x";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.div.Location = new System.Drawing.Point(378, 172);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(41, 28);
            this.div.TabIndex = 8;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(425, 127);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(35, 28);
            this.clear.TabIndex = 9;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.op1);
            this.Controls.Add(this.result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.TextBox operation;
        private System.Windows.Forms.TextBox op1;
        private System.Windows.Forms.TextBox op2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button clear;
    }
}

