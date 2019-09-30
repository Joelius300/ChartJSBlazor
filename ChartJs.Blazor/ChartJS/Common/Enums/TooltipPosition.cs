namespace ChartJs.Blazor.ChartJS.Common.Enums
{
    /// <summary>
    /// Specifies position of the tooltips in the chart.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/configuration/tooltip.html#position-modes </para>
    /// </summary>
    public sealed class TooltipPosition : StringEnum
    {
        /// <summary>
        /// When <see cref="TooltipPosition.Average" /> is set, the tooltips will be placed at the average position of the items displayed in the tooltip.
        /// </summary>
        public static TooltipPosition Average => new TooltipPosition("average");

        /// <summary>
        /// When <see cref="TooltipPosition.Nearest" /> is set, the tooltips will be placed at the position of the element closest to the event position.
        /// </summary>
        public static TooltipPosition Nearest => new TooltipPosition("nearest");

        /// <summary>
        /// Creates a new instance of the <see cref="TooltipPosition"/> class.
        /// </summary>
        /// <param name="stringValue">The <see cref="string"/> value to set.</param>
        private TooltipPosition(string stringValue) : base(stringValue) { }
    }
}
