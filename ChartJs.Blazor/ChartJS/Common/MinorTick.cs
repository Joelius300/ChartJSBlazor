using ChartJs.Blazor.Util.Color;

namespace ChartJs.Blazor.ChartJS.Common
{
    /// <summary>
    /// The minor sub-config of a <see cref="Tick"/>.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/axes/styling.html#minor-tick-configuration </para>
    /// </summary>
    public class MinorTick
    {
        /// <summary>
        /// Gets or sets the font color for tick labels.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string FontColor { get; set; } = "#666";

        /// <summary>
        /// Gets or sets the font family for the tick labels, follows CSS font-family options.
        /// </summary>
        public string FontFamily { get; set; } = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";

        /// <summary>
        /// Gets or sets the font size for the tick labels.
        /// </summary>
        public int FontSize { get; set; } = 12;

        /// <summary>
        /// Gets or sets the font style for the tick labels, follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
        /// </summary>
        public string FontStyle { get; set; } = "normal";

        /// <summary>
        /// Gets or sets the height of an individual line of text.
        /// <para>As per documentation here https://developer.mozilla.org/en-US/docs/Web/CSS/line-height </para>
        /// </summary>
        public double LineHeight { get; set; } = 1.2;
    }
}