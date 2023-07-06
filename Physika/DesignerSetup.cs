using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Handlers;
using ODModules;
using Svg;

namespace Physika {
    public class DesignerSetup {
        public static int LargeIconSize = 32;
        public static int MediumIconSize = 24;
        public static int SmallIconSize = 16;
        public static void SetImageSizes(int DPI) {
            LargeIconSize = SetIconSize(32, DPI);
            MediumIconSize = SetIconSize(24, DPI);
            SmallIconSize = SetIconSize(16, DPI);
        }
        public static Size GetSize(IconSize IconSz) {
            if (IconSz == IconSize.Small) {
                return new Size(SmallIconSize, SmallIconSize);
            }
            else if (IconSz == IconSize.Medium) {
                return new Size(MediumIconSize, MediumIconSize);
            }
            else if (IconSz == IconSize.Large) {
                return new Size(LargeIconSize, LargeIconSize);
            }
            return new Size(SmallIconSize, SmallIconSize);
        }
        private static int SetIconSize(int BasisSize, int DPI) {
            return (int)Math.Floor(((decimal)DPI / (decimal)96) * (decimal)BasisSize);
        }
        public static int ScaleInteger(int Input) {
            return (int)(((float)RenderHandler.DPI() / 96.0f) * (float)Input);
        }
        public static Size ScaleSize(Size Input) {
            float ScaleFactor = ((float)RenderHandler.DPI() / 96.0f);
            float WidthScaled = ScaleFactor * (float)Input.Width;
            float HeightScaled = ScaleFactor * (float)Input.Height;
            return new Size((int)WidthScaled, (int)HeightScaled);
        }
        //public static void LinkSVGtoRibbonControl(byte[] Resource, object LinkedControl) {
        //    using (MemoryStream stream = new MemoryStream(Resource)) {
        //        SvgDocument SVG = new SvgDocument();
        //        var svg = SvgDocument.Open<SvgDocument>(stream);
        //        Type t = LinkedControl.GetType();
        //        if (t == typeof(RibbonButton)) {
        //            ((RibbonButton)LinkedControl).LargeImage = svg.Draw(LargeIconSize, LargeIconSize);
        //            ((RibbonButton)LinkedControl).SmallImage = svg.Draw(SmallIconSize, SmallIconSize);
        //        }
        //        else if (t == typeof(RibbonItem)) {
        //            ((RibbonItem)LinkedControl).Image = svg.Draw(SmallIconSize, SmallIconSize);
        //        }

        //    }
        //}
        public static void LinkSVGtoControl(byte[] Resource, object LinkedControl, Size ImageSize, bool IsThemeAffected = true) {
            using (MemoryStream stream = new MemoryStream(Resource)) {
                SvgDocument SVG = new SvgDocument();
                var svg = SvgDocument.Open<SvgDocument>(stream);
                Type t = LinkedControl.GetType();
                Image Img = svg.Draw(ImageSize.Width, ImageSize.Height);
                if (IsThemeAffected == true) {
                    if (Classes.ApplicationManager.IsDark == true) {
                        Img = RenderHandler.InvertImageColors(Img, true, 180);
                    }
                }
                if (t == typeof(PictureBox)) {
                    ((PictureBox)LinkedControl).Image = Img;
                }
                else if (t == typeof(ToolStripMenuItem)) {
                    ((ToolStripMenuItem)LinkedControl).Image = Img;
                }
                else if (t == typeof(ToolStripButton)) {
                    ((ToolStripButton)LinkedControl).Image = Img;
                }
                else if (t == typeof(ToolStripSplitButton)) {
                    ((ToolStripSplitButton)LinkedControl).Image = Img;
                }
                else if (t == typeof(ToolStripDropDownButton)) {
                    ((ToolStripDropDownButton)LinkedControl).Image = Img;
                }
                else if (t == typeof(GridButton)) {
                    ((GridButton)LinkedControl).Icon = Img;
                }
            }
        }

        [System.Runtime.InteropServices.DllImport("shcore.dll")]
        public static extern int SetProcessDpiAwareness(_Process_DPI_Awareness value);
        public enum _Process_DPI_Awareness {
            Process_DPI_Unaware = 0,
            Process_System_DPI_Aware = 1,
            Process_Per_Monitor_DPI_Aware = 2
        }
        public static void SetupMain() {
            try {
                SetProcessDpiAwareness(_Process_DPI_Awareness.Process_System_DPI_Aware);
            }
            catch {
            }
        }
        public static void SetDoubleBuffering(System.Windows.Forms.Control control, bool value) {
            //System.Reflection.PropertyInfo controlProperty = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);controlProperty.SetValue(control, value, null);
        }
        public static Font GetAdjustedFont(Graphics g, string graphicString, Font originalFont, int containerWidth, int maxFontSize, int minFontSize, bool smallestOnFail) {
            Font? testFont = null;
            for (int adjustedSize = maxFontSize; adjustedSize >= minFontSize; adjustedSize--) {
                testFont = new Font(originalFont.Name, adjustedSize, originalFont.Style);
                SizeF adjustedSizeNew = g.MeasureString(graphicString, testFont);
                if (containerWidth > (int)adjustedSizeNew.Width) {
                    return testFont;
                }
            }
            if (smallestOnFail) {
                if (testFont == null) {
                    return originalFont;
                }
                else {
                    return testFont;
                }
            }
            else {
                return originalFont;
            }
        }
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
        private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

        public static bool UseImmersiveDarkMode(IntPtr handle, bool enabled) {
            if (IsWindows10OrGreater(17763)) {
                var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
                if (IsWindows10OrGreater(18985)) {
                    attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
                }

                int useImmersiveDarkMode = enabled ? 1 : 0;
                return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
            }

            return false;
        }

        public static bool IsWindows10OrGreater(int build = -1) {
            return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
        }
        public enum IconSize {
            Small = 0x00,
            Medium = 0x01,
            Large = 0x02
        }
    }
}
