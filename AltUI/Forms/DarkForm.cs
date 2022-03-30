using System;
using AltUI.Config;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AltUI.Forms
{
    public class DarkForm : Form
    {
        #region Field Region

        private bool _flatBorder;

        #endregion

        #region Property Region

        [Category("Appearance")]
        [Description("Determines whether a single pixel border should be rendered around the form.")]
        [DefaultValue(false)]
        public bool FlatBorder
        {
            get { return _flatBorder; }
            set
            {
                _flatBorder = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructor Region

        public DarkForm()
        {
            BackColor = ThemeProvider.Theme.Colors.GreyBackground;
        }

        #endregion

        #region Paint Region

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            if (!_flatBorder)
                return;

            var g = e.Graphics;

            using (var p = new Pen(ThemeProvider.Theme.Colors.DarkBorder))
            {
                var modRect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, ClientRectangle.Height - 1));
                g.DrawRectangle(p, modRect);
            }
        }

        #endregion

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, uint attr, int[] attrValue, int attrSize);
        protected override void OnHandleCreated(EventArgs e)
        {
            var MSOTOI = Marshal.SizeOf(typeof(int));
            // Round corners (Windows 11 only, mainly here for Borderless forms)
            DwmSetWindowAttribute(Handle, 33, new[] { 2 }, MSOTOI);
            // Apply immersive dark mode if it's used by system
            if (!ThemeProvider.LightMode)
            {
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, MSOTOI);
                // Set Titlebar Font to match DarkTheme
                DwmSetWindowAttribute(Handle, 36, new[] { 0x00D5D5D5 }, MSOTOI);
                // Set Window border to match control border
                DwmSetWindowAttribute(Handle, 34, new[] { 0x00372F2F }, MSOTOI);
                if (ThemeProvider.WindowsVersion < 22523 || !ThemeProvider.TransparencyMode)
                {
                    // Set Window Caption to match background
                    int[] CaptionColour = new[] { ThemeProvider.TransparencyMode ? 0x00202020 : 0x00111010 };
                    DwmSetWindowAttribute(Handle, 35, CaptionColour, MSOTOI);
                }
            }
            // Enable mica effect if transparency is enabled
            if (ThemeProvider.TransparencyMode & ThemeProvider.WindowsVersion >= 22000)
            {
                TransparencyKey = BackColor;
                AllowTransparency = true;
                DwmSetWindowAttribute(Handle, 1029, new[] { 1 }, MSOTOI);
                DwmSetWindowAttribute(Handle, 38, new[] { 2 }, MSOTOI);
            }
        }
    }
}
