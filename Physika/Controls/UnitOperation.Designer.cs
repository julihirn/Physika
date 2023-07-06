namespace Physika.Controls {
    partial class UnitOperation {
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
            this.UnitPanel = new ODModules.LabelPanel();
            this.PrefixEditor = new ODModules.PrefixScale();
            this.NumericEditor = new ODModules.NumericTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.UnitPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnitPanel
            // 
            this.UnitPanel.ArrowColor = System.Drawing.Color.Silver;
            this.UnitPanel.ArrowMouseOverColor = System.Drawing.Color.DodgerBlue;
            this.UnitPanel.AutoSize = true;
            this.UnitPanel.CloseColor = System.Drawing.Color.Silver;
            this.UnitPanel.CloseMouseOverColor = System.Drawing.Color.Red;
            this.UnitPanel.Collapsed = false;
            this.UnitPanel.Controls.Add(this.PrefixEditor);
            this.UnitPanel.Controls.Add(this.panel1);
            this.UnitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitPanel.DropShadow = false;
            this.UnitPanel.DropShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UnitPanel.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.UnitPanel.LabelFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnitPanel.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            this.UnitPanel.Location = new System.Drawing.Point(0, 0);
            this.UnitPanel.Name = "UnitPanel";
            this.UnitPanel.OverrideCollapseControl = true;
            this.UnitPanel.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.UnitPanel.PanelCollapsible = true;
            this.UnitPanel.ShowCloseButton = true;
            this.UnitPanel.Size = new System.Drawing.Size(392, 119);
            this.UnitPanel.TabIndex = 2;
            this.UnitPanel.Text = "Unit";
            this.UnitPanel.CloseButtonClicked += new ODModules.LabelPanel.CloseClickedHandler(this.labelPanel1_CloseButtonClicked);
            this.UnitPanel.CollapseButtonClicked += new ODModules.LabelPanel.CollapseClickedHandler(this.UnitPanel_CollapseButtonClicked);
            this.UnitPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.labelPanel1_Paint);
            // 
            // PrefixEditor
            // 
            this.PrefixEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrefixEditor.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.PrefixEditor.ForeColor = System.Drawing.Color.White;
            this.PrefixEditor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PrefixEditor.InactiveForecolor = System.Drawing.SystemColors.GrayText;
            this.PrefixEditor.LinkedNumericControl = this.NumericEditor;
            this.PrefixEditor.Location = new System.Drawing.Point(0, 53);
            this.PrefixEditor.Name = "PrefixEditor";
            this.PrefixEditor.Size = new System.Drawing.Size(392, 46);
            this.PrefixEditor.TabIndex = 1;
            // 
            // NumericEditor
            // 
            this.NumericEditor.AllowClipboard = true;
            this.NumericEditor.AllowDragValueChange = true;
            this.NumericEditor.AllowDrop = true;
            this.NumericEditor.AllowMouseWheel = true;
            this.NumericEditor.AllowNumberEntry = true;
            this.NumericEditor.AllowTyping = true;
            this.NumericEditor.AutoSizeToText = false;
            this.NumericEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.NumericEditor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.NumericEditor.ButtonDownColor = System.Drawing.Color.Gray;
            this.NumericEditor.ButtonHoverColor = System.Drawing.Color.LightGray;
            this.NumericEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.NumericEditor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumericEditor.ForeColor = System.Drawing.Color.White;
            this.NumericEditor.FormatOutput = false;
            this.NumericEditor.HasUnit = true;
            this.NumericEditor.IsMetric = true;
            this.NumericEditor.IsSecondaryMetric = false;
            this.NumericEditor.LabelFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumericEditor.LabelForeColor = System.Drawing.Color.Gray;
            this.NumericEditor.LabelText = "";
            this.NumericEditor.Location = new System.Drawing.Point(35, 0);
            this.NumericEditor.MaxmiumDecimalPlaces = ((uint)(18u));
            this.NumericEditor.Name = "NumericEditor";
            this.NumericEditor.NumericalFormat = ODModules.NumericTextbox.NumberFormat.Decimal;
            this.NumericEditor.NumericalLeftRadixDigitsMaximum = 7;
            this.NumericEditor.NumericalRightRadixDigitsMaximum = 4;
            this.NumericEditor.Prefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.NumericEditor.SecondaryPrefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.NumericEditor.SecondaryUnit = "";
            this.NumericEditor.SecondaryUnitDisplay = ODModules.NumericTextbox.SecondaryUnitDisplayType.NoSecondaryUnit;
            this.NumericEditor.SelectedBackColor = System.Drawing.Color.Empty;
            this.NumericEditor.SelectedBorderColor = System.Drawing.Color.MidnightBlue;
            this.NumericEditor.ShowLabel = true;
            this.NumericEditor.Size = new System.Drawing.Size(357, 35);
            this.NumericEditor.TabIndex = 0;
            this.NumericEditor.Unit = "";
            this.NumericEditor.Value = "0";
            this.NumericEditor.ValueChanged += new ODModules.NumericTextbox.ValueChangedHandler(this.numericTextbox1_ValueChanged);
            this.NumericEditor.UnitChanged += new ODModules.NumericTextbox.UnitChangedHandler(this.numericTextbox1_UnitChanged);
            this.NumericEditor.PrefixChanged += new ODModules.NumericTextbox.PrefixChangedHandler(this.numericTextbox1_PrefixChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NumericEditor);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 35);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // UnitOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.UnitPanel);
            this.DoubleBuffered = true;
            this.Name = "UnitOperation";
            this.Size = new System.Drawing.Size(392, 119);
            this.UnitPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Button button1;
        public ODModules.NumericTextbox NumericEditor;
        public ODModules.PrefixScale PrefixEditor;
        public ODModules.LabelPanel UnitPanel;
    }
}
