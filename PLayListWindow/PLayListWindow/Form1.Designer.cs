

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
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            MainPanel = new Panel();
            HelpButton = new Bunifu.Framework.UI.BunifuFlatButton();
            SettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            PLayListsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            ExploreButton = new Bunifu.Framework.UI.BunifuFlatButton();
            AlbumsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            PLayingButton = new Bunifu.Framework.UI.BunifuFlatButton();
            PremiumLabel = new Label();
            UserLabel = new Label();
            PFPpic = new PictureBox();
            bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            indicator = new Bunifu.UI.WinForms.BunifuShapes();
            bunifuShapes1 = new Bunifu.UI.WinForms.BunifuShapes();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PFPpic).BeginInit();
            bunifuPages1.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.LightCyan;
            MainPanel.Controls.Add(indicator);
            MainPanel.Controls.Add(HelpButton);
            MainPanel.Controls.Add(SettingsButton);
            MainPanel.Controls.Add(PLayListsButton);
            MainPanel.Controls.Add(ExploreButton);
            MainPanel.Controls.Add(AlbumsButton);
            MainPanel.Controls.Add(PLayingButton);
            MainPanel.Controls.Add(PremiumLabel);
            MainPanel.Controls.Add(UserLabel);
            MainPanel.Controls.Add(PFPpic);
            MainPanel.Controls.Add(bunifuShapes1);
            MainPanel.Dock = DockStyle.Left;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(224, 667);
            MainPanel.TabIndex = 0;
            // 
            // HelpButton
            // 
            HelpButton.Active = false;
            HelpButton.Activecolor = Color.LightCyan;
            HelpButton.BackColor = Color.LightCyan;
            HelpButton.BackgroundImageLayout = ImageLayout.Stretch;
            HelpButton.BorderRadius = 0;
            HelpButton.ButtonText = "Help";
            HelpButton.Cursor = Cursors.Hand;
            HelpButton.DisabledColor = Color.Gray;
            HelpButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HelpButton.ForeColor = SystemColors.ActiveCaptionText;
            HelpButton.Iconcolor = Color.Transparent;
            HelpButton.Iconimage = null;
            HelpButton.Iconimage_right = null;
            HelpButton.Iconimage_right_Selected = null;
            HelpButton.Iconimage_Selected = null;
            HelpButton.IconMarginLeft = 0;
            HelpButton.IconMarginRight = 0;
            HelpButton.IconRightVisible = true;
            HelpButton.IconRightZoom = 0D;
            HelpButton.IconVisible = true;
            HelpButton.IconZoom = 90D;
            HelpButton.IsTab = false;
            HelpButton.Location = new Point(50, 567);
            HelpButton.Margin = new Padding(5, 3, 5, 3);
            HelpButton.Name = "HelpButton";
            HelpButton.Normalcolor = Color.LightCyan;
            HelpButton.OnHovercolor = Color.LightCyan;
            HelpButton.OnHoverTextColor = Color.Black;
            HelpButton.selected = false;
            HelpButton.Size = new Size(125, 41);
            HelpButton.TabIndex = 10;
            HelpButton.Text = "Help";
            HelpButton.TextAlign = ContentAlignment.MiddleLeft;
            HelpButton.Textcolor = SystemColors.ControlDarkDark;
            HelpButton.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // SettingsButton
            // 
            SettingsButton.Active = false;
            SettingsButton.Activecolor = Color.LightCyan;
            SettingsButton.BackColor = Color.LightCyan;
            SettingsButton.BackgroundImageLayout = ImageLayout.Stretch;
            SettingsButton.BorderRadius = 0;
            SettingsButton.ButtonText = "Settings";
            SettingsButton.Cursor = Cursors.Hand;
            SettingsButton.DisabledColor = Color.Gray;
            SettingsButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SettingsButton.ForeColor = SystemColors.ActiveCaptionText;
            SettingsButton.Iconcolor = Color.Transparent;
            SettingsButton.Iconimage = null;
            SettingsButton.Iconimage_right = null;
            SettingsButton.Iconimage_right_Selected = null;
            SettingsButton.Iconimage_Selected = null;
            SettingsButton.IconMarginLeft = 0;
            SettingsButton.IconMarginRight = 0;
            SettingsButton.IconRightVisible = true;
            SettingsButton.IconRightZoom = 0D;
            SettingsButton.IconVisible = true;
            SettingsButton.IconZoom = 90D;
            SettingsButton.IsTab = false;
            SettingsButton.Location = new Point(50, 614);
            SettingsButton.Margin = new Padding(5, 3, 5, 3);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Normalcolor = Color.LightCyan;
            SettingsButton.OnHovercolor = Color.LightCyan;
            SettingsButton.OnHoverTextColor = Color.Black;
            SettingsButton.selected = false;
            SettingsButton.Size = new Size(125, 41);
            SettingsButton.TabIndex = 9;
            SettingsButton.Text = "Settings";
            SettingsButton.TextAlign = ContentAlignment.MiddleLeft;
            SettingsButton.Textcolor = SystemColors.ControlDarkDark;
            SettingsButton.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // PLayListsButton
            // 
            PLayListsButton.Active = false;
            PLayListsButton.Activecolor = Color.LightCyan;
            PLayListsButton.BackColor = Color.LightCyan;
            PLayListsButton.BackgroundImageLayout = ImageLayout.Stretch;
            PLayListsButton.BorderRadius = 0;
            PLayListsButton.ButtonText = "PlayLists";
            PLayListsButton.Cursor = Cursors.Hand;
            PLayListsButton.DisabledColor = Color.Gray;
            PLayListsButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PLayListsButton.ForeColor = SystemColors.ActiveCaptionText;
            PLayListsButton.Iconcolor = Color.Transparent;
            PLayListsButton.Iconimage = null;
            PLayListsButton.Iconimage_right = null;
            PLayListsButton.Iconimage_right_Selected = null;
            PLayListsButton.Iconimage_Selected = null;
            PLayListsButton.IconMarginLeft = 0;
            PLayListsButton.IconMarginRight = 0;
            PLayListsButton.IconRightVisible = true;
            PLayListsButton.IconRightZoom = 0D;
            PLayListsButton.IconVisible = true;
            PLayListsButton.IconZoom = 90D;
            PLayListsButton.IsTab = false;
            PLayListsButton.Location = new Point(50, 277);
            PLayListsButton.Margin = new Padding(5, 3, 5, 3);
            PLayListsButton.Name = "PLayListsButton";
            PLayListsButton.Normalcolor = Color.LightCyan;
            PLayListsButton.OnHovercolor = Color.LightCyan;
            PLayListsButton.OnHoverTextColor = Color.Black;
            PLayListsButton.selected = false;
            PLayListsButton.Size = new Size(125, 41);
            PLayListsButton.TabIndex = 8;
            PLayListsButton.Text = "PlayLists";
            PLayListsButton.TextAlign = ContentAlignment.MiddleLeft;
            PLayListsButton.Textcolor = SystemColors.ControlDarkDark;
            PLayListsButton.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // ExploreButton
            // 
            ExploreButton.Active = false;
            ExploreButton.Activecolor = Color.LightCyan;
            ExploreButton.BackColor = Color.LightCyan;
            ExploreButton.BackgroundImageLayout = ImageLayout.Stretch;
            ExploreButton.BorderRadius = 0;
            ExploreButton.ButtonText = "Explore";
            ExploreButton.Cursor = Cursors.Hand;
            ExploreButton.DisabledColor = Color.Gray;
            ExploreButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ExploreButton.ForeColor = SystemColors.ActiveCaptionText;
            ExploreButton.Iconcolor = Color.Transparent;
            ExploreButton.Iconimage = null;
            ExploreButton.Iconimage_right = null;
            ExploreButton.Iconimage_right_Selected = null;
            ExploreButton.Iconimage_Selected = null;
            ExploreButton.IconMarginLeft = 0;
            ExploreButton.IconMarginRight = 0;
            ExploreButton.IconRightVisible = true;
            ExploreButton.IconRightZoom = 0D;
            ExploreButton.IconVisible = true;
            ExploreButton.IconZoom = 90D;
            ExploreButton.IsTab = false;
            ExploreButton.Location = new Point(50, 183);
            ExploreButton.Margin = new Padding(5, 3, 5, 3);
            ExploreButton.Name = "ExploreButton";
            ExploreButton.Normalcolor = Color.LightCyan;
            ExploreButton.OnHovercolor = Color.LightCyan;
            ExploreButton.OnHoverTextColor = Color.Black;
            ExploreButton.selected = false;
            ExploreButton.Size = new Size(125, 41);
            ExploreButton.TabIndex = 7;
            ExploreButton.Text = "Explore";
            ExploreButton.TextAlign = ContentAlignment.MiddleLeft;
            ExploreButton.Textcolor = SystemColors.ControlDarkDark;
            ExploreButton.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ExploreButton.Click += ExploreButton_Click;
            // 
            // AlbumsButton
            // 
            AlbumsButton.Active = false;
            AlbumsButton.Activecolor = Color.LightCyan;
            AlbumsButton.BackColor = Color.LightCyan;
            AlbumsButton.BackgroundImageLayout = ImageLayout.Stretch;
            AlbumsButton.BorderRadius = 0;
            AlbumsButton.ButtonText = "Albums";
            AlbumsButton.Cursor = Cursors.Hand;
            AlbumsButton.DisabledColor = Color.Gray;
            AlbumsButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AlbumsButton.ForeColor = SystemColors.ActiveCaptionText;
            AlbumsButton.Iconcolor = Color.Transparent;
            AlbumsButton.Iconimage = null;
            AlbumsButton.Iconimage_right = null;
            AlbumsButton.Iconimage_right_Selected = null;
            AlbumsButton.Iconimage_Selected = null;
            AlbumsButton.IconMarginLeft = 0;
            AlbumsButton.IconMarginRight = 0;
            AlbumsButton.IconRightVisible = true;
            AlbumsButton.IconRightZoom = 0D;
            AlbumsButton.IconVisible = true;
            AlbumsButton.IconZoom = 90D;
            AlbumsButton.IsTab = false;
            AlbumsButton.Location = new Point(50, 230);
            AlbumsButton.Margin = new Padding(5, 3, 5, 3);
            AlbumsButton.Name = "AlbumsButton";
            AlbumsButton.Normalcolor = Color.LightCyan;
            AlbumsButton.OnHovercolor = Color.LightCyan;
            AlbumsButton.OnHoverTextColor = Color.Black;
            AlbumsButton.selected = false;
            AlbumsButton.Size = new Size(125, 41);
            AlbumsButton.TabIndex = 6;
            AlbumsButton.Text = "Albums";
            AlbumsButton.TextAlign = ContentAlignment.MiddleLeft;
            AlbumsButton.Textcolor = SystemColors.ControlDarkDark;
            AlbumsButton.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // PLayingButton
            // 
            PLayingButton.Active = false;
            PLayingButton.Activecolor = Color.LightCyan;
            PLayingButton.BackColor = Color.LightCyan;
            PLayingButton.BackgroundImageLayout = ImageLayout.Stretch;
            PLayingButton.BorderRadius = 0;
            PLayingButton.ButtonText = "No Playing..";
            PLayingButton.Cursor = Cursors.Hand;
            PLayingButton.DisabledColor = Color.Gray;
            PLayingButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            PLayingButton.ForeColor = SystemColors.ActiveCaptionText;
            PLayingButton.Iconcolor = Color.Transparent;
            PLayingButton.Iconimage = null;
            PLayingButton.Iconimage_right = null;
            PLayingButton.Iconimage_right_Selected = null;
            PLayingButton.Iconimage_Selected = null;
            PLayingButton.IconMarginLeft = 0;
            PLayingButton.IconMarginRight = 0;
            PLayingButton.IconRightVisible = true;
            PLayingButton.IconRightZoom = 0D;
            PLayingButton.IconVisible = true;
            PLayingButton.IconZoom = 90D;
            PLayingButton.IsTab = false;
            PLayingButton.Location = new Point(50, 136);
            PLayingButton.Margin = new Padding(5, 3, 5, 3);
            PLayingButton.Name = "PLayingButton";
            PLayingButton.Normalcolor = Color.LightCyan;
            PLayingButton.OnHovercolor = Color.LightCyan;
            PLayingButton.OnHoverTextColor = Color.Black;
            PLayingButton.selected = false;
            PLayingButton.Size = new Size(125, 41);
            PLayingButton.TabIndex = 5;
            PLayingButton.Text = "No Playing..";
            PLayingButton.TextAlign = ContentAlignment.MiddleLeft;
            PLayingButton.Textcolor = SystemColors.ControlDarkDark;
            PLayingButton.TextFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PLayingButton.Click += PLayingButton_Click;
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
            // PFPpic
            // 
            PFPpic.BackgroundImageLayout = ImageLayout.Zoom;
            PFPpic.BorderStyle = BorderStyle.FixedSingle;
            PFPpic.Image = (Image)resources.GetObject("PFPpic.Image");
            PFPpic.Location = new Point(12, 23);
            PFPpic.Name = "PFPpic";
            PFPpic.Size = new Size(68, 66);
            PFPpic.SizeMode = PictureBoxSizeMode.Zoom;
            PFPpic.TabIndex = 0;
            PFPpic.TabStop = false;
            // 
            // bunifuPages1
            // 
            bunifuPages1.Alignment = TabAlignment.Bottom;
            bunifuPages1.AllowTransitions = false;
            bunifuPages1.Controls.Add(tabPage1);
            bunifuPages1.Controls.Add(tabPage2);
            bunifuPages1.Dock = DockStyle.Fill;
            bunifuPages1.Location = new Point(224, 0);
            bunifuPages1.Multiline = true;
            bunifuPages1.Name = "bunifuPages1";
            bunifuPages1.Page = tabPage1;
            bunifuPages1.PageIndex = 0;
            bunifuPages1.PageName = "tabPage1";
            bunifuPages1.PageTitle = "Playing";
            bunifuPages1.SelectedIndex = 0;
            bunifuPages1.Size = new Size(884, 667);
            bunifuPages1.TabIndex = 1;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            bunifuPages1.Transition = animation1;
            bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(876, 639);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Playing";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(876, 639);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Explore";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // indicator
            // 
            indicator.Angle = 0F;
            indicator.BackColor = Color.Transparent;
            indicator.BorderColor = Color.LightSeaGreen;
            indicator.BorderThickness = 3;
            indicator.FillColor = Color.Transparent;
            indicator.FillShape = true;
            indicator.Location = new Point(24, 147);
            indicator.Name = "indicator";
            indicator.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            indicator.Sides = 5;
            indicator.Size = new Size(18, 18);
            indicator.TabIndex = 2;
            indicator.Text = "bunifuShapes1";
            // 
            // bunifuShapes1
            // 
            bunifuShapes1.Angle = 90F;
            bunifuShapes1.BackColor = Color.Transparent;
            bunifuShapes1.BorderColor = Color.LightSeaGreen;
            bunifuShapes1.BorderThickness = 2;
            bunifuShapes1.FillColor = Color.Transparent;
            bunifuShapes1.FillShape = true;
            bunifuShapes1.Location = new Point(-54, 151);
            bunifuShapes1.Name = "bunifuShapes1";
            bunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            bunifuShapes1.Sides = 5;
            bunifuShapes1.Size = new Size(172, 151);
            bunifuShapes1.TabIndex = 0;
            bunifuShapes1.Text = "bunifuShapes1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1108, 667);
            Controls.Add(bunifuPages1);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PFPpic).EndInit();
            bunifuPages1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private PictureBox PFPpic;
        private Label UserLabel;
        private Label PremiumLabel;
        private Bunifu.Framework.UI.BunifuFlatButton PLayingButton;
        private Bunifu.Framework.UI.BunifuFlatButton PLayListsButton;
        private Bunifu.Framework.UI.BunifuFlatButton ExploreButton;
        private Bunifu.Framework.UI.BunifuFlatButton AlbumsButton;
        private Bunifu.Framework.UI.BunifuFlatButton SettingsButton;
        private Bunifu.Framework.UI.BunifuFlatButton HelpButton;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Bunifu.UI.WinForms.BunifuShapes indicator;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes1;
    }
}