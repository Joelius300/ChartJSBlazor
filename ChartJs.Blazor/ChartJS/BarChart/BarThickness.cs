﻿using ChartJs.Blazor.ChartJS.BarChart.Axes;
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
        private BarThickness(double doubleValue) : base(doubleValue) { }

        /// <summary>
        /// Gets a <see cref="BarThickness"/> from a <see cref="double"/> value.
        /// </summary>
        /// <param name="thickness">The thickness to use.</param>
        /// <returns>A <see cref="BarThickness"/> from a <see cref="double"/> value.</returns>
        public static BarThickness Absolute(double thickness) => new BarThickness(thickness);

        /// <summary>
        /// Converts the <see cref="double"/> value to a <see cref="BarThickness"/> value.
        /// </summary>
        /// <param name="thickness">The thickness value to set.</param>
        public static implicit operator BarThickness(double thickness) => new BarThickness(thickness);

        /// <summary>
        ///     The bottom border skipped style.
        /// </summary>
        public static BarThickness Flex => new BarThickness("flex");
    }
}