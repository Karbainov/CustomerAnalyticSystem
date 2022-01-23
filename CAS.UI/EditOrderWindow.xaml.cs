using CustomerAnalyticSystem.BLL.Models;
using System.Windows;

namespace CustomerAnalyticSystem.UI
{
    /// <summary>
    /// Interaction logic for EditOrderWindow.xaml
    /// </summary>
    public partial class EditOrderWindow : Window
    {
        MainWindow _mainWindow;
        public EditOrderWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;
            InitializeComponent();
        }

        private void ButtonDeleteOrderEditOrderWndw_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show(this, $"Вы уверены, что хотите удалить заказ № {((OrderBaseModel)_mainWindow.ListViewClients.SelectedItem).Id}?",
                   "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //удаление
            }
        }
    }
}
