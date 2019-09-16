namespace ChartJs.Blazor.ChartJS.Common.Enums
{
    /// <summary>
    /// Specifies the font style of axes.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/axes/labelling.html</para>
    /// </summary>
    public class FontStyle : StringEnum
    {
        /// <summary>
        /// The normal font style.
        /// </summary>
        public static FontStyle Normal => new FontStyle("normal");

        /// <summary>
        /// The italic font style.
        /// </summary>
        public static FontStyle Italic => new FontStyle("italic");

        /// <summary>
        /// The oblique font style.
        /// </summary>
        public static FontStyle Oblique => new FontStyle("oblique");

        /// <summary>
        /// The initial font style.
        /// </summary>
        public static FontStyle Initial => new FontStyle("initial");

        /// <summary>
        /// The inherit font style.
        /// </summary>
        public static FontStyle Inherit => new FontStyle("inherit");

        /// <summary>
        /// Creates a new instance of the <see cref="FontStyle"/> class.
        /// </summary>
        /// <param name="stringValue">The <see cref="string"/> value to set.</param>
        private FontStyle(string stringValue) : base(stringValue) { }
    }
}
