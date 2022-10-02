using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


namespace Calculator_UWP
{
    public sealed partial class MainPage : Page
    {
        string input = string.Empty;
        string x = string.Empty;
        string y = string.Empty;
        char operation;
        double result = 0.0;
        double num1 = 0.0;
        double num2 = 0.0;


        public MainPage()
        {
            InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(8, 635);
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


        private void button_seven_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            input += "7";
            textBox.Text += input;
        }

        private void button_eight_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            input += "8";
            textBox.Text += input;
        }

        private void button_nine_Click(object sender, RoutedEventArgs e)
        {

            textBox.Text = string.Empty;
            input += "9";
            textBox.Text += input;
        }

        private void button_one_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            input += "1";
            textBox.Text += input;
        }

        private void button_two_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            input += "2";
            textBox.Text += input;
        }

        private void button_three_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            input += "3";
            textBox.Text += input;
        }

        private void button_four_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            input += "4";
            textBox.Text += input;
        }

        private void button_five_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            input += "5";
            textBox.Text += input;
        }

        private void button_six_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            input += "6";
            textBox.Text += input;
        }

        private void button_bracket_left_Click(object sender, RoutedEventArgs e)
        {
            x = input;
            operation = '(';
            input = string.Empty;
        }

        private void button_zero_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            input += "0";
            textBox.Text += input;
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


            double.TryParse(x, out num1);
            double.TryParse(y, out num2);
            ;


            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    textBox.Text = result.ToString();
                    textBlock1.Text = num1 + "+" + num2 + "=" + result;
                    input = result.ToString();
                    break;
                case '-':
                    result = num1 - num2;
                    textBox.Text = result.ToString();
                    textBlock1.Text = num1 + "-" + num2 + "=" + result;
                    input = result.ToString();
                    break;
                case '*':
                    result = num1 * num2;
                    textBox.Text = result.ToString();
                    textBlock1.Text = num1 + "*" + num2 + "=" + result;
                    input = result.ToString();
                    break;
                case '/':
                    if (num2 == 0) {
                        textBox.Text = "Деление на ноль!";
                        input = string.Empty;
                        break;
                    }
                    else
                    {
                        result = num1 / num2;
                        textBox.Text = result.ToString();
                        textBlock1.Text = num1 + "/" + num2 + "=" + result;
                        input = result.ToString();
                        break;
                    };
            }
        }

        private void button_clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = string.Empty;
            textBox.Text = "Окно очищено";
            input = string.Empty;
        }

        private void textBlock1_SelectionChanged(object sender, RoutedEventArgs e)
        {



        }

        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}



