namespace SLRD_ClientApp
{
    partial class LoginClient
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginClient));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 143);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.ForeColor = Color.Red;
            button2.Location = new Point(38, 86);
            button2.Name = "button2";
            button2.Size = new Size(50, 38);
            button2.TabIndex = 3;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(124, 86);
            button1.Name = "button1";
            button1.Size = new Size(256, 35);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 63);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 1;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 31);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 1;
            label3.Text = "User Name";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 23);
            textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 23);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(283, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 143);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(439, 62);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 43);
            label2.Name = "label2";
            label2.Size = new Size(169, 15);
            label2.TabIndex = 1;
            label2.Text = "Sri Lankan Railway department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 6);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // LoginClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 242);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
