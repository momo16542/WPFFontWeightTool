using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFFontWeightTool
{
    class FontWeightTool
    {
        public System.Windows.Size MeasureString(string candidate,double fontsize)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.FontSize = fontsize;
            var formattedText = new FormattedText(
                candidate,
                CultureInfo.CurrentUICulture,
                FlowDirection.LeftToRight,
                new Typeface(textBlock.FontFamily, textBlock.FontStyle, textBlock.FontWeight, textBlock.FontStretch),
                textBlock.FontSize,
                 System.Windows.Media.Brushes.Black);
            var si = new System.Windows.Size(formattedText.Width, formattedText.Height);
            return si;
        }
    }
}
