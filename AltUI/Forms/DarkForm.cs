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
        private CornerPreference _cornerPreference;
        public enum CornerPreference { Default, Square, Round, SlightRound }
        #endregion

        #region Property Region

        [Category("Appearance")]
        [Description("Determines whether the form's border should be set to the colour of a Control's border.")]
        [DefaultValue(false)]
        public bool CustomBorder
        {
            get => _customBorder;
            set
            {
                _customBorder = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Determines the \"roundness\" of corners.")]
        [DefaultValue(0)]
        public CornerPreference CornerStyle
        {
            get => _cornerPreference;
            set
            {
                _cornerPreference = value;
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
            var cp = _cornerPreference;
            if (cp == 0) { cp = FormBorderStyle == FormBorderStyle.None ? CornerPreference.SlightRound : CornerPreference.Round; }
            ThemeProvider.SetupWindow(Handle, (int) cp, CustomBorder);
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
