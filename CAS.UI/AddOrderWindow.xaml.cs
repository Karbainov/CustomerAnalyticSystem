using System.Windows;
using System.Text.RegularExpressions;

namespace CustomerAnalyticSystem.UI
{

    public partial class AddOrderWindow : Window
    {
        MainWindow _mainWindow;
        public AddOrderWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        private void ButtonEditOrderStatus_Click(object sender, RoutedEventArgs e)
        {
            EditStatusWindow editStatusWindow = new EditStatusWindow(_mainWindow);
            editStatusWindow.Show();
        }



        private static readonly Regex _regex = new Regex("[^0-9.-]+");

        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }

        private void TextBoxAmountOfProductAddOrderWndw_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
            IsTextAllowed(TextBoxAmountOfProductAddOrderWndw.Text);
        }

        private void TextBoxPriceOfUnitAddOrderWndw_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
            IsTextAllowed(TextBoxAmountOfProductAddOrderWndw.Text);
        }
    }
}
