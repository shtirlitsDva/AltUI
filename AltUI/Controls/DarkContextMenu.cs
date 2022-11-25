using System.Windows.Forms;
using AltUI.Renderers;

namespace AltUI.Controls
{
    public class DarkContextMenu : ContextMenuStrip
    {
        #region Constructor Region

        public DarkContextMenu()
        {
            Renderer = new DarkMenuRenderer();
        }

        #endregion
    }
}
