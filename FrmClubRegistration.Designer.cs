namespace ClubRegistration
{
    partial class FrmClubRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.studentIdTB = new System.Windows.Forms.TextBox();
            this.ageTB = new System.Windows.Forms.TextBox();
            this.mNameTB = new System.Windows.Forms.TextBox();
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.programCB = new System.Windows.Forms.ComboBox();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.clubMemberGrid = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.clubMemberGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIdTB
            // 
            this.studentIdTB.Location = new System.Drawing.Point(45, 52);
            this.studentIdTB.Name = "studentIdTB";
            this.studentIdTB.Size = new System.Drawing.Size(181, 22);
            this.studentIdTB.TabIndex = 0;
            // 
            // ageTB
            // 
            this.ageTB.Location = new System.Drawing.Point(45, 176);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(113, 22);
            this.ageTB.TabIndex = 1;
            // 
            // mNameTB
            // 
            this.mNameTB.Location = new System.Drawing.Point(407, 105);
            this.mNameTB.Name = "mNameTB";
            this.mNameTB.Size = new System.Drawing.Size(154, 22);
            this.mNameTB.TabIndex = 2;
            // 
            // fNameTB
            // 
            this.fNameTB.Location = new System.Drawing.Point(233, 105);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.Size = new System.Drawing.Size(168, 22);
            this.fNameTB.TabIndex = 3;
            // 
            // lNameTB
            // 
            this.lNameTB.Location = new System.Drawing.Point(45, 105);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(181, 22);
            this.lNameTB.TabIndex = 4;
            // 
            // programCB
            // 
            this.programCB.FormattingEnabled = true;
            this.programCB.Items.AddRange(new object[] {
            "BSIT",
            "BSCS",
            "BSIS",
            "IT"});
            this.programCB.Location = new System.Drawing.Point(407, 52);
            this.programCB.Name = "programCB";
            this.programCB.Size = new System.Drawing.Size(154, 24);
            this.programCB.TabIndex = 5;
            // 
            // genderCB
            // 
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.genderCB.Location = new System.Drawing.Point(233, 176);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(121, 24);
            this.genderCB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Middle Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Program";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "List of Club Members";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Last Name";
            // 
            // registerBtn
            // 
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.registerBtn.Location = new System.Drawing.Point(577, 52);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(120, 59);
            this.registerBtn.TabIndex = 15;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // clubMemberGrid
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clubMemberGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.clubMemberGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clubMemberGrid.Location = new System.Drawing.Point(45, 247);
            this.clubMemberGrid.Name = "clubMemberGrid";
            this.clubMemberGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.clubMemberGrid.RowTemplate.Height = 24;
            this.clubMemberGrid.Size = new System.Drawing.Size(516, 178);
            this.clubMemberGrid.TabIndex = 18;
            // 
            // updateBtn
            // 
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.updateBtn.Location = new System.Drawing.Point(577, 117);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(120, 59);
            this.updateBtn.TabIndex = 19;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.refreshBtn.Location = new System.Drawing.Point(577, 247);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(120, 59);
            this.refreshBtn.TabIndex = 20;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // FrmClubRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.clubMemberGrid);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
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
            this.Controls.Add(this.studentIdTB);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "FrmClubRegistration";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmClubRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clubMemberGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentIdTB;
        private System.Windows.Forms.TextBox ageTB;
        private System.Windows.Forms.TextBox mNameTB;
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.ComboBox programCB;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.DataGridView clubMemberGrid;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}

