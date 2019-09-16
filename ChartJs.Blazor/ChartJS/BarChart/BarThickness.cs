using ChartJs.Blazor.ChartJS.BarChart.Axes;
using ChartJs.Blazor.ChartJS.Common.Enums;

namespace ChartJs.Blazor.ChartJS.BarChart
{
    /// <summary>
    /// The bar thickness for a <see cref="BarAxis"/>.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/charts/bar.html#barthickness</para>
    /// </summary>
    public class BarThickness : ObjectEnum
    {
        /// <summary>
        ///     Creates a new instance of the <see cref="BarThickness" /> class.
        /// </summary>
        /// <param name="stringValue">The <see cref="string" /> value to set.</param>
        private BarThickness(string stringValue) : base(stringValue) { }

        /// <summary>
        ///     Creates a new instance of the <see cref="BarThickness" /> class.
        /// </summary>
        /// <param name="doubleValue">The <see cref="double" /> value to set.</param>
        public BarThickness(double doubleValue) : base(doubleValue) { }

        /// <summary>
        ///     The bottom border skipped style.
        /// </summary>
        public static BarThickness Flex => new BarThickness("flex");
    }
}
