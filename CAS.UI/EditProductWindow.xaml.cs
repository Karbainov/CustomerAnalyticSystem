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
    public partial class EditProductWindow : Window
    {
        private MainWindow _mainWindow;
        private ProductBaseModel _product = null;
        public EditProductWindow(MainWindow mainWindow, ProductBaseModel product)
        {
            InitializeComponent();
            _product = product;
            _mainWindow = mainWindow;
            FillingEditProductWindowComboBoxGroups();
            FillingComboBoxTagsForEdditProduct();
            FillingListViewTagsEditWndw();
            TextBoxProductNameEditWndw.Text = product.Name;
            TextBoxProductDescriptionEditWndw.Text = product.Description;
        }

        private void FillingEditProductWindowComboBoxGroups()
        {
            var groups = new ProductTagGroupService();
            var listGroups = groups.GetAllGroups();
            int i = 0;
            foreach (var g in listGroups)
            {
                i++;
                ComboBoxProductGroupEditWndw.Items.Add(g.Name);
                if (g.Name == _product.GroupName)
                {
                    ComboBoxProductGroupEditWndw.SelectedIndex = i;
                }
            }
        }

        private void ButtonSaveChangesOfProductEditing_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxProductNameEditWndw.Text != String.Empty && ComboBoxProductGroupEditWndw.SelectedIndex != -1)
            {
                _product.Name = TextBoxProductNameEditWndw.Text;
                _product.Description = TextBoxProductDescriptionEditWndw.Text;
                _product.GroupName = ComboBoxProductGroupEditWndw.SelectedItem.ToString();
                string group = ComboBoxProductGroupEditWndw.SelectedItem.ToString();
                int id = _mainWindow.GroupsIdAndGroups[group];
                ProductTagGroupService product = new ProductTagGroupService();
                product.UpdateProductById(_product.Id, _product.Name, _product.Description, id);
                _mainWindow.FillingListViewProducts();
                this.Close();
            }
            else
            {
                MessageBox.Show("Введите информацию о продукте");
            }
        }

        private void FillingListViewTagsEditWndw()
        {
            ListViewTagsEditWndw.Items.Clear();
            var tags = new ProductTagGroupService();
            var listTags = tags.GetAllTagsByProductId(_product.Id);
            foreach (var t in listTags)
            {
                ListViewTagsEditWndw.Items.Add(t.Name);
            }
        }

        private void ButtonEditAddTag_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBoxEditWindowTags.SelectedIndex != -1)
            {
                var tags = new ProductTagGroupService();
                string tag = ComboBoxEditWindowTags.SelectedItem.ToString();
                int id = _mainWindow.TagsIdAndTags[tag];
                tags.AddProductTag(_product.Id, id);
                FillingListViewTagsEditWndw();
            }
            else
            {
                MessageBox.Show("Не выбран тэг для добавления");
            }
        }

        private void FillingComboBoxTagsForEdditProduct()
        {
            var tags = new ProductTagGroupService();
            var listTags = tags.GetAllTags();
            foreach (var t in listTags)
            {
                ComboBoxEditWindowTags.Items.Add(t.Name);
            }
        }

        private void ButtonEditDeleteTag_Click(object sender, RoutedEventArgs e)
        {
            if (ListViewTagsEditWndw.SelectedItem != null)
            {
                string tag = ListViewTagsEditWndw.SelectedItem.ToString();
                int id = _mainWindow.TagsIdAndTags[tag];
                var tag2 = new ProductTagGroupService();
                tag2.DeleteProduct_TagByTagIdAndProductId(_product.Id, id);
                FillingListViewTagsEditWndw();
            }
            else
            {
                MessageBox.Show("Не выбран тэг для удаления");
            }
        }

        private void ButtonDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show(this, $"Вы уверены, что хотите удалить {_product.Name}?",
               "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                var products = new ProductTagGroupService();
                products.DeleteProductById(_product.Id);
                _mainWindow.FillingListViewProducts();
            }
        }
    }
}
