using Handlers;
using ODModules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physika.Controls {
    public partial class UnitOperation : UserControl {
        public delegate void ValueChangedHandler (object sender, string Value, UnitOperator MathOperator);
        [Category("Value")]
        public event ValueChangedHandler? ValueChanged;
        public delegate void CloseButtonPressedHandler(object sender);
        [Category("Actions")]
        public event CloseButtonPressedHandler? CloseButtonPressed;
        string variableName = "";
        public string VariableName {
            get { return variableName; }
        }
        public UnitOperation(bool HideOperator) {
            InitializeComponent();
            button1.Visible = !HideOperator;
        }
        public UnitOperation(bool HideOperator, string VarName) {
            InitializeComponent();
            button1.Visible = !HideOperator;
            variableName = VarName;
        }
        ~UnitOperation() {
            
        }
        public UnitType ?CurrentType = null;
        private string numValue = "0";
        public string NumericValue {
            get { return numValue; }
        }
        UnitOperator uoperator = UnitOperator.Addition;
        public UnitOperator Operator {
            get { return uoperator; }
        }
        private void numericTextbox1_ValueChanged(object sender, ODModules.ValueChangedEventArgs e) {
            PrefixEditor.Invalidate();
            Convert();
        }
        private void numericTextbox1_UnitChanged(object sender) {
            PrefixEditor.Invalidate();
            Convert();
        }
        private void Convert() {
            CollapseText();
            try {
                Unit From = new Unit((Unit)NumericEditor.Tag, (ConversionHandler.Prefix)NumericEditor.Prefix, (ConversionHandler.Prefix)NumericEditor.SecondaryPrefix);
                if (CurrentType != null) {
                    numValue = CurrentType.ConvertToBase(new NumericalString(NumericEditor.Value.ToString()), From).ToString();
                }
            }
            catch {
                numValue = "0";
            }
            ValueChanged?.Invoke(this, numValue, uoperator);
        }
        private void numericTextbox1_PrefixChanged(object sender) {
           
            Convert();
            PrefixEditor.Invalidate();
        }
        private void labelPanel1_CloseButtonClicked(object sender, Point HitPoint) {
            CloseButtonPressed?.Invoke(this);
        }

        private void labelPanel1_Paint(object sender, PaintEventArgs e) {

        }
        int OldHeight = 0;
        string NonCollapsedText = "";
        public void SetPanelText(string Input) {
            NonCollapsedText = Input;
            CollapseText(); 
        }
        private void CollapseText() {
            if (UnitPanel.Collapsed == true) {
                UnitPanel.Text = NumericEditor.Value.ToString() ?? "";
            }
            else {
                UnitPanel.Text = NonCollapsedText;
            }
        }
        private void UnitPanel_CollapseButtonClicked(object sender, Point HitPoint) {
            if (UnitPanel.Collapsed == true) {
                OldHeight = this.Height;
                int NewHeight = UnitPanel.Padding.Top + this.Padding.Top + this.Padding.Bottom;
                Height = NewHeight;
            }
            else {
                Height = OldHeight;
            }
            CollapseText();
        }
    }
    public enum UnitOperator {
        //None = 0x00,
        Addition = 0x01,
        Subtraction = 0x02,
        Multiplication = 0x03,
        Division = 0x04
    }
}
