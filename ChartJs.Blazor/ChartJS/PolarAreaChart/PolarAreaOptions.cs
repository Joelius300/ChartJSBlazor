using System;
using ChartJs.Blazor.ChartJS.Common;
using ChartJs.Blazor.ChartJS.Common.Properties;

namespace ChartJs.Blazor.ChartJS.PolarAreaChart
{
    /// <summary>
    /// The options-subconfig of a <see cref="PolarAreaChartConfig"/>
    /// </summary>
    public class PolarAreaOptions : BaseChartConfigOptions
    {
        /// <summary>
        /// Gets or sets the starting angle to draw arcs for the first item in a dataset.
        /// </summary>
        public double StartAngle { get; set; } = -0.5 * Math.PI;

        /// <summary>
        /// Gets or sets the animation the chart uses.
        /// </summary>
        public PieDoughnutAnimation Animation { get; set; }
    }
}