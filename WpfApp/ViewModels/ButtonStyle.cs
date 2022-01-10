using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp.ViewModels
{
    public static class ButtonStyle //Изменение названия и цвета границы кнопки
    {
        //Название:

        public static string GetText(DependencyObject obj)
            => (string)obj.GetValue(TextProperty);

        public static void SetText(DependencyObject obj, string value)
            => obj.SetValue(TextProperty, value);

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.RegisterAttached("Text", typeof(string),
                typeof(ButtonStyle), new PropertyMetadata(""));

        // Цвет границы:

        public static string GetStroke(DependencyObject obj)
            => (string)obj.GetValue(StrokeProperty);

        public static void SetStroke(DependencyObject obj, string value)
            => obj.SetValue(StrokeProperty, value);

        public static readonly DependencyProperty StrokeProperty =
            DependencyProperty.RegisterAttached("Stroke", typeof(string),
                typeof(ButtonStyle), new PropertyMetadata(""));

        // Цвет залики:

        public static string GetFill(DependencyObject obj)
            => (string)obj.GetValue(StrokeProperty);

        public static void SetFill(DependencyObject obj, string value)
            => obj.SetValue(FillProperty, value);

        public static readonly DependencyProperty FillProperty =
            DependencyProperty.RegisterAttached("Fill", typeof(string),
                typeof(ButtonStyle), new PropertyMetadata(""));
    }
}
