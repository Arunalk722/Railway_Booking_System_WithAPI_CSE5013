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
            trainReportToolStripMenuItem = new ToolStripMenuItem();
            routeReportToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            bookingListToolStripMenuItem = new ToolStripMenuItem();
            bookingManagementToolStripMenuItem = new ToolStripMenuItem();
            passengerToolStripMenuItem = new ToolStripMenuItem();
            passengerRegistrationToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem1 = new ToolStripMenuItem();
            makeBookingToolStripMenuItem = new ToolStripMenuItem();
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
            panel1.Location = new Point(0, 548);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 52);
            panel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(37, 17);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(67, 20);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Message";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trainToolStripMenuItem, bookingToolStripMenuItem, passengerToolStripMenuItem, bookingToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // trainToolStripMenuItem
            // 
            trainToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { makeTrainToolStripMenuItem, makeRouteToolStripMenuItem, trainReportToolStripMenuItem, routeReportToolStripMenuItem });
            trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            trainToolStripMenuItem.Size = new Size(55, 24);
            trainToolStripMenuItem.Text = "Train";
            // 
            // makeTrainToolStripMenuItem
            // 
            makeTrainToolStripMenuItem.Name = "makeTrainToolStripMenuItem";
            makeTrainToolStripMenuItem.Size = new Size(224, 26);
            makeTrainToolStripMenuItem.Text = "Make Train";
            makeTrainToolStripMenuItem.Click += makeTrainToolStripMenuItem_Click;
            // 
            // makeRouteToolStripMenuItem
            // 
            makeRouteToolStripMenuItem.Name = "makeRouteToolStripMenuItem";
            makeRouteToolStripMenuItem.Size = new Size(224, 26);
            makeRouteToolStripMenuItem.Text = "Make Route";
            makeRouteToolStripMenuItem.Click += makeRouteToolStripMenuItem_Click;
            // 
            // trainReportToolStripMenuItem
            // 
            trainReportToolStripMenuItem.Name = "trainReportToolStripMenuItem";
            trainReportToolStripMenuItem.Size = new Size(224, 26);
            trainReportToolStripMenuItem.Text = "Train Report";
            trainReportToolStripMenuItem.Click += trainReportToolStripMenuItem_Click;
            // 
            // routeReportToolStripMenuItem
            // 
            routeReportToolStripMenuItem.Name = "routeReportToolStripMenuItem";
            routeReportToolStripMenuItem.Size = new Size(224, 26);
            routeReportToolStripMenuItem.Text = "Route Report";
            routeReportToolStripMenuItem.Click += routeReportToolStripMenuItem_Click;
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookingListToolStripMenuItem, bookingManagementToolStripMenuItem });
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(78, 24);
            bookingToolStripMenuItem.Text = "Booking";
            // 
            // bookingListToolStripMenuItem
            // 
            bookingListToolStripMenuItem.Name = "bookingListToolStripMenuItem";
            bookingListToolStripMenuItem.Size = new Size(239, 26);
            bookingListToolStripMenuItem.Text = "Booking List";
            bookingListToolStripMenuItem.Click += bookingListToolStripMenuItem_Click;
            // 
            // bookingManagementToolStripMenuItem
            // 
            bookingManagementToolStripMenuItem.Name = "bookingManagementToolStripMenuItem";
            bookingManagementToolStripMenuItem.Size = new Size(239, 26);
            bookingManagementToolStripMenuItem.Text = "Booking Management";
            // 
            // passengerToolStripMenuItem
            // 
            passengerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { passengerRegistrationToolStripMenuItem });
            passengerToolStripMenuItem.Name = "passengerToolStripMenuItem";
            passengerToolStripMenuItem.Size = new Size(88, 24);
            passengerToolStripMenuItem.Text = "Passenger";
            // 
            // passengerRegistrationToolStripMenuItem
            // 
            passengerRegistrationToolStripMenuItem.Name = "passengerRegistrationToolStripMenuItem";
            passengerRegistrationToolStripMenuItem.Size = new Size(241, 26);
            passengerRegistrationToolStripMenuItem.Text = "Passenger Registration";
            passengerRegistrationToolStripMenuItem.Click += passengerRegistrationToolStripMenuItem_Click;
            // 
            // bookingToolStripMenuItem1
            // 
            bookingToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { makeBookingToolStripMenuItem });
            bookingToolStripMenuItem1.Name = "bookingToolStripMenuItem1";
            bookingToolStripMenuItem1.Size = new Size(78, 24);
            bookingToolStripMenuItem1.Text = "Booking";
            // 
            // makeBookingToolStripMenuItem
            // 
            makeBookingToolStripMenuItem.Name = "makeBookingToolStripMenuItem";
            makeBookingToolStripMenuItem.Size = new Size(187, 26);
            makeBookingToolStripMenuItem.Text = "Make Booking";
            makeBookingToolStripMenuItem.Click += makeBookingToolStripMenuItem_Click;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
        private ToolStripMenuItem passengerToolStripMenuItem;
        private ToolStripMenuItem passengerRegistrationToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem1;
        private ToolStripMenuItem makeBookingToolStripMenuItem;
        private ToolStripMenuItem trainReportToolStripMenuItem;
        private ToolStripMenuItem routeReportToolStripMenuItem;
    }
}