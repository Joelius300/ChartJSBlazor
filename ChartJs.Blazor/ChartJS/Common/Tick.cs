using ChartJs.Blazor.Util.Color;

namespace ChartJs.Blazor.ChartJS.Common
{
    /// <summary>
    /// The base config for the tick-subconfig of a chart.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/axes/styling.html#tick-configuration </para>
    /// </summary>
    public class Tick
    {
        /// <summary>
        /// Gets or sets the value indicating whether this shows tick marks.
        /// </summary>
        public bool Display { get; set; } = true;

        /// <summary>
        /// Gets or sets the font color for tick labels.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// Gets or sets the font family for the tick labels, follows CSS font-family options.
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Gets or sets the font size for the tick labels.
        /// </summary>
        public int FontSize { get; set; } = 12;

        /// <summary>
        /// Gets or sets the font style for the tick labels, follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
        /// </summary>
        public string FontStyle { get; set; }

        /// <summary>
        /// Gets or sets the height of an individual line of text.
        /// <para>As per documentation here https://developer.mozilla.org/en-US/docs/Web/CSS/line-height </para>
        /// </summary>
        public double LineHeight { get; set; } = 1.2;

        /// <summary>
        /// Gets or sets the value indicating whether the order of tick labels is reversed.
        /// </summary>
        public bool Reverse { get; set; } = false;

        /// <summary>
        /// Gets or sets the minor ticks configuration. Omitted options are inherited from options above.
        /// </summary>
        public MinorTick Minor { get; set; }

        /// <summary>
        /// Gets or sets the major ticks configuration. Omitted options are inherited from options above.
        /// </summary>
        public MajorTick Major { get; set; }

        /// <summary>
        /// Gets or sets the offset of the tick labels from the axis
        /// </summary>
        public int Padding { get; set; } = 0;
    }
}