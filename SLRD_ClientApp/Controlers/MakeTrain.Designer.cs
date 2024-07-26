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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 78);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 25);
            label2.Name = "label2";
            label2.Size = new Size(163, 38);
            label2.TabIndex = 3;
            label2.Text = "Make Train";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 116);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 8;
            label5.Text = "Train Name";
            // 
            // txtTrainName
            // 
            txtTrainName.Location = new Point(130, 113);
            txtTrainName.MaxLength = 50;
            txtTrainName.Name = "txtTrainName";
            txtTrainName.Size = new Size(266, 27);
            txtTrainName.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(169, 161);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 56);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // MakeTrain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 240);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(txtTrainName);
            Controls.Add(panel1);
            Name = "MakeTrain";
            Text = "MakeTrain";
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
    }
}