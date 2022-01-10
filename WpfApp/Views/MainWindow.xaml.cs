using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Window;
        public MainWindow()
        {
            InitializeComponent();
            Window = this;

            foreach (UIElement el in GroupButton.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += ButtonClick;
                }
            }
        }

        // Головной блок
        private void Exit(object sender, RoutedEventArgs e) //Закрыть окно
        {
            Application.Current.Shutdown();
        }

        private void Drag(object sender, RoutedEventArgs e) //Перетаскивание окна
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                MainWindow.Window.DragMove();
            }
        }
        // Головной блок

        private void ButtonClick(Object sender, RoutedEventArgs e)
        {
            string textButton = ((Button)e.OriginalSource).Content.ToString();
            if (textButton == "C")  //Очистка окна от текста
            {
                text_1.Clear();
                text_2.Clear();
            }
            else if (textButton == "CE") //Стирание текста по 1-му знаку
            {
                text_1.Text = text_1.Text.Remove(text_1.Text.Length - 1);
                {
                    if (text_1.Text.Length - 1 < 0)
                    {
                        text_1.Text = "Нажми 'С'!";
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (textButton == "=") // Расчет
            {
                text_2.Text = new DataTable().Compute(text_1.Text, null).ToString();
            }
            else
            {
                text_1.Text += textButton;
            }

        }
    }
}
