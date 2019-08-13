using ChartJs.Blazor.Util.Color;

namespace ChartJs.Blazor.ChartJS.Common
{
    /// <summary>
    /// The minor sub-config of a <see cref="Ticks"/>.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/axes/styling.html#minor-tick-configuration </para>
    /// </summary>
    public abstract class MinorTicks
    {
        /// <summary>
        /// Gets or sets the font color for <see cref="Ticks"/> labels.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// Gets or sets the font family for the <see cref="Ticks"/> labels, follows CSS font-family options.
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the font size for the <see cref="Ticks"/> labels.
        /// </summary>
        public int FontSize { get; set; } = 12;

        /// <summary>
        /// Gets or sets the font style for the <see cref="Ticks"/> labels, follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
        /// </summary>
        public string FontStyle { get; set; }

        /// <summary>
        /// Gets or sets the height of an individual line of text.
        /// <para>As per documentation here https://developer.mozilla.org/en-US/docs/Web/CSS/line-height </para>
        /// </summary>
        public double LineHeight { get; set; } = 1.2;
    }
}