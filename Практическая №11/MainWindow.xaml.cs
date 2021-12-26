using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Практическая__11
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

        private void CalculateFirst_Click(object sender, RoutedEventArgs e)
        {
            result.Clear();
            string phrase = "23 2+3 2++3 2+++3 345 567";
            Regex regex = new Regex(@"2(\D{1,})3");
            MatchCollection match = regex.Matches(phrase);
            object[] array = new object[match.Count];
            match.CopyTo(array, 0);
            for (int i = 0; i < match.Count; i++)
            {
                result.Text += match[i] + "  ";
            }
        }

        private void CalculateSecond_Click(object sender, RoutedEventArgs e)
        {
            result.Clear();
            string phrase = "aa aba abba abbba abbbba abbbbba";
            Regex regex = new Regex(@"a(b{1,3})a");
            MatchCollection match = regex.Matches(phrase);
            object[] array = new object[match.Count];
            match.CopyTo(array, 0);
            for (int i = 0; i < match.Count; i++)
            {
                result.Text += match[i] + "  ";
            }
        }

        private void TaskInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("10. Дана строка '23 2+3 2++3 2+++3 345 567'. Напишите регулярное выражение, " +
              "которое найдет строки 2 + 3, 2++3, 2++ + 3, не захватив остальные(+может быть любое количество)" +
              "Дана строка 'aa aba abba abbba abbbba abbbbba'.Напишите регулярное выражение," +
              "которое найдет строки вида aba, в которых 'b' встречается менее 3 - х раз (включительно).", "Задание");
        }

        private void DeveloperInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Харенко Кирилл  ИСП-34", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
