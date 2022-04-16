using AltUI.Config;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AltUI.Controls
{
    public class DarkLabel : Label
    {
        #region Field Region

        private bool _autoUpdateHeight;
        private bool _isGrowing;
        private bool _isEnabled = true;

        #endregion

        #region Property Region

        [Category("Layout")]
        [Description("Enables automatic height sizing based on the contents of the label.")]
        [DefaultValue(false)]
        public bool AutoUpdateHeight
        {
            get { return _autoUpdateHeight; }
            set
            {
                _autoUpdateHeight = value;

                if (_autoUpdateHeight)
                {
                    AutoSize = false;
                    ResizeLabel();
                }
            }
        }

        public new bool AutoSize
        {
            get { return base.AutoSize; }
            set
            {
                base.AutoSize = value;

                if (AutoSize)
                    AutoUpdateHeight = false;
            }
        }
        public new bool Enabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                ForeColor = _isEnabled ? ThemeProvider.Theme.Colors.LightText : ThemeProvider.Theme.Colors.DisabledText;
                ResizeLabel();
            }
        }

        #endregion

        #region Constructor Region

        public DarkLabel()
        {
            BackColor = Color.Transparent;
            ForeColor = ThemeProvider.Theme.Colors.LightText;
            ResizeRedraw = true;
        }

        #endregion

        #region Method Region

        private void ResizeLabel()
        {
            if (!_autoUpdateHeight || _isGrowing)
                return;

            try
            {
                _isGrowing = true;
                var sz = new Size(Width, int.MaxValue);
                sz = TextRenderer.MeasureText(Text, Font, sz, TextFormatFlags.WordBreak);
                Height = sz.Height + Padding.Vertical;
            }
            finally
            {
                _isGrowing = false;
            }
        }

        #endregion

        #region Event Handler Region

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            ResizeLabel();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            ResizeLabel();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ResizeLabel();
        }

        #endregion
    }
}