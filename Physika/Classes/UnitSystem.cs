using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Handlers;
using ODModules;

namespace Physika.Classes {
    public static class UnitSystem {
        public static bool AutoScale = true;
        public static bool IsMetric(ConversionHandler.UnitSystem Type) {
            if ((Type != ConversionHandler.UnitSystem.Imperial) && (Type != ConversionHandler.UnitSystem.Other)) {
                return true;
            }
            else {
                return false;
            }
        }
        public static void LinkSecondary(NumericTextbox NTB, Unit Input) {
            if (Input.IsCompositeUnit == true) {
                if (Input.CompositeUnitAffectsPrefix == true) {
                    NTB.IsSecondaryMetric = true;
                }
                else { NTB.IsSecondaryMetric = false; }
                if (Input.DivideComposite == true) {
                    NTB.SecondaryUnitDisplay = NumericTextbox.SecondaryUnitDisplayType.Divide;
                }
                else {
                    NTB.SecondaryUnitDisplay = NumericTextbox.SecondaryUnitDisplayType.Multiply;
                }
                NTB.SecondaryUnit = Input.SecondarySymbol;
            }
            else {
                NTB.SecondaryUnitDisplay = NumericTextbox.SecondaryUnitDisplayType.NoSecondaryUnit;
                NTB.IsSecondaryMetric = false;
            }
        }
        public static void ClearEditors(object Collection, UnitType uType) {
            if (Collection.GetType() == typeof(Panel)) {
                Panel TempPnl = (Panel)Collection;
                foreach (Physika.Controls.UnitOperation Uop in TempPnl.Controls) {
                    Uop.NumericEditor.Clear();
                    Uop.NumericEditor.Prefix = NumericTextbox.MetricPrefix.None;
                    Uop.NumericEditor.SecondaryPrefix = NumericTextbox.MetricPrefix.None;
                    Uop.CurrentType = uType;
                    Uop.PrefixEditor.Invalidate();
                }
            }
        }
        public static void CleanUnitHandles(object Collection, EventHandler OnClick) {
            if (Collection.GetType() == typeof(ContextMenu)) {
                ContextMenu TempMenu = (ContextMenu)Collection;
                foreach (ToolStripItem Item in TempMenu.Items) {
                    Item.Click -= OnClick;
                }
                TempMenu.Items.Clear();
            }
        }
        public static void SetUnitTypes(object Collection, UnitType uType) {
            if (Collection.GetType() == typeof(Panel)) {
                Panel TempPnl = (Panel)Collection;
                foreach (Physika.Controls.UnitOperation Uop in TempPnl.Controls) {
                    Uop.CurrentType = uType;
                }
            }
        }
        public static void SetUnit(object Collection, Unit Input, bool IsMetric) {
            if (Collection.GetType() == typeof(Panel)) {
                Panel TempPnl = (Panel)Collection;
                foreach (Physika.Controls.UnitOperation Uop in TempPnl.Controls) {
                    Uop.NumericEditor.Unit = Input.Symbol;
                    Uop.NumericEditor.Tag = Input;
                    Uop.NumericEditor.IsMetric = IsMetric;
                    Uop.SetPanelText(Input.Name);
                    Uop.NumericEditor.SecondaryPrefix = NumericTextbox.MetricPrefix.None;
                    Classes.UnitSystem.LinkSecondary(Uop.NumericEditor, Input);
                    //labelPanel1.Text = Input.Name;
                }
            }
        }
        public static void LoadPrefixes(object Collection, EventHandler OnClick) {
            List<Prefix> Sorted = new List<Prefix>();
            foreach (ODModules.NumericTextbox.MetricPrefix Mp in ODModules.NumericTextbox.MetricPrefix.GetValues(typeof(ODModules.NumericTextbox.MetricPrefix))) {
                Prefix Pfix = new Prefix(Mp.ToString(), "", (int)Mp, Mp);
                Sorted.Add(Pfix);
            }
            Sorted.Sort((s1, s2) => s2.Order.CompareTo(s1.Order));
            if (Collection.GetType() == typeof(ContextMenu)) {
                ContextMenu TempMenu = (ContextMenu)Collection;
                foreach (Prefix Pfix in Sorted) {
                    int PrefixNumer = (int)Pfix.Order;
                    ToolStripMenuItem UPrefixButton = new ToolStripMenuItem();
                    UPrefixButton.Text = Pfix.Name;
                    UPrefixButton.Tag = Pfix.Linked;
                    UPrefixButton.ImageScaling = ToolStripItemImageScaling.None;
                    UPrefixButton.Image = Classes.UnitConverter.DrawIcon(Color.White, ConversionHandler.PrefixToSymbol((ConversionHandler.Prefix)PrefixNumer), DesignerSetup.SmallIconSize, UPrefixButton.Font);
                    UPrefixButton.Click += OnClick;
                    TempMenu.Items.Add(UPrefixButton);
                }
            }
        }
        public static void LoadUnitTypes(object Collection, EventHandler OnClick, object Label) {
            bool IsFirstAdded = false;
            string DisplayText = "";
            UnitType? FirstType = null;
            if (Collection.GetType() == typeof(ContextMenu)) {
                ContextMenu TempMenu = (ContextMenu)Collection;
                foreach (UnitType UType in ConversionHandler.UnitTypes) {
                    ToolStripMenuItem UTypeButton = new ToolStripMenuItem();
                    UTypeButton.Text = UType.Name;
                    UTypeButton.Tag = UType;
                    UTypeButton.ImageScaling = ToolStripItemImageScaling.None;
                    UTypeButton.Click += OnClick;
                    UTypeButton.Image = Classes.UnitConverter.DrawIcon(Color.White, UType.Symbol, DesignerSetup.SmallIconSize, UTypeButton.Font);
                    TempMenu.Items.Add(UTypeButton);
                    if (IsFirstAdded == false) {
                        FirstType = UType;
                        DisplayText = UType.Name;
                        IsFirstAdded = true;
                    }
                }
            }
            else if (Collection.GetType() == typeof(ButtonGrid)) {

                ButtonGrid TempMenu = (ButtonGrid)Collection;
                TempMenu.Buttons.Clear();

                foreach (UnitType UType in ConversionHandler.UnitTypes) {
                    GridButton UTypeButton = new GridButton();
                    UTypeButton.Text = UType.Name;
                    UTypeButton.Tag = UType;
                    //UTypeButton.Click += OnClick;
                    using (Font Fnt = new Font("Times New Roman", 25, FontStyle.Italic)) {
                        UTypeButton.Icon = Classes.UnitConverter.DrawEquation(Color.White, UType.Symbol, DesignerSetup.ScaleInteger(48), Fnt);
                    }
                    //UTypeButton.Icon = Classes.UnitConverter.DrawIcon(Color.White, UType.Symbol, DesignerSetup.SmallIconSize, TempMenu.Font);
                    TempMenu.Buttons.Add(UTypeButton);
                    if (IsFirstAdded == false) {
                        FirstType = UType;
                        DisplayText = UType.Name;
                        IsFirstAdded = true;
                    }
                }
            }
            if (Label.GetType() == typeof(LabelButton)) {
                LabelButton TempLbl = (LabelButton)Label;
                TempLbl.LabelText = DisplayText;
                TempLbl.Tag = FirstType;
            }
            //LoadUnits();
        }

        private static void TempMenu_ButtonClicked(object? Sender, GridButton Button, Point GridLocation) {
            throw new NotImplementedException();
        }

        public static void InsertSelectorButton(string DisplayText, ButtonType DisplayType, bool Checked, object LinkedObject, object Collection, MouseEventHandler OnClick) {
            if (Collection.GetType() == typeof(FlowLayoutPanel)) {
                FlowLayoutPanel TempPnl = (FlowLayoutPanel)Collection;
                ODModules.Button ResBtnSel = new ODModules.Button();
                ResBtnSel.Width = 100;
                ResBtnSel.Height = 30;//73, 23
                ResBtnSel.Text = DisplayText;
                ResBtnSel.RadioButtonGroup = "EqSolveSel";
                ResBtnSel.Type = DisplayType;
                ResBtnSel.AllowGroupUnchecking = true;
                ResBtnSel.MouseClick += OnClick;
                ResBtnSel.Tag = LinkedObject;
                ResBtnSel.Style = ButtonStyle.Round;
                ResBtnSel.BorderRadius = 2;

                ResBtnSel.BackColor = Color.FromArgb(16, 16, 16);
                ResBtnSel.BackColorDownNorth = Color.FromArgb(10, 10, 10);
                ResBtnSel.BackColorDownSouth = Color.FromArgb(10, 10, 10);
                ResBtnSel.BackColorHoverNorth = Color.FromArgb(40, 40, 40);
                ResBtnSel.BackColorHoverSouth = Color.FromArgb(40, 40, 40);
                ResBtnSel.BackColorNorth = Color.FromArgb(30, 30, 30);
                ResBtnSel.BackColorSouth = Color.FromArgb(30, 30, 30);
                ResBtnSel.BorderColorNorth = Color.FromArgb(0, 0, 0);
                ResBtnSel.BorderColorSouth = Color.FromArgb(0, 0, 0);


                ResBtnSel.Checked = Checked;

                TempPnl.Controls.Add(ResBtnSel);
                ResBtnSel.SendToBack();
            }
            else if (Collection.GetType() == typeof(ButtonGrid)) {
                ButtonGrid TempPnl = (ButtonGrid)Collection;
                GridButton Btn = new GridButton();
                Btn.Text = DisplayText;
                Btn.RadioButtonGroup = "EqSolveSel";
                Btn.Checked = Checked;
                Btn.Type = DisplayType;
                Btn.Tag = LinkedObject;
                TempPnl.Buttons.Add(Btn);

            }
        }
        public static bool CollectionHasVariable(object Collection, TemplateVariable TempVar) {
            if (Collection.GetType() == typeof(FlowLayoutPanel)) {
                FlowLayoutPanel TempPnl = (FlowLayoutPanel)Collection;
                foreach (Control Ctrl in TempPnl.Controls) {
                    if (Ctrl.GetType() == typeof(ODModules.Button)) {
                        ODModules.Button Btn = (ODModules.Button)Ctrl;
                        if (Btn.Tag != null) {
                            if (Btn.Tag.GetType() == typeof(TemplateVariable)) {
                                TemplateVariable BtnTV = (TemplateVariable)Btn.Tag;
                                if (BtnTV.VariableName == TempVar.VariableName) {
                                    return true;
                                }
                            }
                        }
                    }
                }
                return false;
            }
            else { return false; }
        }
    }
}
