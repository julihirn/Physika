﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace Physika {
    public class TabHeaderControl : UserControl {
        private TabControl? bindedTabControl = null;
        [System.ComponentModel.Category("Control")]
        public TabControl? BindedTabControl {
            get {
                return bindedTabControl;
            }
            set {
                if (bindedTabControl != null) {
                    bindedTabControl.ControlAdded -= BindedTabControl_ControlAdded;
                    bindedTabControl.ControlRemoved -= BindedTabControl_ControlRemoved;
                }
                bindedTabControl = value;
                if (bindedTabControl != null) {
                    bindedTabControl.ControlAdded += BindedTabControl_ControlAdded;
                    bindedTabControl.ControlRemoved += BindedTabControl_ControlRemoved;
                }
                Invalidate();
            }
        }
        int selectedIndex = 0;
        [System.ComponentModel.Category("Control")]
        public int SelectedIndex {
            get {
                return selectedIndex;
            }
            set {
                selectedIndex = value;
                Invalidate();
            }
        }
        TabStyles tabStyle = TabStyles.Normal;
        [System.ComponentModel.Category("Appearance")]
        public TabStyles TabStyle {
            get {
                return tabStyle;
            }
            set {
                tabStyle = value;
            }
        }
        Color tabBackColor = Color.Gray;
        [System.ComponentModel.Category("Appearance")]
        public Color TabBackColor {
            get {
                return tabBackColor;
            }
            set {
                tabBackColor = value;
            }
        }
        Color tabSelectedBackColor = Color.LightGray;
        [System.ComponentModel.Category("Appearance")]
        public Color TabSelectedBackColor {
            get {
                return tabSelectedBackColor;
            }
            set {
                tabSelectedBackColor = value;
            }
        }
        Color tabHoverBackColor = Color.LightGray;
        [System.ComponentModel.Category("Appearance")]
        public Color TabHoverBackColor {
            get {
                return tabHoverBackColor;
            }
            set {
                tabHoverBackColor = value;
            }
        }
        Color tabClickedBackColor = Color.DarkGray;

        public TabHeaderControl() {
            DoubleBuffered = true;
        }

        [System.ComponentModel.Category("Appearance")]
        public Color TabClickedBackColor {
            get {
                return tabClickedBackColor;
            }
            set {
                tabClickedBackColor = value;
            }
        }
        private void BindedTabControl_ControlRemoved(object? sender, ControlEventArgs e) {
            if (bindedTabControl != null) {
                //if (selectedIndex >= bindedTabControl.TabPages.Count - 1) {
                //    if (Old_Selected < 0) {
                //        Old_Selected = selected;
                //    }
                //    selected = bindedTabControl.TabPages.Count - 1;
                //    ReDraw();
                //}
            }
            Invalidate();
        }
        private void BindedTabControl_ControlAdded(object? sender, ControlEventArgs e) {
            Invalidate();
        }

        protected override void OnMouseMove(MouseEventArgs e) {
            base.OnMouseMove(e);
        }

        protected override void OnPaint(PaintEventArgs e) {
            int TabPadding = Height - (int)(e.Graphics.MeasureString("W", Font).Width * 1.25f);
            if (bindedTabControl != null) {
                int RunningSize = 0;
                for (int i = 0; i < bindedTabControl.TabPages.Count; i++) {
                    Action Current = Action.Normal;
                    if (i == bindedTabControl.SelectedIndex) {
                        Current = Action.Selected;
                    }
                    RunningSize += DrawTab(e, bindedTabControl.TabPages[i].Text, Current, new Point(RunningSize, TabPadding));
                }
            }
        }
        private int DrawTab(PaintEventArgs e, string TabText, Action DisplayAction, Point Location) {
            int TabPadding = (int)e.Graphics.MeasureString("W", Font).Width;
            SizeF TextSize = e.Graphics.MeasureString(TabText, Font);
            Rectangle TabRectangle = new Rectangle(Location.X, Location.Y, (int)TextSize.Width + (TabPadding * 2), (int)TextSize.Height + (TabPadding/4));
            if (tabStyle == TabStyles.Normal) {
                Color backColor = GetTabColor(DisplayAction);
                using (SolidBrush backBrush = new SolidBrush(backColor)) {
                    e.Graphics.FillRectangle(backBrush, TabRectangle);
                }
               
            }
            else if (tabStyle == TabStyles.Angled) {
                Color backColor = GetTabColor(DisplayAction);
                using (SolidBrush backBrush = new SolidBrush(backColor)) {
                    int AngleInset = TabPadding / 4;
                    e.Graphics.FillPolygon(backBrush, new Point[] {
                        new Point(TabRectangle.Left + AngleInset, TabRectangle.Top),
                        new Point(TabRectangle.Right - AngleInset, TabRectangle.Top),
                        new Point(TabRectangle.Right, TabRectangle.Bottom),
                        new Point(TabRectangle.Left, TabRectangle.Bottom),
                    });
                }
            }
            else if (tabStyle == TabStyles.Underlined) {

            }
            using (SolidBrush textBrush = new SolidBrush(ForeColor)) {
                using (StringFormat textFormat = new StringFormat()) {
                    textFormat.Alignment = StringAlignment.Near;
                    textFormat.LineAlignment = StringAlignment.Center;
                    e.Graphics.DrawString(TabText, Font, textBrush, TabRectangle, textFormat);
                }
            }
            return TabRectangle.Width;
        }
        private Color GetTabColor(Action DisplayAction) {
            if (DisplayAction == Action.Normal) {
                return tabBackColor;
            }
            else if (DisplayAction == Action.Selected) {
                return tabSelectedBackColor;
            }
            else if (DisplayAction == Action.MouseDown) {
                return tabClickedBackColor;
            }
            return tabBackColor;
        }
        protected override void OnMouseWheel(MouseEventArgs e) {
            base.OnMouseWheel(e);
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            base.OnMouseDown(e);
        }
        private enum Action {
            Normal = 0x00,
            Selected = 0X01,
            MouseDown = 0x02,
            MouseClick = 0x04
        }
        public enum TabStyles {
            Normal = 0x00,
            Angled = 0x01,
            Underlined = 0x02
        }

        private void InitializeComponent() {
            this.SuspendLayout();
            // 
            // TabHeaderControl
            // 
            this.Name = "TabHeaderControl";
            this.Size = new System.Drawing.Size(351, 56);
            this.Load += new System.EventHandler(this.TabHeaderControl_Load);
            this.ResumeLayout(false);

        }

        private void TabHeaderControl_Load(object sender, EventArgs e) {

        }
    }
}
