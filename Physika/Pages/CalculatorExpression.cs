using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Handlers;
namespace Physika.Pages {
    public partial class CalculatorExpression : UserControl {
        public CalculatorExpression() {
            InitializeComponent();
        }
        TextStyle KeyWord = new TextStyle(Brushes.DeepSkyBlue, null, FontStyle.Regular);
        TextStyle Constants = new TextStyle(Brushes.Teal, null, FontStyle.Regular);
        private void fastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e) {
            e.ChangedRange.ClearStyle(KeyWord);
            e.ChangedRange.ClearStyle(Constants);
            e.ChangedRange.SetStyle(KeyWord, @"(?:\b((?i:\+)|(?i:\-)|(?i:\*)|(?i:\/)|(?i:\^))\b)");
            e.ChangedRange.SetStyle(Constants, @"(?:\b((?i:pi)|(?i:π)|(?i:e))\b)");
            numericTextbox1.Value = MathHandler.EvaluateExpression(ExpressionTextBox.Text, null);
        }
    }
}
