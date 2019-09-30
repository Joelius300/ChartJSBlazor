﻿using ChartJs.Blazor.ChartJS.Common.Enums;

namespace ChartJs.Blazor.ChartJS.Common.Properties
{
    /// <summary>
    /// Defines how tooltips are displayed.
    /// <para>As per documentation here https://www.chartjs.org/docs/latest/configuration/tooltip.html </para>
    /// </summary>
    public class Tooltips
    {
        /// <summary>
        /// Gets or sets which elements appear in the tooltip. See <see cref="InteractionMode"/> for details.
        /// </summary>
        public InteractionMode Mode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the hover mode only applies when the mouse position intersects an item on the chart.
        /// </summary>
        public bool Intersect { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether the tooltips are enabled.
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// Gets or sets the mode for positioning the tooltip.
        /// </summary>
        public TooltipPosition Position { get; set; } = TooltipPosition.Average;

        /// <summary>
        /// Gets or sets the background color of the tooltip.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the title font.
        /// </summary>
        public string TitleFontFamily { get; set; }

        /// <summary>
        /// Gets or sets the title font size.
        /// </summary>
        public double TitleFontSize { get; set; } = 12;

        /// <summary>
        /// Gets or sets the title font style.
        /// </summary>
        public FontStyle TitleFontStyle { get; set; }

        /// <summary>
        /// Gets or sets the title font color.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string TitleFontColor { get; set; }

        /// <summary>
        /// Gets or sets the spacing to add to top and bottom of each title line.
        /// </summary>
        public double TitleSpacing { get; set; } = 2;

        /// <summary>
        /// Gets or sets the spacing to add to top and bottom of each title line.
        /// </summary>
        public double TitleMarginBottom { get; set; } = 6;

        /// <summary>
        /// Gets or sets the body line font.
        /// </summary>
        public string BodyFontFamily { get; set; }

        /// <summary>
        /// Gets or sets the body font size.
        /// </summary>
        public double BodyFontSize { get; set; } = 12;

        /// <summary>
        /// Gets or sets the body font style.
        /// </summary>
        public FontStyle BodyFontStyle { get; set; }

        /// <summary>
        /// Gets or sets the body font color.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string BodyFontColor { get; set; }

        /// <summary>
        /// Gets or sets the spacing to add to top and bottom of each tooltip item.
        /// </summary>
        public double BodySpacing { get; set; } = 2;

        /// <summary>
        /// Gets or sets the footer font.
        /// </summary>
        public string FooterFontFamily { get; set; }

        /// <summary>
        /// Gets or sets the footer font size.
        /// </summary>
        public double FooterFontSize { get; set; } = 12;

        /// <summary>
        /// Gets or sets the footer font style.
        /// </summary>
        public FontStyle FooterFontStyle { get; set; }

        /// <summary>
        /// Gets or sets the footer font color.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string FooterFontColor { get; set; }

        /// <summary>
        /// Gets or sets the spacing to add to top and bottom of each footer line.
        /// </summary>
        public double FooterSpacing { get; set; } = 2;

        /// <summary>
        /// Gets or sets the margin to add before drawing the footer.
        /// </summary>
        public double FooterMarginTop { get; set; } = 6;

        /// <summary>
        /// Gets or sets the padding to add on left and right of tooltip.
        /// </summary>
        public double XPadding { get; set; } = 6;

        /// <summary>
        /// Gets or sets the padding to add on top and bottom of tooltip.
        /// </summary>
        public double YPadding { get; set; } = 6;

        /// <summary>
        /// Gets or sets the extra distance to move the end of the tooltip arrow away from the tooltip point.
        /// </summary>
        public double CaretPadding { get; set; } = 2;

        /// <summary>
        /// Gets or sets the size of the tooltip arrow in pixels.
        /// </summary>
        public double CaretSize { get; set; } = 5;

        /// <summary>
        /// Gets or sets the radius of tooltip corner curves.
        /// </summary>
        public double CornerRadius { get; set; } = 6;

        /// <summary>
        /// Gets or sets the color to draw behind the colored boxes when multiple items are in the tooltip.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string MultiKeyBackground { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether color boxes are shown in the tooltip.
        /// </summary>
        public bool DisplayColors { get; set; } = true;

        /// <summary>
        /// Gets or sets the color of the border.
        /// <para>See <see cref="Util.ColorUtil"/> for working with colors.</para>
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the size of the border.
        /// </summary>
        public double BorderWidth { get; set; } = 0;
    }
}