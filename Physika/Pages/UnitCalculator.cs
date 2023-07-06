using Handlers;
using ODModules;
using Physika.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physika.Pages {
    public partial class UnitCalculator : UserControl {
        ODModules.NumericTextbox? LinkedEditor = null;
        Physika.Controls.UnitTypeSelector UTS = new Controls.UnitTypeSelector();
        bool EditingSecondary = false;
        public UnitCalculator() {
            InitializeComponent();
        }
        ~UnitCalculator() {
            foreach (ToolStripItem Item in ContextMenu_Prefixes.Items) {
                Item.Click -= UPrefixButton_Click;
            }
            foreach (ToolStripItem Item in ContextMenu_UnitTypes.Items) {
                Item.Click -= UTypeButton_Click;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            NewUnit();
        }
        private void NewUnit() {
            if (Base != null) {
                //Physika.Controls.UnitOperation Uop = new Physika.Controls.UnitOperation(true);
                //Uop.Dock = DockStyle.Top;
                //if (UnitTypeControl.Tag != null) {
                //    if (UnitTypeControl.Tag.GetType() == typeof(UnitType)) {
                //        Uop.CurrentType = ((UnitType)UnitTypeControl.Tag);
                //    }
                //}
                //Uop.NumericEditor.Unit = Base.Symbol;
                //Uop.NumericEditor.Tag = Base;
                //Uop.NumericEditor.IsMetric = BaseIsMetric;
                //Classes.UnitSystem.LinkSecondary(Uop.NumericEditor, Base);
                //Uop.SetPanelText(Base.Name);
                //
                //Uop.NumericEditor.UnitClicked += NumericEditor_UnitClicked;
                //Uop.NumericEditor.PrefixClicked += NumericEditor_PrefixClicked;
                //Uop.ValueChanged += Uop_ValueChanged;
                //Uop.CloseButtonPressed += Uop_CloseButtonPressed;
                //
                //panel1.Controls.Add(Uop);
              
                ListItem LiP = new ListItem();
                LiP.Tag = Base;
                ListSubItem LiChk = new ListSubItem(true);
                ListSubItem LiVal = new ListSubItem("0 " + Base.GetSymbol());
                LiVal.Tag = 0;
                LiP.SubItems.Add(LiChk);
                LiP.SubItems.Add(LiVal);
                listControl1.Items.Add(LiP);
                listControl1.Invalidate();
            }
        }
        private void ButtonGrid1_ButtonClicked(object? Sender, GridButton Button, Point GridLocation) {
            object? Selected = Button.Tag;
            if (Selected == null) { return; }
            if (Selected.GetType() == typeof(UnitType)) {
                UnitTypeControl.LabelText = ((UnitType)Selected).Name;
                UnitTypeControl.Tag = Selected;
                Classes.UnitSystem.SetUnitTypes(panel1, (UnitType)Selected);
            }
            LoadUnits();


            prefixScale2.Invalidate();
            Classes.UnitSystem.ClearEditors(panel1, ((UnitType)Selected));
            numericTextbox2.Clear();
            numericTextbox2.Prefix = NumericTextbox.MetricPrefix.None;
            numericTextbox2.SecondaryPrefix = NumericTextbox.MetricPrefix.None;
            Calculate();
        }
        private void UnitCalculator_Load(object sender, EventArgs e) {
            Classes.UnitSystem.LoadUnitTypes(ContextMenu_UnitTypes, UTypeButton_Click, UnitTypeControl);
            Classes.UnitSystem.LoadUnitTypes(UTS.buttonGrid1, UTypeButton_Click, UnitTypeControl);
            UTS.buttonGrid1.ButtonClicked += ButtonGrid1_ButtonClicked;
            UTS.buttonGrid1.ButtonClicked += ButtonGrid1_ButtonClicked;
            UTS.buttonGrid1.ButtonSize = DesignerSetup.ScaleSize(UTS.buttonGrid1.ButtonSize);
            UTS.buttonGrid1.ImageSize = DesignerSetup.ScaleSize(UTS.buttonGrid1.ImageSize);
            LoadUnits();
            Classes.UnitSystem.LoadPrefixes(ContextMenu_Prefixes, UPrefixButton_Click);
            NewUnit();
        }
        #region Dimension System Loading
        Unit? Base = null;
        bool BaseIsMetric = false;
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
                    Base = Unt;
                    BaseIsMetric = IsMetric;
                    Classes.UnitSystem.SetUnit(panel1, Unt, IsMetric);
                    numericTextbox2.IsMetric = IsMetric;
                    labelPanel2.Text = Unt.Name;
                }
            }
        }
        #endregion
        #region Numerical Editor Events
        private void Uop_CloseButtonPressed(object sender) {
            if (sender == null) { return; }
            if (sender.GetType() == typeof(Physika.Controls.UnitOperation)) {
                Physika.Controls.UnitOperation Uop = (Physika.Controls.UnitOperation)sender;

                Uop.NumericEditor.UnitClicked -= NumericEditor_UnitClicked;
                Uop.NumericEditor.PrefixClicked -= NumericEditor_PrefixClicked;
                Uop.ValueChanged -= Uop_ValueChanged;
                Uop.CloseButtonPressed -= Uop_CloseButtonPressed;

                panel1.Controls.Remove(Uop);
                Calculate();
            }
        }
        private void Uop_ValueChanged(object sender, string Value, Controls.UnitOperator MathOperator) {
            Calculate();
        }
        private void NumericEditor_PrefixClicked(object sender, PrefixClickedEventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ODModules.NumericTextbox)) { return; }
            LinkedEditor = (ODModules.NumericTextbox)sender;
            EditingSecondary = e.IsSecondary;
            ContextMenu_Prefixes.Show(e.ScreenLocation);
        }
        private void NumericEditor_UnitClicked(object sender, UnitClickedEventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ODModules.NumericTextbox)) { return; }
            LinkedEditor = (ODModules.NumericTextbox)sender;
            ContextMenu_Units.Show(e.ScreenLocation);
        }
        #endregion
        #region Context Menu Handling
        //private void CleanUnitHandles() {
        //    foreach (ToolStripItem Item in ContextMenu_Units.Items) {
        //        Item.Click -= UnitButton_Click;
        //    }
        //    ContextMenu_Units.Items.Clear();
        //}

        private void UTypeButton_Click(object? sender, EventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ToolStripMenuItem)) { return; }
            object? Selected = ((ToolStripMenuItem)sender).Tag;
            if (Selected == null) { return; }
            if (Selected.GetType() == typeof(UnitType)) {
                UnitTypeControl.LabelText = ((UnitType)Selected).Name;
                UnitTypeControl.Tag = Selected;
                Classes.UnitSystem.SetUnitTypes(panel1, (UnitType)Selected);
            }
            LoadUnits();


            prefixScale2.Invalidate();
            Classes.UnitSystem.ClearEditors(panel1, ((UnitType)Selected));
            numericTextbox2.Clear();
            numericTextbox2.Prefix = NumericTextbox.MetricPrefix.None;
            numericTextbox2.SecondaryPrefix = NumericTextbox.MetricPrefix.None;
            Calculate();
        }
        //A
        private void UnitTypeControl_ButtonClicked(object sender, Point MenuPoint) {
            //ContextMenu_UnitTypes.Show(PointToScreen(MenuPoint));
            Point PointLocation = new Point(PointToScreen(Location).X, PointToScreen(MenuPoint).Y);
            int win = this.Bottom - MenuPoint.Y;
            UTS.Show(PointLocation, new Size(this.Width, win));
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
            Calculate();
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
                    else if (LinkedEditor.Parent.GetType() == typeof(Panel)) {
                        if (LinkedEditor.Parent.Parent != null) {
                            if (LinkedEditor.Parent.Parent.GetType() == typeof(LabelPanel)) {
                                ((LabelPanel)LinkedEditor.Parent.Parent).Text = ((Unit)Selected).Name;
                            }
                        }
                    }
                }
                Classes.UnitSystem.LinkSecondary(LinkedEditor, ((Unit)Selected));
                Calculate();
            }
        }
        #endregion
        #region Result Handling
        private void numericTextbox2_UnitClicked(object sender, UnitClickedEventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ODModules.NumericTextbox)) { return; }
            LinkedEditor = (ODModules.NumericTextbox)sender;
            ContextMenu_Units.Show(e.ScreenLocation);
        }
        private void numericTextbox2_PrefixClicked(object sender, PrefixClickedEventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ODModules.NumericTextbox)) { return; }
            LinkedEditor = (ODModules.NumericTextbox)sender;
            EditingSecondary = e.IsSecondary;
            ContextMenu_Prefixes.Show(e.ScreenLocation);
        }
        private void numericTextbox2_UnitChanged(object sender) {
            prefixScale2.Invalidate();
        }
        private void numericTextbox2_PrefixChanged(object sender) {
            Calculate();
            prefixScale2.Invalidate();
        }
        #endregion
        private void Calculate() {
            try {
                string Equation = "";
                List<MathVariable> Vars = new List<MathVariable>();
                int i = 0;
                foreach (ListItem Li in listControl1.Items) {
                    if (Li.SubItems.Count == 2) {
                        string VarName = Li.Text;
                        if (Li.Text.Trim(' ') == "") {
                            VarName = "nunit" + i.ToString();
                        }
                        Equation += VarName;
                        if (i < listControl1.Items.Count - 1) {
                            //if (Uop.Operator == Physika.Controls.UnitOperator.Addition) {
                            //    Equation += "+";
                            //}
                            //else if (Uop.Operator == Physika.Controls.UnitOperator.Multiplication) {
                            //    Equation += "*";
                            //}
                            //else if (Uop.Operator == Physika.Controls.UnitOperator.Division) {
                            //    Equation += "/";
                            //}
                            Equation += "+";
                        }
                        Vars.Add(new MathVariable(VarName, Li.SubItems[1].Text));
                        i++;
                    }
                }
                //foreach (Physika.Controls.UnitOperation Uop in panel1.Controls) {
                //    string VarName = "nunit" + i.ToString();
                //    Vars.Add(new MathVariable(VarName, Uop.NumericValue));
                //    Equation += VarName;
                //    if (i < panel1.Controls.Count - 1) {
                //        if (Uop.Operator == Physika.Controls.UnitOperator.Addition) {
                //            Equation += "+";
                //        }
                //        else if (Uop.Operator == Physika.Controls.UnitOperator.Multiplication) {
                //            Equation += "*";
                //        }
                //        else if (Uop.Operator == Physika.Controls.UnitOperator.Division) {
                //            Equation += "/";
                //        }
                //    }
                //    i++;
                //}
                NumericalString Output = MathHandler.EvaluateExpression(Equation, Vars);
                Unit To = new Unit((Unit)numericTextbox2.Tag, (ConversionHandler.Prefix)numericTextbox2.Prefix, (ConversionHandler.Prefix)numericTextbox2.SecondaryPrefix);
                if (UnitTypeControl.Tag != null) {
                    if (UnitTypeControl.Tag.GetType() == typeof(UnitType)) {
                        numericTextbox2.Value = ((UnitType)UnitTypeControl.Tag).ConvertFromBase(new NumericalString(Output.ToString()), To).ToString();
                    }
                }
            }
            catch { }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e) {

        }
        private void UnitTypeControl_Load(object sender, EventArgs e) {

        }
        private void button2_Load(object sender, EventArgs e) {

        }

        private void button2_ButtonClicked(object sender) {
            NewUnit();
        }

        private void ContextMenu_Prefixes_Opening(object sender, CancelEventArgs e) {

        }

        private void listControl1_DropDownClicked(object sender, DropDownClickedEventArgs e) {
            if (listControl1.Columns.Count == 3) {
                if (e.Column == 2){
                    UnitOperation Uop = new UnitOperation(true);
                    Uop.Location = e.ScreenLocation;
                    Uop.Show();
                }
            }
        }
    }
}
