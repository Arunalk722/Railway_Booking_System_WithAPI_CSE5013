namespace SLRD_ClientApp.Controlers
{
    partial class TicketMarking
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
            label2 = new Label();
            panel1 = new Panel();
            btnSave = new Button();
            label5 = new Label();
            txtTktNo = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(130, 25);
            label2.Name = "label2";
            label2.Size = new Size(215, 38);
            label2.TabIndex = 3;
            label2.Text = "Ticket Marking";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 78);
            panel1.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(199, 132);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 56);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 87);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 11;
            label5.Text = "Ticket No";
            // 
            // txtTktNo
            // 
            txtTktNo.Location = new Point(160, 84);
            txtTktNo.MaxLength = 50;
            txtTktNo.Name = "txtTktNo";
            txtTktNo.Size = new Size(266, 27);
            txtTktNo.TabIndex = 12;
            // 
            // TicketMarking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 201);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(txtTktNo);
            Controls.Add(panel1);
            Name = "TicketMarking";
            Text = "TicketMarking";
            Load += TicketMarking_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Button btnSave;
        private Label label5;
        private TextBox txtTktNo;
    }
}