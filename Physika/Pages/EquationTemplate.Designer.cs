namespace Physika.Pages {
    partial class EquationTemplate {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.EquationTypeControl = new ODModules.LabelButton();
            this.labelPanel2 = new ODModules.LabelPanel();
            this.prefixScale2 = new ODModules.PrefixScale();
            this.numericTextbox2 = new ODModules.NumericTextbox();
            this.labelPanel1 = new ODModules.LabelPanel();
            this.btngrid_SolveFor = new ODModules.ButtonGrid();
            this.labelPanel3 = new ODModules.LabelPanel();
            this.btngrid_SolveWith = new ODModules.ButtonGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContextMenu_Prefixes = new ODModules.ContextMenu();
            this.ContextMenu_Units = new ODModules.ContextMenu();
            this.ContextMenu_Equations = new ODModules.ContextMenu();
            this.labelPanel2.SuspendLayout();
            this.labelPanel1.SuspendLayout();
            this.labelPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EquationTypeControl
            // 
            this.EquationTypeControl.ButtonDownColor = System.Drawing.Color.Gray;
            this.EquationTypeControl.ButtonHoverColor = System.Drawing.Color.Beige;
            this.EquationTypeControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.EquationTypeControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EquationTypeControl.ForeColor = System.Drawing.Color.White;
            this.EquationTypeControl.LabelText = "No Equations Found ";
            this.EquationTypeControl.Location = new System.Drawing.Point(8, 7);
            this.EquationTypeControl.Name = "EquationTypeControl";
            this.EquationTypeControl.Size = new System.Drawing.Size(416, 53);
            this.EquationTypeControl.TabIndex = 6;
            this.EquationTypeControl.ButtonClicked += new ODModules.LabelButton.ButtonClickedHandler(this.EquationTypeControl_ButtonClicked);
            this.EquationTypeControl.Load += new System.EventHandler(this.EquationTypeControl_Load);
            // 
            // labelPanel2
            // 
            this.labelPanel2.ArrowColor = System.Drawing.Color.Black;
            this.labelPanel2.ArrowMouseOverColor = System.Drawing.Color.DodgerBlue;
            this.labelPanel2.AutoSize = true;
            this.labelPanel2.CloseColor = System.Drawing.Color.Black;
            this.labelPanel2.CloseMouseOverColor = System.Drawing.Color.Red;
            this.labelPanel2.Collapsed = false;
            this.labelPanel2.Controls.Add(this.prefixScale2);
            this.labelPanel2.Controls.Add(this.numericTextbox2);
            this.labelPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelPanel2.DropShadow = false;
            this.labelPanel2.DropShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPanel2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelPanel2.LabelFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPanel2.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPanel2.Location = new System.Drawing.Point(8, 337);
            this.labelPanel2.Name = "labelPanel2";
            this.labelPanel2.OverrideCollapseControl = false;
            this.labelPanel2.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.labelPanel2.PanelCollapsible = true;
            this.labelPanel2.ResizeControl = ODModules.LabelPanel.ResizeDirection.None;
            this.labelPanel2.ShowCloseButton = false;
            this.labelPanel2.Size = new System.Drawing.Size(416, 96);
            this.labelPanel2.TabIndex = 7;
            this.labelPanel2.Text = "Unit";
            // 
            // prefixScale2
            // 
            this.prefixScale2.Dock = System.Windows.Forms.DockStyle.Top;
            this.prefixScale2.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.prefixScale2.ForeColor = System.Drawing.Color.White;
            this.prefixScale2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prefixScale2.InactiveForecolor = System.Drawing.SystemColors.GrayText;
            this.prefixScale2.LinkedNumericControl = this.numericTextbox2;
            this.prefixScale2.Location = new System.Drawing.Point(0, 52);
            this.prefixScale2.Name = "prefixScale2";
            this.prefixScale2.Size = new System.Drawing.Size(416, 44);
            this.prefixScale2.TabIndex = 2;
            // 
            // numericTextbox2
            // 
            this.numericTextbox2.AllowClipboard = true;
            this.numericTextbox2.AllowDragValueChange = true;
            this.numericTextbox2.AllowFractionals = true;
            this.numericTextbox2.AllowMouseWheel = true;
            this.numericTextbox2.AllowNegatives = true;
            this.numericTextbox2.AllowNumberEntry = false;
            this.numericTextbox2.AllowTyping = true;
            this.numericTextbox2.AutoSizeToText = true;
            this.numericTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.numericTextbox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numericTextbox2.ButtonDownColor = System.Drawing.Color.Gray;
            this.numericTextbox2.ButtonHoverColor = System.Drawing.Color.LightGray;
            this.numericTextbox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericTextbox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox2.ForeColor = System.Drawing.Color.White;
            this.numericTextbox2.FormatOutput = true;
            this.numericTextbox2.HasUnit = true;
            this.numericTextbox2.IsMetric = true;
            this.numericTextbox2.IsSecondaryMetric = false;
            this.numericTextbox2.LabelFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox2.LabelForeColor = System.Drawing.Color.Gray;
            this.numericTextbox2.LabelText = "";
            this.numericTextbox2.Location = new System.Drawing.Point(0, 18);
            this.numericTextbox2.MaxmiumDecimalPlaces = ((uint)(6u));
            this.numericTextbox2.MinimumSize = new System.Drawing.Size(0, 34);
            this.numericTextbox2.Name = "numericTextbox2";
            this.numericTextbox2.NumericalFormat = ODModules.NumericTextbox.NumberFormat.Scientific;
            this.numericTextbox2.NumericalLeftRadixDigitsMaximum = 16;
            this.numericTextbox2.NumericalRightRadixDigitsMaximum = 4;
            this.numericTextbox2.Prefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.numericTextbox2.SecondaryPrefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.numericTextbox2.SecondaryTag = null;
            this.numericTextbox2.SecondaryUnit = "";
            this.numericTextbox2.SecondaryUnitDisplay = ODModules.NumericTextbox.SecondaryUnitDisplayType.NoSecondaryUnit;
            this.numericTextbox2.SelectedBackColor = System.Drawing.Color.Empty;
            this.numericTextbox2.SelectedBorderColor = System.Drawing.Color.MidnightBlue;
            this.numericTextbox2.ShowLabel = true;
            this.numericTextbox2.Size = new System.Drawing.Size(416, 34);
            this.numericTextbox2.TabIndex = 1;
            this.numericTextbox2.Unit = "a";
            this.numericTextbox2.Value = "0";
            this.numericTextbox2.ValueChanged += new ODModules.NumericTextbox.ValueChangedHandler(this.numericTextbox2_ValueChanged);
            this.numericTextbox2.PrefixClicked += new ODModules.NumericTextbox.PrefixClickedHandler(this.numericTextbox2_PrefixClicked);
            this.numericTextbox2.UnitClicked += new ODModules.NumericTextbox.UnitClickedHandler(this.numericTextbox2_UnitClicked);
            this.numericTextbox2.UnitChanged += new ODModules.NumericTextbox.UnitChangedHandler(this.numericTextbox2_UnitChanged);
            this.numericTextbox2.PrefixChanged += new ODModules.NumericTextbox.PrefixChangedHandler(this.numericTextbox2_PrefixChanged);
            // 
            // labelPanel1
            // 
            this.labelPanel1.ArrowColor = System.Drawing.Color.DimGray;
            this.labelPanel1.ArrowMouseOverColor = System.Drawing.Color.DodgerBlue;
            this.labelPanel1.CloseColor = System.Drawing.Color.Black;
            this.labelPanel1.CloseMouseOverColor = System.Drawing.Color.Red;
            this.labelPanel1.Collapsed = false;
            this.labelPanel1.Controls.Add(this.btngrid_SolveFor);
            this.labelPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel1.DropShadow = false;
            this.labelPanel1.DropShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPanel1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelPanel1.LabelFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPanel1.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPanel1.Location = new System.Drawing.Point(8, 60);
            this.labelPanel1.Name = "labelPanel1";
            this.labelPanel1.OverrideCollapseControl = true;
            this.labelPanel1.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.labelPanel1.PanelCollapsible = true;
            this.labelPanel1.ResizeControl = ODModules.LabelPanel.ResizeDirection.None;
            this.labelPanel1.ShowCloseButton = false;
            this.labelPanel1.Size = new System.Drawing.Size(416, 86);
            this.labelPanel1.TabIndex = 8;
            this.labelPanel1.Text = "Solve For...";
            this.labelPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPanel1_Paint);
            // 
            // btngrid_SolveFor
            // 
            this.btngrid_SolveFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btngrid_SolveFor.BackColorCheckedNorth = System.Drawing.Color.Orange;
            this.btngrid_SolveFor.BackColorCheckedSouth = System.Drawing.Color.Orange;
            this.btngrid_SolveFor.BackColorDownNorth = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btngrid_SolveFor.BackColorDownSouth = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btngrid_SolveFor.BackColorHoverNorth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btngrid_SolveFor.BackColorHoverSouth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btngrid_SolveFor.BackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btngrid_SolveFor.BackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btngrid_SolveFor.BorderColorCheckedNorth = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btngrid_SolveFor.BorderColorCheckedSouth = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btngrid_SolveFor.BorderColorDownNorth = System.Drawing.Color.Black;
            this.btngrid_SolveFor.BorderColorDownSouth = System.Drawing.Color.Black;
            this.btngrid_SolveFor.BorderColorHoverNorth = System.Drawing.Color.MidnightBlue;
            this.btngrid_SolveFor.BorderColorHoverSouth = System.Drawing.Color.MidnightBlue;
            this.btngrid_SolveFor.BorderColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btngrid_SolveFor.BorderColorShadow = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btngrid_SolveFor.BorderColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btngrid_SolveFor.BorderRadius = 5;
            this.btngrid_SolveFor.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btngrid_SolveFor.ButtonSize = new System.Drawing.Size(125, 36);
            this.btngrid_SolveFor.CenterButtons = false;
            this.btngrid_SolveFor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btngrid_SolveFor.Filter = null;
            this.btngrid_SolveFor.ImageSize = new System.Drawing.Size(32, 32);
            this.btngrid_SolveFor.Location = new System.Drawing.Point(0, 18);
            this.btngrid_SolveFor.Name = "btngrid_SolveFor";
            this.btngrid_SolveFor.ScrollBarMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btngrid_SolveFor.ScrollBarNorth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btngrid_SolveFor.ScrollBarSouth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btngrid_SolveFor.SecondaryFont = null;
            this.btngrid_SolveFor.Size = new System.Drawing.Size(416, 68);
            this.btngrid_SolveFor.Style = ODModules.ButtonStyle.Round;
            this.btngrid_SolveFor.TabIndex = 8;
            this.btngrid_SolveFor.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            this.btngrid_SolveFor.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            this.btngrid_SolveFor.VerScroll = 0;
            this.btngrid_SolveFor.ButtonClicked += new ODModules.ButtonGrid.ButtonClickedEventHandler(this.btngrid_SolveFor_ButtonClicked);
            // 
            // labelPanel3
            // 
            this.labelPanel3.ArrowColor = System.Drawing.Color.DimGray;
            this.labelPanel3.ArrowMouseOverColor = System.Drawing.Color.DodgerBlue;
            this.labelPanel3.CloseColor = System.Drawing.Color.Black;
            this.labelPanel3.CloseMouseOverColor = System.Drawing.Color.Red;
            this.labelPanel3.Collapsed = false;
            this.labelPanel3.Controls.Add(this.btngrid_SolveWith);
            this.labelPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel3.DropShadow = false;
            this.labelPanel3.DropShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPanel3.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelPanel3.LabelFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPanel3.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPanel3.Location = new System.Drawing.Point(8, 146);
            this.labelPanel3.Name = "labelPanel3";
            this.labelPanel3.OverrideCollapseControl = true;
            this.labelPanel3.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.labelPanel3.PanelCollapsible = true;
            this.labelPanel3.ResizeControl = ODModules.LabelPanel.ResizeDirection.None;
            this.labelPanel3.ShowCloseButton = false;
            this.labelPanel3.Size = new System.Drawing.Size(416, 92);
            this.labelPanel3.TabIndex = 9;
            this.labelPanel3.Text = "Solve With...";
            // 
            // btngrid_SolveWith
            // 
            this.btngrid_SolveWith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btngrid_SolveWith.BackColorCheckedNorth = System.Drawing.Color.Orange;
            this.btngrid_SolveWith.BackColorCheckedSouth = System.Drawing.Color.Orange;
            this.btngrid_SolveWith.BackColorDownNorth = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btngrid_SolveWith.BackColorDownSouth = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btngrid_SolveWith.BackColorHoverNorth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btngrid_SolveWith.BackColorHoverSouth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btngrid_SolveWith.BackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btngrid_SolveWith.BackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btngrid_SolveWith.BorderColorCheckedNorth = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btngrid_SolveWith.BorderColorCheckedSouth = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btngrid_SolveWith.BorderColorDownNorth = System.Drawing.Color.Black;
            this.btngrid_SolveWith.BorderColorDownSouth = System.Drawing.Color.Black;
            this.btngrid_SolveWith.BorderColorHoverNorth = System.Drawing.Color.MidnightBlue;
            this.btngrid_SolveWith.BorderColorHoverSouth = System.Drawing.Color.MidnightBlue;
            this.btngrid_SolveWith.BorderColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btngrid_SolveWith.BorderColorShadow = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btngrid_SolveWith.BorderColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btngrid_SolveWith.BorderRadius = 5;
            this.btngrid_SolveWith.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.btngrid_SolveWith.ButtonSize = new System.Drawing.Size(125, 36);
            this.btngrid_SolveWith.CenterButtons = false;
            this.btngrid_SolveWith.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btngrid_SolveWith.Filter = null;
            this.btngrid_SolveWith.ImageSize = new System.Drawing.Size(32, 32);
            this.btngrid_SolveWith.Location = new System.Drawing.Point(0, 18);
            this.btngrid_SolveWith.Name = "btngrid_SolveWith";
            this.btngrid_SolveWith.ScrollBarMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btngrid_SolveWith.ScrollBarNorth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btngrid_SolveWith.ScrollBarSouth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btngrid_SolveWith.SecondaryFont = null;
            this.btngrid_SolveWith.Size = new System.Drawing.Size(416, 74);
            this.btngrid_SolveWith.Style = ODModules.ButtonStyle.Round;
            this.btngrid_SolveWith.TabIndex = 7;
            this.btngrid_SolveWith.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            this.btngrid_SolveWith.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            this.btngrid_SolveWith.VerScroll = 0;
            this.btngrid_SolveWith.ButtonClicked += new ODModules.ButtonGrid.ButtonClickedEventHandler(this.btngrid_SolveWith_ButtonClicked);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(8, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 99);
            this.panel1.TabIndex = 10;
            // 
            // ContextMenu_Prefixes
            // 
            this.ContextMenu_Prefixes.ActionSymbolForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ContextMenu_Prefixes.BorderColor = System.Drawing.Color.Black;
            this.ContextMenu_Prefixes.DropShadowEnabled = false;
            this.ContextMenu_Prefixes.ForeColor = System.Drawing.Color.White;
            this.ContextMenu_Prefixes.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ContextMenu_Prefixes.InsetShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContextMenu_Prefixes.MenuBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ContextMenu_Prefixes.MenuBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ContextMenu_Prefixes.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContextMenu_Prefixes.Name = "contextMenu1";
            this.ContextMenu_Prefixes.ShowInsetShadow = true;
            this.ContextMenu_Prefixes.ShowItemInsetShadow = true;
            this.ContextMenu_Prefixes.Size = new System.Drawing.Size(61, 4);
            // 
            // ContextMenu_Units
            // 
            this.ContextMenu_Units.ActionSymbolForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ContextMenu_Units.BorderColor = System.Drawing.Color.Black;
            this.ContextMenu_Units.DropShadowEnabled = false;
            this.ContextMenu_Units.ForeColor = System.Drawing.Color.White;
            this.ContextMenu_Units.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ContextMenu_Units.InsetShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContextMenu_Units.MenuBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ContextMenu_Units.MenuBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ContextMenu_Units.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContextMenu_Units.Name = "contextMenu1";
            this.ContextMenu_Units.ShowInsetShadow = true;
            this.ContextMenu_Units.ShowItemInsetShadow = true;
            this.ContextMenu_Units.Size = new System.Drawing.Size(61, 4);
            // 
            // ContextMenu_Equations
            // 
            this.ContextMenu_Equations.ActionSymbolForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ContextMenu_Equations.BorderColor = System.Drawing.Color.Black;
            this.ContextMenu_Equations.DropShadowEnabled = false;
            this.ContextMenu_Equations.ForeColor = System.Drawing.Color.White;
            this.ContextMenu_Equations.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ContextMenu_Equations.InsetShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContextMenu_Equations.MenuBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ContextMenu_Equations.MenuBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ContextMenu_Equations.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContextMenu_Equations.Name = "contextMenu1";
            this.ContextMenu_Equations.ShowInsetShadow = true;
            this.ContextMenu_Equations.ShowItemInsetShadow = true;
            this.ContextMenu_Equations.Size = new System.Drawing.Size(61, 4);
            // 
            // EquationTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPanel3);
            this.Controls.Add(this.labelPanel1);
            this.Controls.Add(this.labelPanel2);
            this.Controls.Add(this.EquationTypeControl);
            this.DoubleBuffered = true;
            this.Name = "EquationTemplate";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(432, 440);
            this.Load += new System.EventHandler(this.EquationTemplate_Load);
            this.labelPanel2.ResumeLayout(false);
            this.labelPanel1.ResumeLayout(false);
            this.labelPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ODModules.LabelButton EquationTypeControl;
        private ODModules.LabelPanel labelPanel2;
        private ODModules.PrefixScale prefixScale2;
        private ODModules.NumericTextbox numericTextbox2;
        private ODModules.LabelPanel labelPanel1;
        private ODModules.LabelPanel labelPanel3;
        private Panel panel1;
        private ODModules.ContextMenu ContextMenu_Prefixes;
        private ODModules.ContextMenu ContextMenu_Units;
        private ODModules.ContextMenu ContextMenu_Equations;
        public ODModules.ButtonGrid btngrid_SolveWith;
        public ODModules.ButtonGrid btngrid_SolveFor;
    }
}
