using System.Windows;

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
            EditStatusWindow editStatusWindow = new EditStatusWindow(this);
            editStatusWindow.Show();
        }
    }
}
