namespace Physika {
    partial class Form2 {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.hiddenTabControl1 = new ODModules.HiddenTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabHeaderControl1 = new Physika.TabHeaderControl();
            this.labelPanel1 = new ODModules.LabelPanel();
            this.numericTextbox1 = new ODModules.NumericTextbox();
            this.prefixScale1 = new ODModules.PrefixScale();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.numericTextbox2 = new ODModules.NumericTextbox();
            this.numericTextbox3 = new ODModules.NumericTextbox();
            this.numericTextbox4 = new ODModules.NumericTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.hiddenTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // hiddenTabControl1
            // 
            this.hiddenTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.hiddenTabControl1.Controls.Add(this.tabPage1);
            this.hiddenTabControl1.Controls.Add(this.tabPage2);
            this.hiddenTabControl1.DebugMode = false;
            this.hiddenTabControl1.DefaultColor1 = System.Drawing.Color.DodgerBlue;
            this.hiddenTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.hiddenTabControl1.ForeColor = System.Drawing.Color.White;
            this.hiddenTabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.hiddenTabControl1.Location = new System.Drawing.Point(564, 90);
            this.hiddenTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.hiddenTabControl1.Multiline = true;
            this.hiddenTabControl1.Name = "hiddenTabControl1";
            this.hiddenTabControl1.SelectedIndex = 0;
            this.hiddenTabControl1.Size = new System.Drawing.Size(113, 277);
            this.hiddenTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.hiddenTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(105, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(341, 248);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabHeaderControl1
            // 
            this.tabHeaderControl1.BindedTabControl = this.hiddenTabControl1;
            this.tabHeaderControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabHeaderControl1.Location = new System.Drawing.Point(221, 12);
            this.tabHeaderControl1.Name = "tabHeaderControl1";
            this.tabHeaderControl1.SelectedIndex = 0;
            this.tabHeaderControl1.Size = new System.Drawing.Size(452, 43);
            this.tabHeaderControl1.TabBackColor = System.Drawing.Color.Gray;
            this.tabHeaderControl1.TabClickedBackColor = System.Drawing.Color.DarkGray;
            this.tabHeaderControl1.TabHoverBackColor = System.Drawing.Color.LightGray;
            this.tabHeaderControl1.TabIndex = 1;
            this.tabHeaderControl1.TabSelectedBackColor = System.Drawing.Color.LightGray;
            this.tabHeaderControl1.TabStyle = Physika.TabHeaderControl.TabStyles.Underlined;
            // 
            // labelPanel1
            // 
            this.labelPanel1.ArrowColor = System.Drawing.Color.Black;
            this.labelPanel1.ArrowMouseOverColor = System.Drawing.Color.DodgerBlue;
            this.labelPanel1.CloseColor = System.Drawing.Color.Black;
            this.labelPanel1.CloseMouseOverColor = System.Drawing.Color.Red;
            this.labelPanel1.Collapsed = false;
            this.labelPanel1.DropShadow = false;
            this.labelPanel1.DropShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPanel1.LabelBackColor = System.Drawing.Color.White;
            this.labelPanel1.LabelFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPanel1.LabelForeColor = System.Drawing.Color.Black;
            this.labelPanel1.Location = new System.Drawing.Point(43, 250);
            this.labelPanel1.Name = "labelPanel1";
            this.labelPanel1.OverrideCollapseControl = false;
            this.labelPanel1.Padding = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.labelPanel1.PanelCollapsible = true;
            this.labelPanel1.ResizeControl = ODModules.LabelPanel.ResizeDirection.None;
            this.labelPanel1.ShowCloseButton = true;
            this.labelPanel1.Size = new System.Drawing.Size(159, 44);
            this.labelPanel1.TabIndex = 2;
            this.labelPanel1.Text = "labelPanel1";
            this.labelPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPanel1_Paint);
            // 
            // numericTextbox1
            // 
            this.numericTextbox1.AllowClipboard = true;
            this.numericTextbox1.AllowDragValueChange = true;
            this.numericTextbox1.AllowFractionals = true;
            this.numericTextbox1.AllowMouseWheel = true;
            this.numericTextbox1.AllowNegatives = true;
            this.numericTextbox1.AllowNumberEntry = true;
            this.numericTextbox1.AllowTyping = true;
            this.numericTextbox1.AutoSizeToText = false;
            this.numericTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numericTextbox1.BorderColor = System.Drawing.Color.DimGray;
            this.numericTextbox1.ButtonDownColor = System.Drawing.Color.Gray;
            this.numericTextbox1.ButtonHoverColor = System.Drawing.Color.LightGray;
            this.numericTextbox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox1.FormatOutput = true;
            this.numericTextbox1.HasUnit = true;
            this.numericTextbox1.IsMetric = true;
            this.numericTextbox1.IsSecondaryMetric = true;
            this.numericTextbox1.LabelFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox1.LabelForeColor = System.Drawing.Color.Gray;
            this.numericTextbox1.LabelText = "";
            this.numericTextbox1.Location = new System.Drawing.Point(43, 292);
            this.numericTextbox1.MaxmiumDecimalPlaces = ((uint)(18u));
            this.numericTextbox1.Name = "numericTextbox1";
            this.numericTextbox1.NumericalFormat = ODModules.NumericTextbox.NumberFormat.Decimal;
            this.numericTextbox1.NumericalLeftRadixDigitsMaximum = 7;
            this.numericTextbox1.NumericalRightRadixDigitsMaximum = 4;
            this.numericTextbox1.Prefix = ODModules.NumericTextbox.MetricPrefix.Kilo;
            this.numericTextbox1.SecondaryPrefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.numericTextbox1.SecondaryTag = null;
            this.numericTextbox1.SecondaryUnit = "s";
            this.numericTextbox1.SecondaryUnitDisplay = ODModules.NumericTextbox.SecondaryUnitDisplayType.Divide;
            this.numericTextbox1.SelectedBackColor = System.Drawing.Color.Empty;
            this.numericTextbox1.SelectedBorderColor = System.Drawing.Color.Beige;
            this.numericTextbox1.ShowLabel = true;
            this.numericTextbox1.Size = new System.Drawing.Size(263, 32);
            this.numericTextbox1.TabIndex = 3;
            this.numericTextbox1.Unit = "m";
            this.numericTextbox1.Value = "0";
            // 
            // prefixScale1
            // 
            this.prefixScale1.BackColor = System.Drawing.Color.White;
            this.prefixScale1.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.prefixScale1.ForeColor = System.Drawing.Color.Black;
            this.prefixScale1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prefixScale1.InactiveForecolor = System.Drawing.Color.LightGray;
            this.prefixScale1.LinkedNumericControl = this.numericTextbox1;
            this.prefixScale1.Location = new System.Drawing.Point(43, 429);
            this.prefixScale1.Name = "prefixScale1";
            this.prefixScale1.Size = new System.Drawing.Size(263, 82);
            this.prefixScale1.TabIndex = 4;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(312, 90);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.numericTextbox1;
            this.propertyGrid1.Size = new System.Drawing.Size(283, 348);
            this.propertyGrid1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // numericTextbox2
            // 
            this.numericTextbox2.AllowClipboard = true;
            this.numericTextbox2.AllowDragValueChange = true;
            this.numericTextbox2.AllowFractionals = false;
            this.numericTextbox2.AllowMouseWheel = true;
            this.numericTextbox2.AllowNegatives = true;
            this.numericTextbox2.AllowNumberEntry = true;
            this.numericTextbox2.AllowTyping = true;
            this.numericTextbox2.AutoSizeToText = false;
            this.numericTextbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.numericTextbox2.BorderColor = System.Drawing.Color.DimGray;
            this.numericTextbox2.ButtonDownColor = System.Drawing.Color.Gray;
            this.numericTextbox2.ButtonHoverColor = System.Drawing.Color.LightGray;
            this.numericTextbox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox2.FormatOutput = true;
            this.numericTextbox2.HasUnit = true;
            this.numericTextbox2.IsMetric = true;
            this.numericTextbox2.IsSecondaryMetric = true;
            this.numericTextbox2.LabelFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox2.LabelForeColor = System.Drawing.Color.Gray;
            this.numericTextbox2.LabelText = "";
            this.numericTextbox2.Location = new System.Drawing.Point(43, 330);
            this.numericTextbox2.MaxmiumDecimalPlaces = ((uint)(18u));
            this.numericTextbox2.Name = "numericTextbox2";
            this.numericTextbox2.NumericalFormat = ODModules.NumericTextbox.NumberFormat.Decimal;
            this.numericTextbox2.NumericalLeftRadixDigitsMaximum = 7;
            this.numericTextbox2.NumericalRightRadixDigitsMaximum = 4;
            this.numericTextbox2.Prefix = ODModules.NumericTextbox.MetricPrefix.Kilo;
            this.numericTextbox2.SecondaryPrefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.numericTextbox2.SecondaryTag = null;
            this.numericTextbox2.SecondaryUnit = "s";
            this.numericTextbox2.SecondaryUnitDisplay = ODModules.NumericTextbox.SecondaryUnitDisplayType.Divide;
            this.numericTextbox2.SelectedBackColor = System.Drawing.Color.Empty;
            this.numericTextbox2.SelectedBorderColor = System.Drawing.Color.Beige;
            this.numericTextbox2.ShowLabel = true;
            this.numericTextbox2.Size = new System.Drawing.Size(263, 32);
            this.numericTextbox2.TabIndex = 6;
            this.numericTextbox2.Unit = "m";
            this.numericTextbox2.Value = "0";
            // 
            // numericTextbox3
            // 
            this.numericTextbox3.AllowClipboard = true;
            this.numericTextbox3.AllowDragValueChange = true;
            this.numericTextbox3.AllowFractionals = true;
            this.numericTextbox3.AllowMouseWheel = true;
            this.numericTextbox3.AllowNegatives = false;
            this.numericTextbox3.AllowNumberEntry = true;
            this.numericTextbox3.AllowTyping = true;
            this.numericTextbox3.AutoSizeToText = false;
            this.numericTextbox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numericTextbox3.BorderColor = System.Drawing.Color.DimGray;
            this.numericTextbox3.ButtonDownColor = System.Drawing.Color.Gray;
            this.numericTextbox3.ButtonHoverColor = System.Drawing.Color.LightGray;
            this.numericTextbox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox3.FormatOutput = true;
            this.numericTextbox3.HasUnit = true;
            this.numericTextbox3.IsMetric = true;
            this.numericTextbox3.IsSecondaryMetric = true;
            this.numericTextbox3.LabelFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox3.LabelForeColor = System.Drawing.Color.Gray;
            this.numericTextbox3.LabelText = "";
            this.numericTextbox3.Location = new System.Drawing.Point(43, 365);
            this.numericTextbox3.MaxmiumDecimalPlaces = ((uint)(18u));
            this.numericTextbox3.Name = "numericTextbox3";
            this.numericTextbox3.NumericalFormat = ODModules.NumericTextbox.NumberFormat.Decimal;
            this.numericTextbox3.NumericalLeftRadixDigitsMaximum = 7;
            this.numericTextbox3.NumericalRightRadixDigitsMaximum = 4;
            this.numericTextbox3.Prefix = ODModules.NumericTextbox.MetricPrefix.Kilo;
            this.numericTextbox3.SecondaryPrefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.numericTextbox3.SecondaryTag = null;
            this.numericTextbox3.SecondaryUnit = "s";
            this.numericTextbox3.SecondaryUnitDisplay = ODModules.NumericTextbox.SecondaryUnitDisplayType.Divide;
            this.numericTextbox3.SelectedBackColor = System.Drawing.Color.Empty;
            this.numericTextbox3.SelectedBorderColor = System.Drawing.Color.Beige;
            this.numericTextbox3.ShowLabel = true;
            this.numericTextbox3.Size = new System.Drawing.Size(263, 32);
            this.numericTextbox3.TabIndex = 7;
            this.numericTextbox3.Unit = "m";
            this.numericTextbox3.Value = "0";
            // 
            // numericTextbox4
            // 
            this.numericTextbox4.AllowClipboard = true;
            this.numericTextbox4.AllowDragValueChange = true;
            this.numericTextbox4.AllowFractionals = false;
            this.numericTextbox4.AllowMouseWheel = true;
            this.numericTextbox4.AllowNegatives = false;
            this.numericTextbox4.AllowNumberEntry = true;
            this.numericTextbox4.AllowTyping = true;
            this.numericTextbox4.AutoSizeToText = false;
            this.numericTextbox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numericTextbox4.BorderColor = System.Drawing.Color.DimGray;
            this.numericTextbox4.ButtonDownColor = System.Drawing.Color.Gray;
            this.numericTextbox4.ButtonHoverColor = System.Drawing.Color.LightGray;
            this.numericTextbox4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox4.FormatOutput = true;
            this.numericTextbox4.HasUnit = true;
            this.numericTextbox4.IsMetric = true;
            this.numericTextbox4.IsSecondaryMetric = true;
            this.numericTextbox4.LabelFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox4.LabelForeColor = System.Drawing.Color.Gray;
            this.numericTextbox4.LabelText = "";
            this.numericTextbox4.Location = new System.Drawing.Point(43, 403);
            this.numericTextbox4.MaxmiumDecimalPlaces = ((uint)(18u));
            this.numericTextbox4.Name = "numericTextbox4";
            this.numericTextbox4.NumericalFormat = ODModules.NumericTextbox.NumberFormat.Decimal;
            this.numericTextbox4.NumericalLeftRadixDigitsMaximum = 7;
            this.numericTextbox4.NumericalRightRadixDigitsMaximum = 4;
            this.numericTextbox4.Prefix = ODModules.NumericTextbox.MetricPrefix.Kilo;
            this.numericTextbox4.SecondaryPrefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.numericTextbox4.SecondaryTag = null;
            this.numericTextbox4.SecondaryUnit = "s";
            this.numericTextbox4.SecondaryUnitDisplay = ODModules.NumericTextbox.SecondaryUnitDisplayType.Divide;
            this.numericTextbox4.SelectedBackColor = System.Drawing.Color.Empty;
            this.numericTextbox4.SelectedBorderColor = System.Drawing.Color.Beige;
            this.numericTextbox4.ShowLabel = true;
            this.numericTextbox4.Size = new System.Drawing.Size(263, 32);
            this.numericTextbox4.TabIndex = 8;
            this.numericTextbox4.Unit = "m";
            this.numericTextbox4.Value = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(43, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 156);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 196);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numericTextbox4);
            this.Controls.Add(this.numericTextbox3);
            this.Controls.Add(this.numericTextbox2);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.prefixScale1);
            this.Controls.Add(this.numericTextbox1);
            this.Controls.Add(this.labelPanel1);
            this.Controls.Add(this.tabHeaderControl1);
            this.Controls.Add(this.hiddenTabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.hiddenTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ODModules.HiddenTabControl hiddenTabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabHeaderControl tabHeaderControl1;
        private ODModules.LabelPanel labelPanel1;
        private ODModules.NumericTextbox numericTextbox1;
        private ODModules.PrefixScale prefixScale1;
        private PropertyGrid propertyGrid1;
        private ODModules.NumericTextbox numericTextbox2;
        private ODModules.NumericTextbox numericTextbox3;
        private ODModules.NumericTextbox numericTextbox4;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
    }
}