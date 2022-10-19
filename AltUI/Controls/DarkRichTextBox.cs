using AltUI.Config;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AltUI.Controls
{
    public class DarkRichTextBox : RichTextBox
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool HasFocus
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