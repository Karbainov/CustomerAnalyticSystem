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
    public partial class EditProductWindow : Window
    {
        private MainWindow _mainWindow;
        private ProductBaseModel _product;
        public EditProductWindow(MainWindow mainWindow, ProductBaseModel product)
        {
            InitializeComponent();
            _product = product;
            _mainWindow = mainWindow;
           // _mainWindow.IsEnabled = false;
            FillingEditProductWindowComboBoxGroups();
            FindGroupProduct(_product);
            TextBoxProductNameEditWndw.Text = product.Name;
            TextBoxProductDescriptionEditWndw.Text = product.Description;
            var tags = new ProductTagGroupService();
            var listTags = tags.GetAllTagsByProductId(product.Id);
            foreach (var t in listTags)
            {
                ListViewTagsEditWndw.Items.Add(t);
            }
        }

        private void FillingEditProductWindowComboBoxGroups()
        {
            var groups = new ProductTagGroupService();
            var listGroups = groups.GetAllGroups();
            foreach (var g in listGroups)
            {
                ComboBoxProductGroupEditWndw.Items.Add(g.Name);
            }
        }

        private void FindGroupProduct(ProductBaseModel product)
        {
            int selected = 0;
            int count = ComboBoxProductGroupEditWndw.Items.Count;
            for (int i = 0; i <= (count - 1); i++)
            {
                ComboBoxProductGroupEditWndw.SelectedIndex = i;
                if ((string)ComboBoxProductGroupEditWndw.SelectedValue == product.GroupName)
                {
                    selected = i;
                }
            }
            ComboBoxProductGroupEditWndw.SelectedIndex = selected;
        }

        private void ButtonSaveChangesOfProductEditing_Click(object sender, RoutedEventArgs e)
        {
            _product.Name = TextBoxProductNameEditWndw.Text;
            _product.Description = TextBoxProductDescriptionEditWndw.Text;
            _product.GroupName = ComboBoxProductGroupEditWndw.SelectedItem.ToString();
            string group = ComboBoxProductGroupEditWndw.SelectedItem.ToString();
            int id = 0;
            _mainWindow.GroupsIdAndGroups.TryGetValue(group, out id);
            ProductTagGroupService product = new ProductTagGroupService();
            product.UpdateProductById(_product.Id, _product.Name, _product.Description, id);
            _mainWindow.FillingListViewProducts();
            this.Close();
        }
    }
}
