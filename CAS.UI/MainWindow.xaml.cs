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

namespace CAS.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<int, CustomerInfoModel> customersDict = new Dictionary<int, CustomerInfoModel>();

        public MainWindow()
        {
            InitializeComponent();

            customersDict = GetDictCustomerInfoModelWithId();
            FillCustomerStackPanel(customersDict);
        }

        private Dictionary<int, CustomerInfoModel> GetDictCustomerInfoModelWithId()
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

        private void FillCustomerStackPanel(Dictionary<int, CustomerInfoModel> dict)
        {
            foreach (KeyValuePair<int, CustomerInfoModel> pair in dict)
            {
                ListViewClients.Items.Add(pair.Value);
            }
        }

        private void ButtonOpenWindowOfEditingClient_Click(object sender, RoutedEventArgs e)
        {
            EditClientWindow editClientWindow = new EditClientWindow(this);
            editClientWindow.Show();
        }
    }
}
