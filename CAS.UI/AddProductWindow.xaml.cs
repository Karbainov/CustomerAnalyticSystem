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
    /// Interaction logic for EditProductWindow.xaml
    /// </summary>
    public partial class AddProductWindow : Window
    {
        private MainWindow _mainWindow;
        public AddProductWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            FillingComboBoxTagsForAddProduct();
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

        private void FillingComboBoxTagsForAddProduct()
        {
            var tags = new ProductTagGroupService();
            var listTags = tags.GetAllTags();
            foreach (var t in listTags)
            {
                ComboBoxTagsForAddProduct.Items.Add(t.Name);
            }
        }

        private void ButtonAddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxProductNameAddWndw.Text != String.Empty && ComboBoxProductGroupAddWndw.SelectedIndex != -1)
            {
                //ПОМЕНЯТЬ ПРОВЕРКУ ПОСЛЕ ТОГО КАК ДИНАР ДОДЕЛАЕТ КЛАСС
                bool one = true;
                ProductTagGroupService tmpservice = new ProductTagGroupService();
                var listProducts = tmpservice.GetAllProducts();
                foreach(var p in listProducts)
                {
                    if(p.Name == TextBoxProductNameAddWndw.Text)
                    {
                        one = false;
                    }
                }

                if (one == true)
                {
                    ProductBaseModel product = new ProductBaseModel()
                    {
                        Name = TextBoxProductNameAddWndw.Text,
                        Description = TextBoxProductDescriptionAddWndw.Text,
                        GroupName = ComboBoxProductGroupAddWndw.SelectedItem.ToString()
                    };

                    string group = ComboBoxProductGroupAddWndw.SelectedItem.ToString();
                    int id = _mainWindow.GroupsIdAndGroups[group];

                    ProductTagGroupService service = new ProductTagGroupService();
                    service.AddProduct(product.Name, product.Description, id);
                    _mainWindow.FillingListViewProducts();

                    foreach (var item in ListViewTagsAddWndw.Items)
                    {
                        string tag = item.ToString();
                        int id1 = _mainWindow.TagsIdAndTags[tag];
                        ProductTagGroupService service1 = new ProductTagGroupService();
                        int count = _mainWindow.ListViewProducts.Items.Count;
                        _mainWindow.ListViewProducts.SelectedIndex = count - 1;
                        ProductBaseModel newProduct = (ProductBaseModel)_mainWindow.ListViewProducts.SelectedItem;
                        service.AddProductTag(newProduct.Id, id1);
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Продукт с таким наименованием уже существует");

                }
            }
            else
            {
                MessageBox.Show("Введите информацию о продукте");
            }

        }

        private void ButtonAddTag_Click(object sender, RoutedEventArgs e)
        {
            ListViewTagsAddWndw.Items.Add(ComboBoxTagsForAddProduct.SelectedItem.ToString());          
        }
    }
}
