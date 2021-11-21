
namespace RecoilControl
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.MaxIncreaseSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.Refresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.MaxIncreaseLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.IncreaseSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.IncreaseLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.StepSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.StepLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.ExitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.CheckProcessLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.StatusLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.MaxIncreaseSlider);
            this.bunifuPanel1.Controls.Add(this.Refresh);
            this.bunifuPanel1.Controls.Add(this.MaxIncreaseLabel);
            this.bunifuPanel1.Controls.Add(this.IncreaseSlider);
            this.bunifuPanel1.Controls.Add(this.IncreaseLabel);
            this.bunifuPanel1.Controls.Add(this.StepSlider);
            this.bunifuPanel1.Controls.Add(this.StepLabel);
            this.bunifuPanel1.Location = new System.Drawing.Point(12, 54);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(223, 248);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // MaxIncreaseSlider
            // 
            this.MaxIncreaseSlider.AllowCursorChanges = true;
            this.MaxIncreaseSlider.AllowHomeEndKeysDetection = false;
            this.MaxIncreaseSlider.AllowIncrementalClickMoves = true;
            this.MaxIncreaseSlider.AllowMouseDownEffects = false;
            this.MaxIncreaseSlider.AllowMouseHoverEffects = false;
            this.MaxIncreaseSlider.AllowScrollingAnimations = true;
            this.MaxIncreaseSlider.AllowScrollKeysDetection = true;
            this.MaxIncreaseSlider.AllowScrollOptionsMenu = true;
            this.MaxIncreaseSlider.AllowShrinkingOnFocusLost = false;
            this.MaxIncreaseSlider.BackColor = System.Drawing.Color.Transparent;
            this.MaxIncreaseSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaxIncreaseSlider.BackgroundImage")));
            this.MaxIncreaseSlider.BindingContainer = null;
            this.MaxIncreaseSlider.BorderRadius = 2;
            this.MaxIncreaseSlider.BorderThickness = 1;
            this.MaxIncreaseSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaxIncreaseSlider.DrawThickBorder = false;
            this.MaxIncreaseSlider.DurationBeforeShrink = 2000;
            this.MaxIncreaseSlider.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.MaxIncreaseSlider.LargeChange = 10;
            this.MaxIncreaseSlider.Location = new System.Drawing.Point(4, 161);
            this.MaxIncreaseSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxIncreaseSlider.Maximum = 10;
            this.MaxIncreaseSlider.Minimum = 0;
            this.MaxIncreaseSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.MaxIncreaseSlider.MinimumThumbLength = 18;
            this.MaxIncreaseSlider.Name = "MaxIncreaseSlider";
            this.MaxIncreaseSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.MaxIncreaseSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.MaxIncreaseSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.MaxIncreaseSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.MaxIncreaseSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.MaxIncreaseSlider.ShrinkSizeLimit = 3;
            this.MaxIncreaseSlider.Size = new System.Drawing.Size(214, 31);
            this.MaxIncreaseSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.MaxIncreaseSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.MaxIncreaseSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.MaxIncreaseSlider.SmallChange = 1;
            this.MaxIncreaseSlider.TabIndex = 5;
            this.MaxIncreaseSlider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.MaxIncreaseSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.MaxIncreaseSlider.ThumbLength = 195;
            this.MaxIncreaseSlider.ThumbMargin = 1;
            this.MaxIncreaseSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.MaxIncreaseSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.MaxIncreaseSlider.Value = 0;
            // 
            // Refresh
            // 
            this.Refresh.AllowAnimations = true;
            this.Refresh.AllowMouseEffects = true;
            this.Refresh.AllowToggling = false;
            this.Refresh.AnimationSpeed = 200;
            this.Refresh.AutoGenerateColors = false;
            this.Refresh.AutoRoundBorders = false;
            this.Refresh.AutoSizeLeftIcon = true;
            this.Refresh.AutoSizeRightIcon = true;
            this.Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Refresh.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Refresh.BackgroundImage")));
            this.Refresh.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.Refresh.ButtonText = "Сбросить настройки";
            this.Refresh.ButtonTextMarginLeft = 0;
            this.Refresh.ColorContrastOnClick = 45;
            this.Refresh.ColorContrastOnHover = 45;
            this.Refresh.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Refresh.CustomizableEdges = borderEdges1;
            this.Refresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Refresh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Refresh.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Refresh.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Refresh.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.Refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Refresh.ForeColor = System.Drawing.Color.White;
            this.Refresh.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Refresh.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Refresh.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Refresh.IconMarginLeft = 11;
            this.Refresh.IconPadding = 10;
            this.Refresh.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Refresh.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Refresh.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Refresh.IconSize = 25;
            this.Refresh.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.Refresh.IdleBorderRadius = 1;
            this.Refresh.IdleBorderThickness = 1;
            this.Refresh.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.Refresh.IdleIconLeftImage = null;
            this.Refresh.IdleIconRightImage = null;
            this.Refresh.IndicateFocus = false;
            this.Refresh.Location = new System.Drawing.Point(4, 199);
            this.Refresh.Name = "Refresh";
            this.Refresh.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Refresh.OnDisabledState.BorderRadius = 1;
            this.Refresh.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.Refresh.OnDisabledState.BorderThickness = 1;
            this.Refresh.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Refresh.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Refresh.OnDisabledState.IconLeftImage = null;
            this.Refresh.OnDisabledState.IconRightImage = null;
            this.Refresh.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Refresh.onHoverState.BorderRadius = 1;
            this.Refresh.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.Refresh.onHoverState.BorderThickness = 1;
            this.Refresh.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Refresh.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Refresh.onHoverState.IconLeftImage = null;
            this.Refresh.onHoverState.IconRightImage = null;
            this.Refresh.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Refresh.OnIdleState.BorderRadius = 1;
            this.Refresh.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.Refresh.OnIdleState.BorderThickness = 1;
            this.Refresh.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.Refresh.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Refresh.OnIdleState.IconLeftImage = null;
            this.Refresh.OnIdleState.IconRightImage = null;
            this.Refresh.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Refresh.OnPressedState.BorderRadius = 1;
            this.Refresh.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.Refresh.OnPressedState.BorderThickness = 1;
            this.Refresh.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Refresh.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Refresh.OnPressedState.IconLeftImage = null;
            this.Refresh.OnPressedState.IconRightImage = null;
            this.Refresh.Size = new System.Drawing.Size(214, 39);
            this.Refresh.TabIndex = 4;
            this.Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Refresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Refresh.TextMarginLeft = 0;
            this.Refresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.Refresh.UseDefaultRadiusAndThickness = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // MaxIncreaseLabel
            // 
            this.MaxIncreaseLabel.AllowParentOverrides = false;
            this.MaxIncreaseLabel.AutoEllipsis = false;
            this.MaxIncreaseLabel.CursorType = null;
            this.MaxIncreaseLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaxIncreaseLabel.Location = new System.Drawing.Point(4, 134);
            this.MaxIncreaseLabel.Name = "MaxIncreaseLabel";
            this.MaxIncreaseLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MaxIncreaseLabel.Size = new System.Drawing.Size(89, 20);
            this.MaxIncreaseLabel.TabIndex = 4;
            this.MaxIncreaseLabel.Text = "● Max Inc (0):";
            this.MaxIncreaseLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.MaxIncreaseLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // IncreaseSlider
            // 
            this.IncreaseSlider.AllowCursorChanges = true;
            this.IncreaseSlider.AllowHomeEndKeysDetection = false;
            this.IncreaseSlider.AllowIncrementalClickMoves = true;
            this.IncreaseSlider.AllowMouseDownEffects = false;
            this.IncreaseSlider.AllowMouseHoverEffects = false;
            this.IncreaseSlider.AllowScrollingAnimations = true;
            this.IncreaseSlider.AllowScrollKeysDetection = true;
            this.IncreaseSlider.AllowScrollOptionsMenu = true;
            this.IncreaseSlider.AllowShrinkingOnFocusLost = false;
            this.IncreaseSlider.BackColor = System.Drawing.Color.Transparent;
            this.IncreaseSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IncreaseSlider.BackgroundImage")));
            this.IncreaseSlider.BindingContainer = null;
            this.IncreaseSlider.BorderRadius = 2;
            this.IncreaseSlider.BorderThickness = 1;
            this.IncreaseSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncreaseSlider.DrawThickBorder = false;
            this.IncreaseSlider.DurationBeforeShrink = 2000;
            this.IncreaseSlider.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.IncreaseSlider.LargeChange = 10;
            this.IncreaseSlider.Location = new System.Drawing.Point(4, 96);
            this.IncreaseSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IncreaseSlider.Maximum = 10;
            this.IncreaseSlider.Minimum = 0;
            this.IncreaseSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.IncreaseSlider.MinimumThumbLength = 18;
            this.IncreaseSlider.Name = "IncreaseSlider";
            this.IncreaseSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.IncreaseSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.IncreaseSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.IncreaseSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.IncreaseSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.IncreaseSlider.ShrinkSizeLimit = 3;
            this.IncreaseSlider.Size = new System.Drawing.Size(214, 31);
            this.IncreaseSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.IncreaseSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.IncreaseSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.IncreaseSlider.SmallChange = 1;
            this.IncreaseSlider.TabIndex = 3;
            this.IncreaseSlider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.IncreaseSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.IncreaseSlider.ThumbLength = 195;
            this.IncreaseSlider.ThumbMargin = 1;
            this.IncreaseSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.IncreaseSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.IncreaseSlider.Value = 0;
            // 
            // IncreaseLabel
            // 
            this.IncreaseLabel.AllowParentOverrides = false;
            this.IncreaseLabel.AutoEllipsis = false;
            this.IncreaseLabel.CursorType = null;
            this.IncreaseLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IncreaseLabel.Location = new System.Drawing.Point(4, 69);
            this.IncreaseLabel.Name = "IncreaseLabel";
            this.IncreaseLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IncreaseLabel.Size = new System.Drawing.Size(92, 20);
            this.IncreaseLabel.TabIndex = 2;
            this.IncreaseLabel.Text = "● Increase (0):";
            this.IncreaseLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.IncreaseLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // StepSlider
            // 
            this.StepSlider.AllowCursorChanges = true;
            this.StepSlider.AllowHomeEndKeysDetection = false;
            this.StepSlider.AllowIncrementalClickMoves = true;
            this.StepSlider.AllowMouseDownEffects = false;
            this.StepSlider.AllowMouseHoverEffects = false;
            this.StepSlider.AllowScrollingAnimations = true;
            this.StepSlider.AllowScrollKeysDetection = true;
            this.StepSlider.AllowScrollOptionsMenu = true;
            this.StepSlider.AllowShrinkingOnFocusLost = false;
            this.StepSlider.BackColor = System.Drawing.Color.Transparent;
            this.StepSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StepSlider.BackgroundImage")));
            this.StepSlider.BindingContainer = null;
            this.StepSlider.BorderRadius = 2;
            this.StepSlider.BorderThickness = 1;
            this.StepSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StepSlider.DrawThickBorder = false;
            this.StepSlider.DurationBeforeShrink = 2000;
            this.StepSlider.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.StepSlider.LargeChange = 10;
            this.StepSlider.Location = new System.Drawing.Point(4, 31);
            this.StepSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StepSlider.Maximum = 20;
            this.StepSlider.Minimum = 1;
            this.StepSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.StepSlider.MinimumThumbLength = 18;
            this.StepSlider.Name = "StepSlider";
            this.StepSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.StepSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.StepSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.StepSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.StepSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.StepSlider.ShrinkSizeLimit = 3;
            this.StepSlider.Size = new System.Drawing.Size(214, 31);
            this.StepSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.StepSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.StepSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.StepSlider.SmallChange = 1;
            this.StepSlider.TabIndex = 1;
            this.StepSlider.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.StepSlider.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.StepSlider.ThumbLength = 107;
            this.StepSlider.ThumbMargin = 1;
            this.StepSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.StepSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.StepSlider.Value = 1;
            // 
            // StepLabel
            // 
            this.StepLabel.AllowParentOverrides = false;
            this.StepLabel.AutoEllipsis = false;
            this.StepLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.StepLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.StepLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StepLabel.Location = new System.Drawing.Point(4, 4);
            this.StepLabel.Name = "StepLabel";
            this.StepLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StepLabel.Size = new System.Drawing.Size(68, 20);
            this.StepLabel.TabIndex = 0;
            this.StepLabel.Text = "● Step (1):";
            this.StepLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.StepLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ExitButton
            // 
            this.ExitButton.AllowAnimations = true;
            this.ExitButton.AllowBorderColorChanges = true;
            this.ExitButton.AllowMouseEffects = true;
            this.ExitButton.AnimationSpeed = 200;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.ExitButton.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ExitButton.BorderRadius = 1;
            this.ExitButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.ExitButton.BorderThickness = 1;
            this.ExitButton.ColorContrastOnClick = 30;
            this.ExitButton.ColorContrastOnHover = 30;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.ExitButton.CustomizableEdges = borderEdges2;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageMargin = new System.Windows.Forms.Padding(0);
            this.ExitButton.Location = new System.Drawing.Point(200, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.RoundBorders = true;
            this.ExitButton.ShowBorders = true;
            this.ExitButton.Size = new System.Drawing.Size(35, 35);
            this.ExitButton.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.CheckProcessLabel);
            this.bunifuPanel2.Controls.Add(this.StatusLabel);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel6);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel5);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel4);
            this.bunifuPanel2.Location = new System.Drawing.Point(12, 308);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(223, 83);
            this.bunifuPanel2.TabIndex = 6;
            // 
            // CheckProcessLabel
            // 
            this.CheckProcessLabel.AllowParentOverrides = false;
            this.CheckProcessLabel.AutoEllipsis = false;
            this.CheckProcessLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckProcessLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.CheckProcessLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckProcessLabel.ForeColor = System.Drawing.Color.Red;
            this.CheckProcessLabel.Location = new System.Drawing.Point(102, 29);
            this.CheckProcessLabel.Name = "CheckProcessLabel";
            this.CheckProcessLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CheckProcessLabel.Size = new System.Drawing.Size(73, 20);
            this.CheckProcessLabel.TabIndex = 7;
            this.CheckProcessLabel.Text = "Not Open !";
            this.CheckProcessLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CheckProcessLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AllowParentOverrides = false;
            this.StatusLabel.AutoEllipsis = false;
            this.StatusLabel.CursorType = null;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(66, 55);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatusLabel.Size = new System.Drawing.Size(67, 20);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Disabled !";
            this.StatusLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.StatusLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel6.Location = new System.Drawing.Point(4, 55);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(56, 20);
            this.bunifuLabel6.TabIndex = 4;
            this.bunifuLabel6.Text = "● Status:";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel5.Location = new System.Drawing.Point(3, 29);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(93, 20);
            this.bunifuLabel5.TabIndex = 2;
            this.bunifuLabel5.Text = "● RainbowSix: ";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel4.Location = new System.Drawing.Point(4, 3);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(214, 20);
            this.bunifuLabel4.TabIndex = 1;
            this.bunifuLabel4.Text = "● Activate / DeActivate Key: [F2]";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(247, 408);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.bunifuPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuHSlider MaxIncreaseSlider;
        private Bunifu.UI.WinForms.BunifuLabel MaxIncreaseLabel;
        private Bunifu.UI.WinForms.BunifuHSlider IncreaseSlider;
        private Bunifu.UI.WinForms.BunifuLabel IncreaseLabel;
        private Bunifu.UI.WinForms.BunifuHSlider StepSlider;
        private Bunifu.UI.WinForms.BunifuLabel StepLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 Refresh;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton ExitButton;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel StatusLabel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel CheckProcessLabel;
    }
}

