namespace ChartJs.Blazor.ChartJS.Common.Enums
{
    /// <summary>
    /// As per documentation here https://www.chartjs.org/docs/latest/configuration/tooltip.html#position-modes
    /// </summary>
    /// 
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
               
        private TooltipPosition(string stringRep) : base(stringRep) { }
    }
}