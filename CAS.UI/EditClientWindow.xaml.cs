
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

namespace CustomerAnalyticSystem.UI
{
    /// <summary>
    /// Interaction logic for ClientWindow.xaml
    /// </summary>
    public partial class EditClientWindow : Window
    {
        public Dictionary<int, ContactTypeModel> contactTypesWithId = new Dictionary<int, ContactTypeModel>();
        Dictionary<ContactModel, int> contactModelWitId = new Dictionary<ContactModel, int>();
        private Dictionary<CustomerTypeModel, int> customerTypesWithId = new Dictionary<CustomerTypeModel, int>();
        private MainWindow _mainWindow;
        private CustomerInfoModel _customer;

        public EditClientWindow(MainWindow mainWindow, CustomerInfoModel customer)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _mainWindow.IsEnabled = false;
            _customer = customer;
            customerTypesWithId = GetAllDictCustomerTypeWithId();
            FillDictContactModelWitId();
            GetAllDictContactType();
            FillComboBoxContactType(contactTypesWithId);
            FillCustomerTypeComboBox(customerTypesWithId);
            FillListViewContactContactType(contactModelWitId);
            FillCustomerInfo(_customer);
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

        private void GetAllDictContactType()
        {
            ContactTypeContactService serve = new ContactTypeContactService();
            List<ContactTypeModel> contactTypes = serve.GetAllContactTypeModel();

            foreach(ContactTypeModel contactType in contactTypes)
            {
                contactTypesWithId.Add(contactType.Id, contactType);
            }
        }

        private void FillComboBoxContactType(Dictionary<int, ContactTypeModel> dict)
        {
            ComboBoxContactType.Items.Clear();

            foreach (KeyValuePair<int, ContactTypeModel> pair in dict)
            {
                ComboBoxContactType.Items.Add(pair);
            }
        }

        private void FillCustomerTypeComboBox(Dictionary<CustomerTypeModel, int> dict)
        {
            foreach(KeyValuePair<CustomerTypeModel, int> pair in dict)
            {
                ComboBoxEditTypeOfClient.Items.Add(pair.Key.Name);
            }
        }

        private void FillCustomerInfo(CustomerInfoModel customer)
        {
                ComboBoxEditTypeOfClient.SelectedItem = customer.Name;
                TextBoxEditClientSurname.Text = customer.LastName;
                TextBoxEditClientName.Text = customer.FirstName;
        }

        //GetAllContactModelByCustomerId
        //ListViewContactContactType

        private void FillDictContactModelWitId()
        {
            ContactTypeContactService serve = new ContactTypeContactService();
            List<ContactModel> contactModels = serve.GetAllContactModelByCustomerId(_customer.Id);

            foreach(ContactModel model in contactModels)
            {
                contactModelWitId.Add(model, model.Id);
            }
        }

        private void FillListViewContactContactType(Dictionary<ContactModel, int> dict)
        {
            foreach (KeyValuePair<ContactModel, int> pair in dict)
            {
                ListViewContactContactType.Items.Add(pair);
            }
        }


        // пока не понимаю как обновить комментарии и контакты
        private void ButtonSaveChangesOfEditingClient_Click(object sender, RoutedEventArgs e)
        {
            int typeId = 0;
            foreach (KeyValuePair<CustomerTypeModel, int> pair in customerTypesWithId)
            {
                if (pair.Key.Name == ComboBoxEditTypeOfClient.Text)
                {
                    typeId = pair.Key.Id;
                }
            }

            var customer = new CustomerInfoModel()
            {
                Id = _customer.Id,
                FirstName = TextBoxEditClientName.Text,
                LastName = TextBoxEditClientSurname.Text,
                TypeId = typeId,
                Name = ComboBoxEditTypeOfClient.Text,
            };

            CustomerService serve = new CustomerService();
            serve.UpdateCustomer(customer);
            this.Close();
            _mainWindow.customersDict = _mainWindow.GetDictCustomerInfoModelWithId();
            _mainWindow.FillCustomerStackPanel(_mainWindow.customersDict);
            _mainWindow.IsEnabled = true;
        }

        private void Window_Close(object sender, EventArgs e)
        {
            _mainWindow.IsEnabled = true;
        }

        private void ButtonAddContactEditClientWndw_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxContact.Text != "" && ComboBoxContactType.SelectedIndex > -1)
            {
                ContactTypeContactService contactService = new ContactTypeContactService();
                ContactBaseModel model = new ContactBaseModel()
                {
                    CustomerId = _customer.Id,
                    ContactTypeId = (contactTypesWithId.Values.ToList())[ComboBoxContactType.SelectedIndex].Id,
                    Value = TextBoxContact.Text
                };
                contactService.AddContact(model);
                FillDictContactModelWitId();
                FillListViewContactContactType(contactModelWitId);
            }
        }
    }
}