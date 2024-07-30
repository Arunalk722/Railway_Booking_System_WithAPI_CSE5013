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
            txtName = new TextBox();
            label7 = new Label();
            txtNIC = new TextBox();
            label1 = new Label();
            btnValidate = new Button();
            groupBox2 = new GroupBox();
            lblRouteId = new Label();
            lblTrainId = new Label();
            label5 = new Label();
            dtPickDate = new DateTimePicker();
            txtTrainName = new TextBox();
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
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtNIC);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 171);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(708, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Passenger Identification";
            // 
            // txtName
            // 
            txtName.Location = new Point(112, 55);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.MaxLength = 12;
            txtName.Name = "txtName";
            txtName.Size = new Size(124, 23);
            txtName.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 54);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 4;
            label7.Text = "Name";
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(112, 28);
            txtNIC.Margin = new Padding(3, 2, 3, 2);
            txtNIC.MaxLength = 12;
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(124, 23);
            txtNIC.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 27);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "NIC";
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(228, 79);
            btnValidate.Margin = new Padding(3, 2, 3, 2);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(82, 23);
            btnValidate.TabIndex = 3;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblRouteId);
            groupBox2.Controls.Add(lblTrainId);
            groupBox2.Controls.Add(btnValidate);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(dtPickDate);
            groupBox2.Controls.Add(txtTrainName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(cmbRoute);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 58);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(708, 113);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Booking";
            // 
            // lblRouteId
            // 
            lblRouteId.AutoSize = true;
            lblRouteId.Location = new Point(446, 36);
            lblRouteId.Name = "lblRouteId";
            lblRouteId.Size = new Size(18, 15);
            lblRouteId.TabIndex = 10;
            lblRouteId.Text = "ID";
            // 
            // lblTrainId
            // 
            lblTrainId.AutoSize = true;
            lblTrainId.Location = new Point(446, 62);
            lblTrainId.Name = "lblTrainId";
            lblTrainId.Size = new Size(18, 15);
            lblTrainId.TabIndex = 9;
            lblTrainId.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 82);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 8;
            label5.Text = "Date";
            // 
            // dtPickDate
            // 
            dtPickDate.CustomFormat = "yyyy-MM-dd";
            dtPickDate.Format = DateTimePickerFormat.Custom;
            dtPickDate.Location = new Point(112, 79);
            dtPickDate.Margin = new Padding(3, 2, 3, 2);
            dtPickDate.Name = "dtPickDate";
            dtPickDate.Size = new Size(110, 23);
            dtPickDate.TabIndex = 7;
            dtPickDate.ValueChanged += dtPickDate_ValueChanged;
            // 
            // txtTrainName
            // 
            txtTrainName.Location = new Point(112, 54);
            txtTrainName.Margin = new Padding(3, 2, 3, 2);
            txtTrainName.Name = "txtTrainName";
            txtTrainName.ReadOnly = true;
            txtTrainName.Size = new Size(328, 23);
            txtTrainName.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 56);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 5;
            label4.Text = "Train";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 31);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Route";
            // 
            // cmbRoute
            // 
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(112, 28);
            cmbRoute.Margin = new Padding(3, 2, 3, 2);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(328, 23);
            cmbRoute.TabIndex = 0;
            cmbRoute.SelectedIndexChanged += cmbRoute_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 259);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 251);
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
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(708, 251);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Seat Number";
            // 
            // btnS18
            // 
            btnS18.Location = new Point(403, 126);
            btnS18.Margin = new Padding(3, 2, 3, 2);
            btnS18.Name = "btnS18";
            btnS18.Size = new Size(67, 49);
            btnS18.TabIndex = 0;
            btnS18.Text = "18";
            btnS18.UseVisualStyleBackColor = true;
            btnS18.Click += btnS18_Click;
            // 
            // btnS1
            // 
            btnS1.Location = new Point(40, 20);
            btnS1.Margin = new Padding(3, 2, 3, 2);
            btnS1.Name = "btnS1";
            btnS1.Size = new Size(67, 49);
            btnS1.TabIndex = 0;
            btnS1.Text = "01";
            btnS1.UseVisualStyleBackColor = true;
            btnS1.Click += btnS1_Click;
            // 
            // btnS15
            // 
            btnS15.Location = new Point(331, 126);
            btnS15.Margin = new Padding(3, 2, 3, 2);
            btnS15.Name = "btnS15";
            btnS15.Size = new Size(67, 49);
            btnS15.TabIndex = 0;
            btnS15.Text = "15";
            btnS15.UseVisualStyleBackColor = true;
            btnS15.Click += btnS15_Click;
            // 
            // btnS4
            // 
            btnS4.Location = new Point(113, 20);
            btnS4.Margin = new Padding(3, 2, 3, 2);
            btnS4.Name = "btnS4";
            btnS4.Size = new Size(67, 49);
            btnS4.TabIndex = 0;
            btnS4.Text = "04";
            btnS4.UseVisualStyleBackColor = true;
            btnS4.Click += btnS4_Click;
            // 
            // btnS12
            // 
            btnS12.Location = new Point(258, 126);
            btnS12.Margin = new Padding(3, 2, 3, 2);
            btnS12.Name = "btnS12";
            btnS12.Size = new Size(67, 49);
            btnS12.TabIndex = 0;
            btnS12.Text = "12";
            btnS12.UseVisualStyleBackColor = true;
            btnS12.Click += btnS12_Click;
            // 
            // btnS7
            // 
            btnS7.Location = new Point(186, 20);
            btnS7.Margin = new Padding(3, 2, 3, 2);
            btnS7.Name = "btnS7";
            btnS7.Size = new Size(67, 49);
            btnS7.TabIndex = 0;
            btnS7.Text = "07";
            btnS7.UseVisualStyleBackColor = true;
            btnS7.Click += btnS7_Click;
            // 
            // btnS21
            // 
            btnS21.Location = new Point(476, 126);
            btnS21.Margin = new Padding(3, 2, 3, 2);
            btnS21.Name = "btnS21";
            btnS21.Size = new Size(67, 49);
            btnS21.TabIndex = 0;
            btnS21.Text = "21";
            btnS21.UseVisualStyleBackColor = true;
            btnS21.Click += btnS21_Click;
            // 
            // btnS10
            // 
            btnS10.Location = new Point(258, 20);
            btnS10.Margin = new Padding(3, 2, 3, 2);
            btnS10.Name = "btnS10";
            btnS10.Size = new Size(67, 49);
            btnS10.TabIndex = 0;
            btnS10.Text = "10";
            btnS10.UseVisualStyleBackColor = true;
            btnS10.Click += btnS10_Click;
            // 
            // btnS20
            // 
            btnS20.Location = new Point(476, 73);
            btnS20.Margin = new Padding(3, 2, 3, 2);
            btnS20.Name = "btnS20";
            btnS20.Size = new Size(67, 49);
            btnS20.TabIndex = 0;
            btnS20.Text = "20";
            btnS20.UseVisualStyleBackColor = true;
            btnS20.Click += btnS20_Click;
            // 
            // btnS13
            // 
            btnS13.Location = new Point(331, 20);
            btnS13.Margin = new Padding(3, 2, 3, 2);
            btnS13.Name = "btnS13";
            btnS13.Size = new Size(67, 49);
            btnS13.TabIndex = 0;
            btnS13.Text = "13";
            btnS13.UseVisualStyleBackColor = true;
            btnS13.Click += btnS13_Click;
            // 
            // btnS17
            // 
            btnS17.Location = new Point(403, 73);
            btnS17.Margin = new Padding(3, 2, 3, 2);
            btnS17.Name = "btnS17";
            btnS17.Size = new Size(67, 49);
            btnS17.TabIndex = 0;
            btnS17.Text = "17";
            btnS17.UseVisualStyleBackColor = true;
            btnS17.Click += btnS17_Click;
            // 
            // btnS16
            // 
            btnS16.Location = new Point(403, 20);
            btnS16.Margin = new Padding(3, 2, 3, 2);
            btnS16.Name = "btnS16";
            btnS16.Size = new Size(67, 49);
            btnS16.TabIndex = 0;
            btnS16.Text = "16";
            btnS16.UseVisualStyleBackColor = true;
            btnS16.Click += btnS16_Click;
            // 
            // btnS14
            // 
            btnS14.Location = new Point(331, 73);
            btnS14.Margin = new Padding(3, 2, 3, 2);
            btnS14.Name = "btnS14";
            btnS14.Size = new Size(67, 49);
            btnS14.TabIndex = 0;
            btnS14.Text = "14";
            btnS14.UseVisualStyleBackColor = true;
            btnS14.Click += btnS14_Click;
            // 
            // btnS19
            // 
            btnS19.Location = new Point(476, 20);
            btnS19.Margin = new Padding(3, 2, 3, 2);
            btnS19.Name = "btnS19";
            btnS19.Size = new Size(67, 49);
            btnS19.TabIndex = 0;
            btnS19.Text = "19";
            btnS19.UseVisualStyleBackColor = true;
            btnS19.Click += btnS19_Click;
            // 
            // btnS11
            // 
            btnS11.Location = new Point(258, 73);
            btnS11.Margin = new Padding(3, 2, 3, 2);
            btnS11.Name = "btnS11";
            btnS11.Size = new Size(67, 49);
            btnS11.TabIndex = 0;
            btnS11.Text = "11";
            btnS11.UseVisualStyleBackColor = true;
            btnS11.Click += btnS11_Click;
            // 
            // btnS3
            // 
            btnS3.Location = new Point(40, 126);
            btnS3.Margin = new Padding(3, 2, 3, 2);
            btnS3.Name = "btnS3";
            btnS3.Size = new Size(67, 49);
            btnS3.TabIndex = 0;
            btnS3.Text = "03";
            btnS3.UseVisualStyleBackColor = true;
            btnS3.Click += btnS3_Click;
            // 
            // btnS8
            // 
            btnS8.Location = new Point(186, 73);
            btnS8.Margin = new Padding(3, 2, 3, 2);
            btnS8.Name = "btnS8";
            btnS8.Size = new Size(67, 49);
            btnS8.TabIndex = 0;
            btnS8.Text = "08";
            btnS8.UseVisualStyleBackColor = true;
            btnS8.Click += btnS8_Click;
            // 
            // btnS6
            // 
            btnS6.Location = new Point(113, 126);
            btnS6.Margin = new Padding(3, 2, 3, 2);
            btnS6.Name = "btnS6";
            btnS6.Size = new Size(67, 49);
            btnS6.TabIndex = 0;
            btnS6.Text = "06";
            btnS6.UseVisualStyleBackColor = true;
            btnS6.Click += btnS6_Click;
            // 
            // btnS5
            // 
            btnS5.Location = new Point(113, 73);
            btnS5.Margin = new Padding(3, 2, 3, 2);
            btnS5.Name = "btnS5";
            btnS5.Size = new Size(67, 49);
            btnS5.TabIndex = 0;
            btnS5.Text = "05";
            btnS5.UseVisualStyleBackColor = true;
            btnS5.Click += btnS5_Click;
            // 
            // btnS9
            // 
            btnS9.Location = new Point(186, 126);
            btnS9.Margin = new Padding(3, 2, 3, 2);
            btnS9.Name = "btnS9";
            btnS9.Size = new Size(67, 49);
            btnS9.TabIndex = 0;
            btnS9.Text = "09";
            btnS9.UseVisualStyleBackColor = true;
            btnS9.Click += btnS9_Click;
            // 
            // btnS2
            // 
            btnS2.Location = new Point(40, 73);
            btnS2.Margin = new Padding(3, 2, 3, 2);
            btnS2.Name = "btnS2";
            btnS2.Size = new Size(67, 49);
            btnS2.TabIndex = 0;
            btnS2.Text = "02";
            btnS2.UseVisualStyleBackColor = true;
            btnS2.Click += btnS2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(708, 58);
            panel2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(196, 16);
            label6.Name = "label6";
            label6.Size = new Size(161, 30);
            label6.TabIndex = 3;
            label6.Text = "Make Booking";
            // 
            // MakeBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(566, 510);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txtNIC;
        private Label label1;
        private Button btnValidate;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox cmbRoute;
        private Label label5;
        private DateTimePicker dtPickDate;
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
        private TextBox txtTrainName;
        private Label lblTrainId;
        private Label lblRouteId;
        private TextBox txtName;
        private Label label7;
    }
}