﻿using ChartJs.Blazor.Charts;
using ChartJs.Blazor.ChartJS.Common;

namespace ChartJs.Blazor.ChartJS.BarChart.Axes
{
    /// <summary>
    /// The bar axis for a <see cref="ChartJsBarChart"/>.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/charts/bar.html#scale-configuration</para>
    /// </summary>
    public class BarAxis
    {
        /// <summary>
        /// Creates a new instance of the <see cref="BarAxis"/> class.
        /// </summary>
        public BarAxis()
        {
            GridLines = new GridLines();
        }

        /// <summary>
        /// Gets or sets the percentage (0-1) of the available width each bar should be within the category width.
        /// 1.0 will take the whole category width and put the bars right next to each other.
        /// </summary>
        public double BarPercentage { get; set; } = 0.9;

        /// <summary>
        /// Gets or sets the percentage (0-1) of the available width each category should be within the sample width.
        /// </summary>
        public double CategoryPercentage { get; set; } = 0.8;

        /// <summary>
        /// Gets or sets the width of each bar in pixels.
        /// If set to 'flex', it computes "optimal" sample widths that globally arrange bars side by side. If not set (default), bars are equally sized based on the smallest interval.
        /// </summary>
        public BarThickness BarThickness { get; set; }

        /// <summary>
        /// Gets or sets the maximum bar thickness.
        /// Set this to ensure that bars are not sized thicker than this.
        /// </summary>
        public double MaxBarThickness { get; set; }

        /// <summary>
        /// Gets or sets the minimum bar length.
        /// Set this to ensure that bars have a minimum length in pixels.
        /// </summary>
        public double MinBarLength { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether grid lines will be shifted to be between labels or not.
        /// If <c>true</c>, the bars for a particular data point fall between the grid lines.
        /// The grid line will move to the left by one half of the tick interval.
        /// If <c>false</c>, the grid line will go right down the middle of the bars.
        /// </summary>
        public bool OffsetGridLines
        {
            get => GridLines.OffsetGridLines;
            set => GridLines.OffsetGridLines = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the bar chart is stacked or not.
        /// Bar charts can be configured into stacked bar charts by changing the settings on the X and Y axes to enable stacking.
        /// Stacked bar charts can be used to show how one data series is made up of a number of smaller pieces.
        /// <para>As per documentation here https://www.chartjs.org/docs/latest/charts/bar.html#stacked-bar-chart </para>
        /// </summary>
        public bool Stacked { get; set; } = false;

        /// <summary>
        /// Gets or sets the grid lines.
        /// </summary>
        private GridLines GridLines { get; set; }
    }
}