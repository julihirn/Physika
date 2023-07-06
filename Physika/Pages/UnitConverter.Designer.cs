namespace Physika.Pages {
    partial class UnitConverter {
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
            this.labelPanel1 = new ODModules.LabelPanel();
            this.prefixScale1 = new ODModules.PrefixScale();
            this.numericTextbox1 = new ODModules.NumericTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPanel2 = new ODModules.LabelPanel();
            this.prefixScale2 = new ODModules.PrefixScale();
            this.numericTextbox2 = new ODModules.NumericTextbox();
            this.UnitTypeControl = new ODModules.LabelButton();
            this.ContextMenu_UnitTypes = new ODModules.ContextMenu();
            this.ContextMenu_Units = new ODModules.ContextMenu();
            this.ContextMenu_Prefixes = new ODModules.ContextMenu();
            this.contextMenu3 = new ODModules.ContextMenu();
            this.labelPanel1.SuspendLayout();
            this.labelPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPanel1
            // 
            this.labelPanel1.ArrowColor = System.Drawing.Color.Gray;
            this.labelPanel1.ArrowMouseOverColor = System.Drawing.Color.DodgerBlue;
            this.labelPanel1.AutoSize = true;
            this.labelPanel1.CloseColor = System.Drawing.Color.Black;
            this.labelPanel1.CloseMouseOverColor = System.Drawing.Color.Red;
            this.labelPanel1.Collapsed = false;
            this.labelPanel1.Controls.Add(this.prefixScale1);
            this.labelPanel1.Controls.Add(this.numericTextbox1);
            this.labelPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel1.DropShadow = false;
            this.labelPanel1.DropShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPanel1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelPanel1.LabelFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPanel1.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPanel1.Location = new System.Drawing.Point(15, 68);
            this.labelPanel1.Name = "labelPanel1";
            this.labelPanel1.OverrideCollapseControl = false;
            this.labelPanel1.Padding = new System.Windows.Forms.Padding(0, 37, 0, 0);
            this.labelPanel1.PanelCollapsible = false;
            this.labelPanel1.ResizeControl = ODModules.LabelPanel.ResizeDirection.None;
            this.labelPanel1.ShowCloseButton = false;
            this.labelPanel1.Size = new System.Drawing.Size(402, 176);
            this.labelPanel1.TabIndex = 1;
            this.labelPanel1.Text = "Unit";
            // 
            // prefixScale1
            // 
            this.prefixScale1.Dock = System.Windows.Forms.DockStyle.Top;
            this.prefixScale1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.prefixScale1.ForeColor = System.Drawing.Color.White;
            this.prefixScale1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prefixScale1.InactiveForecolor = System.Drawing.SystemColors.GrayText;
            this.prefixScale1.LinkedNumericControl = this.numericTextbox1;
            this.prefixScale1.Location = new System.Drawing.Point(0, 106);
            this.prefixScale1.Name = "prefixScale1";
            this.prefixScale1.Size = new System.Drawing.Size(402, 70);
            this.prefixScale1.TabIndex = 1;
            // 
            // numericTextbox1
            // 
            this.numericTextbox1.AllowClipboard = true;
            this.numericTextbox1.AllowDragValueChange = true;
            this.numericTextbox1.AllowDrop = true;
            this.numericTextbox1.AllowFractionals = true;
            this.numericTextbox1.AllowMouseWheel = true;
            this.numericTextbox1.AllowNegatives = true;
            this.numericTextbox1.AllowNumberEntry = true;
            this.numericTextbox1.AllowTyping = true;
            this.numericTextbox1.AutoSizeToText = true;
            this.numericTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.numericTextbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numericTextbox1.ButtonDownColor = System.Drawing.Color.Gray;
            this.numericTextbox1.ButtonHoverColor = System.Drawing.Color.LightGray;
            this.numericTextbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericTextbox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox1.ForeColor = System.Drawing.Color.White;
            this.numericTextbox1.FormatOutput = false;
            this.numericTextbox1.HasUnit = true;
            this.numericTextbox1.IsMetric = true;
            this.numericTextbox1.IsSecondaryMetric = false;
            this.numericTextbox1.LabelFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox1.LabelForeColor = System.Drawing.Color.Gray;
            this.numericTextbox1.LabelText = "";
            this.numericTextbox1.Location = new System.Drawing.Point(0, 37);
            this.numericTextbox1.MaxmiumDecimalPlaces = ((uint)(18u));
            this.numericTextbox1.MinimumSize = new System.Drawing.Size(0, 69);
            this.numericTextbox1.Name = "numericTextbox1";
            this.numericTextbox1.NumericalFormat = ODModules.NumericTextbox.NumberFormat.Decimal;
            this.numericTextbox1.NumericalLeftRadixDigitsMaximum = 7;
            this.numericTextbox1.NumericalRightRadixDigitsMaximum = 4;
            this.numericTextbox1.Prefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.numericTextbox1.SecondaryPrefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.numericTextbox1.SecondaryTag = null;
            this.numericTextbox1.SecondaryUnit = "";
            this.numericTextbox1.SecondaryUnitDisplay = ODModules.NumericTextbox.SecondaryUnitDisplayType.NoSecondaryUnit;
            this.numericTextbox1.SelectedBackColor = System.Drawing.Color.Empty;
            this.numericTextbox1.SelectedBorderColor = System.Drawing.Color.MidnightBlue;
            this.numericTextbox1.ShowLabel = true;
            this.numericTextbox1.Size = new System.Drawing.Size(402, 69);
            this.numericTextbox1.TabIndex = 0;
            this.numericTextbox1.Unit = "";
            this.numericTextbox1.Value = "0";
            this.numericTextbox1.ValueChanged += new ODModules.NumericTextbox.ValueChangedHandler(this.numericTextbox1_ValueChanged);
            this.numericTextbox1.PrefixClicked += new ODModules.NumericTextbox.PrefixClickedHandler(this.numericTextbox1_PrefixClicked);
            this.numericTextbox1.UnitClicked += new ODModules.NumericTextbox.UnitClickedHandler(this.numericTextbox1_UnitClicked);
            this.numericTextbox1.UnitChanged += new ODModules.NumericTextbox.UnitChangedHandler(this.numericTextbox1_UnitChanged);
            this.numericTextbox1.PrefixChanged += new ODModules.NumericTextbox.PrefixChangedHandler(this.numericTextbox1_PrefixChanged);
            this.numericTextbox1.Load += new System.EventHandler(this.numericTextbox1_Load);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 29);
            this.panel1.TabIndex = 2;
            // 
            // labelPanel2
            // 
            this.labelPanel2.ArrowColor = System.Drawing.Color.Gray;
            this.labelPanel2.ArrowMouseOverColor = System.Drawing.Color.DodgerBlue;
            this.labelPanel2.AutoSize = true;
            this.labelPanel2.CloseColor = System.Drawing.Color.Black;
            this.labelPanel2.CloseMouseOverColor = System.Drawing.Color.Red;
            this.labelPanel2.Collapsed = false;
            this.labelPanel2.Controls.Add(this.prefixScale2);
            this.labelPanel2.Controls.Add(this.numericTextbox2);
            this.labelPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel2.DropShadow = false;
            this.labelPanel2.DropShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPanel2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelPanel2.LabelFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPanel2.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPanel2.Location = new System.Drawing.Point(15, 273);
            this.labelPanel2.Name = "labelPanel2";
            this.labelPanel2.OverrideCollapseControl = false;
            this.labelPanel2.Padding = new System.Windows.Forms.Padding(0, 37, 0, 0);
            this.labelPanel2.PanelCollapsible = false;
            this.labelPanel2.ResizeControl = ODModules.LabelPanel.ResizeDirection.None;
            this.labelPanel2.ShowCloseButton = false;
            this.labelPanel2.Size = new System.Drawing.Size(402, 156);
            this.labelPanel2.TabIndex = 3;
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
            this.prefixScale2.Location = new System.Drawing.Point(0, 106);
            this.prefixScale2.Name = "prefixScale2";
            this.prefixScale2.Size = new System.Drawing.Size(402, 50);
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
            this.numericTextbox2.Location = new System.Drawing.Point(0, 37);
            this.numericTextbox2.MaxmiumDecimalPlaces = ((uint)(6u));
            this.numericTextbox2.MinimumSize = new System.Drawing.Size(0, 69);
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
            this.numericTextbox2.Size = new System.Drawing.Size(402, 69);
            this.numericTextbox2.TabIndex = 1;
            this.numericTextbox2.Unit = "a";
            this.numericTextbox2.Value = "0";
            this.numericTextbox2.ValueChanged += new ODModules.NumericTextbox.ValueChangedHandler(this.numericTextbox2_ValueChanged);
            this.numericTextbox2.PrefixClicked += new ODModules.NumericTextbox.PrefixClickedHandler(this.numericTextbox2_PrefixClicked);
            this.numericTextbox2.UnitClicked += new ODModules.NumericTextbox.UnitClickedHandler(this.numericTextbox2_UnitClicked);
            this.numericTextbox2.UnitChanged += new ODModules.NumericTextbox.UnitChangedHandler(this.numericTextbox2_UnitChanged);
            this.numericTextbox2.PrefixChanged += new ODModules.NumericTextbox.PrefixChangedHandler(this.numericTextbox2_PrefixChanged);
            this.numericTextbox2.Load += new System.EventHandler(this.numericTextbox2_Load);
            // 
            // UnitTypeControl
            // 
            this.UnitTypeControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.UnitTypeControl.ButtonDownColor = System.Drawing.Color.Gray;
            this.UnitTypeControl.ButtonHoverColor = System.Drawing.Color.Beige;
            this.UnitTypeControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.UnitTypeControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnitTypeControl.ForeColor = System.Drawing.Color.White;
            this.UnitTypeControl.LabelText = "No Units Found ";
            this.UnitTypeControl.Location = new System.Drawing.Point(15, 15);
            this.UnitTypeControl.Name = "UnitTypeControl";
            this.UnitTypeControl.Size = new System.Drawing.Size(402, 53);
            this.UnitTypeControl.TabIndex = 4;
            this.UnitTypeControl.ButtonClicked += new ODModules.LabelButton.ButtonClickedHandler(this.labelButton1_ButtonClicked);
            this.UnitTypeControl.Load += new System.EventHandler(this.labelButton1_Load);
            this.UnitTypeControl.Click += new System.EventHandler(this.labelButton1_Click);
            // 
            // ContextMenu_UnitTypes
            // 
            this.ContextMenu_UnitTypes.ActionSymbolForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ContextMenu_UnitTypes.BorderColor = System.Drawing.Color.Black;
            this.ContextMenu_UnitTypes.DropShadowEnabled = false;
            this.ContextMenu_UnitTypes.ForeColor = System.Drawing.Color.White;
            this.ContextMenu_UnitTypes.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ContextMenu_UnitTypes.InsetShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContextMenu_UnitTypes.MenuBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ContextMenu_UnitTypes.MenuBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ContextMenu_UnitTypes.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ContextMenu_UnitTypes.Name = "contextMenu1";
            this.ContextMenu_UnitTypes.ShowInsetShadow = true;
            this.ContextMenu_UnitTypes.ShowItemInsetShadow = true;
            this.ContextMenu_UnitTypes.Size = new System.Drawing.Size(61, 4);
            this.ContextMenu_UnitTypes.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenu_UnitTypes_Opening);
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
            this.ContextMenu_Units.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenu_Units_Opening);
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
            this.ContextMenu_Prefixes.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenu_Prefixes_Opening);
            // 
            // contextMenu3
            // 
            this.contextMenu3.ActionSymbolForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.contextMenu3.BorderColor = System.Drawing.Color.Black;
            this.contextMenu3.DropShadowEnabled = false;
            this.contextMenu3.ForeColor = System.Drawing.Color.White;
            this.contextMenu3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenu3.InsetShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contextMenu3.MenuBackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.contextMenu3.MenuBackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.contextMenu3.MouseOverColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contextMenu3.Name = "contextMenu1";
            this.contextMenu3.ShowInsetShadow = true;
            this.contextMenu3.ShowItemInsetShadow = true;
            this.contextMenu3.Size = new System.Drawing.Size(61, 4);
            // 
            // UnitConverter
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.labelPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPanel1);
            this.Controls.Add(this.UnitTypeControl);
            this.DoubleBuffered = true;
            this.Name = "UnitConverter";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(432, 304);
            this.Load += new System.EventHandler(this.UnitConverter_Load);
            this.labelPanel1.ResumeLayout(false);
            this.labelPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ODModules.LabelPanel labelPanel1;
        private Panel panel1;
        private ODModules.LabelPanel labelPanel2;
        private ODModules.NumericTextbox numericTextbox1;
        private ODModules.NumericTextbox numericTextbox2;
        private ODModules.LabelButton UnitTypeControl;
        private ODModules.ContextMenu ContextMenu_UnitTypes;
        private ODModules.ContextMenu ContextMenu_Units;
        private ODModules.ContextMenu ContextMenu_Prefixes;
        private ODModules.ContextMenu contextMenu3;
        private ODModules.PrefixScale prefixScale1;
        private ODModules.PrefixScale prefixScale2;
    }
}
