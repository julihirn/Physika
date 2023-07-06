using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Handlers;
using ODModules;

namespace Physika.Pages {
    public partial class UnitConverter : UserControl {
        Physika.Controls.UnitTypeSelector UTS = new Controls.UnitTypeSelector();
        public UnitConverter() {
            InitializeComponent();
            
        }
        ~UnitConverter() {
            foreach (ToolStripItem Item in ContextMenu_Prefixes.Items) {
                Item.Click -= UPrefixButton_Click;
            }
            foreach (ToolStripItem Item in ContextMenu_UnitTypes.Items) {
                Item.Click -= UTypeButton_Click;
            }
        }
        private void UnitConverter_Load(object sender, EventArgs e) {
            Classes.UnitSystem.LoadUnitTypes(ContextMenu_UnitTypes, UTypeButton_Click, UnitTypeControl);
            Classes.UnitSystem.LoadUnitTypes(UTS.buttonGrid1, UTypeButton_Click, UnitTypeControl);
            UTS.buttonGrid1.ButtonClicked += ButtonGrid1_ButtonClicked;
            UTS.buttonGrid1.ButtonSize = DesignerSetup.ScaleSize(UTS.buttonGrid1.ButtonSize);
            UTS.buttonGrid1.ImageSize = DesignerSetup.ScaleSize(UTS.buttonGrid1.ImageSize);
            LoadUnits();
            Classes.UnitSystem.LoadPrefixes(ContextMenu_Prefixes, UPrefixButton_Click);
            prefixScale1.Height = DesignerSetup.ScaleInteger(prefixScale1.Height);
            prefixScale2.Height = prefixScale1.Height;
        }

        private void ButtonGrid1_ButtonClicked(object? Sender, GridButton Button, Point GridLocation) {
            object? Selected = Button.Tag;
            if (Selected == null) { return; }
            if (Selected.GetType() == typeof(UnitType)) {
                UnitTypeControl.LabelText = ((UnitType)Selected).Name;
                UnitTypeControl.Tag = Selected;

            }
            LoadUnits();
            prefixScale1.Invalidate();
            prefixScale2.Invalidate();
            numericTextbox1.Clear();
            numericTextbox1.Prefix = NumericTextbox.MetricPrefix.None;
            numericTextbox1.SecondaryPrefix = NumericTextbox.MetricPrefix.None;
            numericTextbox2.Clear();
            numericTextbox2.Prefix = NumericTextbox.MetricPrefix.None;
            numericTextbox2.SecondaryPrefix = NumericTextbox.MetricPrefix.None;
            Convert();
        }

        private void LoadUnits() {
            Classes.UnitSystem.CleanUnitHandles(ContextMenu_Units, UnitButton_Click);
            if (UnitTypeControl.Tag == null) { return; }
            if (UnitTypeControl.Tag.GetType() != typeof(Handlers.UnitType)) { return; }
            bool FirstAdded = false;
            foreach (Unit Unt in ((Handlers.UnitType)UnitTypeControl.Tag).Units) {
                ToolStripMenuItem UnitButton = new ToolStripMenuItem();
                UnitButton.Text = Unt.Name;
                UnitButton.ImageScaling = ToolStripItemImageScaling.None;
                UnitButton.Tag = Unt;
                UnitButton.Image = Classes.UnitConverter.DrawIcon(Color.White, Unt.GetSymbol(), DesignerSetup.MediumIconSize, UnitButton.Font);
                UnitButton.Click += UnitButton_Click;
                ContextMenu_Units.Items.Add(UnitButton);
                if (FirstAdded == false) {
                    FirstAdded = true;
                    Classes.UnitSystem.LinkSecondary(numericTextbox1, Unt);
                    numericTextbox1.Unit = Unt.Symbol;
                    numericTextbox1.Tag = Unt;


                    labelPanel1.Text = Unt.Name;
                    Classes.UnitSystem.LinkSecondary(numericTextbox2, Unt);
                    numericTextbox2.Unit = Unt.Symbol;
                    numericTextbox2.Tag = Unt;

                    bool IsMetric = false;
                    if (Unt.System == ConversionHandler.UnitSystem.SI) {
                        IsMetric = true;
                    }
                    else if (Unt.System == ConversionHandler.UnitSystem.SI_Accepted) {
                        IsMetric = true;
                    }
                    else if (Unt.System == ConversionHandler.UnitSystem.SI_Other) {
                        IsMetric = true;
                    }
                    numericTextbox1.IsMetric = IsMetric;
                    numericTextbox2.IsMetric = IsMetric;
                    labelPanel2.Text = Unt.Name;
                }
            }
        }
        private void UnitButton_Click(object? sender, EventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ToolStripMenuItem)) { return; }
            object? Selected = ((ToolStripMenuItem)sender).Tag;
            if (Selected == null) { return; }
            if (LinkedEditor == null) { return; }
            if (Selected.GetType() == typeof(Unit)) {
                LinkedEditor.Unit = ((Unit)Selected).Symbol;
                LinkedEditor.Tag = Selected;
                LinkedEditor.IsMetric = ((Unit)Selected).IsBase;
                bool IsMetric = false;
                if (((Unit)Selected).System == ConversionHandler.UnitSystem.SI) {
                    IsMetric = true;
                }
                else if (((Unit)Selected).System == ConversionHandler.UnitSystem.SI_Accepted) {
                    IsMetric = true;
                }
                else if (((Unit)Selected).System == ConversionHandler.UnitSystem.SI_Other) {
                    IsMetric = true;
                }
                LinkedEditor.IsMetric = IsMetric;
                if (LinkedEditor.Parent != null) {
                    if (LinkedEditor.Parent.GetType() == typeof(LabelPanel)) {
                        ((LabelPanel)LinkedEditor.Parent).Text = ((Unit)Selected).Name;
                    }
                }
                Classes.UnitSystem.LinkSecondary(LinkedEditor, ((Unit)Selected));
                Convert();
                if (LinkedEditor.Name == numericTextbox1.Name) {
                    AutoScale();
                }
            }
        }
        private void UPrefixButton_Click(object? sender, EventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ToolStripMenuItem)) { return; }
            object? Selected = ((ToolStripMenuItem)sender).Tag;
            if (Selected == null) { return; }
            if (LinkedEditor == null) { return; }
            if (Selected.GetType() == typeof(ODModules.NumericTextbox.MetricPrefix)) {
                if (EditingSecondary == true) {
                    LinkedEditor.SecondaryPrefix = (ODModules.NumericTextbox.MetricPrefix)Selected;
                }
                else {
                    LinkedEditor.Prefix = (ODModules.NumericTextbox.MetricPrefix)Selected;
                }

            }
            Convert();
        }
        private void UTypeButton_Click(object? sender, EventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ToolStripMenuItem)) { return; }
            object? Selected = ((ToolStripMenuItem)sender).Tag;
            if (Selected == null) { return; }
            if (Selected.GetType() == typeof(UnitType)) {
                UnitTypeControl.LabelText = ((UnitType)Selected).Name;
                UnitTypeControl.Tag = Selected;

            }
            LoadUnits();
            prefixScale1.Invalidate();
            prefixScale2.Invalidate();
            numericTextbox1.Clear();
            numericTextbox1.Prefix = NumericTextbox.MetricPrefix.None;
            numericTextbox1.SecondaryPrefix = NumericTextbox.MetricPrefix.None;
            numericTextbox2.Clear();
            numericTextbox2.Prefix = NumericTextbox.MetricPrefix.None;
            numericTextbox2.SecondaryPrefix = NumericTextbox.MetricPrefix.None;
            Convert();
        }
        private void labelButton1_Click(object sender, EventArgs e) {

        }

        private void labelButton1_Load(object sender, EventArgs e) {

        }

        private void labelButton1_ButtonClicked(object sender, Point MenuPoint) {
            // Point MenuLocation = PointToScreen(new Point(labelButton1.Location.X, labelButton1.Location.Y + labelButton1.Height));

            //ContextMenu_UnitTypes.Show(PointToScreen(MenuPoint));
            Point PointLocation = new Point(PointToScreen(Location).X, PointToScreen(MenuPoint).Y);
            int win = this.Bottom - MenuPoint.Y;
            UTS.Show(PointLocation, new Size(this.Width, win));
        }

        private void ContextMenu_Prefixes_Opening(object sender, CancelEventArgs e) {

        }
        ODModules.NumericTextbox? LinkedEditor = null;
        bool EditingSecondary = false;
        private void numericTextbox1_PrefixClicked(object sender, ODModules.PrefixClickedEventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ODModules.NumericTextbox)) { return; }
            LinkedEditor = (ODModules.NumericTextbox)sender;
            EditingSecondary = e.IsSecondary;
            ContextMenu_Prefixes.Show(e.ScreenLocation);
        }
        private void numericTextbox2_PrefixClicked(object sender, ODModules.PrefixClickedEventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ODModules.NumericTextbox)) { return; }
            LinkedEditor = (ODModules.NumericTextbox)sender;
            EditingSecondary = e.IsSecondary;
            ContextMenu_Prefixes.Show(e.ScreenLocation);
        }
        private void ContextMenu_Units_Opening(object sender, CancelEventArgs e) {

        }

        private void numericTextbox1_UnitClicked(object sender, UnitClickedEventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ODModules.NumericTextbox)) { return; }
            LinkedEditor = (ODModules.NumericTextbox)sender;
            ContextMenu_Units.Show(e.ScreenLocation);
        }
        private void numericTextbox2_UnitClicked(object sender, UnitClickedEventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ODModules.NumericTextbox)) { return; }
            LinkedEditor = (ODModules.NumericTextbox)sender;
            ContextMenu_Units.Show(e.ScreenLocation);
        }

        private void numericTextbox1_ValueChanged(object sender, ValueChangedEventArgs e) {
            prefixScale1.Invalidate();
            Convert();
            AutoScale();
        }
        private void Convert() {
            try {
                //numericTextbox1.Prefix
                Unit From = new Unit((Unit)numericTextbox1.Tag, (ConversionHandler.Prefix)numericTextbox1.Prefix, (ConversionHandler.Prefix)numericTextbox1.SecondaryPrefix);
                Unit To = new Unit((Unit)numericTextbox2.Tag, (ConversionHandler.Prefix)numericTextbox2.Prefix, (ConversionHandler.Prefix)numericTextbox2.SecondaryPrefix);
                if (UnitTypeControl.Tag != null) {
                    if (UnitTypeControl.Tag.GetType() == typeof(UnitType)) {
                        numericTextbox2.Value = ((UnitType)UnitTypeControl.Tag).Convert(new NumericalString(numericTextbox1.Value.ToString()), From, To).ToString();
                    }
                }

            }
            catch { }
        }
        private void AutoScale() {
            if (Classes.UnitSystem.IsMetric(((Unit)numericTextbox2.Tag).System) == false) { return; }
            if (Classes.UnitSystem.AutoScale == false) { return; }
            bool InvokeRepeat = false;
            if (numericTextbox2.ValueStartsWithZero() == true) {
                if (numericTextbox2.ZerosDigitsAfterPoint() > 0) {
                    if (numericTextbox2.Prefix != NumericTextbox.MetricPrefix.Quecto) {
                        numericTextbox2.Prefix -= 1;
                        InvokeRepeat = true;
                    }
                    else {
                        InvokeRepeat = false;
                    }
                    Convert();
                    InvokeRepeat = true;
                }
            }
            else {
                if (numericTextbox2.ValueDigitsBeforePoint() > 3) {
                    if (numericTextbox2.Prefix != NumericTextbox.MetricPrefix.Quetta) {
                        numericTextbox2.Prefix += 1;
                        InvokeRepeat = true;
                    }
                    else {
                        InvokeRepeat = false;
                    }
                    Convert();
                }
            }
            if (numericTextbox1.IsZeroed() == true) {
                numericTextbox2.Prefix = NumericTextbox.MetricPrefix.None;
                InvokeRepeat = false;
            }
            if (InvokeRepeat == true) {
                AutoScale();
            }
        }
        private void numericTextbox2_ValueChanged(object sender, ValueChangedEventArgs e) {
            prefixScale2.Invalidate();
        }
        private void numericTextbox1_UnitChanged(object sender) {
            prefixScale1.Invalidate();
        }
        private void numericTextbox2_UnitChanged(object sender) {
            prefixScale2.Invalidate();
        }

        private void numericTextbox1_Load(object sender, EventArgs e) {

        }
        private void numericTextbox1_PrefixChanged(object sender) {
            Convert();
            prefixScale1.Invalidate();
        }
        private void numericTextbox2_PrefixChanged(object sender) {
            Convert();
            prefixScale2.Invalidate();
        }

        private void ContextMenu_UnitTypes_Opening(object sender, CancelEventArgs e) {

        }

        private void numericTextbox2_Load(object sender, EventArgs e) {

        }
    }

}
