namespace PragueeParking
{
    partial class Form
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.vechileCheckOutButton = new FontAwesome.Sharp.IconButton();
            this.settingButton = new FontAwesome.Sharp.IconButton();
            this.exitButton = new FontAwesome.Sharp.IconButton();
            this.vechileCheckInButton = new FontAwesome.Sharp.IconButton();
            this.vehicleManagementButton = new FontAwesome.Sharp.IconButton();
            this.parkingLotButton = new FontAwesome.Sharp.IconButton();
            this.homeButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currentChildFormLabel = new System.Windows.Forms.Label();
            this.currentChildButton = new FontAwesome.Sharp.IconButton();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.menuPanel.Controls.Add(this.vechileCheckOutButton);
            this.menuPanel.Controls.Add(this.settingButton);
            this.menuPanel.Controls.Add(this.exitButton);
            this.menuPanel.Controls.Add(this.vechileCheckInButton);
            this.menuPanel.Controls.Add(this.vehicleManagementButton);
            this.menuPanel.Controls.Add(this.parkingLotButton);
            this.menuPanel.Controls.Add(this.homeButton);
            this.menuPanel.Controls.Add(this.panel1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(220, 735);
            this.menuPanel.TabIndex = 0;
            // 
            // vechileCheckOutButton
            // 
            this.vechileCheckOutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.vechileCheckOutButton.FlatAppearance.BorderSize = 0;
            this.vechileCheckOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vechileCheckOutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vechileCheckOutButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.vechileCheckOutButton.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.vechileCheckOutButton.IconColor = System.Drawing.Color.Gainsboro;
            this.vechileCheckOutButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vechileCheckOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vechileCheckOutButton.Location = new System.Drawing.Point(0, 380);
            this.vechileCheckOutButton.Name = "vechileCheckOutButton";
            this.vechileCheckOutButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.vechileCheckOutButton.Size = new System.Drawing.Size(220, 60);
            this.vechileCheckOutButton.TabIndex = 6;
            this.vechileCheckOutButton.Text = "Check Out";
            this.vechileCheckOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vechileCheckOutButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vechileCheckOutButton.UseVisualStyleBackColor = true;
            this.vechileCheckOutButton.Click += new System.EventHandler(this.vechileCheckOutButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.settingButton.FlatAppearance.BorderSize = 0;
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.settingButton.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.settingButton.IconColor = System.Drawing.Color.Gainsboro;
            this.settingButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingButton.Location = new System.Drawing.Point(0, 615);
            this.settingButton.Name = "settingButton";
            this.settingButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.settingButton.Size = new System.Drawing.Size(220, 60);
            this.settingButton.TabIndex = 5;
            this.settingButton.Text = "Settings";
            this.settingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitButton.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.exitButton.IconColor = System.Drawing.Color.Gainsboro;
            this.exitButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 675);
            this.exitButton.Name = "exitButton";
            this.exitButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.exitButton.Size = new System.Drawing.Size(220, 60);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // vechileCheckInButton
            // 
            this.vechileCheckInButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.vechileCheckInButton.FlatAppearance.BorderSize = 0;
            this.vechileCheckInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vechileCheckInButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vechileCheckInButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.vechileCheckInButton.IconChar = FontAwesome.Sharp.IconChar.ConciergeBell;
            this.vechileCheckInButton.IconColor = System.Drawing.Color.Gainsboro;
            this.vechileCheckInButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vechileCheckInButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vechileCheckInButton.Location = new System.Drawing.Point(0, 320);
            this.vechileCheckInButton.Name = "vechileCheckInButton";
            this.vechileCheckInButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.vechileCheckInButton.Size = new System.Drawing.Size(220, 60);
            this.vechileCheckInButton.TabIndex = 3;
            this.vechileCheckInButton.Text = "Check In";
            this.vechileCheckInButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vechileCheckInButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vechileCheckInButton.UseVisualStyleBackColor = true;
            this.vechileCheckInButton.Click += new System.EventHandler(this.vechileCheckInButton_Click);
            // 
            // vehicleManagementButton
            // 
            this.vehicleManagementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.vehicleManagementButton.FlatAppearance.BorderSize = 0;
            this.vehicleManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleManagementButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vehicleManagementButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.vehicleManagementButton.IconChar = FontAwesome.Sharp.IconChar.CarAlt;
            this.vehicleManagementButton.IconColor = System.Drawing.Color.Gainsboro;
            this.vehicleManagementButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vehicleManagementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicleManagementButton.Location = new System.Drawing.Point(0, 260);
            this.vehicleManagementButton.Name = "vehicleManagementButton";
            this.vehicleManagementButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.vehicleManagementButton.Size = new System.Drawing.Size(220, 60);
            this.vehicleManagementButton.TabIndex = 2;
            this.vehicleManagementButton.Text = "Vehicle Managment";
            this.vehicleManagementButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehicleManagementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.vehicleManagementButton.UseVisualStyleBackColor = true;
            this.vehicleManagementButton.Click += new System.EventHandler(this.vechileManagementButton_Click);
            // 
            // parkingLotButton
            // 
            this.parkingLotButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.parkingLotButton.FlatAppearance.BorderSize = 0;
            this.parkingLotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parkingLotButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.parkingLotButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.parkingLotButton.IconChar = FontAwesome.Sharp.IconChar.Parking;
            this.parkingLotButton.IconColor = System.Drawing.Color.Gainsboro;
            this.parkingLotButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.parkingLotButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkingLotButton.Location = new System.Drawing.Point(0, 200);
            this.parkingLotButton.Name = "parkingLotButton";
            this.parkingLotButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.parkingLotButton.Size = new System.Drawing.Size(220, 60);
            this.parkingLotButton.TabIndex = 1;
            this.parkingLotButton.Text = "Parking Lot";
            this.parkingLotButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkingLotButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.parkingLotButton.UseVisualStyleBackColor = true;
            this.parkingLotButton.Click += new System.EventHandler(this.parkingLotButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.homeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.homeButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.homeButton.IconColor = System.Drawing.Color.Gainsboro;
            this.homeButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 140);
            this.homeButton.Name = "homeButton";
            this.homeButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.homeButton.Size = new System.Drawing.Size(220, 60);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 0;
            // 
            // logoButton
            // 
            this.logoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoButton.Image = global::UI.Properties.Resources.knight_logo_clip_art_knight_c744684370c393f827995e46e5a11427;
            this.logoButton.Location = new System.Drawing.Point(0, 0);
            this.logoButton.Name = "logoButton";
            this.logoButton.Size = new System.Drawing.Size(220, 134);
            this.logoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoButton.TabIndex = 0;
            this.logoButton.TabStop = false;
            this.logoButton.Click += new System.EventHandler(this.logoButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.panel2.Controls.Add(this.currentChildFormLabel);
            this.panel2.Controls.Add(this.currentChildButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1219, 100);
            this.panel2.TabIndex = 1;
            // 
            // currentChildFormLabel
            // 
            this.currentChildFormLabel.AutoSize = true;
            this.currentChildFormLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentChildFormLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.currentChildFormLabel.Location = new System.Drawing.Point(90, 32);
            this.currentChildFormLabel.Name = "currentChildFormLabel";
            this.currentChildFormLabel.Size = new System.Drawing.Size(66, 25);
            this.currentChildFormLabel.TabIndex = 1;
            this.currentChildFormLabel.Text = "Home";
            // 
            // currentChildButton
            // 
            this.currentChildButton.FlatAppearance.BorderSize = 0;
            this.currentChildButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentChildButton.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currentChildButton.IconColor = System.Drawing.Color.Gainsboro;
            this.currentChildButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentChildButton.Location = new System.Drawing.Point(20, 12);
            this.currentChildButton.Name = "currentChildButton";
            this.currentChildButton.Size = new System.Drawing.Size(64, 70);
            this.currentChildButton.TabIndex = 0;
            this.currentChildButton.UseVisualStyleBackColor = true;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(111)))), ((int)(((byte)(164)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 100);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1219, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(165)))), ((int)(((byte)(216)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 110);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1219, 625);
            this.panelDesktop.TabIndex = 3;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 735);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuPanel);
            this.Name = "Form";
            this.Text = "Prague Parking 2.0";
            this.menuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private FontAwesome.Sharp.IconButton vechileCheckOutButton;
        private FontAwesome.Sharp.IconButton settingButton;
        private FontAwesome.Sharp.IconButton exitButton;
        private FontAwesome.Sharp.IconButton vechileCheckInButton;
        private FontAwesome.Sharp.IconButton vehicleManagementButton;
        private FontAwesome.Sharp.IconButton parkingLotButton;
        private FontAwesome.Sharp.IconButton homeButton;
        private Panel panel1;
        private PictureBox logoButton;
        private Panel panel2;
        private Label currentChildFormLabel;
        private FontAwesome.Sharp.IconButton currentChildButton;
        private Panel panelShadow;
        private Panel panelDesktop;
    }
}