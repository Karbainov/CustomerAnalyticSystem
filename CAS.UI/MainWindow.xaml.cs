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

namespace CustomerAnalyticSystem.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Dictionary<string, int> TagsIdAndTags = new Dictionary<string, int>();
        public Dictionary<string, int> GroupsIdAndGroups = new Dictionary<string, int>();
        public Dictionary<string, int> StatusIdAndStatus = new Dictionary<string, int>();
        public Dictionary<int, CustomerInfoModel> customersDict = new Dictionary<int, CustomerInfoModel>();


        public MainWindow()
        {
            InitializeComponent();
            FillingDictTags();
            FillingDictGroups();
            FillingDictStatus();
            FillingComboBoxStatus();
            FillingComboBoxTags();
            FillingComboBoxGroups();
            FillingListViewProducts();
            FillingListViewOrders();
            customersDict = GetDictCustomerInfoModelWithId();
            FillingCustomerStackPanel(customersDict);

            //ComboBoxStatus
        }

        private void ComboBoxTags_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxTags.SelectedIndex != -1)
            {
                ComboBoxGroups.SelectedIndex = -1;
            }
            FillingListViewProducts();
        }

        private void ComboBoxGroups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxGroups.SelectedIndex != -1)
            {
                ComboBoxTags.SelectedIndex = -1;
            }
            FillingListViewProducts();
        }

        private void ButtonViewAllProducts_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxTags.SelectedIndex != -1 || ComboBoxGroups.SelectedIndex != -1)
            {
                ComboBoxGroups.SelectedIndex = -1;
                ComboBoxTags.SelectedIndex = -1;
            }
            FillingListViewProducts();
        }

        private void ButtonFastProductDelete_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewProducts.SelectedIndex > -1)
            {
                if (System.Windows.MessageBox.Show(this, $"Вы уверены, что хотите удалить {((ProductBaseModel)ListViewProducts.SelectedItem).Name}?",
                   "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    ProductBaseModel actual = (ProductBaseModel)ListViewProducts.SelectedItem;
                    int id = actual.Id;
                    var products = new ProductTagGroupService();
                    products.DeleteProductById(id);
                    FillingListViewProducts();
                }
            }
            else
            {
                MessageBox.Show("Выберите продукт");
            }
        }

        private void ButtonFastClientDelete_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewClients.SelectedIndex > -1)
            {
                if (System.Windows.MessageBox.Show(this, $"Вы уверены, что хотите удалить клиента " +
                    $"{((CustomerInfoModel)ListViewClients.SelectedItem).FirstName} {((CustomerInfoModel)ListViewClients.SelectedItem).LastName}?",
                   "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    CustomerService serve = new CustomerService();
                    serve.DeleteCustomerById(((CustomerInfoModel)ListViewClients.SelectedItem).Id);
                    customersDict = GetDictCustomerInfoModelWithId();
                    FillingCustomerStackPanel(customersDict);
                }
            }
            else
            {
                MessageBox.Show("Выберите пользователя");
            }
        }

        private void ButtonFastOrderDelete_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewOrders.SelectedIndex > -1)
            {
                if (System.Windows.MessageBox.Show(this, $"Вы уверены, что хотите удалить заказ № {((OrderBaseModel)ListViewClients.SelectedItem).Id}?",
                   "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    //удаление
                }
            }
            else
            {
                MessageBox.Show("Выберите заказ");
            }
        }

        #region filling
        public void FillingCustomerStackPanel(Dictionary<int, CustomerInfoModel> dict)
        {
            foreach (KeyValuePair<int, CustomerInfoModel> pair in dict)
            {
                ListViewClients.Items.Add(pair.Value);
            }
        }

        public void FillingComboBoxStatus()
        {
            ComboBoxStatus.Items.Clear();
            foreach (string Key in StatusIdAndStatus.Keys)
            {
                ComboBoxStatus.Items.Add(Key);
            }
        }

        public void FillingComboBoxTags()
        {
            ComboBoxTags.Items.Clear();;
            foreach (string Key in TagsIdAndTags.Keys)
            {
                ComboBoxTags.Items.Add(Key);
            }
        }

        public void FillingComboBoxGroups()
        {
            ComboBoxGroups.Items.Clear();
            foreach (string Key in GroupsIdAndGroups.Keys)
            {
                ComboBoxGroups.Items.Add(Key);
            }
        }

        public void FillingListViewProducts()
        {
            ListViewProducts.Items.Clear();

            if (ComboBoxTags.SelectedIndex > -1)
            {
                int id = TagsIdAndTags[ComboBoxTags.SelectedItem.ToString()];
                var products = new ProductTagGroupService();
                var listProducts = products.GetAllProductsByTagId(id);
                foreach (var p in listProducts)
                {
                    ListViewProducts.Items.Add(p);
                }
            }
            else if (ComboBoxGroups.SelectedIndex > -1)
            {
                int id = GroupsIdAndGroups[ComboBoxGroups.SelectedItem.ToString()];
                var products = new ProductTagGroupService();
                var listProducts = products.GetAllProductsByGroupId(id);
                foreach (var p in listProducts)
                {
                    ListViewProducts.Items.Add(p);
                }
            }
            else
            {
                var products = new ProductTagGroupService();
                var listProducts = products.GetAllProducts();
                foreach (var p in listProducts)
                {
                    ListViewProducts.Items.Add(p);
                }
            }
        }

        public void FillingListViewOrders()
        {
            ListViewOrders.Items.Clear();
            if (ComboBoxStatus.SelectedIndex > -1)
            {
                var orders = new OrderCheckStatusService();
                int id = StatusIdAndStatus[ComboBoxStatus.SelectedItem.ToString()];
                var listOrders = orders.GetAllOrdersByStatusId(id);
                foreach (var p in listOrders)
                {
                    ListViewOrders.Items.Add(p);
                }
            }
            else
            {
                var orders = new OrderCheckStatusService();
                var listOrders = orders.GetBaseOrderModel();
                foreach (var p in listOrders)
                {
                    ListViewOrders.Items.Add(p);
                }
            }
        }

    #endregion

        #region dictionary
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

        public void FillingDictGroups()
        {
            GroupsIdAndGroups.Clear();
            var service = new ProductTagGroupService();
            var groupList = service.GetAllGroups();
            foreach (var g in groupList)
            {
                GroupsIdAndGroups.Add(g.Name, g.Id);
            }
        }

        public void FillingDictTags()
        {
            TagsIdAndTags.Clear();
            var service = new ProductTagGroupService();
            var tagList = service.GetAllTags();
            foreach (var t in tagList)
            {
                TagsIdAndTags.Add(t.Name, t.Id);
            }
        }

        public void FillingDictStatus()
        {
            StatusIdAndStatus.Clear();
            var service = new OrderCheckStatusService();
            var statusList = service.GetAllStatus();
            foreach (var s in statusList)
            {
                StatusIdAndStatus.Add(s.Name, s.Id);
            }
        }

        #endregion

        #region Open pop-up wndws

        private void ButtonOpenAddOrderWndw_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindow addOrderWindow = new AddOrderWindow(this);
            addOrderWindow.Show();

        }

        private void ButtonOpenEditOrderWndw_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewOrders.SelectedIndex > -1)
            {
                EditOrderWindow editOrderWindow = new EditOrderWindow(this);
                editOrderWindow.Show();
            }
            else
            {
                MessageBox.Show("Выберите заказ");
            }
        }

        private void ButtonOpenWindowOfProductAdding_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow addProductWindow = new AddProductWindow(this);
            addProductWindow.Show();
        }

        private void ButtonOpenWindowOfAddingClient_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow addClientWindow = new AddClientWindow(this);
            addClientWindow.Show();
        }

        private void ButtonOpenWindowOfProductEditing_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewProducts.SelectedIndex > -1)
            {
                ProductBaseModel product = (ProductBaseModel)ListViewProducts.SelectedItem;
                EditProductWindow editProductWindow = new EditProductWindow(this, product);
                editProductWindow.Show();
            }
            else
            {
                MessageBox.Show("Выберите продукт для редактирования");
            }
        }

        private void ButtonEditTags_Click(object sender, RoutedEventArgs e)
        {
            EditTagsWindow editTagsWindow = new EditTagsWindow(this);
            editTagsWindow.Show();
        }

        private void ButtonEditGroups_Click(object sender, RoutedEventArgs e)
        {
            EditGroupsWindow editGroupsWindow = new EditGroupsWindow(this);
            editGroupsWindow.Show();
        }

        private void ButtonOpenWindowOfEditingClient_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewClients.SelectedIndex > -1)
            {
                EditClientWindow editClientWindow = new EditClientWindow(this, (CustomerInfoModel)ListViewClients.SelectedItem);
                editClientWindow.Show();
            }
        }


        #endregion

        private void ComboBoxStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FillingListViewOrders();
        }

        private void ButtonViewAllOrders_Click(object sender, RoutedEventArgs e)
        {
            ComboBoxStatus.SelectedIndex = -1;
            FillingListViewOrders();
        }
    }
}
