namespace ChartJs.Blazor.ChartJS.Common.Enums
{
    /// <summary>
    /// Specifies the border join style.
    /// <para>As per documentation here https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineJoin</para>
    /// </summary>
    public class BorderJoinStyle : StringEnum
    {
        /// <summary>
        /// The bevel border join style.
        /// </summary>
        public static BorderJoinStyle Bevel => new BorderJoinStyle("bevel");

        /// <summary>
        /// The round border join style.
        /// </summary>
        public static BorderJoinStyle Round => new BorderJoinStyle("round");

        /// <summary>
        /// The miter border join style.
        /// </summary>
        public static BorderJoinStyle Miter => new BorderJoinStyle("miter");

        /// <summary>
        /// Creates a new instance of the <see cref="BorderJoinStyle"/> class.
        /// </summary>
        /// <param name="stringValue">The <see cref="string"/> value to set.</param>
        private BorderJoinStyle(string stringValue) : base(stringValue) { }
    }
}
