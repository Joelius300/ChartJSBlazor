using System;
using System.Collections.Generic;
using ChartJs.Blazor.ChartJS.Common;
using ChartJs.Blazor.ChartJS.Common.Enums;
using ChartJs.Blazor.ChartJS.MixedChart;
using Newtonsoft.Json;

namespace ChartJs.Blazor.ChartJS.BarChart
{
    /// <summary>
    /// A base dataset for a <see cref="Charts.ChartJsBarChart"/>.
    /// </summary>
    /// <typeparam name="TData">Defines the type of data in this dataset. Use Wrappers from <see cref="Common.Wrappers"/> for value types.</typeparam>
    public class BaseBarDataset<TData> : BaseMixableDataset<TData> where TData : class
    {
        /// <summary>
        /// Creates a new instance of the <see cref="BaseBarDataset{TData}"/> class.
        /// </summary>
        /// <param name="data">The data to initialize the chart with.</param>
        public BaseBarDataset(IEnumerable<TData> data) : this()
        {
            this.AddRange(data);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="BaseBarDataset{TData}"/> class.
        /// </summary>
        public BaseBarDataset() { }

        /// <summary>
        /// Gets or sets the chart type. <see cref="ChartType.Bar"/> in this case. This is needed for mixed datasets only.
        /// </summary>
        public override ChartType Type => ChartType.Bar;

        /// <summary>
        /// Gets or sets a value to avoid drawing the bar stroke at the base of the fill.
        /// In general, this does not need to be changed except when creating chart types that derive from a bar chart.
        /// </summary>
        public IndexableOption<BorderSkipped> BorderSkipped { get; set; }

        /// <summary>
        /// Gets or sets the label for the dataset which appears in the legend and tooltips.
        /// </summary>
        public string Label { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ID of the x axis to plot this dataset on. If not specified, this defaults to the ID of the first found x axis.
        /// </summary>
        [JsonProperty("xAxisID")]
        public string XAxisId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the y axis to plot this dataset on. If not specified, this defaults to the ID of the first found y axis.
        /// </summary>
        [JsonProperty("yAxisID")]
        public string YAxisId { get; set; }

        /// <summary>
        /// Gets or sets the id of the group to which this dataset belongs to (when stacked, each group will be a separate stack).
        /// <para>
        /// Specific for stacked bar charts.
        /// </para>
        /// </summary>
        public string Stack { get; set; } = Guid.NewGuid().ToString();
    }
}