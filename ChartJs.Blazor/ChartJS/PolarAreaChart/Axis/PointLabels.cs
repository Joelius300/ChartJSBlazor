using System.Collections.Generic;

namespace ChartJs.Blazor.ChartJS.PolarAreaChart.Axis
{
    /// <summary>
    /// The point labels sub-config of the <see cref="LinearRadialAxis"/> class.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/axes/radial/linear.html#point-label-options </para>
    /// </summary>
    public class PointLabels
    {
        /// <summary>
        /// Gets the font color for point labels.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public List<string> FontColor { get; } = new List<string>();

        /// <summary>
        /// Gets or sets the font family to use when rendering labels.
        /// </summary>
        public string FontFamily { get; set; } = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";

        /// <summary>
        /// Gets or sets the font size in pixels.
        /// </summary>
        public int FontSize { get; set; } = 10;

        /// <summary>
        /// Gets or sets the font style to use when rendering point labels.
        /// </summary>
        public string FontStyle { get; set; } = "normal";

        /// <summary>
        /// Gets or sets the height of an individual line of text.
        /// /// <para>As per documentation here https://developer.mozilla.org/en-US/docs/Web/CSS/line-height </para>
        /// </summary>
        public string LineHeight { get; set; } = "1.2";
    }
}