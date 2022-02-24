using Microsoft.Win32;

namespace DarkUI2.Config
{
    public class ThemeProvider
    {
        private static ITheme theme;
        public static int LightMode = (int) Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "SystemUsesLightTheme", 1);
        public static ITheme Theme
        {
            get
            {
                if (LightMode == 1)
                    theme = new LightTheme();
                else
                    theme = new DarkTheme();

                return theme;
            }
            set
            {
                theme = value;
            }
        }
    }
}
