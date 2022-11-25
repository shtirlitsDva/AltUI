using System.Windows.Forms;
using AltUI.Config;

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

        #endregion
    }
}