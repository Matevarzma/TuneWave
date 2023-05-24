namespace PlayListWindow
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MainPanel = new Panel();
            PFPpic = new PictureBox();
            UserLabel = new Label();
            PremiumLabel = new Label();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PFPpic).BeginInit();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.LightCyan;
            MainPanel.Controls.Add(PremiumLabel);
            MainPanel.Controls.Add(UserLabel);
            MainPanel.Controls.Add(PFPpic);
            MainPanel.Dock = DockStyle.Left;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(224, 667);
            MainPanel.TabIndex = 0;
            // 
            // PFPpic
            // 
            PFPpic.BackgroundImageLayout = ImageLayout.Zoom;
            PFPpic.BorderStyle = BorderStyle.FixedSingle;
            PFPpic.Image = (Image)resources.GetObject("PFPpic.Image");
            PFPpic.Location = new Point(22, 23);
            PFPpic.Name = "PFPpic";
            PFPpic.Size = new Size(58, 66);
            PFPpic.SizeMode = PictureBoxSizeMode.Zoom;
            PFPpic.TabIndex = 0;
            PFPpic.TabStop = false;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UserLabel.Location = new Point(86, 33);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(115, 21);
            UserLabel.TabIndex = 1;
            UserLabel.Text = "Mate Milorava";
            // 
            // PremiumLabel
            // 
            PremiumLabel.AutoSize = true;
            PremiumLabel.BackColor = Color.LightSeaGreen;
            PremiumLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            PremiumLabel.ForeColor = Color.LightCyan;
            PremiumLabel.Location = new Point(100, 68);
            PremiumLabel.Name = "PremiumLabel";
            PremiumLabel.Size = new Size(75, 21);
            PremiumLabel.TabIndex = 2;
            PremiumLabel.Text = "Premium";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1108, 667);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PFPpic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private PictureBox PFPpic;
        private Label UserLabel;
        private Label PremiumLabel;
    }
}