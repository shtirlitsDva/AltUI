using System.Drawing;

namespace DarkUI2.Config
{
    public class DarkTheme : ITheme
    {
        public Sizes Sizes { get; } = new Sizes();

        public Colors Colors { get; } = new Colors();

        public DarkTheme()
        {
            Colors.GreyBackground = Color.FromArgb(31, 31, 31);
            Colors.HeaderBackground = Color.FromArgb(57, 60, 62);
            Colors.BlueBackground = Color.FromArgb(66, 77, 95);
            Colors.DarkBlueBackground = Color.FromArgb(52, 57, 66);
            Colors.DarkBackground = Color.FromArgb(43, 43, 43);
            Colors.MediumBackground = Color.FromArgb(49, 51, 53);
            Colors.LightBackground = Color.FromArgb(46, 46, 46);
            Colors.LighterBackground = Color.FromArgb(61, 61, 61);
            Colors.LightestBackground = Color.FromArgb(230, 230, 230);
            Colors.LightBorder = Color.FromArgb(81, 81, 81);
            Colors.DarkBorder = Color.FromArgb(32, 32, 32);
            Colors.LightText = Color.FromArgb(255, 255, 255);
            Colors.DisabledText = Color.FromArgb(122, 122, 122);
            Colors.BlueHighlight = Color.FromArgb(57, 135, 214);
            Colors.BlueSelection = Color.FromArgb(38, 79, 120);
            Colors.GreyHighlight = Color.FromArgb(122, 128, 132);
            Colors.GreySelection = Color.FromArgb(92, 92, 92);
            Colors.DarkGreySelection = Color.FromArgb(82, 82, 82);
            Colors.DarkBlueBorder = Color.FromArgb(51, 61, 78);
            Colors.LightBlueBorder = Color.FromArgb(86, 97, 114);
            Colors.ActiveControl = Color.FromArgb(159, 178, 196);

            Sizes.Padding = 10;
            Sizes.ScrollBarSize = 15;
            Sizes.ArrowButtonSize = 15;
            Sizes.MinimumThumbSize = 11;
            Sizes.CheckBoxSize = 12;
            Sizes.RadioButtonSize = 12;
            Sizes.ToolWindowHeaderSize = 25;
            Sizes.DocumentTabAreaSize = 24;
            Sizes.ToolWindowTabAreaSize = 21;

        }
    }
}
