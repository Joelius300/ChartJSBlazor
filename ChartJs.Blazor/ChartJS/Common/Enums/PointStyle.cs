
namespace ChartJs.Blazor.ChartJS.Common.Enums
{
    /// <summary>
    /// Specifies the point style.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/configuration/elements.html#point-styles</para>
    /// </summary>
    public class PointStyle : StringEnum
    {
        /// <summary>
        /// The circle point style.
        /// </summary>
        public static PointStyle Circle = new PointStyle("circle");

        /// <summary>
        /// The cross point style.
        /// </summary>
        public static PointStyle Cross = new PointStyle("cross");

        /// <summary>
        /// The crossRot point style.
        /// </summary>
        public static PointStyle CrossRot = new PointStyle("crossRot");

        /// <summary>
        /// The dash point style.
        /// </summary>
        public static PointStyle Dash = new PointStyle("dash");

        /// <summary>
        /// The line point style.
        /// </summary>
        public static PointStyle Line = new PointStyle("line");

        /// <summary>
        /// The rect point style.
        /// </summary>
        public static PointStyle Rect = new PointStyle("rect");

        /// <summary>
        /// The rectRounded point style.
        /// </summary>
        public static PointStyle RectRounded = new PointStyle("rectRounded");

        /// <summary>
        /// The rectRot point style.
        /// </summary>
        public static PointStyle RectRot = new PointStyle("rectRot");

        /// <summary>
        /// The star point style.
        /// </summary>
        public static PointStyle Star = new PointStyle("star");

        /// <summary>
        /// The triangle point style.
        /// </summary>
        public static PointStyle Triangle = new PointStyle("triangle");

        /// <summary>
        /// Creates a new instance of the <see cref="PointStyle"/> class.
        /// </summary>
        /// <param name="stringValue">The <see cref="string"/> value to set.</param>
        private PointStyle(string stringValue) : base(stringValue) { }
    }
}