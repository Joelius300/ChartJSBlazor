using ChartJs.Blazor.Util;
using ChartJs.Blazor.ChartJS.Common;

namespace ChartJs.Blazor.ChartJS.BarChart
{
    /// <summary>
    /// A dataset for a <see cref="Charts.ChartJsBarChart"/>.
    /// </summary>
    /// <para>As per documentation here: http://www.chartjs.org/docs/latest/charts/bar.html#dataset-properties.</para>
    /// <typeparam name="TData">Defines the type of data in this dataset. Use Wrappers from <see cref="Common.Wrappers"/> for value types.</typeparam>
    public class BarDataset<TData> : BaseBarDataset<TData> where TData : class
    {
        /// <summary>
        /// Gets or sets the fill color of the bars in the dataset.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public IndexableOption<string> BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the border color of the bars in the dataset.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public IndexableOption<string> BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the border width of the bars in the dataset.
        /// </summary>
        public IndexableOption<int> BorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the fill colour of the bars when hovered.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public IndexableOption<string> HoverBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the stroke colour of the bars when hovered.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public IndexableOption<string> HoverBorderColor { get; set; }

        /// <summary>
        /// Gets or sets the stroke width of the bars when hovered.
        /// </summary>
        public IndexableOption<int> HoverBorderWidth { get; set; }
    }
}