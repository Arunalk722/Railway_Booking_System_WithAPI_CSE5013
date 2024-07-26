namespace SLRD_ClientApp.Controlers
{
    partial class MakePassengers
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
            txtNic = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            btnSave = new Button();
            label4 = new Label();
            txtPhoneNo = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNic
            // 
            txtNic.Location = new Point(195, 41);
            txtNic.MaxLength = 12;
            txtNic.Name = "txtNic";
            txtNic.Size = new Size(141, 27);
            txtNic.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 44);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 2;
            label1.Text = "NIC";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 78);
            panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPhoneNo);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtNic);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(514, 233);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Passenger Info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 23);
            label2.Name = "label2";
            label2.Size = new Size(314, 38);
            label2.TabIndex = 3;
            label2.Text = "Passenger Registration";
            // 
            // txtName
            // 
            txtName.Location = new Point(195, 74);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.Size = new Size(266, 27);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 77);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 2;
            label3.Text = "Name";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(195, 107);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 27);
            txtEmail.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 110);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 2;
            label5.Text = "Email";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(227, 171);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 56);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 141);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 5;
            label4.Text = "Phone No";
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(195, 138);
            txtPhoneNo.MaxLength = 10;
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(141, 27);
            txtPhoneNo.TabIndex = 6;
            // 
            // MakePassengers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 309);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "MakePassengers";
            Text = "MakePassengers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtNic;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtName;
        private Label label5;
        private TextBox txtEmail;
        private Button btnSave;
        private Label label4;
        private TextBox txtPhoneNo;
    }
}