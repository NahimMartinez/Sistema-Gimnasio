using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Presentation
{
    public class UITheme
    {
        // Base
        public static readonly Color Primary = Color.FromArgb(33, 150, 243);
        public static readonly Color AccentOrange = Color.FromArgb(249, 115, 22);
        public static readonly Color AccentOrangeAlt = Color.FromArgb(255, 112, 67);
        public static readonly Color Gray = Color.FromArgb(108, 117, 125);
        public static readonly Color Surface = Color.FromArgb(245, 247, 250);
        public static readonly Color SurfaceAlt = Color.White;

        // Textos
        public static class Text
        {
            public static readonly Color Default = Color.FromArgb(33, 37, 41);
            public static readonly Color Muted = Color.FromArgb(73, 80, 87);
            public static readonly Color Inverse = Color.White;
        }

        // Sidebar
        public static class Sidebar
        {
            public static readonly Color Background = Color.FromArgb(15, 23, 42);
            public static readonly Color UserPanel = Color.FromArgb(11, 18, 34);
            public static readonly Color Submenu = Color.FromArgb(21, 31, 56);
            public static readonly Color Brand = AccentOrange;
            public static readonly Color Foreground = Color.White;
        }

        // Botones
        public static class Buttons
        {
            public static readonly Color Save = Primary;
            public static readonly Color Clean = Gray;
            public static readonly Color BrandAction = AccentOrangeAlt; // “Nueva clase”
            public static readonly Color Foreground = Color.White;
        }

        // Tablas
        public static class Grid
        {
            public static readonly Color Alternating = Color.FromArgb(248, 250, 252);
            public static readonly Color Selection = Color.FromArgb(227, 242, 253);
            public static readonly Color GridLines = Color.FromArgb(241, 243, 245);
            public static readonly Color Header = Color.FromArgb(224, 224, 224);
            public static readonly Color Background = Color.White;
        }
    }
}
