using System.Drawing;

namespace AltUI.Config
{
    public interface ITheme
    {
        Sizes Sizes { get; }
        
        Colors Colors { get; }
    }
}
