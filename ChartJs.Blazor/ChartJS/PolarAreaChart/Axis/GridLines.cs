namespace ChartJs.Blazor.ChartJS.PolarAreaChart.Axis
{
    using ChartJs.Blazor.Util.Color;
    using System.Collections.Generic;

    /// <summary>
    /// The grid lines sub-config of the <see cref="LinearRadialAxis"/> class.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/axes/cartesian/linear.html </para>
    /// </summary>
    public class GridLines
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="GridLines"/> are displayed or not.
        /// </summary>
        public bool Display { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="GridLines"/> are circular or not.
        /// </summary>
        public bool Circular { get; set; } = false;

        /// <summary>
        /// Gets the color of the grid lines. If specified as an array, the first color applies to the first grid line, the second to the second grid line and so on.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public List<string> Color { get; } = new List<string>();

        /// <summary>
        /// Gets or sets the length and spacing of dashes of the grid lines.
        /// <para>As per documentation here https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash </para>
        /// </summary>
        public int[] BorderDash { get; set; }

        /// <summary>
        /// Gets or sets the offset for the line dashes.
        /// <para>As per documentation here https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineDashOffset </para>
        /// </summary>
        public double BorderDashOffset { get; set; }

        /// <summary>
        /// Gets or sets the stroke width of the grid lines.
        /// </summary>
        public int LineWidth { get; set; } = 1;

        /// <summary>
        /// Gets or sets a value indicating whether the border at the edge between the axis and the chart area is drawn or not.
        /// </summary>
        public bool DrawBorder { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the lines are drawn on the chart area inside the axis lines.
        /// This is useful when there are multiple axes and you need to control which grid lines are drawn.
        /// </summary>
        public bool DrawOnChartArea { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the lines are drawn beside the ticks in the axis area beside the chart.
        /// </summary>
        public bool DrawTicks { get; set; } = true;

        /// <summary>
        /// Gets or sets the length in pixels that the grid lines will draw into the axis area.
        /// </summary>
        public int TickMarkLength { get; set; } = 10;

        /// <summary>
        /// Gets or sets the stroke width of the grid line for the first index (index 0).
        /// </summary>
        public int ZeroLineWidth { get; set; } = 1;

        /// <summary>
        /// Gets or sets the stroke color of the grid line for the first index (index 0).
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string ZeroLineColor { get; set; } = "rgba(0, 0, 0, 0.25)";

        /// <summary>
        /// Gets or sets the length and spacing of dashes of the grid line for the first index (index 0).
        /// <para>As per documentation here https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/setLineDash </para>
        /// </summary>
        public int[] ZeroLineBorderDash { get; set; }

        /// <summary>
        /// Gets or sets the offset for line dashes of the grid line for the first index (index 0).
        /// <para>As per documentation here https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineDashOffset </para>
        /// </summary>
        public double ZeroLineBorderDashOffset { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether grid lines will be shifted to be between labels.
        /// This is set to true for a category scale in a bar chart by default.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public bool OffsetGridLines { get; set; } = false;
    }
}