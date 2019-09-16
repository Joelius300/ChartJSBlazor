﻿namespace ChartJs.Blazor.ChartJS.Common.Enums
{
    /// <summary>
    /// Specifies the border alignment of a <see cref="PieChart"/> and a <see cref="PolarAreaChart"/>.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/charts/doughnut.html#border-alignment</para>
    /// </summary>
    public class BorderAlign : StringEnum
    {
        /// <summary>
        /// When 'center' is set, the borders of arcs next to each other will overlap. The default value.
        /// </summary>
        public static BorderAlign Center => new BorderAlign("center");

        /// <summary>
        /// When 'inner' is set, it is guaranteed that all the borders are not overlap.
        /// </summary>
        public static BorderAlign Inner => new BorderAlign("inner");

        /// <summary>
        /// Creates a new instance of the <see cref="BorderAlign"/> class.
        /// </summary>
        /// <param name="stringValue">The <see cref="string"/> value to set.</param>
        private BorderAlign(string stringValue) : base(stringValue) { }
    }
}