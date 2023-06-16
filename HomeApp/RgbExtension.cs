using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp
{
    public class RgbExtension : IMarkupExtension
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            // Генерация цвета по цифровым значениям (красный, зеленый, синий)
            return Color.FromRgb(Red, Green, Blue);
        }
    }
}