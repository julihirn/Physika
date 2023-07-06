namespace Physika.Pages {
    partial class CalculatorExpression {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorExpression));
            ODModules.Column column1 = new ODModules.Column();
            ODModules.Column column2 = new ODModules.Column();
            this.ExpressionTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.labelPanel2 = new ODModules.LabelPanel();
            this.labelPanel1 = new ODModules.LabelPanel();
            this.numericTextbox1 = new ODModules.NumericTextbox();
            this.labelPanel3 = new ODModules.LabelPanel();
            this.listControl1 = new ODModules.ListControl();
            ((System.ComponentModel.ISupportInitialize)(this.ExpressionTextBox)).BeginInit();
            this.labelPanel2.SuspendLayout();
            this.labelPanel1.SuspendLayout();
            this.labelPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExpressionTextBox
            // 
            this.ExpressionTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ExpressionTextBox.AutoScrollMinSize = new System.Drawing.Size(2, 18);
            this.ExpressionTextBox.BackBrush = null;
            this.ExpressionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ExpressionTextBox.CharHeight = 18;
            this.ExpressionTextBox.CharWidth = 10;
            this.ExpressionTextBox.CommentPrefix = "";
            this.ExpressionTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ExpressionTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ExpressionTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpressionTextBox.ForeColor = System.Drawing.Color.White;
            this.ExpressionTextBox.IsReplaceMode = false;
            this.ExpressionTextBox.LeftBracket = '(';
            this.ExpressionTextBox.Location = new System.Drawing.Point(2, 18);
            this.ExpressionTextBox.Multiline = false;
            this.ExpressionTextBox.Name = "ExpressionTextBox";
            this.ExpressionTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ExpressionTextBox.RightBracket = ')';
            this.ExpressionTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.ExpressionTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ExpressionTextBox.ServiceColors")));
            this.ExpressionTextBox.ShowLineNumbers = false;
            this.ExpressionTextBox.ShowScrollBars = false;
            this.ExpressionTextBox.Size = new System.Drawing.Size(397, 38);
            this.ExpressionTextBox.TabIndex = 0;
            this.ExpressionTextBox.TextAreaBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ExpressionTextBox.Zoom = 100;
            this.ExpressionTextBox.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBox1_TextChanged);
            // 
            // labelPanel2
            // 
            this.labelPanel2.ArrowColor = System.Drawing.Color.Gray;
            this.labelPanel2.ArrowMouseOverColor = System.Drawing.Color.DodgerBlue;
            this.labelPanel2.AutoSize = true;
            this.labelPanel2.CloseColor = System.Drawing.Color.Black;
            this.labelPanel2.CloseMouseOverColor = System.Drawing.Color.Red;
            this.labelPanel2.Collapsed = false;
            this.labelPanel2.Controls.Add(this.ExpressionTextBox);
            this.labelPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel2.DropShadow = false;
            this.labelPanel2.DropShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPanel2.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelPanel2.LabelFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPanel2.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPanel2.Location = new System.Drawing.Point(15, 15);
            this.labelPanel2.Name = "labelPanel2";
            this.labelPanel2.OverrideCollapseControl = false;
            this.labelPanel2.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.labelPanel2.PanelCollapsible = true;
            this.labelPanel2.ShowCloseButton = false;
            this.labelPanel2.Size = new System.Drawing.Size(401, 58);
            this.labelPanel2.TabIndex = 4;
            this.labelPanel2.Text = "Expression";
            // 
            // labelPanel1
            // 
            this.labelPanel1.ArrowColor = System.Drawing.Color.Gray;
            this.labelPanel1.ArrowMouseOverColor = System.Drawing.Color.DodgerBlue;
            this.labelPanel1.AutoSize = true;
            this.labelPanel1.CloseColor = System.Drawing.Color.Black;
            this.labelPanel1.CloseMouseOverColor = System.Drawing.Color.Red;
            this.labelPanel1.Collapsed = false;
            this.labelPanel1.Controls.Add(this.numericTextbox1);
            this.labelPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelPanel1.DropShadow = false;
            this.labelPanel1.DropShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPanel1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelPanel1.LabelFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPanel1.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPanel1.Location = new System.Drawing.Point(15, 306);
            this.labelPanel1.Name = "labelPanel1";
            this.labelPanel1.OverrideCollapseControl = false;
            this.labelPanel1.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.labelPanel1.PanelCollapsible = true;
            this.labelPanel1.ShowCloseButton = false;
            this.labelPanel1.Size = new System.Drawing.Size(401, 53);
            this.labelPanel1.TabIndex = 5;
            this.labelPanel1.Text = "Output";
            // 
            // numericTextbox1
            // 
            this.numericTextbox1.AllowClipboard = true;
            this.numericTextbox1.AllowDragValueChange = true;
            this.numericTextbox1.AllowMouseWheel = true;
            this.numericTextbox1.AllowNumberEntry = false;
            this.numericTextbox1.AllowTyping = true;
            this.numericTextbox1.AutoSizeToText = false;
            this.numericTextbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.numericTextbox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numericTextbox1.ButtonDownColor = System.Drawing.Color.Gray;
            this.numericTextbox1.ButtonHoverColor = System.Drawing.Color.LightGray;
            this.numericTextbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericTextbox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox1.ForeColor = System.Drawing.Color.White;
            this.numericTextbox1.FormatOutput = true;
            this.numericTextbox1.HasUnit = false;
            this.numericTextbox1.IsMetric = true;
            this.numericTextbox1.LabelFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox1.LabelForeColor = System.Drawing.Color.Gray;
            this.numericTextbox1.LabelText = "";
            this.numericTextbox1.Location = new System.Drawing.Point(0, 18);
            this.numericTextbox1.MaxmiumDecimalPlaces = ((uint)(6u));
            this.numericTextbox1.Name = "numericTextbox1";
            this.numericTextbox1.NumericalFormat = ODModules.NumericTextbox.NumberFormat.Scientific;
            this.numericTextbox1.NumericalLeftRadixDigitsMaximum = 16;
            this.numericTextbox1.NumericalRightRadixDigitsMaximum = 4;
            this.numericTextbox1.Prefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.numericTextbox1.SelectedBackColor = System.Drawing.Color.Empty;
            this.numericTextbox1.SelectedBorderColor = System.Drawing.Color.MidnightBlue;
            this.numericTextbox1.ShowLabel = true;
            this.numericTextbox1.Size = new System.Drawing.Size(401, 35);
            this.numericTextbox1.TabIndex = 1;
            this.numericTextbox1.Unit = "a";
            this.numericTextbox1.Value = "0";
            // 
            // labelPanel3
            // 
            this.labelPanel3.ArrowColor = System.Drawing.Color.Gray;
            this.labelPanel3.ArrowMouseOverColor = System.Drawing.Color.DodgerBlue;
            this.labelPanel3.CloseColor = System.Drawing.Color.Black;
            this.labelPanel3.CloseMouseOverColor = System.Drawing.Color.Red;
            this.labelPanel3.Collapsed = false;
            this.labelPanel3.Controls.Add(this.listControl1);
            this.labelPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPanel3.DropShadow = false;
            this.labelPanel3.DropShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPanel3.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.labelPanel3.LabelFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPanel3.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelPanel3.Location = new System.Drawing.Point(15, 73);
            this.labelPanel3.Name = "labelPanel3";
            this.labelPanel3.OverrideCollapseControl = false;
            this.labelPanel3.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.labelPanel3.PanelCollapsible = false;
            this.labelPanel3.ShowCloseButton = false;
            this.labelPanel3.Size = new System.Drawing.Size(401, 233);
            this.labelPanel3.TabIndex = 6;
            this.labelPanel3.Text = "Variables";
            // 
            // listControl1
            // 
            this.listControl1.AllowColumnSpanning = true;
            this.listControl1.AllowMouseWheel = true;
            this.listControl1.ColumnColor = System.Drawing.Color.LightGray;
            this.listControl1.ColumnForeColor = System.Drawing.Color.Black;
            this.listControl1.ColumnLineColor = System.Drawing.Color.DimGray;
            column1.ColumnAlignment = ODModules.ColumnTextAlignment.Left;
            column1.DisplayType = ODModules.ColumnDisplayType.Text;
            column1.ItemAlignment = ODModules.ItemTextAlignment.Left;
            column1.Text = "Name";
            column1.UseItemBackColor = false;
            column1.UseItemForeColor = false;
            column1.Visible = true;
            column1.Width = 100;
            column2.ColumnAlignment = ODModules.ColumnTextAlignment.Left;
            column2.DisplayType = ODModules.ColumnDisplayType.Text;
            column2.ItemAlignment = ODModules.ItemTextAlignment.Left;
            column2.Text = "Value";
            column2.UseItemBackColor = false;
            column2.UseItemForeColor = false;
            column2.Visible = true;
            column2.Width = 297;
            this.listControl1.Columns.Add(column1);
            this.listControl1.Columns.Add(column2);
            this.listControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listControl1.GridlineColor = System.Drawing.Color.LightGray;
            this.listControl1.HighlightStrength = 128;
            this.listControl1.HorScroll = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.listControl1.Location = new System.Drawing.Point(2, 18);
            this.listControl1.Name = "listControl1";
            this.listControl1.RowColor = System.Drawing.Color.LightGray;
            this.listControl1.ScrollBarMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listControl1.ScrollBarNorth = System.Drawing.Color.DarkTurquoise;
            this.listControl1.ScrollBarSouth = System.Drawing.Color.DeepSkyBlue;
            this.listControl1.ScrollItems = 3;
            this.listControl1.SelectedColor = System.Drawing.Color.SkyBlue;
            this.listControl1.SelectionColor = System.Drawing.Color.Gray;
            this.listControl1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listControl1.ShowGrid = false;
            this.listControl1.ShowRowColors = false;
            this.listControl1.Size = new System.Drawing.Size(397, 213);
            this.listControl1.SpanColumn = 1;
            this.listControl1.TabIndex = 0;
            this.listControl1.VerScroll = -1;
            // 
            // CalculatorExpression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.labelPanel3);
            this.Controls.Add(this.labelPanel1);
            this.Controls.Add(this.labelPanel2);
            this.Name = "CalculatorExpression";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(431, 374);
            ((System.ComponentModel.ISupportInitialize)(this.ExpressionTextBox)).EndInit();
            this.labelPanel2.ResumeLayout(false);
            this.labelPanel1.ResumeLayout(false);
            this.labelPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox ExpressionTextBox;
        private ODModules.LabelPanel labelPanel2;
        private ODModules.LabelPanel labelPanel1;
        private ODModules.NumericTextbox numericTextbox1;
        private ODModules.LabelPanel labelPanel3;
        private ODModules.ListControl listControl1;
    }
}
