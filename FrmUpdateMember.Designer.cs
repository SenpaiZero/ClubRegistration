namespace ClubRegistration
{
    partial class FrmUpdateMember
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
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.programCB = new System.Windows.Forms.ComboBox();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.mNameTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.studentCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Program";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Middle Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Student ID";
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Location = new System.Drawing.Point(32, 274);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(181, 24);
            this.genderCB.TabIndex = 21;
            // 
            // programCB
            // 
            this.programCB.FormattingEnabled = true;
            this.programCB.Location = new System.Drawing.Point(32, 321);
            this.programCB.Name = "programCB";
            this.programCB.Size = new System.Drawing.Size(181, 24);
            this.programCB.TabIndex = 20;
            // 
            // lNameTB
            // 
            this.lNameTB.Location = new System.Drawing.Point(32, 96);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(181, 22);
            this.lNameTB.TabIndex = 19;
            // 
            // fNameTB
            // 
            this.fNameTB.Location = new System.Drawing.Point(32, 140);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.Size = new System.Drawing.Size(181, 22);
            this.fNameTB.TabIndex = 18;
            // 
            // mNameTB
            // 
            this.mNameTB.Location = new System.Drawing.Point(32, 182);
            this.mNameTB.Name = "mNameTB";
            this.mNameTB.Size = new System.Drawing.Size(181, 22);
            this.mNameTB.TabIndex = 17;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(32, 231);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(181, 22);
            this.ageTB.TabIndex = 16;
            // 
            // confirmBtn
            // 
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.confirmBtn.Location = new System.Drawing.Point(62, 351);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(120, 41);
            this.confirmBtn.TabIndex = 29;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // studentCB
            // 
            this.studentCB.FormattingEnabled = true;
            this.studentCB.Location = new System.Drawing.Point(32, 43);
            this.studentCB.Name = "studentCB";
            this.studentCB.Size = new System.Drawing.Size(181, 24);
            this.studentCB.TabIndex = 30;
            this.studentCB.SelectedIndexChanged += new System.EventHandler(this.studentCB_SelectedIndexChanged);
            // 
            // FrmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(242, 417);
            this.Controls.Add(this.studentCB);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.programCB);
            this.Controls.Add(this.lNameTB);
            this.Controls.Add(this.fNameTB);
            this.Controls.Add(this.mNameTB);
            this.Controls.Add(this.ageTB);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmUpdateMember";
            this.Text = "FrmUpdateMember";
            this.Load += new System.EventHandler(this.FrmUpdateMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.ComboBox programCB;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.TextBox mNameTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.ComboBox studentCB;
    }
}