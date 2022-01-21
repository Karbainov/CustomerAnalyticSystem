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
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Services;

namespace CustomerAnalyticSystem.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Dictionary<int, CustomerInfoModel> customersDict = new Dictionary<int, CustomerInfoModel>();

        public MainWindow()
        {
            InitializeComponent();

            customersDict = GetDictCustomerInfoModelWithId();
            FillCustomerStackPanel(customersDict);
        }

        public Dictionary<int, CustomerInfoModel> GetDictCustomerInfoModelWithId()
        {
            CustomerService customerService = new CustomerService();
            List<CustomerInfoModel> customers = customerService.GetAllCustomerInfoModels();

            Dictionary<int, CustomerInfoModel> customersDict = new Dictionary<int, CustomerInfoModel>();

            foreach (CustomerInfoModel customer in customers)
            {
                customersDict.Add(customer.Id, customer);
            }
            return customersDict;
        }

        public void FillCustomerStackPanel(Dictionary<int, CustomerInfoModel> dict)
        {
            ListViewClients.Items.Clear();
            foreach (KeyValuePair<int, CustomerInfoModel> pair in dict)
            {
                ListViewClients.Items.Add(pair.Value);
            }
        }
        #region Open pop-up wndws
        private void ButtonOpenWindowOfAddingClient_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow addClientWindow = new AddClientWindow(this);
            addClientWindow.Show();
        }

        private void ButtonOpenAddOrderWndw_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindow addOrderWindow = new AddOrderWindow(this);
            addOrderWindow.Show();

        }

        private void ButtonOpenEditOrderWndw_Click(object sender, RoutedEventArgs e)
        {
            EditOrderWindow editOrderWindow = new EditOrderWindow(this);
            editOrderWindow.Show();
        }


        private void ButtonOpenWindowOfProductAdding_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow addProductWindow = new AddProductWindow(this);
            addProductWindow.Show();
        }

        private void ButtonOpenWindowOfProductEditing_Click(object sender, RoutedEventArgs e)
        {
            EditProductWindow editProductWindow = new EditProductWindow(this);
            editProductWindow.Show();
        }
        #endregion

        private void ButtonOpenWindowOfEditingClient_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewClients.SelectedIndex > -1)
            {
                EditClientWindow editClientWindow = new EditClientWindow(this, (CustomerInfoModel)ListViewClients.SelectedItem);
                editClientWindow.Show();
            }
        }

        private void ButtonFastClientDelete_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewClients.SelectedIndex > -1)
            {
                CustomerService serve = new CustomerService();
                serve.DeleteCustomerById(((CustomerInfoModel)ListViewClients.SelectedItem).Id);
                customersDict = GetDictCustomerInfoModelWithId();
                FillCustomerStackPanel(customersDict);
            }
        }
    }
}
