﻿using System;
using System.Globalization;

namespace ChartJs.Blazor.Util
{
    /// <summary>
    /// Provides useful methods for working with colors. Particularly the conversion from different kinds of C#-colors to string colors which are understood by javascript/css.
    /// </summary>
    public static class ColorUtil
    {
        /// <summary>
        /// Produces a string of the form 'rgba(r, g, b, 1)' with the provided rgb values where the alpha is fixed at 1
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string ColorString(byte r, byte g, byte b)
        {
            return $"rgba({r}, {g}, {b}, 1)";
        }

        /// <summary>
        /// Produces a string of the form '#aabbc' with the provided rgb values
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string ColorHexString(byte r, byte g, byte b)
        {
            return $"#{r:X2}{g:X2}{b:X2}";
        }

        /// <summary>
        /// Produces a string of the form 'rgba(r, g, b, alpha)' with the provided rgb and alpha values
        /// </summary>
        /// <param name="r"></param>
        /// <param name="g"></param>
        /// <param name="b"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public static string ColorString(byte r, byte g, byte b, double alpha)
        {
            return $"rgba({r}, {g}, {b}, {alpha})";
        }

        /// <summary>
        /// Produces a string of the form 'rgba(r, g, b, alpha)' with random values for rgb and alpha
        /// </summary>
        /// <returns></returns>
        public static string RandomColorString()
        {
            var rand = new Random();
            return $"rgba({1 + rand.Next(255)}, {1 + rand.Next(255)}, {1 + rand.Next(255)}, {rand.NextDouble().ToString(CultureInfo.InvariantCulture)})";
        }

        /// <summary>
        /// Generates the corresponding string representation (as hex) of a <see cref="System.Drawing.Color"></see> object.
        /// </summary>
        /// <returns>The string representation as a hex color string</returns>
        public static string FromDrawingColor(System.Drawing.Color color)
        {
            return ColorHexString(color.R, color.G, color.B);
        }
    }
}