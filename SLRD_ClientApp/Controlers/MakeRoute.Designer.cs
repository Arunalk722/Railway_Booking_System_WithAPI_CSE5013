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
            groupBox1.Location = new Point(0, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 352);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Passenger Info";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(107, 178);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 10;
            label6.Text = "Time";
            // 
            // dtSchaduleTime
            // 
            dtSchaduleTime.CustomFormat = "HH:mm:ss";
            dtSchaduleTime.Format = DateTimePickerFormat.Custom;
            dtSchaduleTime.Location = new Point(195, 171);
            dtSchaduleTime.Name = "dtSchaduleTime";
            dtSchaduleTime.Size = new Size(125, 27);
            dtSchaduleTime.TabIndex = 9;
            // 
            // cmbTrainName
            // 
            cmbTrainName.FormattingEnabled = true;
            cmbTrainName.Location = new Point(195, 73);
            cmbTrainName.Name = "cmbTrainName";
            cmbTrainName.Size = new Size(266, 28);
            cmbTrainName.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 141);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 5;
            label4.Text = "Destination";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(195, 138);
            txtDestination.MaxLength = 10;
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(266, 27);
            txtDestination.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(210, 220);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 56);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 110);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 2;
            label5.Text = "Source";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 77);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Train";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 44);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 2;
            label1.Text = "Route Id";
            // 
            // txtSource
            // 
            txtSource.Location = new Point(195, 107);
            txtSource.MaxLength = 50;
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(266, 27);
            txtSource.TabIndex = 3;
            // 
            // txtRouteId
            // 
            txtRouteId.Location = new Point(195, 41);
            txtRouteId.MaxLength = 12;
            txtRouteId.Name = "txtRouteId";
            txtRouteId.Size = new Size(141, 27);
            txtRouteId.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 78);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 19);
            label2.Name = "label2";
            label2.Size = new Size(175, 38);
            label2.TabIndex = 3;
            label2.Text = "Make Route";
            // 
            // MakeRoute
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 442);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
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
    }
}