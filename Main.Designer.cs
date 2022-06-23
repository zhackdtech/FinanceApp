namespace FinanceApp
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.ellipseControl1 = new FinanceApp.UserInterface.Components.EllipseControl();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.ELLIPSE = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.customTextbox1 = new FinanceApp.UserInterface.CustomTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new FinanceApp.UserInterface.Controls.SmoothButton();
            this.btnStatistics = new FinanceApp.UserInterface.Controls.SmoothButton();
            this.btnComboChart = new FinanceApp.UserInterface.Controls.SmoothButton();
            this.btnMessages = new FinanceApp.UserInterface.Controls.SmoothButton();
            this.btnHome = new FinanceApp.UserInterface.Controls.SmoothButton();
            this.btnDashboard = new FinanceApp.UserInterface.Controls.SmoothButton();
            this.pnlContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 40;
            this.ellipseControl1.TargetControl = this;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.pictureBox2);
            this.pnlContent.Controls.Add(this.customTextbox1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlContent.Font = new System.Drawing.Font("MT Extra", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.pnlContent.Location = new System.Drawing.Point(92, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1108, 720);
            this.pnlContent.TabIndex = 2;
            // 
            // ELLIPSE
            // 
            this.ELLIPSE.ElipseRadius = 30;
            this.ELLIPSE.TargetControl = this.pnlContent;
            // 
            // customTextbox1
            // 
            this.customTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.customTextbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.customTextbox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(45)))), ((int)(((byte)(166)))));
            this.customTextbox1.BorderRadius = 15;
            this.customTextbox1.BorderSize = 2;
            this.customTextbox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.customTextbox1.Location = new System.Drawing.Point(32, 22);
            this.customTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextbox1.Multiline = false;
            this.customTextbox1.Name = "customTextbox1";
            this.customTextbox1.Padding = new System.Windows.Forms.Padding(40, 10, 13, 10);
            this.customTextbox1.PasswordChar = false;
            this.customTextbox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextbox1.PlaceholderText = "";
            this.customTextbox1.Size = new System.Drawing.Size(639, 38);
            this.customTextbox1.TabIndex = 0;
            this.customTextbox1.Texts = "Search";
            this.customTextbox1.UnderlinedStyle = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.pictureBox2.Image = global::FinanceApp.Properties.Resources.search_20px;
            this.pictureBox2.Location = new System.Drawing.Point(42, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinanceApp.Properties.Resources.sdfghjk;
            this.pictureBox1.Location = new System.Drawing.Point(21, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(170)))));
            this.btnLogOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(170)))));
            this.btnLogOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogOut.BorderRadius = 10;
            this.btnLogOut.BorderSize = 0;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::FinanceApp.Properties.Resources.imac_exit_20px;
            this.btnLogOut.Location = new System.Drawing.Point(24, 666);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(42, 42);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.TextColor = System.Drawing.Color.White;
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(170)))));
            this.btnStatistics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(170)))));
            this.btnStatistics.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnStatistics.BorderRadius = 10;
            this.btnStatistics.BorderSize = 0;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Image = global::FinanceApp.Properties.Resources.statistics_20px;
            this.btnStatistics.Location = new System.Drawing.Point(24, 511);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(42, 42);
            this.btnStatistics.TabIndex = 1;
            this.btnStatistics.TextColor = System.Drawing.Color.White;
            this.btnStatistics.UseVisualStyleBackColor = false;
            // 
            // btnComboChart
            // 
            this.btnComboChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(170)))));
            this.btnComboChart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(170)))));
            this.btnComboChart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnComboChart.BorderRadius = 10;
            this.btnComboChart.BorderSize = 0;
            this.btnComboChart.FlatAppearance.BorderSize = 0;
            this.btnComboChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComboChart.ForeColor = System.Drawing.Color.White;
            this.btnComboChart.Image = global::FinanceApp.Properties.Resources.combo_chart_20px;
            this.btnComboChart.Location = new System.Drawing.Point(24, 436);
            this.btnComboChart.Name = "btnComboChart";
            this.btnComboChart.Size = new System.Drawing.Size(42, 42);
            this.btnComboChart.TabIndex = 1;
            this.btnComboChart.TextColor = System.Drawing.Color.White;
            this.btnComboChart.UseVisualStyleBackColor = false;
            // 
            // btnMessages
            // 
            this.btnMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(170)))));
            this.btnMessages.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(170)))));
            this.btnMessages.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMessages.BorderRadius = 10;
            this.btnMessages.BorderSize = 0;
            this.btnMessages.FlatAppearance.BorderSize = 0;
            this.btnMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessages.ForeColor = System.Drawing.Color.White;
            this.btnMessages.Image = global::FinanceApp.Properties.Resources.new_message_20px;
            this.btnMessages.Location = new System.Drawing.Point(24, 361);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(42, 42);
            this.btnMessages.TabIndex = 1;
            this.btnMessages.TextColor = System.Drawing.Color.White;
            this.btnMessages.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(170)))));
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(170)))));
            this.btnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHome.BorderRadius = 10;
            this.btnHome.BorderSize = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::FinanceApp.Properties.Resources.home_20px1;
            this.btnHome.Location = new System.Drawing.Point(24, 286);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(42, 42);
            this.btnHome.TabIndex = 1;
            this.btnHome.TextColor = System.Drawing.Color.White;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.BackgroundColor = System.Drawing.Color.White;
            this.btnDashboard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDashboard.BorderRadius = 10;
            this.btnDashboard.BorderSize = 0;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::FinanceApp.Properties.Resources.dashboard_layout_20px1;
            this.btnDashboard.Location = new System.Drawing.Point(24, 211);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(42, 42);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.TextColor = System.Drawing.Color.White;
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(44)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnComboChart);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.pnlContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UserInterface.Components.EllipseControl ellipseControl1;
        private UserInterface.Controls.SmoothButton btnDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserInterface.Controls.SmoothButton btnComboChart;
        private UserInterface.Controls.SmoothButton btnMessages;
        private UserInterface.Controls.SmoothButton btnHome;
        private UserInterface.Controls.SmoothButton btnStatistics;
        private UserInterface.Controls.SmoothButton btnLogOut;
        private System.Windows.Forms.Panel pnlContent;
        private Bunifu.Framework.UI.BunifuElipse ELLIPSE;
        private UserInterface.CustomTextbox customTextbox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

