using AltUI.Config;
using System;
using Microsoft.TeamFoundation.Common.Internal;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace AltUI.Controls
{
    public class DarkListBox : ListBox
    {
        #region Constructor Region

        public DarkListBox()
        {
            BackColor = ThemeProvider.Theme.Colors.LightBackground;
            ForeColor = ThemeProvider.Theme.Colors.LightText;
            BorderStyle = BorderStyle.FixedSingle;
        }
        [DllImport("user32.dll")]
        public static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, RedrawWindowFlags flags);

        [Flags()]
        public enum RedrawWindowFlags : uint
        {
            Invalidate = 0X1,
            InternalPaint = 0X2,
            Erase = 0X4,
            Validate = 0X8,
            NoInternalPaint = 0X10,
            NoErase = 0X20,
            NoChildren = 0X40,
            AllChildren = 0X80,
            UpdateNow = 0X100,
            EraseNow = 0X200,
            Frame = 0X400,
            NoFrame = 0X800
        }

        // Make sure that WS_BORDER is a style, otherwise borders aren't painted at all
        protected override CreateParams CreateParams
        {
            get
            {
                if (DesignMode)
                {
                    return base.CreateParams;
                }
                CreateParams cp = base.CreateParams;
                cp.ExStyle &= (~0x00000200); // WS_EX_CLIENTEDGE
                cp.Style |= 0x00800000; // WS_BORDER
                return cp;
            }
        }

        // During OnResize, call RedrawWindow with Frame|UpdateNow|Invalidate so that the frame is always redrawn accordingly
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (DesignMode)
            {
                RecreateHandle();
            }
            RedrawWindow(this.Handle, IntPtr.Zero, IntPtr.Zero, RedrawWindowFlags.Frame | RedrawWindowFlags.UpdateNow | RedrawWindowFlags.Invalidate);
        }

        // Catch WM_NCPAINT for painting
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_NCPAINT)
            {
                WmNcPaint(ref m);
                return;
            }
            base.WndProc(ref m);
        }

        // Paint the custom frame here
        private void WmNcPaint(ref Message m)
        {
            if (BorderStyle == BorderStyle.None)
            {
                return;
            }
            IntPtr hDC = NativeMethods.GetWindowDC(new HandleRef(this, m.HWnd));
            using (Graphics g = Graphics.FromHdc(hDC))
            {
                Invalidate();
                g.DrawRectangle(new Pen(ThemeProvider.Theme.Colors.GreySelection, 1), new Rectangle(0, 0, Width - 1, Height - 1));
            }
            NativeMethods.ReleaseDC(m.HWnd, hDC);
        }


        #endregion
    }
}