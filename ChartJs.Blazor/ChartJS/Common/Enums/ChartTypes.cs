namespace ChartJs.Blazor.ChartJS.Common.Enums
{
    /// <summary>
    /// Defines the chart types.
    /// </summary>
    public sealed class ChartTypes : StringEnum
    {
        /// <summary>
        /// The bar chart type.
        /// </summary>
        public static ChartTypes Bar => new ChartTypes("bar");

        /// <summary>
        /// The horizontal bar chart type.
        /// </summary>
        public static ChartTypes HorizontalBar => new ChartTypes("horizontalBar");

        /// <summary>
        /// The line chart type.
        /// </summary>
        public static ChartTypes Line => new ChartTypes("line");

        /// <summary>
        /// The pie chart type.
        /// </summary>
        public static ChartTypes Pie => new ChartTypes("pie");

        /// <summary>
        /// The doughnut chart type.
        /// </summary>
        public static ChartTypes Doughnut => new ChartTypes("doughnut");

        /// <summary>
        /// The radar chart type.
        /// </summary>
        public static ChartTypes Radar => new ChartTypes("radar");

        /// <summary>
        /// The bubble chart type.
        /// </summary>
        public static ChartTypes Bubble => new ChartTypes("bubble");

        /// <summary>
        /// The polar area chart type.
        /// </summary>
        public static ChartTypes PolarArea => new ChartTypes("polarArea");

        /// <summary>
        /// The scatter chart type.
        /// </summary>
        public static ChartTypes Scatter => new ChartTypes("scatter");

        /// <summary>
        /// Creates a new instance of the <see cref="ChartTypes"/> class.
        /// </summary>
        /// <param name="stringValue">The <see cref="string"/> value to set.</param>
        private ChartTypes(string stringValue) : base(stringValue) { }
    }
}