﻿using System.Collections.Generic;
using Newtonsoft.Json;
using ChartJs.Blazor.ChartJS.Common.Axes;

namespace ChartJs.Blazor.ChartJS.BarChart
{
    /// <summary>
    /// Defines the scales for bar charts by holding the x and y axes.
    /// </summary>
    public class BarScales
    {
        /// <summary>
        /// Gets or sets the axes on the x coordinate.
        /// <para>You can use any <see cref="CartesianAxis"/> but there are extended axes in the <see cref="BarChart.Axes"/> namespace which contain additional properties to customize the bar chart axes.</para>        
        /// </summary>
        [JsonProperty("xAxes")]
        public List<CartesianAxis> XAxes { get; set; }

        /// <summary>
        /// Gets or sets the axes on the y coordinate.
        /// <para>You can use any <see cref="CartesianAxis"/> but there are extended axes in the <see cref="BarChart.Axes"/> namespace which contain additional properties to customize the bar chart axes.</para>
        /// </summary>
        [JsonProperty("yAxes")]
        public List<CartesianAxis> YAxes { get; set; }
    }
}