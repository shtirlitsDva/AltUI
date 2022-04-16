using AltUI.Config;
using Microsoft.TeamFoundation.Common.Internal;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace AltUI.Controls
{
    public class DarkTextBox : TextBox
    {
        #region Constructor Region

        public DarkTextBox()
        {
            BackColor = ThemeProvider.Theme.Colors.LightBackground;
            ForeColor = ThemeProvider.Theme.Colors.LightText;
            Padding = new Padding(2, 2, 2, 2);
            BorderStyle = BorderStyle.FixedSingle;
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == NativeMethods.WM_PAINT)
            {
                OnWmPaint();
            }
        }

        private void OnWmPaint()
        {
            using (Graphics g = CreateGraphics())
            {
                RoundRects.DrawCustomBorder(g, new Rectangle(0, 0, Width, Height), 4);
            }
        }

        #endregion
    }
}
