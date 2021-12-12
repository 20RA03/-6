using System;
using System.Collections.Generic;
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

namespace ПР6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Pair pair = new Pair();
        Pair pair2 = new Pair();
        Pair pair4 = new Pair();
        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pair.One = Convert.ToInt32(OneValue.Text);
                pair.Second = Convert.ToInt32(FourValue.Text);
                pair2.One = Convert.ToInt32(TwoValue.Text);
                pair2.Second = Convert.ToInt32(ThirdValue.Text);
                pair4 = pair.Multiply(pair2);
                if (!pair.Multiply(pair2, out pair4))
                {
                    MessageBox.Show("Проверьте правильность ввода данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                rezult1.Text = pair4.One.ToString();
                rezult2.Text = pair4.Second.ToString();
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №6 Вариант 8. Выполнил студент группы ИСП-34 Ржевский А.М. Использовать класс Pair(пара четных чисел).Разработать операцию инкремента, который действие(а, b) = (а * b, b).Разработать операцию для вычисления произведения 2 пар чисел – (а, b) * (с, d) = (а * c, b * d).", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            OneValue.Clear();
            TwoValue.Clear();
            ThirdValue.Clear();
            FourValue.Clear();
            rezult1.Clear();
            rezult2.Clear();
        }
    }
}
