namespace SLRD_ClientApp.Controlers
{
    partial class MakeTrain
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
            panel1 = new Panel();
            label2 = new Label();
            label5 = new Label();
            txtTrainName = new TextBox();
            btnSave = new Button();
            txtTrainId = new TextBox();
            label1 = new Label();
            chkIsActive = new CheckBox();
            btnDelete = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 78);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 26);
            label2.Name = "label2";
            label2.Size = new Size(265, 38);
            label2.TabIndex = 3;
            label2.Text = "Train Management";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 169);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 8;
            label5.Text = "Train Name";
            // 
            // txtTrainName
            // 
            txtTrainName.Location = new Point(130, 166);
            txtTrainName.MaxLength = 50;
            txtTrainName.Name = "txtTrainName";
            txtTrainName.Size = new Size(266, 27);
            txtTrainName.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.Location = new Point(282, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 56);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtTrainId
            // 
            txtTrainId.Location = new Point(130, 133);
            txtTrainId.MaxLength = 50;
            txtTrainId.Name = "txtTrainId";
            txtTrainId.Size = new Size(266, 27);
            txtTrainId.TabIndex = 9;
            txtTrainId.KeyDown += txtTrainId_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 136);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 8;
            label1.Text = "Train Id";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Location = new Point(130, 199);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(86, 24);
            chkIsActive.TabIndex = 11;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(130, 262);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 56);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // MakeTrain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 371);
            Controls.Add(btnDelete);
            Controls.Add(chkIsActive);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(txtTrainId);
            Controls.Add(txtTrainName);
            Controls.Add(panel1);
            Name = "MakeTrain";
            Text = "MakeTrain";
            Load += MakeTrain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label5;
        private TextBox txtTrainName;
        private Button btnSave;
        private TextBox txtTrainId;
        private Label label1;
        private CheckBox chkIsActive;
        private Button btnDelete;
    }
}