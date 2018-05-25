// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="Color.cs">
//  Copyright (c) 2003-2018 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Signature.Cloud.Sdk.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Utility class for  serialization
    /// </summary>  
    public class Color
    {
        static Color()
        {
            AliceBlue = new Color("#F0F8FF");
            AntiqueWhite = new Color("#FAEBD7");
            Aqua = new Color("#00FFFF");
            Aquamarine = new Color("#7FFFD4");
            Azure = new Color("#F0FFFF");
            Beige = new Color("#F5F5DC");
            Bisque = new Color("#FFE4C4");
            Black = new Color("#000000");
            BlanchedAlmond = new Color("#FFEBCD");
            Blue = new Color("#0000FF");
            BlueViolet = new Color("#8A2BE2");
            Brown = new Color("#A52A2A");
            BurlyWood = new Color("#DEB887");
            CadetBlue = new Color("#5F9EA0");
            Chartreuse = new Color("#7FFF00");
            Chocolate = new Color("#D2691E");
            Coral = new Color("#FF7F50");
            CornflowerBlue = new Color("#6495ED");
            Cornsilk = new Color("#FFF8DC");
            Crimson = new Color("#DC143C");
            Cyan = new Color("#00FFFF");
            DarkBlue = new Color("#00008B");
            DarkCyan = new Color("#008B8B");
            DarkGoldenrod = new Color("#B8860B");
            DarkGray = new Color("#A9A9A9");
            DarkGreen = new Color("#006400");
            DarkKhaki = new Color("#BDB76B");
            DarkMagenta = new Color("#8B008B");
            DarkOliveGreen = new Color("#556B2F");
            DarkOrange = new Color("#FF8C00");
            DarkOrchid = new Color("#9932CC");
            DarkRed = new Color("#8B0000");
            DarkSalmon = new Color("#E9967A");
            DarkSeaGreen = new Color("#8FBC8B");
            DarkSlateBlue = new Color("#483D8B");
            DarkSlateGray = new Color("#2F4F4F");
            DarkTurquoise = new Color("#00CED1");
            DarkViolet = new Color("#9400D3");
            DeepPink = new Color("#FF1493");
            DeepSkyBlue = new Color("#00BFFF");
            DimGray = new Color("#696969");
            DodgerBlue = new Color("#1E90FF");
            Firebrick = new Color("#B22222");
            FloralWhite = new Color("#FFFAF0");
            ForestGreen = new Color("#228B22");
            Fuchsia = new Color("#FF00FF");
            Gainsboro = new Color("#DCDCDC");
            GhostWhite = new Color("#F8F8FF");
            Gold = new Color("#FFD700");
            Goldenrod = new Color("#DAA520");
            Gray = new Color("#808080");
            Green = new Color("#008000");
            GreenYellow = new Color("#ADFF2F");
            Honeydew = new Color("#F0FFF0");
            HotPink = new Color("#FF69B4");
            IndianRed = new Color("#CD5C5C");
            Indigo = new Color("#4B0082");
            Ivory = new Color("#FFFFF0");
            Khaki = new Color("#F0E68C");
            Lavender = new Color("#E6E6FA");
            LavenderBlush = new Color("#FFF0F5");
            LawnGreen = new Color("#7CFC00");
            LemonChiffon = new Color("#FFFACD");
            LightBlue = new Color("#ADD8E6");
            LightCoral = new Color("#F08080");
            LightCyan = new Color("#E0FFFF");
            LightGoldenrodYellow = new Color("#FAFAD2");
            LightGray = new Color("#D3D3D3");
            LightGreen = new Color("#90EE90");
            LightPink = new Color("#FFB6C1");
            LightSalmon = new Color("#FFA07A");
            LightSeaGreen = new Color("#20B2AA");
            LightSkyBlue = new Color("#87CEFA");
            LightSlateGray = new Color("#778899");
            LightSteelBlue = new Color("#B0C4DE");
            LightYellow = new Color("#FFFFE0");
            Lime = new Color("#00FF00");
            LimeGreen = new Color("#32CD32");
            Linen = new Color("#FAF0E6");
            Magenta = new Color("#FF00FF");
            Maroon = new Color("#800000");
            MediumAquamarine = new Color("#66CDAA");
            MediumBlue = new Color("#0000CD");
            MediumOrchid = new Color("#BA55D3");
            MediumPurple = new Color("#9370DB");
            MediumSeaGreen = new Color("#3CB371");
            MediumSlateBlue = new Color("#7B68EE");
            MediumSpringGreen = new Color("#00FA9A");
            MediumTurquoise = new Color("#48D1CC");
            MediumVioletRed = new Color("#C71585");
            MidnightBlue = new Color("#191970");
            MintCream = new Color("#F5FFFA");
            MistyRose = new Color("#FFE4E1");
            Moccasin = new Color("#FFE4B5");
            NavajoWhite = new Color("#FFDEAD");
            Navy = new Color("#000080");
            OldLace = new Color("#FDF5E6");
            Olive = new Color("#808000");
            OliveDrab = new Color("#6B8E23");
            Orange = new Color("#FFA500");
            OrangeRed = new Color("#FF4500");
            Orchid = new Color("#DA70D6");
            PaleGoldenrod = new Color("#EEE8AA");
            PaleGreen = new Color("#98FB98");
            PaleTurquoise = new Color("#AFEEEE");
            PaleVioletRed = new Color("#DB7093");
            PapayaWhip = new Color("#FFEFD5");
            PeachPuff = new Color("#FFDAB9");
            Peru = new Color("#CD853F");
            Pink = new Color("#FFC0CB");
            Plum = new Color("#DDA0DD");
            PowderBlue = new Color("#B0E0E6");
            Purple = new Color("#800080");
            Red = new Color("#FF0000");
            RosyBrown = new Color("#BC8F8F");
            RoyalBlue = new Color("#4169E1");
            SaddleBrown = new Color("#8B4513");
            Salmon = new Color("#FA8072");
            SandyBrown = new Color("#F4A460");
            SeaGreen = new Color("#2E8B57");
            SeaShell = new Color("#FFF5EE");
            Sienna = new Color("#A0522D");
            Silver = new Color("#C0C0C0");
            SkyBlue = new Color("#87CEEB");
            SlateBlue = new Color("#6A5ACD");
            SlateGray = new Color("#708090");
            Snow = new Color("#FFFAFA");
            SpringGreen = new Color("#00FF7F");
            SteelBlue = new Color("#4682B4");
            Tan = new Color("#D2B48C");
            Teal = new Color("#008080");
            Thistle = new Color("#D8BFD8");
            Tomato = new Color("#FF6347");
            Transparent = new Color("#FFFFFF");
            Turquoise = new Color("#40E0D0");
            Violet = new Color("#EE82EE");
            Wheat = new Color("#F5DEB3");
            White = new Color("#FFFFFF");
            WhiteSmoke = new Color("#F5F5F5");
            Yellow = new Color("#FFFF00");
            YellowGreen = new Color("#9ACD32");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Color"/> class with default values.
        /// </summary>
        public Color()
        {
            this.Web = "#FFFFFF";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Color"/> class with predefined values.
        /// </summary>
        /// <param name="web">String representation web format color</param>
        public Color(string web)
        {
            this.Web = web;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Color"/> class with predefined values.
        /// </summary>
        /// <param name="web">String representation web format color</param>
        /// <param name="alpha">Optional alpha value</param>
        public Color(string web, int? alpha)
        {
            this.Web = web;
            this.Alpha = alpha;
        }
        
        #region Static predefined Colors
        
        /// <summary>
        /// Gets a predefined color that has an ARGB value of AliceBlue or #F0F8FF.
        /// </summary>
        public static Color AliceBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of AntiqueWhite or #FAEBD7.
        /// </summary>
        public static Color AntiqueWhite { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Aqua or #00FFFF.
        /// </summary>
        public static Color Aqua { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Aquamarine or #7FFFD4.
        /// </summary>
        public static Color Aquamarine { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Azure or #F0FFFF.
        /// </summary>
        public static Color Azure { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Beige or #F5F5DC.
        /// </summary>
        public static Color Beige { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Bisque or #FFE4C4.
        /// </summary>
        public static Color Bisque { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Black or #000000.
        /// </summary>
        public static Color Black { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of BlanchedAlmond or #FFEBCD.
        /// </summary>
        public static Color BlanchedAlmond { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Blue or #0000FF.
        /// </summary>
        public static Color Blue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of BlueViolet or #8A2BE2.
        /// </summary>
        public static Color BlueViolet { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Brown or #A52A2A.
        /// </summary>
        public static Color Brown { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of BurlyWood or #DEB887.
        /// </summary>
        public static Color BurlyWood { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of CadetBlue or #5F9EA0.
        /// </summary>
        public static Color CadetBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Chartreuse or #7FFF00.
        /// </summary>
        public static Color Chartreuse { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Chocolate or #D2691E.
        /// </summary>
        public static Color Chocolate { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Coral or #FF7F50.
        /// </summary>
        public static Color Coral { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of CornflowerBlue or #6495ED.
        /// </summary>
        public static Color CornflowerBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Cornsilk or #FFF8DC.
        /// </summary>
        public static Color Cornsilk { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Crimson or #DC143C.
        /// </summary>
        public static Color Crimson { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Cyan or #00FFFF.
        /// </summary>
        public static Color Cyan { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkBlue or #00008B.
        /// </summary>
        public static Color DarkBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkCyan or #008B8B.
        /// </summary>
        public static Color DarkCyan { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkGoldenrod or #B8860B.
        /// </summary>
        public static Color DarkGoldenrod { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkGray or #A9A9A9.
        /// </summary>
        public static Color DarkGray { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkGreen or #006400.
        /// </summary>
        public static Color DarkGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkKhaki or #BDB76B.
        /// </summary>
        public static Color DarkKhaki { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkMagenta or #8B008B.
        /// </summary>
        public static Color DarkMagenta { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkOliveGreen or #556B2F.
        /// </summary>
        public static Color DarkOliveGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkOrange or #FF8C00.
        /// </summary>
        public static Color DarkOrange { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkOrchid or #9932CC.
        /// </summary>
        public static Color DarkOrchid { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkRed or #8B0000.
        /// </summary>
        public static Color DarkRed { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkSalmon or #E9967A.
        /// </summary>
        public static Color DarkSalmon { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkSeaGreen or #8FBC8B.
        /// </summary>
        public static Color DarkSeaGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkSlateBlue or #483D8B.
        /// </summary>
        public static Color DarkSlateBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkSlateGray or #2F4F4F.
        /// </summary>
        public static Color DarkSlateGray { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkTurquoise or #00CED1.
        /// </summary>
        public static Color DarkTurquoise { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DarkViolet or #9400D3.
        /// </summary>
        public static Color DarkViolet { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DeepPink or #FF1493.
        /// </summary>
        public static Color DeepPink { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DeepSkyBlue or #00BFFF.
        /// </summary>
        public static Color DeepSkyBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DimGray or #696969.
        /// </summary>
        public static Color DimGray { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of DodgerBlue or #1E90FF.
        /// </summary>
        public static Color DodgerBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Firebrick or #B22222.
        /// </summary>
        public static Color Firebrick { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of FloralWhite or #FFFAF0.
        /// </summary>
        public static Color FloralWhite { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of ForestGreen or #228B22.
        /// </summary>
        public static Color ForestGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Fuchsia or #FF00FF.
        /// </summary>
        public static Color Fuchsia { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Gainsboro or #DCDCDC.
        /// </summary>
        public static Color Gainsboro { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of GhostWhite or #F8F8FF.
        /// </summary>
        public static Color GhostWhite { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Gold or #FFD700.
        /// </summary>
        public static Color Gold { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Goldenrod or #DAA520.
        /// </summary>
        public static Color Goldenrod { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Gray or #808080.
        /// </summary>
        public static Color Gray { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Green or #008000.
        /// </summary>
        public static Color Green { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of GreenYellow or #ADFF2F.
        /// </summary>
        public static Color GreenYellow { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Honeydew or #F0FFF0.
        /// </summary>
        public static Color Honeydew { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of HotPink or #FF69B4.
        /// </summary>
        public static Color HotPink { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of IndianRed or #CD5C5C.
        /// </summary>
        public static Color IndianRed { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Indigo or #4B0082.
        /// </summary>
        public static Color Indigo { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Ivory or #FFFFF0.
        /// </summary>
        public static Color Ivory { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Khaki or #F0E68C.
        /// </summary>
        public static Color Khaki { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Lavender or #E6E6FA.
        /// </summary>
        public static Color Lavender { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LavenderBlush or #FFF0F5.
        /// </summary>
        public static Color LavenderBlush { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LawnGreen or #7CFC00.
        /// </summary>
        public static Color LawnGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LemonChiffon or #FFFACD.
        /// </summary>
        public static Color LemonChiffon { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightBlue or #ADD8E6.
        /// </summary>
        public static Color LightBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightCoral or #F08080.
        /// </summary>
        public static Color LightCoral { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightCyan or #E0FFFF.
        /// </summary>
        public static Color LightCyan { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightGoldenrodYellow or #FAFAD2.
        /// </summary>
        public static Color LightGoldenrodYellow { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightGrey or #D3D3D3.
        /// </summary>
        public static Color LightGray { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightGreen or #90EE90.
        /// </summary>
        public static Color LightGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightPink or #FFB6C1.
        /// </summary>
        public static Color LightPink { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightSalmon or #FFA07A.
        /// </summary>
        public static Color LightSalmon { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightSeaGreen or #20B2AA.
        /// </summary>
        public static Color LightSeaGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightSkyBlue or #87CEFA.
        /// </summary>
        public static Color LightSkyBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightSlateGray or #778899.
        /// </summary>
        public static Color LightSlateGray { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightSteelBlue or #B0C4DE.
        /// </summary>
        public static Color LightSteelBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LightYellow or #FFFFE0.
        /// </summary>
        public static Color LightYellow { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Lime or #00FF00.
        /// </summary>
        public static Color Lime { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of LimeGreen or #32CD32.
        /// </summary>
        public static Color LimeGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Linen or #FAF0E6.
        /// </summary>
        public static Color Linen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Magenta or #FF00FF.
        /// </summary>
        public static Color Magenta { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Maroon or #800000.
        /// </summary>
        public static Color Maroon { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of MediumAquamarine or #66CDAA.
        /// </summary>
        public static Color MediumAquamarine { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of MediumBlue or #0000CD.
        /// </summary>
        public static Color MediumBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of MediumOrchid or #BA55D3.
        /// </summary>
        public static Color MediumOrchid { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of MediumPurple or #9370DB.
        /// </summary>
        public static Color MediumPurple { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of MediumSeaGreen or #3CB371.
        /// </summary>
        public static Color MediumSeaGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of MediumSlateBlue or #7B68EE.
        /// </summary>
        public static Color MediumSlateBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of MediumSpringGreen or #00FA9A.
        /// </summary>
        public static Color MediumSpringGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of MediumTurquoise or #48D1CC.
        /// </summary>
        public static Color MediumTurquoise { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of MediumVioletRed or #C71585.
        /// </summary>
        public static Color MediumVioletRed { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of MidnightBlue or #191970.
        /// </summary>
        public static Color MidnightBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of MintCream or #F5FFFA.
        /// </summary>
        public static Color MintCream { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of MistyRose or #FFE4E1.
        /// </summary>
        public static Color MistyRose { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Moccasin or #FFE4B5.
        /// </summary>
        public static Color Moccasin { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of NavajoWhite or #FFDEAD.
        /// </summary>
        public static Color NavajoWhite { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Navy or #000080.
        /// </summary>
        public static Color Navy { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of OldLace or #FDF5E6.
        /// </summary>
        public static Color OldLace { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Olive or #808000.
        /// </summary>
        public static Color Olive { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of OliveDrab or #6B8E23.
        /// </summary>
        public static Color OliveDrab { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Orange or #FFA500.
        /// </summary>
        public static Color Orange { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of OrangeRed or #FF4500.
        /// </summary>
        public static Color OrangeRed { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Orchid or #DA70D6.
        /// </summary>
        public static Color Orchid { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of PaleGoldenrod or #EEE8AA.
        /// </summary>
        public static Color PaleGoldenrod { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of PaleGreen or #98FB98.
        /// </summary>
        public static Color PaleGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of PaleTurquoise or #AFEEEE.
        /// </summary>
        public static Color PaleTurquoise { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of PaleVioletRed or #DB7093.
        /// </summary>
        public static Color PaleVioletRed { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of PapayaWhip or #FFEFD5.
        /// </summary>
        public static Color PapayaWhip { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of PeachPuff or #FFDAB9.
        /// </summary>
        public static Color PeachPuff { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Peru or #CD853F.
        /// </summary>
        public static Color Peru { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Pink or #FFC0CB.
        /// </summary>
        public static Color Pink { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Plum or #DDA0DD.
        /// </summary>
        public static Color Plum { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of PowderBlue or #B0E0E6.
        /// </summary>
        public static Color PowderBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Purple or #800080.
        /// </summary>
        public static Color Purple { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Red or #FF0000.
        /// </summary>
        public static Color Red { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of RosyBrown or #BC8F8F.
        /// </summary>
        public static Color RosyBrown { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of RoyalBlue or #4169E1.
        /// </summary>
        public static Color RoyalBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of SaddleBrown or #8B4513.
        /// </summary>
        public static Color SaddleBrown { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Salmon or #FA8072.
        /// </summary>
        public static Color Salmon { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of SandyBrown or #F4A460.
        /// </summary>
        public static Color SandyBrown { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of SeaGreen or #2E8B57.
        /// </summary>
        public static Color SeaGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of SeaShell or #FFF5EE.
        /// </summary>
        public static Color SeaShell { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Sienna or #A0522D.
        /// </summary>
        public static Color Sienna { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Silver or #C0C0C0.
        /// </summary>
        public static Color Silver { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of SkyBlue or #87CEEB.
        /// </summary>
        public static Color SkyBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of SlateBlue or #6A5ACD.
        /// </summary>
        public static Color SlateBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of SlateGray or #708090.
        /// </summary>
        public static Color SlateGray { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Snow or #FFFAFA.
        /// </summary>
        public static Color Snow { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of SpringGreen or #00FF7F.
        /// </summary>
        public static Color SpringGreen { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of SteelBlue or #4682B4.
        /// </summary>
        public static Color SteelBlue { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Tan or #D2B48C.
        /// </summary>
        public static Color Tan { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Teal or #008080.
        /// </summary>
        public static Color Teal { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Thistle or #D8BFD8.
        /// </summary>
        public static Color Thistle { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Tomato or #FF6347.
        /// </summary>
        public static Color Tomato { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Transparent or #FFFFFF.
        /// </summary>
        public static Color Transparent { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Turquoise or #40E0D0.
        /// </summary>
        public static Color Turquoise { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Violet or #EE82EE.
        /// </summary>
        public static Color Violet { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Wheat or #F5DEB3.
        /// </summary>
        public static Color Wheat { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of White or #FFFFFF.
        /// </summary>
        public static Color White { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of WhiteSmoke or #F5F5F5.
        /// </summary>
        public static Color WhiteSmoke { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of Yellow or #FFFF00.
        /// </summary>
        public static Color Yellow { get; private set; }

        /// <summary>
        /// Gets a predefined color that has an ARGB value of YellowGreen or #9ACD32.
        /// </summary>
        public static Color YellowGreen { get; private set; }

        #endregion
        
        /// <summary>
        /// HTML string color representation
        /// </summary>  
        public string Web { get; set; }

        /// <summary>
        /// Alpha component of color structure
        /// </summary>  
        public int? Alpha { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Color {\n");
            sb.Append("  Web: ").Append(this.Web).Append("\n");
            sb.Append("  Alpha: ").Append(this.Alpha).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}