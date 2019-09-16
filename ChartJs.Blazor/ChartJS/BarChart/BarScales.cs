using System.Collections.Generic;
using Newtonsoft.Json;
using ChartJs.Blazor.ChartJS.BarChart.Axes;

namespace ChartJs.Blazor.ChartJS.BarChart
{
    /// <summary>
    /// Defines the scales for bar charts by holding the x and y axes.
    /// </summary>
    public class BarScales
    {
        /// <summary>
        /// Gets or sets the axes on the x coordinate.
        /// </summary>
        [JsonProperty("xAxes")]
        public List<BarAxis> XAxes { get; set; }

        /// <summary>
        /// Gets or sets the axes on the y coordinate.
        /// </summary>
        [JsonProperty("yAxes")]
        public BarAxis[] YAxes { get; set; }
    }
}