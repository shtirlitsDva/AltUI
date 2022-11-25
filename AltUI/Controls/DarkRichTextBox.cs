using System.ComponentModel;
using System.Windows.Forms;
using AltUI.Config;

namespace AltUI.Controls
{
    public class DarkRichTextBox : RichTextBox
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool HasFocus
        {
            get { return Focused; }
        }
        public DarkRichTextBox()
        {
            BackColor = ThemeProvider.Theme.Colors.GreyBackground;
            ForeColor = ThemeProvider.Theme.Colors.LightText;
        }
    }
}