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

namespace calculatorWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstNumber;
        double secondNumber;
        bool HasTheUserPressedPlus;
        bool HasTheUserPressedMinus;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            this.ScreenTest.Text += "7";

            double.TryParse(this.ScreenTest.Text, out var number);

            if (HasTheUserPressedMinus || HasTheUserPressedPlus)
            {
                secondNumber = number;

            }
            else
            {
                firstNumber = number;

            }
        }
        private void Button_one_Click(object sender, RoutedEventArgs e)
        {
            this.ScreenTest.Text += "1";

            double.TryParse(this.ScreenTest.Text, out var number);

            if (HasTheUserPressedMinus || HasTheUserPressedPlus)
            {
                secondNumber = number;

            }
            else
            {
                firstNumber = number;

            }
        }
        private void Button_two_Click(object sender, RoutedEventArgs e)
        {
            this.ScreenTest.Text += "2";

            double.TryParse(this.ScreenTest.Text, out var number);

            if (HasTheUserPressedMinus || HasTheUserPressedPlus)
            {
                secondNumber = number;

            }
            else
            {
                firstNumber = number;

            }
        }
        private void Button_three_Click(object sender, RoutedEventArgs e)
        {
            this.ScreenTest.Text += "3";

            double.TryParse(this.ScreenTest.Text, out var number);

            if (HasTheUserPressedMinus || HasTheUserPressedPlus)
            {
                secondNumber = number;

            }
            else
            {
                firstNumber = number;

            }
        }
        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            this.ScreenTest.Text += "8";

            double.TryParse(this.ScreenTest.Text, out var number);

            if (HasTheUserPressedMinus || HasTheUserPressedPlus)
            {
                secondNumber = number;

            }
            else
            {
                firstNumber = number;

            }
        }

        private void Button_minus_Click(object sender, RoutedEventArgs e)
        {
            HasTheUserPressedPlus = false;
            HasTheUserPressedMinus = true;
            this.ScreenTest.Text = "";
        }

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(this.ScreenTest.Text, out var number);
            firstNumber = number;
            HasTheUserPressedPlus = true;
            HasTheUserPressedMinus = false;
            this.ScreenTest.Text = "";

        }

        private void Button_equals_Click(object sender, RoutedEventArgs e)
        {
           if (HasTheUserPressedMinus)
            {
                this.ScreenTest.Text = (firstNumber - secondNumber).ToString();
            }
           else if (HasTheUserPressedPlus)
            {
                this.ScreenTest.Text = (firstNumber + secondNumber).ToString();

            }
            HasTheUserPressedMinus = false;
            HasTheUserPressedPlus = false;
        }
    }
}
