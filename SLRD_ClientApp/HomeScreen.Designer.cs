namespace SLRD_ClientApp.Properties
{
    partial class HomeScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            panel1 = new Panel();
            lblMessage = new Label();
            menuStrip1 = new MenuStrip();
            trainToolStripMenuItem = new ToolStripMenuItem();
            makeTrainToolStripMenuItem = new ToolStripMenuItem();
            makeRouteToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            bookingListToolStripMenuItem = new ToolStripMenuItem();
            bookingManagementToolStripMenuItem = new ToolStripMenuItem();
            errprvSuccessMessage = new ErrorProvider(components);
            errprvErrorMessage = new ErrorProvider(components);
            errprvInfoMessage = new ErrorProvider(components);
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errprvSuccessMessage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errprvErrorMessage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errprvInfoMessage).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblMessage);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 411);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 39);
            panel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(32, 13);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(53, 15);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Message";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { trainToolStripMenuItem, bookingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // trainToolStripMenuItem
            // 
            trainToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { makeTrainToolStripMenuItem, makeRouteToolStripMenuItem });
            trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            trainToolStripMenuItem.Size = new Size(44, 20);
            trainToolStripMenuItem.Text = "Train";
            // 
            // makeTrainToolStripMenuItem
            // 
            makeTrainToolStripMenuItem.Name = "makeTrainToolStripMenuItem";
            makeTrainToolStripMenuItem.Size = new Size(137, 22);
            makeTrainToolStripMenuItem.Text = "Make Train";
            // 
            // makeRouteToolStripMenuItem
            // 
            makeRouteToolStripMenuItem.Name = "makeRouteToolStripMenuItem";
            makeRouteToolStripMenuItem.Size = new Size(137, 22);
            makeRouteToolStripMenuItem.Text = "Make Route";
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookingListToolStripMenuItem, bookingManagementToolStripMenuItem });
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(63, 20);
            bookingToolStripMenuItem.Text = "Booking";
            // 
            // bookingListToolStripMenuItem
            // 
            bookingListToolStripMenuItem.Name = "bookingListToolStripMenuItem";
            bookingListToolStripMenuItem.Size = new Size(192, 22);
            bookingListToolStripMenuItem.Text = "Booking List";
            // 
            // bookingManagementToolStripMenuItem
            // 
            bookingManagementToolStripMenuItem.Name = "bookingManagementToolStripMenuItem";
            bookingManagementToolStripMenuItem.Size = new Size(192, 22);
            bookingManagementToolStripMenuItem.Text = "Booking Management";
            // 
            // errprvSuccessMessage
            // 
            errprvSuccessMessage.ContainerControl = this;
            errprvSuccessMessage.Icon = (Icon)resources.GetObject("errprvSuccessMessage.Icon");
            // 
            // errprvErrorMessage
            // 
            errprvErrorMessage.ContainerControl = this;
            // 
            // errprvInfoMessage
            // 
            errprvInfoMessage.ContainerControl = this;
            errprvInfoMessage.Icon = (Icon)resources.GetObject("errprvInfoMessage.Icon");
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomeScreen";
            Text = "HomeScreen";
            Load += HomeScreen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errprvSuccessMessage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errprvErrorMessage).EndInit();
            ((System.ComponentModel.ISupportInitialize)errprvInfoMessage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem trainToolStripMenuItem;
        private ToolStripMenuItem makeTrainToolStripMenuItem;
        private ToolStripMenuItem makeRouteToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ToolStripMenuItem bookingListToolStripMenuItem;
        private ToolStripMenuItem bookingManagementToolStripMenuItem;
        private Label lblMessage;
        private ErrorProvider errprvSuccessMessage;
        private ErrorProvider errprvErrorMessage;
        private ErrorProvider errprvInfoMessage;
    }
}