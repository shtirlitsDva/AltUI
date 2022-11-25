using System;
using System.ComponentModel;
using System.Windows.Forms;
using AltUI.Config;

namespace AltUI.Forms
{
    public class DarkForm : Form
    {
        #region Field Region

        private bool _customBorder;

        #endregion

        #region Property Region

        [Category("Appearance")]
        [Description("Determines whether the form's border should be set to the colour of a Control's border.")]
        [DefaultValue(false)]
        public bool CustomBorder
        {
            get { return _customBorder; }
            set
            {
                _customBorder = value;
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

        protected override void OnHandleCreated(EventArgs e)
        {
            ThemeProvider.SetupWindow(Handle, FormBorderStyle == FormBorderStyle.None ? 3 : 2, CustomBorder);
            if (ThemeProvider.TransparencyMode & ThemeProvider.WindowsVersion >= 22000)
            {
                TransparencyKey = BackColor;
                AllowTransparency = true;
            }
            else
            {
                AllowTransparency = false;
            }
            base.OnHandleCreated(e);
        }
    }
}
