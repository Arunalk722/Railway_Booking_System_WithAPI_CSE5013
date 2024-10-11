namespace SLRD_ClientApp.Controlers
{
    partial class MakeRoute
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
            chkIsActive = new CheckBox();
            lblTrainID = new Label();
            btnDelete = new Button();
            label6 = new Label();
            dtSchaduleTime = new DateTimePicker();
            cmbTrainName = new ComboBox();
            label4 = new Label();
            txtDestination = new TextBox();
            btnSave = new Button();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtSource = new TextBox();
            txtRouteId = new TextBox();
            panel1 = new Panel();
            label2 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkIsActive);
            groupBox1.Controls.Add(lblTrainID);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtSchaduleTime);
            groupBox1.Controls.Add(cmbTrainName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtDestination);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtSource);
            groupBox1.Controls.Add(txtRouteId);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 58);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(429, 264);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Passenger Info";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(171, 153);
            chkIsActive.Margin = new Padding(3, 2, 3, 2);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(70, 19);
            chkIsActive.TabIndex = 13;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // lblTrainID
            // 
            lblTrainID.AutoSize = true;
            lblTrainID.Location = new Point(367, 58);
            lblTrainID.Name = "lblTrainID";
            lblTrainID.Size = new Size(18, 15);
            lblTrainID.TabIndex = 12;
            lblTrainID.Text = "ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(150, 188);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 42);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 134);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 10;
            label6.Text = "Time";
            // 
            // dtSchaduleTime
            // 
            dtSchaduleTime.CustomFormat = "HH:mm:ss";
            dtSchaduleTime.Format = DateTimePickerFormat.Custom;
            dtSchaduleTime.Location = new Point(171, 128);
            dtSchaduleTime.Margin = new Padding(3, 2, 3, 2);
            dtSchaduleTime.Name = "dtSchaduleTime";
            dtSchaduleTime.Size = new Size(110, 23);
            dtSchaduleTime.TabIndex = 9;
            // 
            // cmbTrainName
            // 
            cmbTrainName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTrainName.FormattingEnabled = true;
            cmbTrainName.Location = new Point(171, 55);
            cmbTrainName.Margin = new Padding(3, 2, 3, 2);
            cmbTrainName.Name = "cmbTrainName";
            cmbTrainName.Size = new Size(196, 23);
            cmbTrainName.TabIndex = 7;
            cmbTrainName.SelectedIndexChanged += cmbTrainName_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 106);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 5;
            label4.Text = "Destination";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(171, 104);
            txtDestination.Margin = new Padding(3, 2, 3, 2);
            txtDestination.MaxLength = 10;
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(233, 23);
            txtDestination.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(273, 188);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 42);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 82);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 2;
            label5.Text = "Source";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 58);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Train";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Route Id";
            // 
            // txtSource
            // 
            txtSource.Location = new Point(171, 80);
            txtSource.Margin = new Padding(3, 2, 3, 2);
            txtSource.MaxLength = 50;
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(233, 23);
            txtSource.TabIndex = 3;
            // 
            // txtRouteId
            // 
            txtRouteId.Location = new Point(171, 31);
            txtRouteId.Margin = new Padding(3, 2, 3, 2);
            txtRouteId.MaxLength = 12;
            txtRouteId.Name = "txtRouteId";
            txtRouteId.Size = new Size(124, 23);
            txtRouteId.TabIndex = 3;
            txtRouteId.KeyDown += txtRouteId_KeyDown;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(429, 58);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(150, 14);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 3;
            label2.Text = "Make Route";
            // 
            // MakeRoute
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 332);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MakeRoute";
            Text = "MakeRoute";
            Load += MakeRoute_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtDestination;
        private Button btnSave;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox txtSource;
        private TextBox txtRouteId;
        private Panel panel1;
        private Label label2;
        private ComboBox cmbTrainName;
        private Label label6;
        private DateTimePicker dtSchaduleTime;
        private Button btnDelete;
        private Label lblTrainID;
        private CheckBox chkIsActive;
    }
}