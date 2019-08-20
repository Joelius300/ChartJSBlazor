using ChartJs.Blazor.Util.Color;

namespace ChartJs.Blazor.ChartJS.Common
{
    /// <summary>
    /// The major ticks sub-config of the tick-configuration (see <see cref="Ticks"/>).
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/axes/styling.html#major-tick-configuration </para>
    /// </summary>
    public abstract class MajorTicks
    {
        /// <summary>
        /// Gets or sets the value indicating whether these options are used to show major ticks.
        /// </summary>
        public bool Enabled { get; set; } = false;

        /// <summary>
        /// Gets or sets the font color for a tick's label.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// Gets or sets the font family for a tick's label, follows CSS font-family options.
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the font size for a tick's label.
        /// </summary>
        public int FontSize { get; set; } = 12;

        /// <summary>
        /// Gets or sets the font style for a tick's label, follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
        /// </summary>
        public string FontStyle { get; set; }

        /// <summary>
        /// Gets or sets the height of an individual line of text.
        /// <para>As per documentation here https://developer.mozilla.org/en-US/docs/Web/CSS/line-height </para>
        /// </summary>
        public double LineHeight { get; set; } = 1.2;
    }
}