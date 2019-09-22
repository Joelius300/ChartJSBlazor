using ChartJs.Blazor.ChartJS.Common.Enums;

namespace ChartJs.Blazor.ChartJS.Common.Properties
{
    // TODO: expand (https://www.chartjs.org/docs/latest/configuration/tooltip.html)
    /// <summary>
    /// Defines how tooltips are displayed
    /// </summary>
    public class Tooltips
    {
        /// <summary>
        /// Sets which elements appear in the tooltip. See <see cref="InteractionMode"/> for details.
        /// </summary>
        public InteractionMode Mode { get; set; }

        /// <summary>
        /// If true, the hover mode only applies when the mouse position intersects an item on the chart.
        /// </summary>
        public bool Intersect { get; set; } = true;

        /// <summary>
        /// Are on-canvas tooltips enabled
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// The mode for positioning the tooltip.
        /// <para>See <see cref="Enums.TooltipPosition"/> for working with tooltip position.</para>
        /// </summary>
        public TooltipPosition Position { get; set; } = TooltipPosition.Average;

        /// <summary>
        /// Background color of the tooltip.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Title font
        /// </summary>
        public string TitleFontFamily { get; set; }

        /// <summary>
        /// Title font size.
        /// </summary>
        public double TitleFontSize { get; set; } = 12;

        /// <summary>
        /// Title font style.
        /// <para>See <see cref="Enums.FontStyle"/> for working with font styles.</para>
        /// </summary>
        public FontStyle TitleFontStyle { get; set; }

        /// <summary>
        /// Title font color.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string TitleFontColor { get; set; }

        /// <summary>
        /// Spacing to add to top and bottom of each title line.
        /// </summary>
        public double TitleSpacing { get; set; } = 2;

        /// <summary>
        /// Spacing to add to top and bottom of each title line.
        /// </summary>
        public double TitleMarginBottom { get; set; } = 6;

        /// <summary>
        /// Body line font.
        /// </summary>
        public string BodyFontFamily { get; set; }

        /// <summary>
        /// Body font size.
        /// </summary>
        public double BodyFontSize { get; set; } = 12;

        /// <summary>
        /// Body font style.
        /// <para>See <see cref="Enums.FontStyle"/> for working with font styles.</para>
        /// </summary>
        public FontStyle BodyFontStyle { get; set; }

        /// <summary>
        /// Body font color.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string BodyFontColor { get; set; }

        /// <summary>
        /// Spacing to add to top and bottom of each tooltip item.
        /// </summary>
        public double BodySpacing { get; set; } = 2;

        /// <summary>
        /// Footer font.
        /// </summary>
        public string FooterFontFamily { get; set; }

        /// <summary>
        /// Footer font size.
        /// </summary>
        public double FooterFontSize { get; set; } = 12;

        /// <summary>
        /// Footer font style.
        /// <para>See <see cref="Enums.FontStyle"/> for working with font styles.</para>
        /// </summary>
        public FontStyle FooterFontStyle { get; set; }

        /// <summary>
        /// Footer font color.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string FooterFontColor { get; set; }

        /// <summary>
        /// Spacing to add to top and bottom of each footer line.
        /// </summary>
        public double FooterSpacing { get; set; } = 2;

        /// <summary>
        /// Margin to add before drawing the footer.
        /// </summary>
        public double FooterMarginTop { get; set; } = 6;

        /// <summary>
        /// Padding to add on left and right of tooltip.
        /// </summary>
        public double XPadding { get; set; } = 6;

        /// <summary>
        /// Padding to add on top and bottom of tooltip.
        /// </summary>
        public double YPadding { get; set; } = 6;

        /// <summary>
        /// Extra distance to move the end of the tooltip arrow away from the tooltip point.
        /// </summary>
        public double CaretPadding { get; set; } = 2;

        /// <summary>
        /// Size, in px, of the tooltip arrow.
        /// </summary>
        public double CaretSize { get; set; } = 5;

        /// <summary>
        /// Radius of tooltip corner curves.
        /// </summary>
        public double CornerRadius { get; set; } = 6;

        /// <summary>
        /// Color to draw behind the colored boxes when multiple items are in the tooltip.
        /// </summary>
        public string MultiKeyBackground { get; set; }

        /// <summary>
        /// If true, color boxes are shown in the tooltip.
        /// </summary>
        public bool DisplayColors { get; set; } = true;

        /// <summary>
        /// Color of the border.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Size of the border.
        /// </summary>
        public double BorderWidth { get; set; } = 0;
    }
}