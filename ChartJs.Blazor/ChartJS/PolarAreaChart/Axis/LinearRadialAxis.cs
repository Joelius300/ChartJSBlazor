using ChartJs.Blazor.ChartJS.Common;

namespace ChartJs.Blazor.ChartJS.PolarAreaChart.Axis
{
    /// <summary>
    /// As per documentation here https://www.chartjs.org/docs/latest/axes/radial/linear.html.
    /// </summary>
    public class LinearRadialAxis
    {
        /// <summary>
        /// Gets or sets the angle lines configuration. Check
        /// <para>As per documentation here https://www.chartjs.org/docs/latest/axes/radial/linear.html#angle-line-options </para>
        /// </summary>
        public AngleLine AngleLines { get; set; }

        /// <summary>
        /// Gets or sets the grid lines configuration.
        /// <para>As per documentation here https://www.chartjs.org/docs/latest/axes/styling.html#grid-line-configuration </para>
        /// </summary>
        public GridLines GridLines { get; set; }

        /// <summary>
        /// Gets or sets the point labels configuration.
        /// <para>As per documentation here https://www.chartjs.org/docs/latest/axes/radial/linear.html#point-label-options </para>
        /// </summary>
        public PointLabels PointLabels { get; set; }

        /// <summary>
        /// Gets or sets the grid lines configuration.
        /// <para>As per documentation here https://www.chartjs.org/docs/latest/axes/radial/linear.html#tick-options </para>
        /// </summary>
        public LinearTick Ticks { get; set; }
    }
}