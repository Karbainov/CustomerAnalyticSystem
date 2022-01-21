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
        private Dictionary<int, CustomerInfoModel> customersDict = new Dictionary<int, CustomerInfoModel>();


        public MainWindow()
        {
            InitializeComponent();
            FillingDictTags();
            FillingDictGroups();
            FillingComboBoxTags();
            FillingComboBoxGroups();
            FillingListViewProducts();
            customersDict = GetDictCustomerInfoModelWithId();
            FillingCustomerStackPanel(customersDict);
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
            ProductBaseModel actual = (ProductBaseModel)ListViewProducts.SelectedItem;
            int id = actual.Id;
            var products = new ProductTagGroupService();
            products.DeleteProductById(id);
            FillingListViewProducts();
        }


        #region filling
        private void FillingCustomerStackPanel(Dictionary<int, CustomerInfoModel> dict)
        {
            foreach (KeyValuePair<int, CustomerInfoModel> pair in dict)
            {
                ListViewClients.Items.Add(pair.Value);
            }
        }

        public void FillingComboBoxTags()
        {
            ComboBoxTags.Items.Clear();
            var tags = new ProductTagGroupService();
            var listTags = tags.GetAllTags();
            foreach (var t in listTags)
            {
                ComboBoxTags.Items.Add(t.Name);
            }
        }

        public void FillingComboBoxGroups()
        {
            ComboBoxGroups.Items.Clear();
            var groups = new ProductTagGroupService();
            var listGroups = groups.GetAllGroups();
            foreach (var g in listGroups)
            {
                ComboBoxGroups.Items.Add(g.Name);
            }
        }

        public void FillingListViewProducts()
        {
            ListViewProducts.Items.Clear();

            if (ComboBoxTags.SelectedIndex > -1)
            {
                string tag = ComboBoxTags.SelectedItem.ToString();
                int id;
                TagsIdAndTags.TryGetValue(tag, out id);
                var products = new ProductTagGroupService();
                var listProducts = products.GetAllProductsByTagId(id);
                foreach (var p in listProducts)
                {
                    ListViewProducts.Items.Add(p);
                }
            }
            else if (ComboBoxGroups.SelectedIndex > -1)
            {
                string group = ComboBoxGroups.SelectedItem.ToString();
                int id;
                GroupsIdAndGroups.TryGetValue(group, out id);
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

        #endregion


        #region dictionary
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
        #endregion


        #region Open pop-up wndws

        private void ButtonOpenWindowOfEditingClient_Click(object sender, RoutedEventArgs e)
        {
            EditClientWindow editClientWindow = new EditClientWindow(this);
            editClientWindow.Show();
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

        private void ButtonOpenWindowOfAddingClient_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow addClientWindow = new AddClientWindow(this);
            addClientWindow.Show();
        }

        private void ButtonOpenWindowOfProductEditing_Click(object sender, RoutedEventArgs e)
        {
            ProductBaseModel product = (ProductBaseModel)ListViewProducts.SelectedItem;
            EditProductWindow editProductWindow = new EditProductWindow(this, product);
            editProductWindow.Show();
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

        #endregion

    }
}
