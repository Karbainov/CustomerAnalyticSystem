using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Services;
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
using CustomerAnalyticSystem.BLL;

namespace CAS.UI
{
    /// <summary>
    /// Interaction logic for EditProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        private MainWindow _mainWindow;
        public AddProductWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            FillingEditProductWindowComboBoxGroups();
            _mainWindow = mainWindow;
        }

        private void FillingEditProductWindowComboBoxGroups()
        {
            var groups = new ProductTagGroupService();
            var listGroups = groups.GetAllGroups();
            foreach (var g in listGroups)
            {
                ComboBoxProductGroupAddWndw.Items.Add(g.Name);
            }
        }

        private void ButtonAddProduct_Click(object sender, RoutedEventArgs e)
        {

            ProductBaseModel product = new ProductBaseModel();
            product.Name = TextBoxProductNameAddWndw.Text;
            product.Description = TextBoxProductDescriptionAddWndw.Text;
            product.GroupName = ComboBoxProductGroupAddWndw.SelectedItem.ToString();
            string group = ComboBoxProductGroupAddWndw.SelectedItem.ToString();
            int id = 0;
            _mainWindow.GroupsIdAndGroups.TryGetValue(group, out id);
            ProductTagGroupService service = new ProductTagGroupService();
            service.AddProduct(product.Name, product.Description, id);
            _mainWindow.FillingListViewProducts();
            this.Close();
        }
    }
}
