﻿using ChartJs.Blazor.ChartJS.Common;
using ChartJs.Blazor.ChartJS.Common.Properties;
using ChartJs.Blazor.ChartJS.Common.Axes;

namespace ChartJs.Blazor.ChartJS.LineChart
{
    /// <summary>
    /// The options-subconfig of a <see cref="LineConfig"/>
    /// </summary>
    public class LineOptions : BaseConfigOptions
    {
        /// <summary>
        /// General animation time
        /// </summary>
        public Animation Animation { get; set; }

        /// <summary>
        /// Hover options for hovering over an item
        /// </summary>
        public LineOptionsHover Hover { get; set; }

        /// <summary>
        /// The scales for this chart. You can use any <see cref="CartesianAxis"/> for x and y.
        /// </summary>
        public Scales Scales { get; set; }

        /// <summary>
        /// If false, the lines between points are not drawn.
        /// </summary>
        public bool ShowLines { get; set; } = true;

        /// <summary>
        /// If false, NaN data causes a break in the line.
        /// </summary>
        public bool SpanGaps { get; set; } = true;
    }
}