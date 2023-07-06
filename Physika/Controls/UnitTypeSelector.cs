using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Physika.Controls {
    public partial class UnitTypeSelector : UserControl {
        private const int WS_EX_TOOLWINDOW = 0x00000080;
        private const int WS_EX_NOACTIVATE = 0x08000000;
        private const int WS_EX_TOPMOST = 0x00000008;

        private static MyFilter ?mf = null;

        public UnitTypeSelector() {
            InitializeComponent();

            if (mf == null) {
                mf = new MyFilter();
               Application.AddMessageFilter(mf);
            }

            mf.MouseDown += new MyFilter.LeftButtonDown(mf_MouseDown);
            
            //mf.KeyUp += new MyFilter.KeyPressUp(mf_KeyUp);
        }
        private void UnitTypeSelector_Load(object sender, EventArgs e) {
         
        }
        [DllImport("user32")]
        public static extern int SetParent
        (IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32")]
        public static extern int ShowWindow
         (IntPtr hWnd, int nCmdShow);


        protected override CreateParams CreateParams {
            get {

                CreateParams p = base.CreateParams;
                p.ExStyle |= (WS_EX_NOACTIVATE | WS_EX_TOOLWINDOW | WS_EX_TOPMOST);
                p.Parent = IntPtr.Zero;
                return p;
            }
        }
        public new void Show(Point ShowLocation, Size PopupSize) {
            if (this.Handle == IntPtr.Zero) base.CreateControl();

            this.Location = ShowLocation;
            this.Width = PopupSize.Width;
            this.Height = PopupSize.Height;
            SetParent(base.Handle, IntPtr.Zero);
            ShowWindow(base.Handle, 1);
            this.Focus();
            textBox1.Focus();

        }
        const int WM_PARENTNOTIFY = 0x210;
        const int WM_LBUTTONDOWN = 0x201;

        //protected override void WndProc(ref Message m) {
        //    if (!this.DesignMode) {
        //        if (m.Msg == WM_PARENTNOTIFY) {
        //            if (m.WParam.ToInt32() == WM_LBUTTONDOWN) {
        //                //do you staff
        //                Debug.Print("aaa");
        //            }
        //        }
        //    }
        //    base.WndProc(ref m);
        //}
        public bool PreFilterMessage(ref Message m) {
            var mhwnd = m.HWnd;
            if (m.Msg == WM_LBUTTONDOWN) {
                //System.Diagnostics.Debug.WriteLine("BEEP!");
                // get clicks OUTSİDE OF the control

                if (Controls.Cast<Control>().All(x => x.Handle != mhwnd)) {
                    // do your  what you wanna do here


                    return true;  // handle click
                }
            }
            return false;
        }
        private void buttonGrid1_Load(object sender, EventArgs e) {

        }
        protected override void OnLeave(EventArgs e) {
            base.OnLeave(e);
            this.Hide();
        }

        private void mf_KeyUp(IntPtr target) {
            if (!target.Equals(IntPtr.Zero)) {
                //if (PanelVisible) {
                 //   if (!IsTargetMine(target)) {
                 //       TogglePanel();
                 //   }
                //}
            }
        }
        private bool IsTargetMine(IntPtr target) {
            return IsTargetMine(this, target);
        }
        private bool IsTargetMine(Control ctl, IntPtr target) {
            foreach (Control child in ctl.Controls) {
                if (child.Handle.Equals(target)) {
                    return true;
                }
                else if (child.HasChildren) {
                    bool result = IsTargetMine(child, target);
                    if (result) {
                        return true;
                    }
                }
            }
            return false;
        }
        private void mf_MouseDown() {
            if (this.Visible) {
                if (!this.RectangleToScreen(this.ClientRectangle).Contains(System.Windows.Forms.Cursor.Position)) {
                    this.Hide();
                }
            }
        }

        private class MyFilter : IMessageFilter {

            public delegate void LeftButtonDown();
            public event LeftButtonDown MouseDown;

            //public delegate void KeyPressUp(IntPtr target);
            //public event KeyPressUp KeyUp;

            private const int WM_KEYUP = 0x101;
            private const int WM_LBUTTONDOWN = 0x201;

            bool IMessageFilter.PreFilterMessage(ref Message m) {
                switch (m.Msg) {
                    // raise our KeyUp() event whenever a key is released in our app
                   //case WM_KEYUP:
                   //    if (KeyUp != null) {
                   //        KeyUp(m.HWnd);
                   //    }
                   //    break;
                   //
                    // raise our MouseDown() event whenever the mouse is left clicked somewhere in our app
                    case WM_LBUTTONDOWN:
                        if (MouseDown != null) {
                            MouseDown();
                        }
                        break;
                   case 96:
                       if (MouseDown != null) {
                           MouseDown();
                       }
                       break;
                    case 161:
                        if (MouseDown != null) {
                            MouseDown();
                        }
                        break;
                    case 15:
                        break;

                }
                return false;
            }
        
        }

        private void buttonGrid1_ButtonClicked(object Sender, ODModules.GridButton Button, Point GridLocation) {
            this.Hide();
            buttonGrid1.VerScroll = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            buttonGrid1.Filter = textBox1.Text;
        }

        private void UnitTypeSelector_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
        
        }

        private void UnitTypeSelector_KeyPress(object sender, KeyPressEventArgs e) {
            int keyValue = e.KeyChar;
            char c = (char)keyValue;//ToChar(kc, e.Shift);
            if (char.IsLetterOrDigit(c) || char.IsSymbol(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c)) {
                if (c != 0x00) {
                    if (e.KeyChar != Convert.ToChar(Keys.Enter)) {
                        textBox1.Text += c;
                    }
                }
            }
            else {
            }
        }

        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) {
            base.OnKeyDown(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e) {
            base.OnKeyPress(e);
        }
    }
}
