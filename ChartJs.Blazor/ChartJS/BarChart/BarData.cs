using System.Collections.Generic;
using ChartJs.Blazor.ChartJS.MixedChart;

namespace ChartJs.Blazor.ChartJS.BarChart
{
    /// <summary>
    /// The data-subconfig of a <see cref="BarConfig"/>.
    /// </summary>
    public class BarData
    {
        /// <summary>
        /// Creates a new instance of <see cref="BarData"/>
        /// </summary>
        public BarData()
        {
            Datasets = new HashSet<IMixableDataset<object>>();
        }

        /// <summary>
        /// The data sets displayed in this chart.
        /// </summary>
        public HashSet<IMixableDataset<object>> Datasets { get; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        public List<string> Labels { get; set; } = new List<string>();
    }
}
