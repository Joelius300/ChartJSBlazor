namespace ChartJs.Blazor.ChartJS.Common.Enums
{
    /// <summary>
    /// Specifies the border cap style.
    /// <para>As per documentation here https://developer.mozilla.org/en-US/docs/Web/API/CanvasRenderingContext2D/lineCap</para>
    /// </summary>
    public class BorderCapStyle: StringEnum
    {
        /// <summary>
        /// The butt border cap style.
        /// </summary>
        public static BorderCapStyle Butt => new BorderCapStyle("butt");

        /// <summary>
        /// The round border cap style.
        /// </summary>
        public static BorderCapStyle Round => new BorderCapStyle("round");

        /// <summary>
        /// The square border cap style.
        /// </summary>
        public static BorderCapStyle Square => new BorderCapStyle("square");

        /// <summary>
        /// Creates a new instance of the <see cref="BorderCapStyle"/> class.
        /// </summary>
        /// <param name="stringValue">The <see cref="string"/> value to set.</param>
        private BorderCapStyle(string stringValue) : base(stringValue) { }
    }
}
