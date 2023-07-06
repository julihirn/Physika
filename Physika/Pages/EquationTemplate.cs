using Handlers;
using ODModules;
using Physika.Classes;
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
    public partial class EquationTemplate : UserControl {
        ODModules.NumericTextbox? LinkedEditor = null;
        bool EditingSecondary = false;
        public EquationTemplate() {
            InitializeComponent();
        }
        private void EquationTemplate_Load(object sender, EventArgs e) {
            btngrid_SolveWith.ButtonSize = DesignerSetup.ScaleSize(btngrid_SolveWith.ButtonSize);
            btngrid_SolveFor.ButtonSize = DesignerSetup.ScaleSize(btngrid_SolveFor.ButtonSize);
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Classes.UnitSystem.LoadPrefixes(ContextMenu_Prefixes, UPrefixButton_Click);
            LoadEquations();

        }

        #region Equation Loading System
        private void LoadEquations() {
            bool IsFirstAdded = false;
            foreach (TemplateEquationGroup EQGroup in EquationManager.Equations) {
                ToolStripMenuItem EQGroupButton = new ToolStripMenuItem();
                EQGroupButton.Text = EQGroup.Name;
                EQGroupButton.Tag = EQGroup;
                EQGroupButton.Click += EqTypeButton_Click;
                ContextMenu_Equations.Items.Add(EQGroupButton);
                if (IsFirstAdded == false) {
                    EquationTypeControl.LabelText = EQGroup.Name;
                    EquationTypeControl.Tag = EQGroup;
                    IsFirstAdded = true;
                }
            }
            LoadSolvers();
        }
        TemplateEquation? CurrentTemplate = null;
        private void LoadSolvers() {
            bool IsFirst = true; ;
            Classes.UnitSystem.CleanUnitHandles(ContextMenu_Units, UnitButton_Click);
            if (EquationTypeControl.Tag == null) { return; }
            if (EquationTypeControl.Tag.GetType() != typeof(Classes.TemplateEquationGroup)) { return; }
            TemplateEquationGroup EqTempGroup = (Classes.TemplateEquationGroup)EquationTypeControl.Tag;
            //ResetUnitTypeSelectors();
            btngrid_SolveFor.Buttons.Clear();
            foreach (TemplateEquation Eq in EqTempGroup.Forumlas) {
                if (Eq.Result != null) {
                    if (IsFirst == true) {
                        CurrentTemplate = Eq;

                    }
                    string DisplayText = "";
                    if (Eq.Result.AttachedUnit != null) {
                        DisplayText = Eq.Result.AttachedUnit.Name;
                    }
                    else {
                        DisplayText = Eq.Result.VariableName;
                    }
                    Classes.UnitSystem.InsertSelectorButton(DisplayText, ButtonType.RadioButton, IsFirst, Eq, btngrid_SolveFor, ResBtnSel_MouseClick);
                    IsFirst = false;
                }
            }
            btngrid_SolveFor.Invalidate();
            if (CurrentTemplate != null) {
                LoadEquationInputs(btngrid_SolveWith);
            }
        }

        private void ResBtnSel_MouseClick(object? sender, MouseEventArgs e) {
            CurrentEquation = null;
            if (sender == null) { return; }
            if (sender.GetType() == typeof(ODModules.Button)) {
                if (((ODModules.Button)sender).Tag != null) {
                    if (((ODModules.Button)sender).Tag.GetType() == typeof(TemplateEquation)) {
                        CurrentTemplate = (TemplateEquation)((ODModules.Button)sender).Tag;
                        SetOutput();
                        LoadEquationInputs(btngrid_SolveWith);
                    }
                }
            }
        }
        private void LoadEquationInputs(object Collection) {
            if (CurrentTemplate == null) { return; }

            List<TemplateVariable> TemplateVariables = new List<TemplateVariable>();
            foreach (TemplateVariablePairing TVP in CurrentTemplate.Equations) {
                foreach (TemplateVariable TV in TVP.Inputs) {
                    if (!TemplateVariables.Exists(x => (x.VariableName == TV.VariableName))) {
                        TemplateVariables.Add(EquationManager.CopyVariable(TV));

                    }
                }
            }
            btngrid_SolveWith.Buttons.Clear();
            foreach (TemplateVariable TV in TemplateVariables) {
                string DisplayText = "";
                if (TV.AttachedUnit != null) {
                    DisplayText = TV.AttachedUnit.Name;
                }
                else {
                    DisplayText = TV.VariableName;
                }
                if (UnitSystem.CollectionHasVariable(btngrid_SolveWith, TV) == false) {
                    //FlowPnl_SolveWith
                    Classes.UnitSystem.InsertSelectorButton(DisplayText, ButtonType.Checkbox, false, TV, btngrid_SolveWith, VarBtnSel_MouseClick);
                }
            }
            //int CheckedCount = 0;
            //Point VarsRange = GetMaximumAllowVariables();
            //for (int i = FlowPnl_SolveWith.Controls.Count - 1; i >= 0; i--) {
            //    if (FlowPnl_SolveWith.Controls[i].GetType() == typeof(ODModules.Button)) {
            //        bool MarkForRemoval = true;
            //        ODModules.Button Btn = ((ODModules.Button)FlowPnl_SolveWith.Controls[i]);
            //        if (Btn.Tag != null) {
            //            if (Btn.Tag.GetType() == typeof(TemplateVariable)) {
            //                TemplateVariable CurrentTempVar = (TemplateVariable)Btn.Tag;
            //                foreach (TemplateVariable TV in TemplateVariables) {
            //                    if (TV.VariableName == CurrentTempVar.VariableName) {
            //                        MarkForRemoval = false;
            //                        break;
            //                    }
            //                }
            //            }
            //        }
            //        if (MarkForRemoval == true) {
            //            Btn.MouseClick -= VarBtnSel_MouseClick;
            //            FlowPnl_SolveWith.Controls.RemoveAt(i);
            //        }
            //        else {
            //            Btn.GroupMaximumChecked = VarsRange.Y;
            //            if (Btn.Checked == true) { CheckedCount++; }
            //        }
            //    }
            //}
            //if (CheckedCount < VarsRange.X) {
            //    for (int i = FlowPnl_SolveWith.Controls.Count - 1; i >= 0; i--) {
            //        if (FlowPnl_SolveWith.Controls[i].GetType() == typeof(ODModules.Button)) {
            //            ODModules.Button Btn = ((ODModules.Button)FlowPnl_SolveWith.Controls[i]);
            //            if (Btn.Checked == false) {
            //                Btn.Checked = true;
            //                CheckedCount++;
            //                if (CheckedCount == VarsRange.X) {
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //}
            btngrid_SolveWith.Invalidate();
            LoadEquation();
        }
        UnitType? OutputType = null;
        private void SetOutput() {
            if (CurrentTemplate == null) { return; }
            prefixScale2.Invalidate();
            numericTextbox2.Clear();
            TemplateVariable? Result = CurrentTemplate.Result;
            if (Result != null) {
                OutputType = Result.AttachedUnit;
                bool IsScalar = false;
                if (OutputType == null) { IsScalar = true; }
                else {
                    IsScalar = Result.Type == TemplateVariableType.Scalar ? true : false;
                }
                if (IsScalar == true) {
                    numericTextbox2.Unit = "";
                    numericTextbox2.Tag = null;
                    numericTextbox2.IsMetric = false;
                    numericTextbox2.Prefix = NumericTextbox.MetricPrefix.None;
                    numericTextbox2.SecondaryUnitDisplay = NumericTextbox.SecondaryUnitDisplayType.NoSecondaryUnit;
                    numericTextbox2.SecondaryPrefix = NumericTextbox.MetricPrefix.None;
                    numericTextbox2.IsSecondaryMetric = false;
                    labelPanel2.Text = Result.VariableName;
                }
                else {
                    if (OutputType == null) { return; }
                    Classes.UnitSystem.LinkSecondary(numericTextbox2, OutputType.GetBaseUnit);
                    numericTextbox2.Unit = OutputType.GetBaseUnit.Symbol;
                    numericTextbox2.Tag = OutputType.GetBaseUnit;
                    numericTextbox2.Prefix = NumericTextbox.MetricPrefix.None;
                    bool IsMetric = false;
                    if (OutputType.GetBaseUnit.System == ConversionHandler.UnitSystem.SI) {
                        IsMetric = true;
                    }
                    else if (OutputType.GetBaseUnit.System == ConversionHandler.UnitSystem.SI_Accepted) {
                        IsMetric = true;
                    }
                    else if (OutputType.GetBaseUnit.System == ConversionHandler.UnitSystem.SI_Other) {
                        IsMetric = true;
                    }
                    numericTextbox2.IsMetric = IsMetric;
                    labelPanel2.Text = OutputType.GetBaseUnit.Name;
                }
            }
        }
        private void VarBtnSel_MouseClick(object? sender, MouseEventArgs e) {
            LoadEquation();
        }
        TemplateVariablePairing? CurrentEquation = null;
        private void LoadEquation() {
            panel1.SuspendLayout();
            foreach (Control Ctrl in panel1.Controls) {
                Uop_CloseButtonPressed(Ctrl);
            }

            if (CurrentTemplate != null) {
                bool BreakAll = false;
                bool IsVaild = false;
                int CheckCount = GetCheckCount();
                foreach (TemplateVariablePairing TVP in CurrentTemplate.Equations) {
                    int VariableCount = 0;
                    if (CheckCount == TVP.Inputs.Count) {
                        for (int i = 0; i < TVP.Inputs.Count; i++) {
                            bool FoundVar = IsVariableActive(TVP.Inputs[i]);
                            if (FoundVar == true) { VariableCount++; }
                            if (i == TVP.Inputs.Count - 1) {
                                if (TVP.Inputs.Count == VariableCount) {
                                    CurrentEquation = TVP;
                                    BreakAll = true;
                                    IsVaild = true;
                                    break;
                                }
                            }
                        }
                    }
                    if (BreakAll == true) { break; }
                }
                if (BreakAll == false) { if (IsVaild == false) { CurrentEquation = null; } }
            }
            else { CurrentEquation = null; }
            panel1.Controls.Clear();
            if (CurrentEquation != null) {
                foreach (TemplateVariable TV in CurrentEquation.Inputs) {
                    NewUnit(TV.VariableName, TV.Type, TV.AttachedUnit);
                }
            }
            panel1.ResumeLayout();
        }
        private bool IsVariableActive(TemplateVariable VariableOption) {
            foreach (GridButton Btn in btngrid_SolveWith.Buttons) {
                if (Btn.Tag != null) {
                    if (Btn.Tag.GetType() == typeof(TemplateVariable)) {
                        TemplateVariable TV = (TemplateVariable)Btn.Tag;
                        if ((TV.VariableName == VariableOption.VariableName) && (TV.Type == VariableOption.Type)) {
                            return Btn.Checked;
                        }
                    }
                }
            }
            return false;
        }
        private int GetCheckCount() {
            int i = 0;
            foreach (GridButton Btn in btngrid_SolveWith.Buttons) {
                if (Btn.Checked) { i++; }
            }
            return i;
        }
        private void NewUnit(string VariableName, TemplateVariableType VarType, UnitType? UntType) {
            bool IsScalar = false;
            if (UntType == null) {
                IsScalar = true;
            }
            else {
                IsScalar = VarType == TemplateVariableType.Scalar ? true : false;
            }
            Physika.Controls.UnitOperation Uop = new Physika.Controls.UnitOperation(true, VariableName);
            Uop.Dock = DockStyle.Top;
            if (IsScalar == true) {
                Uop.NumericEditor.Unit = "";
                Uop.NumericEditor.Tag = null;
                Uop.NumericEditor.SecondaryTag = null;
                Uop.NumericEditor.IsMetric = false;
                Uop.NumericEditor.Prefix = NumericTextbox.MetricPrefix.None;
                Uop.NumericEditor.SecondaryUnitDisplay = NumericTextbox.SecondaryUnitDisplayType.NoSecondaryUnit;
                Uop.NumericEditor.SecondaryPrefix = NumericTextbox.MetricPrefix.None;
                Uop.NumericEditor.IsSecondaryMetric = false;
                Uop.SetPanelText(VariableName);
            }
            else {
                Uop.CurrentType = UntType;
                Unit Base = UntType.GetBaseUnit;
                Uop.NumericEditor.Unit = Base.Symbol;
                Uop.NumericEditor.Tag = Base;
                Uop.NumericEditor.SecondaryTag = UntType;
                Uop.NumericEditor.Prefix = NumericTextbox.MetricPrefix.None;
                bool BaseIsMetric = true;
                if ((Base.System == ConversionHandler.UnitSystem.Imperial) || (Base.System == ConversionHandler.UnitSystem.Other)) {
                    BaseIsMetric = false;
                }
                Uop.NumericEditor.IsMetric = BaseIsMetric;
                Classes.UnitSystem.LinkSecondary(Uop.NumericEditor, Base);
                Uop.SetPanelText(Base.Name);
            }
            Uop.NumericEditor.UnitClicked += NumericEditor_UnitClicked;
            Uop.NumericEditor.PrefixClicked += NumericEditor_PrefixClicked;
            Uop.ValueChanged += Uop_ValueChanged;
            //Uop.CloseButtonPressed += Uop_CloseButtonPressed;

            panel1.Controls.Add(Uop);
            Uop.BringToFront();
        }
        private Point GetMaximumAllowVariables() {
            if (CurrentTemplate == null) { return new Point(0, 0); }
            int OutputMax = 0;
            int OutputMin = 0;
            bool isFirst = true;
            foreach (TemplateVariablePairing TVP in CurrentTemplate.Equations) {
                if (isFirst == true) {
                    OutputMin = TVP.Inputs.Count;
                    isFirst = false;
                }
                if (TVP.Inputs.Count >= OutputMax) {
                    OutputMax = TVP.Inputs.Count;
                }
                if (TVP.Inputs.Count <= OutputMax) {
                    OutputMin = TVP.Inputs.Count;
                }
            }
            return new Point(OutputMin, OutputMax);
        }
        private void ResetUnitTypeSelectors() {
            //To do remove handles

            btngrid_SolveFor.Controls.Clear();
            btngrid_SolveWith.Controls.Clear();
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

                panel1.Controls.Remove(Uop);
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
            if (LinkedEditor.SecondaryTag != null) {
                if (LinkedEditor.SecondaryTag.GetType() == typeof(UnitType)) {
                    LoadUnits((UnitType)LinkedEditor.SecondaryTag);
                }
            }

            ContextMenu_Units.Show(e.ScreenLocation);
        }

        #endregion
        #region Context Menu Handling
        private void EqTypeButton_Click(object? sender, EventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ToolStripMenuItem)) { return; }
            object? Selected = ((ToolStripMenuItem)sender).Tag;
            if (Selected == null) { return; }
            if (Selected.GetType() == typeof(Classes.TemplateEquationGroup)) {
                EquationTypeControl.LabelText = ((TemplateEquationGroup)Selected).Name;
                EquationTypeControl.Tag = Selected;
                //SetUnitTypes((UnitType)Selected);
            }
            LoadSolvers();


            prefixScale2.Invalidate();
            //ClearEditors(((UnitType)Selected));
            numericTextbox2.Clear();
            numericTextbox2.Prefix = NumericTextbox.MetricPrefix.None;
            numericTextbox2.SecondaryPrefix = NumericTextbox.MetricPrefix.None;
            Calculate();
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
        private void numericTextbox2_PrefixChanged(object sender) {
            Calculate();
            prefixScale2.Invalidate();
        }
        private void numericTextbox2_PrefixClicked(object sender, ODModules.PrefixClickedEventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ODModules.NumericTextbox)) { return; }
            LinkedEditor = (ODModules.NumericTextbox)sender;
            EditingSecondary = e.IsSecondary;
            ContextMenu_Prefixes.Show(e.ScreenLocation);
        }
        private void numericTextbox2_UnitChanged(object sender) {
            prefixScale2.Invalidate();
        }
        private void numericTextbox2_UnitClicked(object sender, ODModules.UnitClickedEventArgs e) {
            if (sender == null) { return; }
            if (sender.GetType() != typeof(ODModules.NumericTextbox)) { return; }
            LinkedEditor = (ODModules.NumericTextbox)sender;
            LoadUnits(OutputType);
            ContextMenu_Units.Show(e.ScreenLocation);
        }
        private void LoadUnits(UnitType? InputType) {
            Classes.UnitSystem.CleanUnitHandles(ContextMenu_Units, UnitButton_Click);
            if (InputType == null) { return; }
            bool FirstAdded = false;
            foreach (Unit Unt in InputType.Units) {
                ToolStripMenuItem UnitButton = new ToolStripMenuItem();
                UnitButton.Text = Unt.Name;
                UnitButton.ImageScaling = ToolStripItemImageScaling.None;
                UnitButton.Tag = Unt;
                UnitButton.Image = Classes.UnitConverter.DrawIcon(Color.White, Unt.GetSymbol(), DesignerSetup.MediumIconSize, UnitButton.Font);
                UnitButton.Click += UnitButton_Click;
                ContextMenu_Units.Items.Add(UnitButton);
            }
        }
        private void numericTextbox2_ValueChanged(object sender, ODModules.ValueChangedEventArgs e) {

        }
        #endregion
        private void Calculate() {
            try {
                //CurrentTemplate.Result.
                if (numericTextbox2.Tag == null) { return; }
                if (CurrentTemplate == null) { return; }
                if (CurrentEquation != null) {
                    List<MathVariable> Vars = new List<MathVariable>();
                    foreach (Physika.Controls.UnitOperation Uop in panel1.Controls) {
                        Vars.Add(new MathVariable(Uop.VariableName, Uop.NumericValue));
                    }
                    NumericalString Output = MathHandler.EvaluateExpression(CurrentEquation.Expression, Vars);
                    Unit To = new Unit((Unit)numericTextbox2.Tag, (ConversionHandler.Prefix)numericTextbox2.Prefix, (ConversionHandler.Prefix)numericTextbox2.SecondaryPrefix);
                    if (CurrentTemplate.Result != null) {
                        if (CurrentTemplate.Result.AttachedUnit != null) {
                            numericTextbox2.Value = CurrentTemplate.Result.AttachedUnit.ConvertFromBase(new NumericalString(Output.ToString()), To).ToString();
                        }
                        else {
                            numericTextbox2.Value = To.ToString();
                        }
                    }
                }
            }
            catch { }
        }

        private void EquationTypeControl_ButtonClicked(object sender, Point MenuPoint) {
            ContextMenu_Equations.Show(PointToScreen(MenuPoint));
        }

        private void labelPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void EquationTypeControl_Load(object sender, EventArgs e) {

        }

        private void btngrid_SolveFor_ButtonClicked(object Sender, GridButton Button, Point GridLocation) {

            CurrentEquation = null;
            if (Button.Tag != null) {
                if (Button.Tag.GetType() == typeof(TemplateEquation)) {
                    CurrentTemplate = (TemplateEquation)Button.Tag;
                    SetOutput();
                    LoadEquationInputs(btngrid_SolveWith);
                }
            }
        }

        private void btngrid_SolveWith_ButtonClicked(object Sender, GridButton Button, Point GridLocation) {
            LoadEquation();
        }
    }
}
