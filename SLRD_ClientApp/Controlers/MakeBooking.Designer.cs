namespace SLRD_ClientApp.Controlers
{
    partial class MakeBooking
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
            groupBox1 = new GroupBox();
            btnValidate = new Button();
            btnGetOtp = new Button();
            txtOTPCode = new TextBox();
            txtNIC = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            dtPickDate = new DateTimePicker();
            txtTrainId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            cmbRoute = new ComboBox();
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            btnS18 = new Button();
            btnS1 = new Button();
            btnS15 = new Button();
            btnS4 = new Button();
            btnS12 = new Button();
            btnS7 = new Button();
            btnS21 = new Button();
            btnS10 = new Button();
            btnS20 = new Button();
            btnS13 = new Button();
            btnS17 = new Button();
            btnS16 = new Button();
            btnS14 = new Button();
            btnS19 = new Button();
            btnS11 = new Button();
            btnS3 = new Button();
            btnS8 = new Button();
            btnS6 = new Button();
            btnS5 = new Button();
            btnS9 = new Button();
            btnS2 = new Button();
            panel2 = new Panel();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnValidate);
            groupBox1.Controls.Add(btnGetOtp);
            groupBox1.Controls.Add(txtOTPCode);
            groupBox1.Controls.Add(txtNIC);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 108);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Passenger Identification";
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(407, 41);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(94, 56);
            btnValidate.TabIndex = 3;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            // 
            // btnGetOtp
            // 
            btnGetOtp.Location = new Point(275, 41);
            btnGetOtp.Name = "btnGetOtp";
            btnGetOtp.Size = new Size(92, 56);
            btnGetOtp.TabIndex = 2;
            btnGetOtp.Text = "Get OTP";
            btnGetOtp.UseVisualStyleBackColor = true;
            // 
            // txtOTPCode
            // 
            txtOTPCode.Location = new Point(128, 70);
            txtOTPCode.Name = "txtOTPCode";
            txtOTPCode.Size = new Size(141, 27);
            txtOTPCode.TabIndex = 1;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(128, 37);
            txtNIC.MaxLength = 12;
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(141, 27);
            txtNIC.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 73);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 0;
            label2.Text = "OTP Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 36);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 0;
            label1.Text = "NIC";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dtPickDate);
            groupBox2.Controls.Add(txtTrainId);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbRoute);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(673, 147);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Booking";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 110);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 8;
            label5.Text = "Date";
            // 
            // dtPickDate
            // 
            dtPickDate.CustomFormat = "MM-dd-yyyy";
            dtPickDate.Format = DateTimePickerFormat.Custom;
            dtPickDate.Location = new Point(128, 105);
            dtPickDate.Name = "dtPickDate";
            dtPickDate.Size = new Size(125, 27);
            dtPickDate.TabIndex = 7;
            // 
            // txtTrainId
            // 
            txtTrainId.Location = new Point(128, 72);
            txtTrainId.Name = "txtTrainId";
            txtTrainId.Size = new Size(506, 27);
            txtTrainId.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 75);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 5;
            label4.Text = "Train";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 41);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Route";
            // 
            // cmbRoute
            // 
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(128, 38);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(506, 28);
            cmbRoute.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 333);
            panel1.Name = "panel1";
            panel1.Size = new Size(673, 243);
            panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnS18);
            groupBox3.Controls.Add(btnS1);
            groupBox3.Controls.Add(btnS15);
            groupBox3.Controls.Add(btnS4);
            groupBox3.Controls.Add(btnS12);
            groupBox3.Controls.Add(btnS7);
            groupBox3.Controls.Add(btnS21);
            groupBox3.Controls.Add(btnS10);
            groupBox3.Controls.Add(btnS20);
            groupBox3.Controls.Add(btnS13);
            groupBox3.Controls.Add(btnS17);
            groupBox3.Controls.Add(btnS16);
            groupBox3.Controls.Add(btnS14);
            groupBox3.Controls.Add(btnS19);
            groupBox3.Controls.Add(btnS11);
            groupBox3.Controls.Add(btnS3);
            groupBox3.Controls.Add(btnS8);
            groupBox3.Controls.Add(btnS6);
            groupBox3.Controls.Add(btnS5);
            groupBox3.Controls.Add(btnS9);
            groupBox3.Controls.Add(btnS2);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(673, 243);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Seat Number";
            // 
            // btnS18
            // 
            btnS18.Location = new Point(461, 168);
            btnS18.Name = "btnS18";
            btnS18.Size = new Size(77, 65);
            btnS18.TabIndex = 0;
            btnS18.Text = "18";
            btnS18.UseVisualStyleBackColor = true;
            // 
            // btnS1
            // 
            btnS1.Location = new Point(46, 26);
            btnS1.Name = "btnS1";
            btnS1.Size = new Size(77, 65);
            btnS1.TabIndex = 0;
            btnS1.Text = "01";
            btnS1.UseVisualStyleBackColor = true;
            btnS1.Click += btnS1_Click;
            // 
            // btnS15
            // 
            btnS15.Location = new Point(378, 168);
            btnS15.Name = "btnS15";
            btnS15.Size = new Size(77, 65);
            btnS15.TabIndex = 0;
            btnS15.Text = "15";
            btnS15.UseVisualStyleBackColor = true;
            // 
            // btnS4
            // 
            btnS4.Location = new Point(129, 26);
            btnS4.Name = "btnS4";
            btnS4.Size = new Size(77, 65);
            btnS4.TabIndex = 0;
            btnS4.Text = "04";
            btnS4.UseVisualStyleBackColor = true;
            // 
            // btnS12
            // 
            btnS12.Location = new Point(295, 168);
            btnS12.Name = "btnS12";
            btnS12.Size = new Size(77, 65);
            btnS12.TabIndex = 0;
            btnS12.Text = "12";
            btnS12.UseVisualStyleBackColor = true;
            // 
            // btnS7
            // 
            btnS7.Location = new Point(212, 26);
            btnS7.Name = "btnS7";
            btnS7.Size = new Size(77, 65);
            btnS7.TabIndex = 0;
            btnS7.Text = "07";
            btnS7.UseVisualStyleBackColor = true;
            // 
            // btnS21
            // 
            btnS21.Location = new Point(544, 168);
            btnS21.Name = "btnS21";
            btnS21.Size = new Size(77, 65);
            btnS21.TabIndex = 0;
            btnS21.Text = "21";
            btnS21.UseVisualStyleBackColor = true;
            // 
            // btnS10
            // 
            btnS10.Location = new Point(295, 26);
            btnS10.Name = "btnS10";
            btnS10.Size = new Size(77, 65);
            btnS10.TabIndex = 0;
            btnS10.Text = "10";
            btnS10.UseVisualStyleBackColor = true;
            // 
            // btnS20
            // 
            btnS20.Location = new Point(544, 97);
            btnS20.Name = "btnS20";
            btnS20.Size = new Size(77, 65);
            btnS20.TabIndex = 0;
            btnS20.Text = "20";
            btnS20.UseVisualStyleBackColor = true;
            // 
            // btnS13
            // 
            btnS13.Location = new Point(378, 26);
            btnS13.Name = "btnS13";
            btnS13.Size = new Size(77, 65);
            btnS13.TabIndex = 0;
            btnS13.Text = "13";
            btnS13.UseVisualStyleBackColor = true;
            // 
            // btnS17
            // 
            btnS17.Location = new Point(461, 97);
            btnS17.Name = "btnS17";
            btnS17.Size = new Size(77, 65);
            btnS17.TabIndex = 0;
            btnS17.Text = "17";
            btnS17.UseVisualStyleBackColor = true;
            // 
            // btnS16
            // 
            btnS16.Location = new Point(461, 26);
            btnS16.Name = "btnS16";
            btnS16.Size = new Size(77, 65);
            btnS16.TabIndex = 0;
            btnS16.Text = "16";
            btnS16.UseVisualStyleBackColor = true;
            // 
            // btnS14
            // 
            btnS14.Location = new Point(378, 97);
            btnS14.Name = "btnS14";
            btnS14.Size = new Size(77, 65);
            btnS14.TabIndex = 0;
            btnS14.Text = "14";
            btnS14.UseVisualStyleBackColor = true;
            // 
            // btnS19
            // 
            btnS19.Location = new Point(544, 26);
            btnS19.Name = "btnS19";
            btnS19.Size = new Size(77, 65);
            btnS19.TabIndex = 0;
            btnS19.Text = "19";
            btnS19.UseVisualStyleBackColor = true;
            // 
            // btnS11
            // 
            btnS11.Location = new Point(295, 97);
            btnS11.Name = "btnS11";
            btnS11.Size = new Size(77, 65);
            btnS11.TabIndex = 0;
            btnS11.Text = "11";
            btnS11.UseVisualStyleBackColor = true;
            // 
            // btnS3
            // 
            btnS3.Location = new Point(46, 168);
            btnS3.Name = "btnS3";
            btnS3.Size = new Size(77, 65);
            btnS3.TabIndex = 0;
            btnS3.Text = "03";
            btnS3.UseVisualStyleBackColor = true;
            // 
            // btnS8
            // 
            btnS8.Location = new Point(212, 97);
            btnS8.Name = "btnS8";
            btnS8.Size = new Size(77, 65);
            btnS8.TabIndex = 0;
            btnS8.Text = "08";
            btnS8.UseVisualStyleBackColor = true;
            // 
            // btnS6
            // 
            btnS6.Location = new Point(129, 168);
            btnS6.Name = "btnS6";
            btnS6.Size = new Size(77, 65);
            btnS6.TabIndex = 0;
            btnS6.Text = "06";
            btnS6.UseVisualStyleBackColor = true;
            // 
            // btnS5
            // 
            btnS5.Location = new Point(129, 97);
            btnS5.Name = "btnS5";
            btnS5.Size = new Size(77, 65);
            btnS5.TabIndex = 0;
            btnS5.Text = "05";
            btnS5.UseVisualStyleBackColor = true;
            // 
            // btnS9
            // 
            btnS9.Location = new Point(212, 168);
            btnS9.Name = "btnS9";
            btnS9.Size = new Size(77, 65);
            btnS9.TabIndex = 0;
            btnS9.Text = "09";
            btnS9.UseVisualStyleBackColor = true;
            // 
            // btnS2
            // 
            btnS2.Location = new Point(46, 97);
            btnS2.Name = "btnS2";
            btnS2.Size = new Size(77, 65);
            btnS2.TabIndex = 0;
            btnS2.Text = "02";
            btnS2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 78);
            panel2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(224, 21);
            label6.Name = "label6";
            label6.Size = new Size(208, 38);
            label6.TabIndex = 3;
            label6.Text = "Make Booking";
            // 
            // MakeBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 576);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Name = "MakeBooking";
            Text = "MakeBooking";
            Load += MakeBooking_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtOTPCode;
        private TextBox txtNIC;
        private Label label2;
        private Label label1;
        private Button btnGetOtp;
        private Button btnValidate;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox cmbRoute;
        private Label label5;
        private DateTimePicker dtPickDate;
        private TextBox txtTrainId;
        private Label label4;
        private Panel panel1;
        private Button btnS2;
        private Button btnS1;
        private Button btnS18;
        private Button btnS15;
        private Button btnS12;
        private Button btnS20;
        private Button btnS17;
        private Button btnS14;
        private Button btnS11;
        private Button btnS8;
        private Button btnS5;
        private Button btnS9;
        private Button btnS6;
        private Button btnS3;
        private Button btnS19;
        private Button btnS16;
        private Button btnS13;
        private Button btnS10;
        private Button btnS7;
        private Button btnS4;
        private Button btnS21;
        private GroupBox groupBox3;
        private Panel panel2;
        private Label label6;
    }
}