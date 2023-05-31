

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            PnlleftBar = new Panel();
            indicator = new Bunifu.UI.WinForms.BunifuShapes();
            HelpButton = new Bunifu.Framework.UI.BunifuFlatButton();
            SettingsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            PLayListsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            ExploreButton = new Bunifu.Framework.UI.BunifuFlatButton();
            AlbumsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            PLayingButton = new Bunifu.Framework.UI.BunifuFlatButton();
            PremiumLabel = new Label();
            UserLabel = new Label();
            PFPpic = new PictureBox();
            bunifuShapes1 = new Bunifu.UI.WinForms.BunifuShapes();
            bunifuFormDock1 = new Bunifu.UI.WinForms.BunifuFormDock();
            PnlHeadbar = new Panel();
            ExitBtn = new Bunifu.UI.WinForms.BunifuImageButton();
            bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            panel1 = new Panel();
            bunifuhSlider1 = new Bunifu.UI.WinForms.BunifuHSlider();
            label1 = new Label();
            bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            bunifuImageButton4 = new Bunifu.UI.WinForms.BunifuImageButton();
            PnlleftBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PFPpic).BeginInit();
            PnlHeadbar.SuspendLayout();
            bunifuPages1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PnlleftBar
            // 
            PnlleftBar.BackColor = Color.LightCyan;
            PnlleftBar.Controls.Add(indicator);
            PnlleftBar.Controls.Add(HelpButton);
            PnlleftBar.Controls.Add(SettingsButton);
            PnlleftBar.Controls.Add(PLayListsButton);
            PnlleftBar.Controls.Add(ExploreButton);
            PnlleftBar.Controls.Add(AlbumsButton);
            PnlleftBar.Controls.Add(PLayingButton);
            PnlleftBar.Controls.Add(PremiumLabel);
            PnlleftBar.Controls.Add(UserLabel);
            PnlleftBar.Controls.Add(PFPpic);
            PnlleftBar.Controls.Add(bunifuShapes1);
            PnlleftBar.Dock = DockStyle.Left;
            PnlleftBar.Location = new Point(0, 0);
            PnlleftBar.Name = "PnlleftBar";
            PnlleftBar.Size = new Size(224, 643);
            PnlleftBar.TabIndex = 0;
            // 
            // indicator
            // 
            indicator.Angle = 0F;
            indicator.BackColor = Color.Transparent;
            indicator.BorderColor = Color.LightSeaGreen;
            indicator.BorderThickness = 3;
            indicator.FillColor = Color.Transparent;
            indicator.FillShape = true;
            indicator.Location = new Point(24, 178);
            indicator.Name = "indicator";
            indicator.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            indicator.Sides = 5;
            indicator.Size = new Size(18, 18);
            indicator.TabIndex = 2;
            indicator.Text = "bunifuShapes1";
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
            HelpButton.Location = new Point(50, 528);
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
            SettingsButton.Location = new Point(50, 575);
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
            PLayListsButton.Location = new Point(50, 308);
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
            ExploreButton.Location = new Point(50, 214);
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
            AlbumsButton.Location = new Point(50, 261);
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
            PLayingButton.Location = new Point(50, 167);
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
            PremiumLabel.Location = new Point(59, 124);
            PremiumLabel.Name = "PremiumLabel";
            PremiumLabel.Size = new Size(75, 21);
            PremiumLabel.TabIndex = 2;
            PremiumLabel.Text = "Premium";
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            UserLabel.Location = new Point(31, 91);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(138, 25);
            UserLabel.TabIndex = 1;
            UserLabel.Text = "Mate Milorava";
            // 
            // PFPpic
            // 
            PFPpic.BackgroundImageLayout = ImageLayout.Zoom;
            PFPpic.BorderStyle = BorderStyle.FixedSingle;
            PFPpic.Image = (Image)resources.GetObject("PFPpic.Image");
            PFPpic.Location = new Point(63, 12);
            PFPpic.Name = "PFPpic";
            PFPpic.Size = new Size(68, 66);
            PFPpic.SizeMode = PictureBoxSizeMode.Zoom;
            PFPpic.TabIndex = 0;
            PFPpic.TabStop = false;
            // 
            // bunifuShapes1
            // 
            bunifuShapes1.Angle = 90F;
            bunifuShapes1.BackColor = Color.Transparent;
            bunifuShapes1.BorderColor = Color.LightSeaGreen;
            bunifuShapes1.BorderThickness = 2;
            bunifuShapes1.FillColor = Color.Transparent;
            bunifuShapes1.FillShape = true;
            bunifuShapes1.Location = new Point(-54, 182);
            bunifuShapes1.Name = "bunifuShapes1";
            bunifuShapes1.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            bunifuShapes1.Sides = 5;
            bunifuShapes1.Size = new Size(172, 151);
            bunifuShapes1.TabIndex = 0;
            bunifuShapes1.Text = "bunifuShapes1";
            // 
            // bunifuFormDock1
            // 
            bunifuFormDock1.AllowFormDragging = true;
            bunifuFormDock1.AllowFormDropShadow = true;
            bunifuFormDock1.AllowFormResizing = true;
            bunifuFormDock1.AllowHidingBottomRegion = true;
            bunifuFormDock1.AllowOpacityChangesWhileDragging = false;
            bunifuFormDock1.BorderOptions.BottomBorder.BorderColor = Color.Silver;
            bunifuFormDock1.BorderOptions.BottomBorder.BorderThickness = 1;
            bunifuFormDock1.BorderOptions.BottomBorder.ShowBorder = true;
            bunifuFormDock1.BorderOptions.LeftBorder.BorderColor = Color.Silver;
            bunifuFormDock1.BorderOptions.LeftBorder.BorderThickness = 1;
            bunifuFormDock1.BorderOptions.LeftBorder.ShowBorder = true;
            bunifuFormDock1.BorderOptions.RightBorder.BorderColor = Color.Silver;
            bunifuFormDock1.BorderOptions.RightBorder.BorderThickness = 1;
            bunifuFormDock1.BorderOptions.RightBorder.ShowBorder = true;
            bunifuFormDock1.BorderOptions.TopBorder.BorderColor = Color.Silver;
            bunifuFormDock1.BorderOptions.TopBorder.BorderThickness = 1;
            bunifuFormDock1.BorderOptions.TopBorder.ShowBorder = true;
            bunifuFormDock1.ContainerControl = this;
            bunifuFormDock1.DockingIndicatorsColor = Color.AliceBlue;
            bunifuFormDock1.DockingIndicatorsOpacity = 0.5D;
            bunifuFormDock1.DockingOptions.DockAll = true;
            bunifuFormDock1.DockingOptions.DockBottomLeft = true;
            bunifuFormDock1.DockingOptions.DockBottomRight = true;
            bunifuFormDock1.DockingOptions.DockFullScreen = true;
            bunifuFormDock1.DockingOptions.DockLeft = true;
            bunifuFormDock1.DockingOptions.DockRight = true;
            bunifuFormDock1.DockingOptions.DockTopLeft = true;
            bunifuFormDock1.DockingOptions.DockTopRight = true;
            bunifuFormDock1.FormDraggingOpacity = 0.9D;
            bunifuFormDock1.ParentForm = this;
            bunifuFormDock1.ShowCursorChanges = true;
            bunifuFormDock1.ShowDockingIndicators = true;
            bunifuFormDock1.TitleBarOptions.AllowFormDragging = true;
            bunifuFormDock1.TitleBarOptions.BunifuFormDock = bunifuFormDock1;
            bunifuFormDock1.TitleBarOptions.DoubleClickToExpandWindow = true;
            bunifuFormDock1.TitleBarOptions.TitleBarControl = PnlHeadbar;
            bunifuFormDock1.TitleBarOptions.UseBackColorOnDockingIndicators = true;
            // 
            // PnlHeadbar
            // 
            PnlHeadbar.Controls.Add(label1);
            PnlHeadbar.Controls.Add(ExitBtn);
            PnlHeadbar.Dock = DockStyle.Top;
            PnlHeadbar.Location = new Point(224, 0);
            PnlHeadbar.Name = "PnlHeadbar";
            PnlHeadbar.Size = new Size(884, 53);
            PnlHeadbar.TabIndex = 2;
            // 
            // ExitBtn
            // 
            ExitBtn.ActiveImage = null;
            ExitBtn.AllowAnimations = true;
            ExitBtn.AllowBuffering = false;
            ExitBtn.AllowToggling = false;
            ExitBtn.AllowZooming = true;
            ExitBtn.AllowZoomingOnFocus = false;
            ExitBtn.BackColor = Color.Transparent;
            ExitBtn.BackgroundImage = (Image)resources.GetObject("ExitBtn.BackgroundImage");
            ExitBtn.BackgroundImageLayout = ImageLayout.Center;
            ExitBtn.DialogResult = DialogResult.None;
            ExitBtn.ErrorImage = (Image)resources.GetObject("ExitBtn.ErrorImage");
            ExitBtn.FadeWhenInactive = false;
            ExitBtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            ExitBtn.Image = (Image)resources.GetObject("ExitBtn.Image");
            ExitBtn.ImageActive = null;
            ExitBtn.ImageLocation = null;
            ExitBtn.ImageMargin = 20;
            ExitBtn.ImageSize = new Size(20, 20);
            ExitBtn.ImageZoomSize = new Size(40, 40);
            ExitBtn.InitialImage = (Image)resources.GetObject("ExitBtn.InitialImage");
            ExitBtn.Location = new Point(831, 5);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Rotation = 0;
            ExitBtn.ShowActiveImage = true;
            ExitBtn.ShowCursorChanges = true;
            ExitBtn.ShowImageBorders = true;
            ExitBtn.ShowSizeMarkers = false;
            ExitBtn.Size = new Size(40, 40);
            ExitBtn.TabIndex = 1;
            ExitBtn.ToolTipText = "";
            ExitBtn.WaitOnLoad = false;
            ExitBtn.Zoom = 20;
            ExitBtn.ZoomSpeed = 10;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // bunifuPages1
            // 
            bunifuPages1.Alignment = TabAlignment.Bottom;
            bunifuPages1.AllowTransitions = false;
            bunifuPages1.Controls.Add(tabPage2);
            bunifuPages1.Controls.Add(tabPage1);
            bunifuPages1.Dock = DockStyle.Fill;
            bunifuPages1.Location = new Point(224, 0);
            bunifuPages1.Margin = new Padding(3, 2, 3, 2);
            bunifuPages1.Multiline = true;
            bunifuPages1.Name = "bunifuPages1";
            bunifuPages1.Page = tabPage2;
            bunifuPages1.PageIndex = 0;
            bunifuPages1.PageName = "tabPage2";
            bunifuPages1.PageTitle = "Explore";
            bunifuPages1.SelectedIndex = 0;
            bunifuPages1.Size = new Size(884, 589);
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 4);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(876, 561);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Explore";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 4);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(876, 581);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Playing";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(bunifuImageButton4);
            panel1.Controls.Add(bunifuImageButton3);
            panel1.Controls.Add(bunifuImageButton2);
            panel1.Controls.Add(bunifuImageButton1);
            panel1.Controls.Add(bunifuhSlider1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(224, 589);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 54);
            panel1.TabIndex = 3;
            // 
            // bunifuhSlider1
            // 
            bunifuhSlider1.AllowCursorChanges = true;
            bunifuhSlider1.AllowHomeEndKeysDetection = false;
            bunifuhSlider1.AllowIncrementalClickMoves = true;
            bunifuhSlider1.AllowMouseDownEffects = false;
            bunifuhSlider1.AllowMouseHoverEffects = false;
            bunifuhSlider1.AllowScrollingAnimations = true;
            bunifuhSlider1.AllowScrollKeysDetection = true;
            bunifuhSlider1.AllowScrollOptionsMenu = true;
            bunifuhSlider1.AllowShrinkingOnFocusLost = false;
            bunifuhSlider1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            bunifuhSlider1.BackColor = Color.Transparent;
            bunifuhSlider1.BackgroundImage = (Image)resources.GetObject("bunifuhSlider1.BackgroundImage");
            bunifuhSlider1.BindingContainer = null;
            bunifuhSlider1.BorderRadius = 2;
            bunifuhSlider1.BorderThickness = 1;
            bunifuhSlider1.DrawThickBorder = false;
            bunifuhSlider1.DurationBeforeShrink = 2000;
            bunifuhSlider1.ElapsedColor = Color.DodgerBlue;
            bunifuhSlider1.LargeChange = 10;
            bunifuhSlider1.Location = new Point(203, 15);
            bunifuhSlider1.Maximum = 100;
            bunifuhSlider1.Minimum = 0;
            bunifuhSlider1.MinimumSize = new Size(0, 31);
            bunifuhSlider1.MinimumThumbLength = 18;
            bunifuhSlider1.Name = "bunifuhSlider1";
            bunifuhSlider1.OnDisable.ScrollBarBorderColor = Color.Silver;
            bunifuhSlider1.OnDisable.ScrollBarColor = Color.Transparent;
            bunifuhSlider1.OnDisable.ThumbColor = Color.Silver;
            bunifuhSlider1.ScrollBarBorderColor = Color.FromArgb(210, 232, 255);
            bunifuhSlider1.ScrollBarColor = Color.FromArgb(210, 232, 255);
            bunifuhSlider1.ShrinkSizeLimit = 3;
            bunifuhSlider1.Size = new Size(490, 31);
            bunifuhSlider1.SliderColor = Color.FromArgb(210, 232, 255);
            bunifuhSlider1.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            bunifuhSlider1.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            bunifuhSlider1.SmallChange = 1;
            bunifuhSlider1.TabIndex = 0;
            bunifuhSlider1.ThumbColor = Color.DodgerBlue;
            bunifuhSlider1.ThumbFillColor = SystemColors.Control;
            bunifuhSlider1.ThumbLength = 48;
            bunifuhSlider1.ThumbMargin = 1;
            bunifuhSlider1.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            bunifuhSlider1.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            bunifuhSlider1.Value = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 10);
            label1.Name = "label1";
            label1.Size = new Size(202, 30);
            label1.TabIndex = 2;
            label1.Text = "Song Title -Playing";
            // 
            // bunifuImageButton1
            // 
            bunifuImageButton1.ActiveImage = null;
            bunifuImageButton1.AllowAnimations = true;
            bunifuImageButton1.AllowBuffering = false;
            bunifuImageButton1.AllowToggling = false;
            bunifuImageButton1.AllowZooming = true;
            bunifuImageButton1.AllowZoomingOnFocus = false;
            bunifuImageButton1.BackColor = Color.Transparent;
            bunifuImageButton1.BackgroundImage = (Image)resources.GetObject("bunifuImageButton1.BackgroundImage");
            bunifuImageButton1.BackgroundImageLayout = ImageLayout.Center;
            bunifuImageButton1.DialogResult = DialogResult.None;
            bunifuImageButton1.ErrorImage = (Image)resources.GetObject("bunifuImageButton1.ErrorImage");
            bunifuImageButton1.FadeWhenInactive = false;
            bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            bunifuImageButton1.Image = (Image)resources.GetObject("bunifuImageButton1.Image");
            bunifuImageButton1.ImageActive = null;
            bunifuImageButton1.ImageLocation = null;
            bunifuImageButton1.ImageMargin = 20;
            bunifuImageButton1.ImageSize = new Size(20, 20);
            bunifuImageButton1.ImageZoomSize = new Size(40, 40);
            bunifuImageButton1.InitialImage = (Image)resources.GetObject("bunifuImageButton1.InitialImage");
            bunifuImageButton1.Location = new Point(53, 8);
            bunifuImageButton1.Name = "bunifuImageButton1";
            bunifuImageButton1.Rotation = 0;
            bunifuImageButton1.ShowActiveImage = true;
            bunifuImageButton1.ShowCursorChanges = true;
            bunifuImageButton1.ShowImageBorders = true;
            bunifuImageButton1.ShowSizeMarkers = false;
            bunifuImageButton1.Size = new Size(40, 40);
            bunifuImageButton1.TabIndex = 2;
            bunifuImageButton1.ToolTipText = "";
            bunifuImageButton1.WaitOnLoad = false;
            bunifuImageButton1.Zoom = 20;
            bunifuImageButton1.ZoomSpeed = 10;
            // 
            // bunifuImageButton2
            // 
            bunifuImageButton2.ActiveImage = null;
            bunifuImageButton2.AllowAnimations = true;
            bunifuImageButton2.AllowBuffering = false;
            bunifuImageButton2.AllowToggling = false;
            bunifuImageButton2.AllowZooming = true;
            bunifuImageButton2.AllowZoomingOnFocus = false;
            bunifuImageButton2.BackColor = Color.Transparent;
            bunifuImageButton2.BackgroundImage = (Image)resources.GetObject("bunifuImageButton2.BackgroundImage");
            bunifuImageButton2.BackgroundImageLayout = ImageLayout.Center;
            bunifuImageButton2.DialogResult = DialogResult.None;
            bunifuImageButton2.ErrorImage = (Image)resources.GetObject("bunifuImageButton2.ErrorImage");
            bunifuImageButton2.FadeWhenInactive = false;
            bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            bunifuImageButton2.Image = (Image)resources.GetObject("bunifuImageButton2.Image");
            bunifuImageButton2.ImageActive = null;
            bunifuImageButton2.ImageLocation = null;
            bunifuImageButton2.ImageMargin = 20;
            bunifuImageButton2.ImageSize = new Size(20, 20);
            bunifuImageButton2.ImageZoomSize = new Size(40, 40);
            bunifuImageButton2.InitialImage = (Image)resources.GetObject("bunifuImageButton2.InitialImage");
            bunifuImageButton2.Location = new Point(7, 8);
            bunifuImageButton2.Name = "bunifuImageButton2";
            bunifuImageButton2.Rotation = 0;
            bunifuImageButton2.ShowActiveImage = true;
            bunifuImageButton2.ShowCursorChanges = true;
            bunifuImageButton2.ShowImageBorders = true;
            bunifuImageButton2.ShowSizeMarkers = false;
            bunifuImageButton2.Size = new Size(40, 40);
            bunifuImageButton2.TabIndex = 3;
            bunifuImageButton2.ToolTipText = "";
            bunifuImageButton2.WaitOnLoad = false;
            bunifuImageButton2.Zoom = 20;
            bunifuImageButton2.ZoomSpeed = 10;
            // 
            // bunifuImageButton3
            // 
            bunifuImageButton3.ActiveImage = null;
            bunifuImageButton3.AllowAnimations = true;
            bunifuImageButton3.AllowBuffering = false;
            bunifuImageButton3.AllowToggling = false;
            bunifuImageButton3.AllowZooming = true;
            bunifuImageButton3.AllowZoomingOnFocus = false;
            bunifuImageButton3.BackColor = Color.Transparent;
            bunifuImageButton3.BackgroundImage = (Image)resources.GetObject("bunifuImageButton3.BackgroundImage");
            bunifuImageButton3.BackgroundImageLayout = ImageLayout.Center;
            bunifuImageButton3.DialogResult = DialogResult.None;
            bunifuImageButton3.ErrorImage = (Image)resources.GetObject("bunifuImageButton3.ErrorImage");
            bunifuImageButton3.FadeWhenInactive = false;
            bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            bunifuImageButton3.Image = (Image)resources.GetObject("bunifuImageButton3.Image");
            bunifuImageButton3.ImageActive = null;
            bunifuImageButton3.ImageLocation = null;
            bunifuImageButton3.ImageMargin = 20;
            bunifuImageButton3.ImageSize = new Size(20, 20);
            bunifuImageButton3.ImageZoomSize = new Size(40, 40);
            bunifuImageButton3.InitialImage = (Image)resources.GetObject("bunifuImageButton3.InitialImage");
            bunifuImageButton3.Location = new Point(99, 8);
            bunifuImageButton3.Name = "bunifuImageButton3";
            bunifuImageButton3.Rotation = 0;
            bunifuImageButton3.ShowActiveImage = true;
            bunifuImageButton3.ShowCursorChanges = true;
            bunifuImageButton3.ShowImageBorders = true;
            bunifuImageButton3.ShowSizeMarkers = false;
            bunifuImageButton3.Size = new Size(40, 40);
            bunifuImageButton3.TabIndex = 4;
            bunifuImageButton3.ToolTipText = "";
            bunifuImageButton3.WaitOnLoad = false;
            bunifuImageButton3.Zoom = 20;
            bunifuImageButton3.ZoomSpeed = 10;
            // 
            // bunifuImageButton4
            // 
            bunifuImageButton4.ActiveImage = null;
            bunifuImageButton4.AllowAnimations = true;
            bunifuImageButton4.AllowBuffering = false;
            bunifuImageButton4.AllowToggling = false;
            bunifuImageButton4.AllowZooming = true;
            bunifuImageButton4.AllowZoomingOnFocus = false;
            bunifuImageButton4.BackColor = Color.Transparent;
            bunifuImageButton4.BackgroundImage = (Image)resources.GetObject("bunifuImageButton4.BackgroundImage");
            bunifuImageButton4.BackgroundImageLayout = ImageLayout.Center;
            bunifuImageButton4.DialogResult = DialogResult.None;
            bunifuImageButton4.ErrorImage = (Image)resources.GetObject("bunifuImageButton4.ErrorImage");
            bunifuImageButton4.FadeWhenInactive = false;
            bunifuImageButton4.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            bunifuImageButton4.Image = (Image)resources.GetObject("bunifuImageButton4.Image");
            bunifuImageButton4.ImageActive = null;
            bunifuImageButton4.ImageLocation = null;
            bunifuImageButton4.ImageMargin = 20;
            bunifuImageButton4.ImageSize = new Size(20, 20);
            bunifuImageButton4.ImageZoomSize = new Size(40, 40);
            bunifuImageButton4.InitialImage = (Image)resources.GetObject("bunifuImageButton4.InitialImage");
            bunifuImageButton4.Location = new Point(145, 8);
            bunifuImageButton4.Name = "bunifuImageButton4";
            bunifuImageButton4.Rotation = 0;
            bunifuImageButton4.ShowActiveImage = true;
            bunifuImageButton4.ShowCursorChanges = true;
            bunifuImageButton4.ShowImageBorders = true;
            bunifuImageButton4.ShowSizeMarkers = false;
            bunifuImageButton4.Size = new Size(40, 40);
            bunifuImageButton4.TabIndex = 5;
            bunifuImageButton4.ToolTipText = "";
            bunifuImageButton4.WaitOnLoad = false;
            bunifuImageButton4.Zoom = 20;
            bunifuImageButton4.ZoomSpeed = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1108, 643);
            Controls.Add(PnlHeadbar);
            Controls.Add(bunifuPages1);
            Controls.Add(panel1);
            Controls.Add(PnlleftBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PnlleftBar.ResumeLayout(false);
            PnlleftBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PFPpic).EndInit();
            PnlHeadbar.ResumeLayout(false);
            PnlHeadbar.PerformLayout();
            bunifuPages1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlleftBar;
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
        private Bunifu.UI.WinForms.BunifuShapes indicator;
        private Bunifu.UI.WinForms.BunifuShapes bunifuShapes1;
        private Bunifu.UI.WinForms.BunifuFormDock bunifuFormDock1;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel PnlHeadbar;
        private Panel panel1;
        private Bunifu.UI.WinForms.BunifuHSlider bunifuhSlider1;
        private Bunifu.UI.WinForms.BunifuImageButton ExitBtn;
        private Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton4;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
    }
}