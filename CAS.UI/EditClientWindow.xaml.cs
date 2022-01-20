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
using System.Windows.Shapes;
using CustomerAnalyticSystem.BLL.Models;
using CustomerAnalyticSystem.BLL.Services;
using CustomerAnalyticSystem.BLL;

namespace CAS.UI
{
    /// <summary>
    /// Interaction logic for ClientWindow.xaml
    /// </summary>
    public partial class EditClientWindow : Window
    {
        private Dictionary<CustomerTypeModel, int> customerTypesWithId = new Dictionary<CustomerTypeModel, int>();
        private MainWindow _mainWindow;

        public EditClientWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            customerTypesWithId = GetAllDictCustomerTypeWithId();
            FillCustomerTypeComboBox(customerTypesWithId);
            _mainWindow = mainWindow;
            _mainWindow.IsEnabled = false;
        }

        private Dictionary<CustomerTypeModel, int> GetAllDictCustomerTypeWithId()
        {
            Dictionary<CustomerTypeModel, int> customerTypesAndId = new Dictionary<CustomerTypeModel, int>();
            CustomerTypeCustomerCommentService serve = new CustomerTypeCustomerCommentService();
            List<CustomerTypeModel> customerModels = serve.GetAllCustomerTypeModel();

            foreach (CustomerTypeModel customerTypeModel in customerModels)
            {
                customerTypesAndId.Add(customerTypeModel, customerTypeModel.Id);
            }
            return customerTypesAndId;
        }

        private void FillCustomerTypeComboBox(Dictionary<CustomerTypeModel, int> dict)
        {
            foreach(KeyValuePair<CustomerTypeModel, int> pair in dict)
            {
                ComboBoxEditTypeOfClient.Items.Add(pair.Key.Name);
            }
        }
    }
}