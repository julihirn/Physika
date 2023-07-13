namespace Physika.Controls {
    partial class UnitTypeSelector {
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
            this.buttonGrid1 = new ODModules.ButtonGrid();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGrid1
            // 
            this.buttonGrid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.buttonGrid1.BackColorCheckedNorth = System.Drawing.Color.Orange;
            this.buttonGrid1.BackColorCheckedSouth = System.Drawing.Color.Orange;
            this.buttonGrid1.BackColorDownNorth = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonGrid1.BackColorDownSouth = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.buttonGrid1.BackColorHoverNorth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonGrid1.BackColorHoverSouth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonGrid1.BackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonGrid1.BackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonGrid1.BorderColorCheckedNorth = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonGrid1.BorderColorCheckedSouth = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.buttonGrid1.BorderColorDownNorth = System.Drawing.Color.Black;
            this.buttonGrid1.BorderColorDownSouth = System.Drawing.Color.Black;
            this.buttonGrid1.BorderColorHoverNorth = System.Drawing.Color.MidnightBlue;
            this.buttonGrid1.BorderColorHoverSouth = System.Drawing.Color.MidnightBlue;
            this.buttonGrid1.BorderColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonGrid1.BorderColorShadow = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonGrid1.BorderColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonGrid1.BorderRadius = 5;
            this.buttonGrid1.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.buttonGrid1.ButtonSize = new System.Drawing.Size(90, 90);
            this.buttonGrid1.CenterButtons = true;
            this.buttonGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGrid1.Filter = null;
            this.buttonGrid1.ImageSize = new System.Drawing.Size(32, 32);
            this.buttonGrid1.Location = new System.Drawing.Point(0, 16);
            this.buttonGrid1.Name = "buttonGrid1";
            this.buttonGrid1.ScrollBarMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonGrid1.ScrollBarNorth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGrid1.ScrollBarSouth = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGrid1.SecondaryFont = null;
            this.buttonGrid1.Size = new System.Drawing.Size(386, 253);
            this.buttonGrid1.Style = ODModules.ButtonStyle.Round;
            this.buttonGrid1.TabIndex = 6;
            this.buttonGrid1.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            this.buttonGrid1.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            this.buttonGrid1.VerScroll = 0;
            this.buttonGrid1.ButtonClicked += new ODModules.ButtonGrid.ButtonClickedEventHandler(this.buttonGrid1_ButtonClicked);
            this.buttonGrid1.Load += new System.EventHandler(this.buttonGrid1_Load);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search";
            this.textBox1.Size = new System.Drawing.Size(386, 16);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UnitTypeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.buttonGrid1);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UnitTypeSelector";
            this.Size = new System.Drawing.Size(386, 269);
            this.Load += new System.EventHandler(this.UnitTypeSelector_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UnitTypeSelector_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitTypeSelector_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public ODModules.ButtonGrid buttonGrid1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
