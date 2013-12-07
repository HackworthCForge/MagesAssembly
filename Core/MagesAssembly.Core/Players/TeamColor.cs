
namespace MagesAssembly.Core.Players
{
    public class TeamColor
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamColor"/> struct.
        /// </summary>
        /// <param name="r">The red channel.</param>
        /// <param name="g">The green channel.</param>
        /// <param name="b">The blue channel.</param>
        public TeamColor(int r, int g, int b)
        {
            if ((((r | g) | b) & -256) != 0)
            {
                r = r < 0 ? 0 : (r > 255 ? 255 : r);
                g = g < 0 ? 0 : (g > 255 ? 255 : g);
                b = b < 0 ? 0 : (b > 255 ? 255 : b);
            }

            this._packedValue = ((r | g << 8) | b << 16) | -16777216;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamColor"/> struct.
        /// </summary>
        /// <param name="r">The red channel.</param>
        /// <param name="g">The green channel.</param>
        /// <param name="b">The blue channel.</param>
        /// <param name="a">The alpha channel.</param>
        public TeamColor(int r, int g, int b, int a)
        {
            if (((((r | g) | b) | a) & -256) != 0)
            {
                r = r < 0 ? 0 : (r > 255 ? 255 : r);
                g = g < 0 ? 0 : (g > 255 ? 255 : g);
                b = b < 0 ? 0 : (b > 255 ? 255 : b);
                a = a < 0 ? 0 : (a > 255 ? 255 : a);
            }

            this._packedValue = ((r | g << 8) | b << 16) | a << 24;
        }
        /// <summary>
        /// Prevents a default instance of the <see cref="TeamColor"/> struct from being created.
        /// </summary>
        /// <param name="packedValue">The packed value.</param>
        private TeamColor(int packedValue)
        {
            this._packedValue = packedValue;
        }
        #endregion

        #region Fields
        internal int _packedValue;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the packed value.
        /// </summary>
        public int PackedValue
        {
            get { return this._packedValue; }
            set { this._packedValue = value; }
        }
        /// <summary>
        /// Gets or sets the red channel.
        /// </summary>
        public byte R
        {
            get { return (byte)this._packedValue; }
            set { this._packedValue = (int)(this._packedValue & 0xffffff00) | value; }
        }
        /// <summary>
        /// Gets or sets the green channel.
        /// </summary>
        public byte G
        {
            get { return (byte)(this._packedValue >> 8); }
            set { this._packedValue = (int)(this._packedValue & 0xffff00ff) | (value << 8); }
        }
        /// <summary>
        /// Gets or sets the blue channel.
        /// </summary>
        public byte B
        {
            get { return (byte)(this._packedValue >> 0x10); }
            set { this._packedValue = (int)(this._packedValue & 0xff00ffff) | (value << 16); }
        }
        /// <summary>
        /// Gets or sets the alpha channel.
        /// </summary>
        public byte A
        {
            get { return (byte)(this._packedValue >> 0x18); }
            set { this._packedValue = (this._packedValue & 0xffffff) | (value << 24); }
        }

        #endregion Properties

        #region Pre-defined colors


        public static TeamColor AliceBlue
        {
            get { return new TeamColor(240, 248, 255, 255); }
        }
        public static TeamColor AntiqueWhite
        {
            get { return new TeamColor(250, 235, 215, 255); }
        }
        public static TeamColor Aqua
        {
            get { return new TeamColor(0, 255, 255, 255); }
        }
        public static TeamColor Aquamarine
        {
            get { return new TeamColor(127, 255, 212, 255); }
        }
        public static TeamColor Azure
        {
            get { return new TeamColor(240, 255, 255, 255); }
        }
        public static TeamColor Beige
        {
            get { return new TeamColor(245, 245, 220, 255); }
        }
        public static TeamColor Bisque
        {
            get { return new TeamColor(255, 228, 196, 255); }
        }
        public static TeamColor Black
        {
            get { return new TeamColor(0, 0, 0, 255); }
        }
        public static TeamColor BlanchedAlmond
        {
            get { return new TeamColor(255, 235, 205, 255); }
        }
        public static TeamColor Blue
        {
            get { return new TeamColor(0, 0, 255, 255); }
        }
        public static TeamColor BlueViolet
        {
            get { return new TeamColor(138, 43, 226, 255); }
        }
        public static TeamColor Brown
        {
            get { return new TeamColor(165, 42, 42, 255); }
        }
        public static TeamColor BurlyWood
        {
            get { return new TeamColor(222, 184, 135, 255); }
        }
        public static TeamColor CadetBlue
        {
            get { return new TeamColor(95, 158, 160, 255); }
        }
        public static TeamColor Chartreuse
        {
            get { return new TeamColor(127, 255, 0, 255); }
        }
        public static TeamColor Chocolate
        {
            get { return new TeamColor(210, 105, 30, 255); }
        }
        public static TeamColor Coral
        {
            get { return new TeamColor(255, 127, 80, 255); }
        }
        public static TeamColor CornflowerBlue
        {
            get { return new TeamColor(100, 149, 237, 255); }
        }
        public static TeamColor Cornsilk
        {
            get { return new TeamColor(255, 248, 220, 255); }
        }
        public static TeamColor Crimson
        {
            get { return new TeamColor(220, 20, 60, 255); }
        }
        public static TeamColor Cyan
        {
            get { return new TeamColor(0, 255, 255, 255); }
        }
        public static TeamColor DarkBlue
        {
            get { return new TeamColor(0, 0, 139, 255); }
        }
        public static TeamColor DarkCyan
        {
            get { return new TeamColor(0, 139, 139, 255); }
        }
        public static TeamColor DarkGoldenrod
        {
            get { return new TeamColor(184, 134, 11, 255); }
        }
        public static TeamColor DarkGray
        {
            get { return new TeamColor(169, 169, 169, 255); }
        }
        public static TeamColor DarkGreen
        {
            get { return new TeamColor(0, 100, 0, 255); }
        }
        public static TeamColor DarkKhaki
        {
            get { return new TeamColor(189, 183, 107, 255); }
        }
        public static TeamColor DarkMagenta
        {
            get { return new TeamColor(139, 0, 139, 255); }
        }
        public static TeamColor DarkOliveGreen
        {
            get { return new TeamColor(85, 107, 47, 255); }
        }
        public static TeamColor DarkOrange
        {
            get { return new TeamColor(255, 140, 0, 255); }
        }
        public static TeamColor DarkOrchid
        {
            get { return new TeamColor(153, 50, 204, 255); }
        }
        public static TeamColor DarkRed
        {
            get { return new TeamColor(139, 0, 0, 255); }
        }
        public static TeamColor DarkSalmon
        {
            get { return new TeamColor(233, 150, 122, 255); }
        }
        public static TeamColor DarkSeaGreen
        {
            get { return new TeamColor(143, 188, 139, 255); }
        }
        public static TeamColor DarkSlateBlue
        {
            get { return new TeamColor(72, 61, 139, 255); }
        }
        public static TeamColor DarkSlateGray
        {
            get { return new TeamColor(47, 79, 79, 255); }
        }
        public static TeamColor DarkTurquoise
        {
            get { return new TeamColor(0, 206, 209, 255); }
        }
        public static TeamColor DarkViolet
        {
            get { return new TeamColor(148, 0, 211, 255); }
        }
        public static TeamColor DeepPink
        {
            get { return new TeamColor(255, 20, 147, 255); }
        }
        public static TeamColor DeepSkyBlue
        {
            get { return new TeamColor(0, 191, 255, 255); }
        }
        public static TeamColor DimGray
        {
            get { return new TeamColor(105, 105, 105, 255); }
        }
        public static TeamColor DodgerBlue
        {
            get { return new TeamColor(30, 144, 255, 255); }
        }
        public static TeamColor Firebrick
        {
            get { return new TeamColor(178, 34, 34, 255); }
        }
        public static TeamColor FloralWhite
        {
            get { return new TeamColor(255, 250, 240, 255); }
        }
        public static TeamColor ForestGreen
        {
            get { return new TeamColor(34, 139, 34, 255); }
        }
        public static TeamColor Fuchsia
        {
            get { return new TeamColor(255, 0, 255, 255); }
        }
        public static TeamColor Gainsboro
        {
            get { return new TeamColor(220, 220, 220, 255); }
        }
        public static TeamColor GhostWhite
        {
            get { return new TeamColor(248, 248, 255, 255); }
        }
        public static TeamColor Gold
        {
            get { return new TeamColor(255, 215, 0, 255); }
        }
        public static TeamColor Goldenrod
        {
            get { return new TeamColor(218, 165, 32, 255); }
        }
        public static TeamColor Gray
        {
            get { return new TeamColor(128, 128, 128, 255); }
        }
        public static TeamColor Green
        {
            get { return new TeamColor(0, 128, 0, 255); }
        }
        public static TeamColor GreenYellow
        {
            get { return new TeamColor(173, 255, 47, 255); }
        }
        public static TeamColor Honeydew
        {
            get { return new TeamColor(240, 255, 240, 255); }
        }
        public static TeamColor HotPink
        {
            get { return new TeamColor(255, 105, 180, 255); }
        }
        public static TeamColor IndianRed
        {
            get { return new TeamColor(205, 92, 92, 255); }
        }
        public static TeamColor Indigo
        {
            get { return new TeamColor(75, 0, 130, 255); }
        }
        public static TeamColor Ivory
        {
            get { return new TeamColor(255, 255, 240, 255); }
        }
        public static TeamColor Khaki
        {
            get { return new TeamColor(240, 230, 140, 255); }
        }
        public static TeamColor Lavender
        {
            get { return new TeamColor(230, 230, 250, 255); }
        }
        public static TeamColor LavenderBlush
        {
            get { return new TeamColor(255, 240, 245, 255); }
        }
        public static TeamColor LawnGreen
        {
            get { return new TeamColor(124, 252, 0, 255); }
        }
        public static TeamColor LemonChiffon
        {
            get { return new TeamColor(255, 250, 205, 255); }
        }
        public static TeamColor LightBlue
        {
            get { return new TeamColor(173, 216, 230, 255); }
        }
        public static TeamColor LightCoral
        {
            get { return new TeamColor(240, 128, 128, 255); }
        }
        public static TeamColor LightCyan
        {
            get { return new TeamColor(224, 255, 255, 255); }
        }
        public static TeamColor LightGoldenrodYellow
        {
            get { return new TeamColor(250, 250, 210, 255); }
        }
        public static TeamColor LightGray
        {
            get { return new TeamColor(211, 211, 211, 255); }
        }
        public static TeamColor LightGreen
        {
            get { return new TeamColor(144, 238, 144, 255); }
        }
        public static TeamColor LightPink
        {
            get { return new TeamColor(255, 182, 193, 255); }
        }
        public static TeamColor LightSalmon
        {
            get { return new TeamColor(255, 160, 122, 255); }
        }
        public static TeamColor LightSeaGreen
        {
            get { return new TeamColor(32, 178, 170, 255); }
        }
        public static TeamColor LightSkyBlue
        {
            get { return new TeamColor(135, 206, 250, 255); }
        }
        public static TeamColor LightSlateGray
        {
            get { return new TeamColor(119, 136, 153, 255); }
        }
        public static TeamColor LightSteelBlue
        {
            get { return new TeamColor(176, 196, 222, 255); }
        }
        public static TeamColor LightYellow
        {
            get { return new TeamColor(255, 255, 224, 255); }
        }
        public static TeamColor Lime
        {
            get { return new TeamColor(0, 255, 0, 255); }
        }
        public static TeamColor LimeGreen
        {
            get { return new TeamColor(50, 205, 50, 255); }
        }
        public static TeamColor Linen
        {
            get { return new TeamColor(250, 240, 230, 255); }
        }
        public static TeamColor Magenta
        {
            get { return new TeamColor(255, 0, 255, 255); }
        }
        public static TeamColor Maroon
        {
            get { return new TeamColor(128, 0, 0, 255); }
        }
        public static TeamColor MediumAquamarine
        {
            get { return new TeamColor(102, 205, 170, 255); }
        }
        public static TeamColor MediumBlue
        {
            get { return new TeamColor(0, 0, 205, 255); }
        }
        public static TeamColor MediumOrchid
        {
            get { return new TeamColor(186, 85, 211, 255); }
        }
        public static TeamColor MediumPurple
        {
            get { return new TeamColor(147, 112, 219, 255); }
        }
        public static TeamColor MediumSeaGreen
        {
            get { return new TeamColor(60, 179, 113, 255); }
        }
        public static TeamColor MediumSlateBlue
        {
            get { return new TeamColor(123, 104, 238, 255); }
        }
        public static TeamColor MediumSpringGreen
        {
            get { return new TeamColor(0, 250, 154, 255); }
        }
        public static TeamColor MediumTurquoise
        {
            get { return new TeamColor(72, 209, 204, 255); }
        }
        public static TeamColor MediumVioletRed
        {
            get { return new TeamColor(199, 21, 133, 255); }
        }
        public static TeamColor MidnightBlue
        {
            get { return new TeamColor(25, 25, 112, 255); }
        }
        public static TeamColor MintCream
        {
            get { return new TeamColor(245, 255, 250, 255); }
        }
        public static TeamColor MistyRose
        {
            get { return new TeamColor(255, 228, 225, 255); }
        }
        public static TeamColor Moccasin
        {
            get { return new TeamColor(255, 228, 181, 255); }
        }
        public static TeamColor NavajoWhite
        {
            get { return new TeamColor(255, 222, 173, 255); }
        }
        public static TeamColor Navy
        {
            get { return new TeamColor(0, 0, 128, 255); }
        }
        public static TeamColor OldLace
        {
            get { return new TeamColor(253, 245, 230, 255); }
        }
        public static TeamColor Olive
        {
            get { return new TeamColor(128, 128, 0, 255); }
        }
        public static TeamColor OliveDrab
        {
            get { return new TeamColor(107, 142, 35, 255); }
        }
        public static TeamColor Orange
        {
            get { return new TeamColor(255, 165, 0, 255); }
        }
        public static TeamColor OrangeRed
        {
            get { return new TeamColor(255, 69, 0, 255); }
        }
        public static TeamColor Orchid
        {
            get { return new TeamColor(218, 112, 214, 255); }
        }
        public static TeamColor PaleGoldenrod
        {
            get { return new TeamColor(238, 232, 170, 255); }
        }
        public static TeamColor PaleGreen
        {
            get { return new TeamColor(152, 251, 152, 255); }
        }
        public static TeamColor PaleTurquoise
        {
            get { return new TeamColor(175, 238, 238, 255); }
        }
        public static TeamColor PaleVioletRed
        {
            get { return new TeamColor(219, 112, 147, 255); }
        }
        public static TeamColor PapayaWhip
        {
            get { return new TeamColor(255, 239, 213, 255); }
        }
        public static TeamColor PeachPuff
        {
            get { return new TeamColor(255, 218, 185, 255); }
        }
        public static TeamColor Peru
        {
            get { return new TeamColor(205, 133, 63, 255); }
        }
        public static TeamColor Pink
        {
            get { return new TeamColor(255, 192, 203, 255); }
        }
        public static TeamColor Plum
        {
            get { return new TeamColor(221, 160, 221, 255); }
        }
        public static TeamColor PowderBlue
        {
            get { return new TeamColor(176, 224, 230, 255); }
        }
        public static TeamColor Purple
        {
            get { return new TeamColor(128, 0, 128, 255); }
        }
        public static TeamColor Red
        {
            get { return new TeamColor(255, 0, 0, 255); }
        }
        public static TeamColor RosyBrown
        {
            get { return new TeamColor(188, 143, 143, 255); }
        }
        public static TeamColor RoyalBlue
        {
            get { return new TeamColor(65, 105, 225, 255); }
        }
        public static TeamColor SaddleBrown
        {
            get { return new TeamColor(139, 69, 19, 255); }
        }
        public static TeamColor Salmon
        {
            get { return new TeamColor(250, 128, 114, 255); }
        }
        public static TeamColor SandyBrown
        {
            get { return new TeamColor(244, 164, 96, 255); }
        }
        public static TeamColor SeaGreen
        {
            get { return new TeamColor(46, 139, 87, 255); }
        }
        public static TeamColor SeaShell
        {
            get { return new TeamColor(255, 245, 238, 255); }
        }
        public static TeamColor Sienna
        {
            get { return new TeamColor(160, 82, 45, 255); }
        }
        public static TeamColor Silver
        {
            get { return new TeamColor(192, 192, 192, 255); }
        }
        public static TeamColor SkyBlue
        {
            get { return new TeamColor(135, 206, 235, 255); }
        }
        public static TeamColor SlateBlue
        {
            get { return new TeamColor(106, 90, 205, 255); }
        }
        public static TeamColor SlateGray
        {
            get { return new TeamColor(112, 128, 144, 255); }
        }
        public static TeamColor Snow
        {
            get { return new TeamColor(255, 250, 250, 255); }
        }
        public static TeamColor SpringGreen
        {
            get { return new TeamColor(0, 255, 127, 255); }
        }
        public static TeamColor SteelBlue
        {
            get { return new TeamColor(70, 130, 180, 255); }
        }
        public static TeamColor Tan
        {
            get { return new TeamColor(210, 180, 140, 255); }
        }
        public static TeamColor Teal
        {
            get { return new TeamColor(0, 128, 128, 255); }
        }
        public static TeamColor Thistle
        {
            get { return new TeamColor(216, 191, 216, 255); }
        }
        public static TeamColor Tomato
        {
            get { return new TeamColor(255, 99, 71, 255); }
        }
        public static TeamColor Transparent
        {
            get { return new TeamColor(0, 0, 0, 0); }
        }
        public static TeamColor Turquoise
        {
            get { return new TeamColor(64, 224, 208, 255); }
        }
        public static TeamColor Violet
        {
            get { return new TeamColor(238, 130, 238, 255); }
        }
        public static TeamColor Wheat
        {
            get { return new TeamColor(245, 222, 179, 255); }
        }
        public static TeamColor White
        {
            get { return new TeamColor(255, 255, 255, 255); }
        }
        public static TeamColor WhiteSmoke
        {
            get { return new TeamColor(245, 245, 245, 255); }
        }
        public static TeamColor Yellow
        {
            get { return new TeamColor(255, 255, 0, 255); }
        }
        public static TeamColor YellowGreen
        {
            get { return new TeamColor(154, 205, 50, 255); }
        }

        #endregion Pre-defined colors
    }
}
