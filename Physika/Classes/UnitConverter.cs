using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;
using Handlers;
using System.IO;
//using UnitConverter.Properties;
namespace Physika.Classes {
    public class UnitConverter {
        public static void LoadDimensions() {
            bool IsFirst = true;
            try {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Environment.CurrentDirectory + @"\Dimensions\");
                System.IO.FileInfo[] aryFi = di.GetFiles("*.dim");
                foreach (System.IO.FileInfo fi in aryFi) {
                    DocumentHandler.Open(fi.FullName);
                    bool CurrentIsBase = false;
                    Debug.Print(Path.GetFileNameWithoutExtension(fi.FullName));
                    string BaseName = "";
                    string BaseSymbol = "";
                    string BaseSymbolB = "";
                    string BasePrefixEq = "x";
                    bool BaseCompositeAffectsPrefix = false;
                    bool BaseHasPrefixEq = false;

                    bool BaseIsCompositeUnit = false;
                    bool BaseDivideComposite = false;

                    ConversionHandler.UnitSystem BaseSystem = ConversionHandler.UnitSystem.Other;
                    List<Unit> Units = new List<Unit>();
                    foreach (ParameterStructure Parm in DocumentHandler.PARM) {
                        bool HasPrefixEquation = false;
                        bool CompositeAffectsPrefix = false;
                        string PrefixEquation = "x";
                        CurrentIsBase = (bool)Parm.GetVariable("IsBase", true, DataType.BOL);
                        if (DocumentHandler.IsDefinedInParameter("UsePrefixEquation", Parm)) {
                            HasPrefixEquation = (bool)Parm.GetVariable("UsePrefixEquation", true, DataType.BOL);
                        }
                        if (DocumentHandler.IsDefinedInParameter("PrefixEquation", Parm)) {
                            PrefixEquation = (string)Parm.GetVariable("PrefixEquation", true, DataType.STR);
                        }
                        if (DocumentHandler.IsDefinedInParameter("CompositePrefix", Parm)) {
                            CompositeAffectsPrefix = (bool)Parm.GetVariable("CompositePrefix", true, DataType.BOL);
                        }

                        string CurrentName = (string)Parm.GetVariable("Name", true, DataType.STR);
                        string CurrentSymbol = (string)Parm.GetVariable("Symbol", true, DataType.STR);
                        ConversionHandler.UnitSystem CurrentSystem = IntToSystem((int)Parm.GetVariable("UnitType", true, DataType.INT));

                        if (CurrentIsBase == true) {
                            BaseName = CurrentName;
                            BaseSymbol = CurrentSymbol;
                            BaseSystem = CurrentSystem;
                            BasePrefixEq = PrefixEquation;
                            BaseHasPrefixEq = HasPrefixEquation;
                            BaseCompositeAffectsPrefix = CompositeAffectsPrefix;

                            if (DocumentHandler.IsDefinedInParameter("CompositeUnit", Parm)) {
                                BaseIsCompositeUnit = (bool)Parm.GetVariable("CompositeUnit", true, DataType.BOL);
                            }
                            if (DocumentHandler.IsDefinedInParameter("SymbolB", Parm)) {
                                BaseSymbolB = (string)Parm.GetVariable("SymbolB", true, DataType.STR);
                            }
                            if (DocumentHandler.IsDefinedInParameter("DivideComposite", Parm)) {
                                BaseDivideComposite = (bool)Parm.GetVariable("DivideComposite", true, DataType.BOL);
                            }
                        }
                        else {
                            string CurrentEqTo = (string)Parm.GetVariable("ToBaseEq", true, DataType.STR);
                            string CurrentEqFrom = (string)Parm.GetVariable("FromBaseEq", true, DataType.STR);
                            bool IsComp = false;
                            bool IsDiv = false;
                            string SymbolB = "";
                            if (DocumentHandler.IsDefinedInParameter("CompositeUnit", Parm)) {
                                IsComp = (bool)Parm.GetVariable("CompositeUnit", true, DataType.BOL);
                            }
                            if (DocumentHandler.IsDefinedInParameter("SymbolB", Parm)) {
                                SymbolB = (string)Parm.GetVariable("SymbolB", true, DataType.STR);
                            }
                            if (DocumentHandler.IsDefinedInParameter("DivideComposite", Parm)) {
                                IsDiv = (bool)Parm.GetVariable("DivideComposite", true, DataType.BOL);
                            }

                            UnitConversionEquation Eq = new UnitConversionEquation(CurrentEqTo, CurrentEqFrom, PrefixEquation);
                            Unit CurrentUnit = new Unit(CurrentName, CurrentSymbol, Eq, CurrentSystem, false, HasPrefixEquation, IsComp, CompositeAffectsPrefix, IsDiv, SymbolB);
                            Units.Add(CurrentUnit);

                        }
                    }
                    Unit BaseUnit = new Unit(BaseName, BaseSymbol, new UnitConversionEquation("x", "x", BasePrefixEq), BaseSystem, true, BaseHasPrefixEq, BaseCompositeAffectsPrefix, BaseIsCompositeUnit, BaseDivideComposite, BaseSymbolB);
                    string Dim = (string)DocumentHandler.GetVariable("Dimension", true, DataType.STR);
                    UnitType Dimension = new UnitType((string)DocumentHandler.GetVariable("Dimension", true, DataType.STR), BaseUnit, Units);
                    Dimension.Symbol = DocumentHandler.GetStringVariable("Symbol");
                    Dimension.VariableName = DocumentHandler.GetStringVariable("VariableName");
                    ConversionHandler.UnitTypes.Add(Dimension);

                    //RibbonButton RibBtn = new RibbonButton();
                    //RibBtn.Click += RibBtn_Click;
                    //RibBtn.Text = Dim;
                    //RibBtn.Tag = Dimension;
                    //RibBtn.MaxSizeMode = RibbonElementSizeMode.Medium;

                    //ribbonButtonList1.Buttons.Add(RibBtn);
                    //if (IsFirst == true) {
                    //    IsFirst = false;
                    //    RibBtn.Checked = true;
                    //    LoadUnits(ribbonComboBox1, Dimension.Units);
                    //    LoadUnits(ribbonComboBox2, Dimension.Units);
                    //    SelectedType = Dimension;
                    //    Convert();
                    //}
                }
            }
            catch { }
        }
        //private void LoadUnits(RibbonComboBox List, List<Unit> Units) {
        //    List.DropDownItems.Clear();
        //    bool IsFirst = true;
        //    bool FirstAdded = false;
        //    List<Color> cols = GetConstants(typeof(Color));
        //    int colin = 10;
        //    foreach (Unit U in Units) {
        //        RibbonButton RibBtn = new RibbonButton();
        //        // if (IsFirst == true) { IsFirst = false; RibBtn.Checked = true; }
        //        RibBtn.Text = U.Name;
        //        RibBtn.Tag = U;
        //        RibBtn.SmallImage = DrawIcon(RenderHandler.WhiteLightenColor(cols[colin], 200), U.Symbol, 32);
        //        List.DropDownItems.Add(RibBtn);
        //        if (FirstAdded == false) { FirstAdded = true; List.SelectedItem = RibBtn; }
        //        colin++;
        //    }
        //}
        private static List<Color> GetConstants(Type enumType) {
            MethodAttributes attributes = MethodAttributes.Static | MethodAttributes.Public;
            PropertyInfo[] properties = enumType.GetProperties();
            List<Color> list = new List<Color>();
            for (int i = 0; i < properties.Length; i++) {
                PropertyInfo info = properties[i];
                if (info.PropertyType == typeof(Color)) {
                    MethodInfo getMethod = info.GetGetMethod();
                    if ((getMethod != null) && ((getMethod.Attributes & attributes) == attributes)) {
                        object[] index = null;
                        list.Add((Color)info.GetValue(null, index));
                    }
                }
            }
            return list;
        }
        private static ConversionHandler.UnitSystem IntToSystem(int Input) {
            if (Input == 0) {
                return ConversionHandler.UnitSystem.SI;
            }
            else if (Input == 1) {
                return ConversionHandler.UnitSystem.Imperial;
            }
            else {
                return ConversionHandler.UnitSystem.Other;
            }
        }
        public static Image DrawIcon(Color Colour, string Text, int size, Font ParentFont) {
            var bmp = new Bitmap(size, size);
            Graphics g = Graphics.FromImage(bmp);
            //using (SolidBrush br = new SolidBrush(Color.FromArgb(0, 0, 0))) {
            //    g.FillRectangle(br, new Rectangle(0, 0, size, size));
            //}
            //int off_in = (int)Math.Ceiling(size / (double)16) * 2;
            Rectangle TextBounds = new Rectangle(0, 0, size, size);

            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            using (StringFormat sf = new StringFormat()) {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                using (SolidBrush txtbr = new SolidBrush(Colour)) {
                    g.DrawString(Text, DesignerSetup.GetAdjustedFont(g, Text, ParentFont, TextBounds.Width, (int)ParentFont.Size, 3, true), txtbr, TextBounds, sf);
                    //TextRenderer.DrawText(g,Text, DesignerSetup.GetAdjustedFont(g, Text, ParentFont, TextBounds.Width, (int)ParentFont.Size, 3, true), TextBounds, Colour);
                }
            }
            g.Dispose();
            return bmp;
        }
        public static Image DrawEquation(Color Colour, string Text, int size, Font ParentFont) {
            Bitmap bmp = new Bitmap(size, size);
            Graphics g = Graphics.FromImage(bmp);
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            //}
            g.Clear(Color.Transparent);
            float CurrentX = 0;
            float LastX = 0;
            float LastWidth = 0;
            ExpressionScriptType LastScriptType = ExpressionScriptType.Normal;
            List<ExpressionFormat> Sym = MathHandler.DecomposeRquationToScriptTypes(Text);
            float GenHeight = g.MeasureString("0", ParentFont).Height;
            float VerPos = (size - GenHeight)/2.0f;
            using (StringFormat sf = new StringFormat(StringFormat.GenericTypographic)) {
                sf.FormatFlags = StringFormatFlags.NoClip;
                sf.Trimming = StringTrimming.None;
                using (SolidBrush txtbr = new SolidBrush(Colour)) {
                    foreach (ExpressionFormat ex in Sym) {
                        string CurrentString = ex.Text;
                        float TextWidth = g.MeasureString(CurrentString, ParentFont, 100, sf).Width;
                        float LinePos = 0;
                        if (ex.ScriptType == ExpressionScriptType.Normal) { LinePos = 0; }
                        else if (ex.ScriptType == ExpressionScriptType.Superscript) { LinePos = -GenHeight * 0.33f; }
                        else if (ex.ScriptType == ExpressionScriptType.Subscript) { LinePos = GenHeight * 0.33f; }

                        if ((ex.ScriptType == ExpressionScriptType.Superscript) && (LastScriptType == ExpressionScriptType.Subscript)) {
                            CurrentX = LastX;
                            if (LastWidth > TextWidth) { TextWidth = LastWidth; }
                        }
                        else if ((ex.ScriptType == ExpressionScriptType.Subscript) && (LastScriptType == ExpressionScriptType.Superscript)) {
                            CurrentX = LastX;
                            if (LastWidth > TextWidth) { TextWidth = LastWidth; }
                        }
                        LastX = CurrentX;
                        CurrentX += TextWidth;
                        LastWidth = TextWidth;
                        LastScriptType = ex.ScriptType;
                    }
                    CurrentX = (size- CurrentX) /2.0f;
                    LastX = CurrentX;
                    LastWidth = 0;
                    LastScriptType = ExpressionScriptType.Normal;
                    foreach (ExpressionFormat ex in Sym) {
                        string CurrentString = ex.Text;
                        float TextWidth = g.MeasureString(CurrentString, ParentFont, 100, sf).Width;
                        float LinePos = 0;
                        if (ex.ScriptType == ExpressionScriptType.Normal) { LinePos = 0; }
                        else if (ex.ScriptType == ExpressionScriptType.Superscript) { LinePos = -GenHeight * 0.33f; }
                        else if (ex.ScriptType == ExpressionScriptType.Subscript) { LinePos = GenHeight * 0.33f; }

                        if ((ex.ScriptType == ExpressionScriptType.Superscript) && (LastScriptType == ExpressionScriptType.Subscript)) {
                            CurrentX = LastX;
                            if (LastWidth > TextWidth) { TextWidth = LastWidth; }
                        }
                        else if ((ex.ScriptType == ExpressionScriptType.Subscript) && (LastScriptType == ExpressionScriptType.Superscript)) {
                            CurrentX = LastX;
                            if (LastWidth > TextWidth) { TextWidth = LastWidth; }
                        }
                        g.DrawString(CurrentString, ParentFont, txtbr, new PointF(CurrentX, VerPos + LinePos), sf);
                        LastX = CurrentX;
                        CurrentX += TextWidth;
                        LastWidth = TextWidth;
                        LastScriptType = ex.ScriptType;
                    }
                }
            }
            g.Dispose();
            return bmp;
        }
    }
    // public class Dimension {

    //  }
}
