using Microsoft.Win32;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AltUI.Config
{
    public static class ThemeProvider
    {
        private static ITheme theme;
        public static bool LightMode = (int)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize", "SystemUsesLightTheme", 0) == 1;
        public static bool IsWindows11 = int.Parse((string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentBuild", 0)) >= 22000;
        public static ITheme Theme
        {
            get
            {
                if (LightMode)
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
    public static class RoundRects
    {
        public static GraphicsPath RoundedRect(Rectangle bounds, int radius, bool flatBottom)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            if (flatBottom)
            {
                // bottom line
                PointF br = new PointF(bounds.Right, bounds.Bottom + 1);
                PointF bl = new PointF(bounds.Left, bounds.Bottom + 1);
                path.AddLine(br, bl);
            }
            else
            {       
                // bottom right arc
                arc.Y = bounds.Bottom - diameter;
                path.AddArc(arc, 0, 90);

                // bottom left arc 
                arc.X = bounds.Left;
                path.AddArc(arc, 90, 90);
            }
            path.CloseFigure();
            return path;
        }

        public static void DrawRoundedRectangle(this Graphics graphics, Pen pen, Rectangle bounds, int cornerRadius, bool flatBottom)
        {
            if (graphics == null)
                throw new ArgumentNullException("graphics");
            if (pen == null)
                throw new ArgumentNullException("pen");

            using (GraphicsPath path = RoundedRect(bounds, cornerRadius, flatBottom))
            {
                graphics.DrawPath(pen, path);
            }
        }

        public static void FillRoundedRectangle(this Graphics graphics, Brush brush, Rectangle bounds, int cornerRadius, bool flatBottom)
        {
            if (graphics == null)
                throw new ArgumentNullException("graphics");
            if (brush == null)
                throw new ArgumentNullException("brush");

            using (GraphicsPath path = RoundedRect(bounds, cornerRadius, flatBottom))
            {
                graphics.FillPath(brush, path);
            }
        }
    }

}
