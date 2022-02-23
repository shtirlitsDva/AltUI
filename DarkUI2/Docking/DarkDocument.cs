using DarkUI2.Config;
using System.ComponentModel;

namespace DarkUI2.Docking
{
    [ToolboxItem(false)]
    public class DarkDocument : DarkDockContent
    {
        #region Property Region

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DarkDockArea DefaultDockArea
        {
            get { return base.DefaultDockArea; }
        }

        #endregion

        #region Constructor Region

        public DarkDocument()
        {
            BackColor = ThemeProvider.Theme.Colors.GreyBackground;
            base.DefaultDockArea = DarkDockArea.Document;
        }

        #endregion
    }
}
