namespace Physika.Pages {
    partial class UnitCalculator {
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
            ODModules.Column column1 = new ODModules.Column();
            ODModules.Column column2 = new ODModules.Column();
            ODModules.Column column3 = new ODModules.Column();
            this.UnitTypeControl = new ODModules.LabelButton();
            this.labelPanel2 = new ODModules.LabelPanel();
            this.prefixScale2 = new ODModules.PrefixScale();
            this.numericTextbox2 = new ODModules.NumericTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContextMenu_Prefixes = new ODModules.ContextMenu();
            this.ContextMenu_Units = new ODModules.ContextMenu();
            this.ContextMenu_UnitTypes = new ODModules.ContextMenu();
            this.button2 = new ODModules.Button();
            this.listControl1 = new ODModules.ListControl();
            this.labelPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnitTypeControl
            // 
            this.UnitTypeControl.ButtonDownColor = System.Drawing.Color.Gray;
            this.UnitTypeControl.ButtonHoverColor = System.Drawing.Color.Beige;
            this.UnitTypeControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.UnitTypeControl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnitTypeControl.ForeColor = System.Drawing.Color.White;
            this.UnitTypeControl.LabelText = "No Units Found ";
            this.UnitTypeControl.Location = new System.Drawing.Point(8, 7);
            this.UnitTypeControl.Name = "UnitTypeControl";
            this.UnitTypeControl.Size = new System.Drawing.Size(416, 53);
            this.UnitTypeControl.TabIndex = 5;
            this.UnitTypeControl.ButtonClicked += new ODModules.LabelButton.ButtonClickedHandler(this.UnitTypeControl_ButtonClicked);
            this.UnitTypeControl.Load += new System.EventHandler(this.UnitTypeControl_Load);
            // 
            // labelPanel2
            // 
            this.labelPanel2.ArrowColor = System.Drawing.Color.DimGray;
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
            this.labelPanel2.Location = new System.Drawing.Point(8, 271);
            this.labelPanel2.Name = "labelPanel2";
            this.labelPanel2.OverrideCollapseControl = false;
            this.labelPanel2.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.labelPanel2.PanelCollapsible = true;
            this.labelPanel2.ResizeControl = ODModules.LabelPanel.ResizeDirection.None;
            this.labelPanel2.ShowCloseButton = false;
            this.labelPanel2.Size = new System.Drawing.Size(416, 96);
            this.labelPanel2.TabIndex = 6;
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
            this.numericTextbox2.PrefixClicked += new ODModules.NumericTextbox.PrefixClickedHandler(this.numericTextbox2_PrefixClicked);
            this.numericTextbox2.UnitClicked += new ODModules.NumericTextbox.UnitClickedHandler(this.numericTextbox2_UnitClicked);
            this.numericTextbox2.UnitChanged += new ODModules.NumericTextbox.UnitChangedHandler(this.numericTextbox2_UnitChanged);
            this.numericTextbox2.PrefixChanged += new ODModules.NumericTextbox.PrefixChangedHandler(this.numericTextbox2_PrefixChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(414, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 138);
            this.panel1.TabIndex = 7;
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
            // 
            // button2
            // 
            this.button2.AllowGroupUnchecking = false;
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColorCheckedNorth = System.Drawing.Color.Orange;
            this.button2.BackColorCheckedSouth = System.Drawing.Color.Orange;
            this.button2.BackColorDownNorth = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button2.BackColorDownSouth = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button2.BackColorHoverNorth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.BackColorHoverSouth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.BackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.BackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button2.BorderColorCheckedNorth = System.Drawing.Color.Black;
            this.button2.BorderColorCheckedSouth = System.Drawing.Color.Black;
            this.button2.BorderColorDownNorth = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button2.BorderColorDownSouth = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.button2.BorderColorHoverNorth = System.Drawing.Color.MidnightBlue;
            this.button2.BorderColorHoverSouth = System.Drawing.Color.MidnightBlue;
            this.button2.BorderColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.BorderColorShadow = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.BorderColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.BorderRadius = 5;
            this.button2.Checked = false;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.GroupMaximumChecked = 2;
            this.button2.Location = new System.Drawing.Point(364, 31);
            this.button2.Name = "button2";
            this.button2.RadioButtonGroup = "";
            this.button2.SecondaryFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.SecondaryText = "";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.Style = ODModules.ButtonStyle.Square;
            this.button2.TabIndex = 0;
            this.button2.Text = "Add";
            this.button2.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            this.button2.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            this.button2.Type = ODModules.ButtonType.Button;
            this.button2.ButtonClicked += new ODModules.Button.ButtonClickedHandler(this.button2_ButtonClicked);
            this.button2.Load += new System.EventHandler(this.button2_Load);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // listControl1
            // 
            this.listControl1.AllowColumnSpanning = true;
            this.listControl1.AllowMouseWheel = true;
            this.listControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.listControl1.ColumnColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listControl1.ColumnForeColor = System.Drawing.Color.WhiteSmoke;
            this.listControl1.ColumnLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            column1.ColumnAlignment = ODModules.ColumnTextAlignment.Left;
            column1.DisplayType = ODModules.ColumnDisplayType.DropDown;
            column1.DropDownRight = false;
            column1.DropDownVisible = true;
            column1.FixedWidth = false;
            column1.ItemAlignment = ODModules.ItemTextAlignment.Left;
            column1.Text = "Name";
            column1.UseItemBackColor = false;
            column1.UseItemForeColor = false;
            column1.Visible = true;
            column1.Width = 120;
            column2.ColumnAlignment = ODModules.ColumnTextAlignment.Center;
            column2.DisplayType = ODModules.ColumnDisplayType.Checkbox;
            column2.DropDownRight = false;
            column2.DropDownVisible = true;
            column2.FixedWidth = true;
            column2.ItemAlignment = ODModules.ItemTextAlignment.Left;
            column2.Text = "";
            column2.UseItemBackColor = false;
            column2.UseItemForeColor = false;
            column2.Visible = true;
            column2.Width = 20;
            column3.ColumnAlignment = ODModules.ColumnTextAlignment.Left;
            column3.DisplayType = ODModules.ColumnDisplayType.DropDown;
            column3.DropDownRight = false;
            column3.DropDownVisible = false;
            column3.FixedWidth = false;
            column3.ItemAlignment = ODModules.ItemTextAlignment.Right;
            column3.Text = "Value";
            column3.UseItemBackColor = false;
            column3.UseItemForeColor = false;
            column3.Visible = true;
            column3.Width = 276;
            this.listControl1.Columns.Add(column1);
            this.listControl1.Columns.Add(column2);
            this.listControl1.Columns.Add(column3);
            this.listControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listControl1.DropDownMouseDown = System.Drawing.Color.DimGray;
            this.listControl1.DropDownMouseOver = System.Drawing.Color.LightGray;
            this.listControl1.Filter = null;
            this.listControl1.FilterColumn = 0;
            this.listControl1.GridlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listControl1.HighlightStrength = 128;
            this.listControl1.HorScroll = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.listControl1.LineMarkerIndex = 0;
            this.listControl1.Location = new System.Drawing.Point(8, 60);
            this.listControl1.MarkerBorderColor = System.Drawing.Color.LimeGreen;
            this.listControl1.MarkerFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.listControl1.MarkerStyle = ODModules.MarkerStyleType.Highlight;
            this.listControl1.Name = "listControl1";
            this.listControl1.RowColor = System.Drawing.Color.LightGray;
            this.listControl1.ScrollBarMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listControl1.ScrollBarNorth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listControl1.ScrollBarSouth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listControl1.ScrollItems = 3;
            this.listControl1.SelectedColor = System.Drawing.Color.SteelBlue;
            this.listControl1.SelectionColor = System.Drawing.Color.Gray;
            this.listControl1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listControl1.ShowGrid = false;
            this.listControl1.ShowMarker = false;
            this.listControl1.ShowRowColors = false;
            this.listControl1.Size = new System.Drawing.Size(416, 211);
            this.listControl1.SpanColumn = 2;
            this.listControl1.TabIndex = 8;
            this.listControl1.VerScroll = 0;
            this.listControl1.DropDownClicked += new ODModules.ListControl.DropDownClickedHandler(this.listControl1_DropDownClicked);
            // 
            // UnitCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.listControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelPanel2);
            this.Controls.Add(this.UnitTypeControl);
            this.Name = "UnitCalculator";
            this.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Size = new System.Drawing.Size(432, 374);
            this.Load += new System.EventHandler(this.UnitCalculator_Load);
            this.labelPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ODModules.LabelButton UnitTypeControl;
        private ODModules.LabelPanel labelPanel2;
        private ODModules.PrefixScale prefixScale2;
        private ODModules.NumericTextbox numericTextbox2;
        private Panel panel1;
        private ODModules.ContextMenu ContextMenu_Prefixes;
        private ODModules.ContextMenu ContextMenu_Units;
        private ODModules.ContextMenu ContextMenu_UnitTypes;
        private ODModules.Button button2;
        private ODModules.ListControl listControl1;
    }
}
