using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.ViewManagement;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        string input = string.Empty;
        string x = string.Empty;
        string y = string.Empty;
        char operation;
        double result = 0.0;
        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size { Height = 600, Width = 400 };
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        private void Btn_plus(object sender, RoutedEventArgs e)
        {

        }

        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            x = input;
            operation = '+';
            input = string.Empty;
        }

        private void button_plus_Copy_Click(object sender, RoutedEventArgs e)
        {
            x = input;
            operation = '+';
            input = string.Empty;
        }

        private void button_seven_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "7";
            this.textBox.Text += input;
        }

        private void button_eight_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "8";
            this.textBox.Text += input;
        }

        private void button_nine_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "9";
            this.textBox.Text += input;
        }

        private void button_one_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "1";
            this.textBox.Text += input;
        }

        private void button_two_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "2";
            this.textBox.Text += input;
        }

        private void button_three_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "3";
            this.textBox.Text += input;
        }

        private void button_four_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "4";
            this.textBox.Text += input;
        }

        private void button_five_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "5";
            this.textBox.Text += input;
        }

        private void button_six_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "6";
            this.textBox.Text += input;
        }

        private void button_bracket_left_Click(object sender, RoutedEventArgs e)
        {
            x = input;
            operation = '(';
            input = string.Empty;
        }

        private void button_zero_Click(object sender, RoutedEventArgs e)
        {
            this.textBox.Text = " ";
            input += "0";
            this.textBox.Text += input;
        }

        private void button_bracket_right_Click(object sender, RoutedEventArgs e)
        {
            x = input;
            operation = ')';
            input = string.Empty;
        }

        private void button_minus_Click(object sender, RoutedEventArgs e)
        {
            x = input;
            operation = '-';
            input = string.Empty;
        }

        private void button_divide_Click(object sender, RoutedEventArgs e)
        {
            x = input;
            operation = '/';
            input = string.Empty;
        }

        private void button_multiply_Click(object sender, RoutedEventArgs e)
        {
            x = input;
            operation = '*';
            input = string.Empty;
        }

        private void button_answer_Click(object sender, RoutedEventArgs e)
        {
            y = input;
            double num1, num2;

            double.TryParse(x, out num1);
            double.TryParse(y, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                textBox.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    textBox.Text = result.ToString();
                }
                else
                {
                    textBox.Text = "DIV/Zero!";
                }

            }
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "0";
        }
    }
}



