﻿namespace Physika.Pages {
    partial class Calculator {
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
            ODModules.KeypadButton keypadButton1 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton2 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton3 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton4 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton5 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton6 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton7 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton8 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton9 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton10 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton11 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton12 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton13 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton14 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton15 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton16 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton17 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton18 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton19 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton20 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton21 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton22 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton23 = new ODModules.KeypadButton();
            ODModules.KeypadButton keypadButton24 = new ODModules.KeypadButton();
            this.numericTextbox1 = new ODModules.NumericTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.keypad1 = new ODModules.Keypad();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericTextbox1
            // 
            this.numericTextbox1.AllowClipboard = true;
            this.numericTextbox1.AllowDragValueChange = true;
            this.numericTextbox1.AllowFractionals = true;
            this.numericTextbox1.AllowMouseWheel = true;
            this.numericTextbox1.AllowNegatives = true;
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
            this.numericTextbox1.IsSecondaryMetric = false;
            this.numericTextbox1.LabelFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numericTextbox1.LabelForeColor = System.Drawing.Color.Gray;
            this.numericTextbox1.LabelText = "";
            this.numericTextbox1.Location = new System.Drawing.Point(15, 15);
            this.numericTextbox1.MaxmiumDecimalPlaces = ((uint)(6u));
            this.numericTextbox1.Name = "numericTextbox1";
            this.numericTextbox1.NumericalFormat = ODModules.NumericTextbox.NumberFormat.Scientific;
            this.numericTextbox1.NumericalLeftRadixDigitsMaximum = 16;
            this.numericTextbox1.NumericalRightRadixDigitsMaximum = 4;
            this.numericTextbox1.Prefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.numericTextbox1.SecondaryPrefix = ODModules.NumericTextbox.MetricPrefix.None;
            this.numericTextbox1.SecondaryTag = null;
            this.numericTextbox1.SecondaryUnit = "";
            this.numericTextbox1.SecondaryUnitDisplay = ODModules.NumericTextbox.SecondaryUnitDisplayType.NoSecondaryUnit;
            this.numericTextbox1.SelectedBackColor = System.Drawing.Color.Empty;
            this.numericTextbox1.SelectedBorderColor = System.Drawing.Color.MidnightBlue;
            this.numericTextbox1.ShowLabel = true;
            this.numericTextbox1.Size = new System.Drawing.Size(290, 35);
            this.numericTextbox1.TabIndex = 2;
            this.numericTextbox1.Unit = "a";
            this.numericTextbox1.Value = "0";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 17);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.keypad1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(15, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 321);
            this.panel2.TabIndex = 4;
            // 
            // keypad1
            // 
            this.keypad1.BackColorCheckedNorth = System.Drawing.Color.Orange;
            this.keypad1.BackColorCheckedSouth = System.Drawing.Color.Orange;
            this.keypad1.BackColorDownNorth = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.keypad1.BackColorDownSouth = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.keypad1.BackColorHoverNorth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.keypad1.BackColorHoverSouth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.keypad1.BackColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.keypad1.BackColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.keypad1.BorderColorCheckedNorth = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.keypad1.BorderColorCheckedSouth = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.keypad1.BorderColorDownNorth = System.Drawing.Color.Black;
            this.keypad1.BorderColorDownSouth = System.Drawing.Color.Black;
            this.keypad1.BorderColorHoverNorth = System.Drawing.Color.MidnightBlue;
            this.keypad1.BorderColorHoverSouth = System.Drawing.Color.MidnightBlue;
            this.keypad1.BorderColorNorth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.keypad1.BorderColorShadow = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.keypad1.BorderColorSouth = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.keypad1.BorderRadius = 5;
            this.keypad1.ButtonPadding = new System.Windows.Forms.Padding(2);
            keypadButton1.BackColorNorth = System.Drawing.Color.White;
            keypadButton1.BackColorSouth = System.Drawing.Color.White;
            keypadButton1.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton1.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton1.Checked = false;
            keypadButton1.Position = new System.Drawing.Point(0, 0);
            keypadButton1.RadioButtonGroup = "";
            keypadButton1.SecondaryFont = null;
            keypadButton1.SecondaryText = "";
            keypadButton1.Text = "";
            keypadButton1.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton1.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton1.Type = ODModules.ButtonType.Button;
            keypadButton1.UseCustomColors = false;
            keypadButton2.BackColorNorth = System.Drawing.Color.White;
            keypadButton2.BackColorSouth = System.Drawing.Color.White;
            keypadButton2.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton2.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton2.Checked = false;
            keypadButton2.Position = new System.Drawing.Point(0, 0);
            keypadButton2.RadioButtonGroup = "";
            keypadButton2.SecondaryFont = null;
            keypadButton2.SecondaryText = "";
            keypadButton2.Text = "";
            keypadButton2.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton2.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton2.Type = ODModules.ButtonType.Button;
            keypadButton2.UseCustomColors = false;
            keypadButton3.BackColorNorth = System.Drawing.Color.White;
            keypadButton3.BackColorSouth = System.Drawing.Color.White;
            keypadButton3.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton3.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton3.Checked = false;
            keypadButton3.Position = new System.Drawing.Point(0, 0);
            keypadButton3.RadioButtonGroup = "";
            keypadButton3.SecondaryFont = null;
            keypadButton3.SecondaryText = "";
            keypadButton3.Text = "";
            keypadButton3.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton3.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton3.Type = ODModules.ButtonType.Button;
            keypadButton3.UseCustomColors = false;
            keypadButton4.BackColorNorth = System.Drawing.Color.White;
            keypadButton4.BackColorSouth = System.Drawing.Color.White;
            keypadButton4.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton4.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton4.Checked = false;
            keypadButton4.Position = new System.Drawing.Point(0, 0);
            keypadButton4.RadioButtonGroup = "";
            keypadButton4.SecondaryFont = null;
            keypadButton4.SecondaryText = "";
            keypadButton4.Text = "";
            keypadButton4.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton4.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton4.Type = ODModules.ButtonType.Button;
            keypadButton4.UseCustomColors = false;
            keypadButton5.BackColorNorth = System.Drawing.Color.White;
            keypadButton5.BackColorSouth = System.Drawing.Color.White;
            keypadButton5.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton5.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton5.Checked = false;
            keypadButton5.Position = new System.Drawing.Point(0, 0);
            keypadButton5.RadioButtonGroup = "";
            keypadButton5.SecondaryFont = null;
            keypadButton5.SecondaryText = "";
            keypadButton5.Text = "";
            keypadButton5.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton5.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton5.Type = ODModules.ButtonType.Button;
            keypadButton5.UseCustomColors = false;
            keypadButton6.BackColorNorth = System.Drawing.Color.White;
            keypadButton6.BackColorSouth = System.Drawing.Color.White;
            keypadButton6.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton6.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton6.Checked = false;
            keypadButton6.Position = new System.Drawing.Point(0, 0);
            keypadButton6.RadioButtonGroup = "";
            keypadButton6.SecondaryFont = null;
            keypadButton6.SecondaryText = "";
            keypadButton6.Text = "";
            keypadButton6.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton6.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton6.Type = ODModules.ButtonType.Button;
            keypadButton6.UseCustomColors = false;
            keypadButton7.BackColorNorth = System.Drawing.Color.White;
            keypadButton7.BackColorSouth = System.Drawing.Color.White;
            keypadButton7.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton7.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton7.Checked = false;
            keypadButton7.Position = new System.Drawing.Point(0, 0);
            keypadButton7.RadioButtonGroup = "";
            keypadButton7.SecondaryFont = null;
            keypadButton7.SecondaryText = "";
            keypadButton7.Text = "";
            keypadButton7.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton7.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton7.Type = ODModules.ButtonType.Button;
            keypadButton7.UseCustomColors = false;
            keypadButton8.BackColorNorth = System.Drawing.Color.White;
            keypadButton8.BackColorSouth = System.Drawing.Color.White;
            keypadButton8.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton8.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton8.Checked = false;
            keypadButton8.Position = new System.Drawing.Point(0, 0);
            keypadButton8.RadioButtonGroup = "";
            keypadButton8.SecondaryFont = null;
            keypadButton8.SecondaryText = "";
            keypadButton8.Text = "";
            keypadButton8.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton8.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton8.Type = ODModules.ButtonType.Button;
            keypadButton8.UseCustomColors = false;
            keypadButton9.BackColorNorth = System.Drawing.Color.White;
            keypadButton9.BackColorSouth = System.Drawing.Color.White;
            keypadButton9.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton9.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton9.Checked = false;
            keypadButton9.Position = new System.Drawing.Point(0, 0);
            keypadButton9.RadioButtonGroup = "";
            keypadButton9.SecondaryFont = null;
            keypadButton9.SecondaryText = "";
            keypadButton9.Text = "";
            keypadButton9.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton9.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton9.Type = ODModules.ButtonType.Button;
            keypadButton9.UseCustomColors = false;
            keypadButton10.BackColorNorth = System.Drawing.Color.White;
            keypadButton10.BackColorSouth = System.Drawing.Color.White;
            keypadButton10.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton10.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton10.Checked = false;
            keypadButton10.Position = new System.Drawing.Point(0, 0);
            keypadButton10.RadioButtonGroup = "";
            keypadButton10.SecondaryFont = null;
            keypadButton10.SecondaryText = "";
            keypadButton10.Text = "";
            keypadButton10.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton10.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton10.Type = ODModules.ButtonType.Button;
            keypadButton10.UseCustomColors = false;
            keypadButton11.BackColorNorth = System.Drawing.Color.White;
            keypadButton11.BackColorSouth = System.Drawing.Color.White;
            keypadButton11.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton11.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton11.Checked = false;
            keypadButton11.Position = new System.Drawing.Point(0, 0);
            keypadButton11.RadioButtonGroup = "";
            keypadButton11.SecondaryFont = null;
            keypadButton11.SecondaryText = "";
            keypadButton11.Text = "a";
            keypadButton11.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton11.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton11.Type = ODModules.ButtonType.Button;
            keypadButton11.UseCustomColors = false;
            keypadButton12.BackColorNorth = System.Drawing.Color.White;
            keypadButton12.BackColorSouth = System.Drawing.Color.White;
            keypadButton12.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton12.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton12.Checked = false;
            keypadButton12.Position = new System.Drawing.Point(0, 0);
            keypadButton12.RadioButtonGroup = "";
            keypadButton12.SecondaryFont = null;
            keypadButton12.SecondaryText = "";
            keypadButton12.Text = "";
            keypadButton12.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton12.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton12.Type = ODModules.ButtonType.Button;
            keypadButton12.UseCustomColors = false;
            keypadButton13.BackColorNorth = System.Drawing.Color.White;
            keypadButton13.BackColorSouth = System.Drawing.Color.White;
            keypadButton13.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton13.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton13.Checked = false;
            keypadButton13.Position = new System.Drawing.Point(0, 0);
            keypadButton13.RadioButtonGroup = "";
            keypadButton13.SecondaryFont = null;
            keypadButton13.SecondaryText = "";
            keypadButton13.Text = "";
            keypadButton13.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton13.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton13.Type = ODModules.ButtonType.Button;
            keypadButton13.UseCustomColors = false;
            keypadButton14.BackColorNorth = System.Drawing.Color.White;
            keypadButton14.BackColorSouth = System.Drawing.Color.White;
            keypadButton14.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton14.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton14.Checked = false;
            keypadButton14.Position = new System.Drawing.Point(0, 0);
            keypadButton14.RadioButtonGroup = "";
            keypadButton14.SecondaryFont = null;
            keypadButton14.SecondaryText = "";
            keypadButton14.Text = "";
            keypadButton14.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton14.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton14.Type = ODModules.ButtonType.Button;
            keypadButton14.UseCustomColors = false;
            keypadButton15.BackColorNorth = System.Drawing.Color.White;
            keypadButton15.BackColorSouth = System.Drawing.Color.White;
            keypadButton15.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton15.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton15.Checked = false;
            keypadButton15.Position = new System.Drawing.Point(0, 0);
            keypadButton15.RadioButtonGroup = "";
            keypadButton15.SecondaryFont = null;
            keypadButton15.SecondaryText = "";
            keypadButton15.Text = "";
            keypadButton15.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton15.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton15.Type = ODModules.ButtonType.Button;
            keypadButton15.UseCustomColors = false;
            keypadButton16.BackColorNorth = System.Drawing.Color.White;
            keypadButton16.BackColorSouth = System.Drawing.Color.White;
            keypadButton16.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton16.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton16.Checked = false;
            keypadButton16.Position = new System.Drawing.Point(0, 0);
            keypadButton16.RadioButtonGroup = "";
            keypadButton16.SecondaryFont = null;
            keypadButton16.SecondaryText = "";
            keypadButton16.Text = "";
            keypadButton16.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton16.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton16.Type = ODModules.ButtonType.Button;
            keypadButton16.UseCustomColors = false;
            keypadButton17.BackColorNorth = System.Drawing.Color.White;
            keypadButton17.BackColorSouth = System.Drawing.Color.White;
            keypadButton17.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton17.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton17.Checked = false;
            keypadButton17.Position = new System.Drawing.Point(0, 0);
            keypadButton17.RadioButtonGroup = "";
            keypadButton17.SecondaryFont = null;
            keypadButton17.SecondaryText = "";
            keypadButton17.Text = "";
            keypadButton17.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton17.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton17.Type = ODModules.ButtonType.Button;
            keypadButton17.UseCustomColors = false;
            keypadButton18.BackColorNorth = System.Drawing.Color.White;
            keypadButton18.BackColorSouth = System.Drawing.Color.White;
            keypadButton18.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton18.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton18.Checked = false;
            keypadButton18.Position = new System.Drawing.Point(0, 0);
            keypadButton18.RadioButtonGroup = "";
            keypadButton18.SecondaryFont = null;
            keypadButton18.SecondaryText = "";
            keypadButton18.Text = "";
            keypadButton18.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton18.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton18.Type = ODModules.ButtonType.Button;
            keypadButton18.UseCustomColors = false;
            keypadButton19.BackColorNorth = System.Drawing.Color.White;
            keypadButton19.BackColorSouth = System.Drawing.Color.White;
            keypadButton19.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton19.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton19.Checked = false;
            keypadButton19.Position = new System.Drawing.Point(0, 0);
            keypadButton19.RadioButtonGroup = "";
            keypadButton19.SecondaryFont = null;
            keypadButton19.SecondaryText = "";
            keypadButton19.Text = "";
            keypadButton19.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton19.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton19.Type = ODModules.ButtonType.Button;
            keypadButton19.UseCustomColors = false;
            keypadButton20.BackColorNorth = System.Drawing.Color.White;
            keypadButton20.BackColorSouth = System.Drawing.Color.White;
            keypadButton20.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton20.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton20.Checked = false;
            keypadButton20.Position = new System.Drawing.Point(0, 0);
            keypadButton20.RadioButtonGroup = "";
            keypadButton20.SecondaryFont = null;
            keypadButton20.SecondaryText = "";
            keypadButton20.Text = "";
            keypadButton20.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton20.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton20.Type = ODModules.ButtonType.Button;
            keypadButton20.UseCustomColors = false;
            keypadButton21.BackColorNorth = System.Drawing.Color.White;
            keypadButton21.BackColorSouth = System.Drawing.Color.White;
            keypadButton21.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton21.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton21.Checked = false;
            keypadButton21.Position = new System.Drawing.Point(0, 0);
            keypadButton21.RadioButtonGroup = "";
            keypadButton21.SecondaryFont = null;
            keypadButton21.SecondaryText = "";
            keypadButton21.Text = "";
            keypadButton21.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton21.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton21.Type = ODModules.ButtonType.Button;
            keypadButton21.UseCustomColors = false;
            keypadButton22.BackColorNorth = System.Drawing.Color.White;
            keypadButton22.BackColorSouth = System.Drawing.Color.White;
            keypadButton22.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton22.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton22.Checked = false;
            keypadButton22.Position = new System.Drawing.Point(0, 0);
            keypadButton22.RadioButtonGroup = "";
            keypadButton22.SecondaryFont = null;
            keypadButton22.SecondaryText = "";
            keypadButton22.Text = "";
            keypadButton22.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton22.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton22.Type = ODModules.ButtonType.Button;
            keypadButton22.UseCustomColors = false;
            keypadButton23.BackColorNorth = System.Drawing.Color.White;
            keypadButton23.BackColorSouth = System.Drawing.Color.White;
            keypadButton23.BorderColorNorth = System.Drawing.Color.Black;
            keypadButton23.BorderColorSouth = System.Drawing.Color.Black;
            keypadButton23.Checked = false;
            keypadButton23.Position = new System.Drawing.Point(0, 0);
            keypadButton23.RadioButtonGroup = "";
            keypadButton23.SecondaryFont = null;
            keypadButton23.SecondaryText = "";
            keypadButton23.Text = "";
            keypadButton23.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton23.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton23.Type = ODModules.ButtonType.Button;
            keypadButton23.UseCustomColors = false;
            keypadButton24.BackColorNorth = System.Drawing.Color.MidnightBlue;
            keypadButton24.BackColorSouth = System.Drawing.Color.MidnightBlue;
            keypadButton24.BorderColorNorth = System.Drawing.Color.RoyalBlue;
            keypadButton24.BorderColorSouth = System.Drawing.Color.RoyalBlue;
            keypadButton24.Checked = false;
            keypadButton24.Position = new System.Drawing.Point(0, 0);
            keypadButton24.RadioButtonGroup = "";
            keypadButton24.SecondaryFont = null;
            keypadButton24.SecondaryText = "";
            keypadButton24.Text = "";
            keypadButton24.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            keypadButton24.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            keypadButton24.Type = ODModules.ButtonType.Button;
            keypadButton24.UseCustomColors = true;
            this.keypad1.Buttons.Add(keypadButton1);
            this.keypad1.Buttons.Add(keypadButton2);
            this.keypad1.Buttons.Add(keypadButton3);
            this.keypad1.Buttons.Add(keypadButton4);
            this.keypad1.Buttons.Add(keypadButton5);
            this.keypad1.Buttons.Add(keypadButton6);
            this.keypad1.Buttons.Add(keypadButton7);
            this.keypad1.Buttons.Add(keypadButton8);
            this.keypad1.Buttons.Add(keypadButton9);
            this.keypad1.Buttons.Add(keypadButton10);
            this.keypad1.Buttons.Add(keypadButton11);
            this.keypad1.Buttons.Add(keypadButton12);
            this.keypad1.Buttons.Add(keypadButton13);
            this.keypad1.Buttons.Add(keypadButton14);
            this.keypad1.Buttons.Add(keypadButton15);
            this.keypad1.Buttons.Add(keypadButton16);
            this.keypad1.Buttons.Add(keypadButton17);
            this.keypad1.Buttons.Add(keypadButton18);
            this.keypad1.Buttons.Add(keypadButton19);
            this.keypad1.Buttons.Add(keypadButton20);
            this.keypad1.Buttons.Add(keypadButton21);
            this.keypad1.Buttons.Add(keypadButton22);
            this.keypad1.Buttons.Add(keypadButton23);
            this.keypad1.Buttons.Add(keypadButton24);
            this.keypad1.Columns = 4;
            this.keypad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keypad1.Location = new System.Drawing.Point(0, 0);
            this.keypad1.Name = "keypad1";
            this.keypad1.Rows = 6;
            this.keypad1.SecondaryFont = null;
            this.keypad1.Size = new System.Drawing.Size(290, 321);
            this.keypad1.Style = ODModules.ButtonStyle.Round;
            this.keypad1.TabIndex = 0;
            this.keypad1.TextHorizontalAlignment = ODModules.ButtonTextHorizontal.Center;
            this.keypad1.TextVerticalAlignment = ODModules.ButtonTextVertical.Middle;
            // 
            // Calculator
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numericTextbox1);
            this.DoubleBuffered = true;
            this.Name = "Calculator";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Size = new System.Drawing.Size(320, 403);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ODModules.NumericTextbox numericTextbox1;
        private Panel panel1;
        private Panel panel2;
        private ODModules.Keypad keypad1;
    }
}
