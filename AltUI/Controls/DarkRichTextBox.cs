using AltUI.Config;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AltUI.Controls
{
    public class DarkRichTextBox : RichTextBox
    {
        public DarkRichTextBox()
        {
            BackColor = ThemeProvider.Theme.Colors.GreyBackground;
            ForeColor = ThemeProvider.Theme.Colors.LightText;
        }
    }
}