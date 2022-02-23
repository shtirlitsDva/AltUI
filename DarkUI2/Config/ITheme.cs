using System.Drawing;

namespace DarkUI2.Config
{
    public interface ITheme
    {
        Sizes Sizes { get; }
        
        Colors Colors { get; }
    }
}
