﻿using CustomerAnalyticSystem.BLL.Models;
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

            ProductBaseModel product = new ProductBaseModel();
            product.Name = TextBoxProductNameAddWndw.Text;
            product.Description = TextBoxProductDescriptionAddWndw.Text;
            product.GroupName = ComboBoxProductGroupAddWndw.SelectedItem.ToString();
            string group = ComboBoxProductGroupAddWndw.SelectedItem.ToString();
            int id = -1;
            _mainWindow.GroupsIdAndGroups.TryGetValue(group, out id);
            ProductTagGroupService service = new ProductTagGroupService();
            service.AddProduct(product.Name, product.Description, id);
            _mainWindow.FillingListViewProducts();
            foreach (var item in ListViewTagsAddWndw.Items)
            {
                string tag = item.ToString();
                int id1 = -1;
                _mainWindow.TagsIdAndTags.TryGetValue(tag, out id1);
                ProductTagGroupService service1 = new ProductTagGroupService();
                int count = _mainWindow.ListViewProducts.Items.Count;
                int index = _mainWindow.ListViewProducts.SelectedIndex = count - 1;
                ProductBaseModel newProduct = (ProductBaseModel)_mainWindow.ListViewProducts.SelectedItem;
                service.AddProductTag(newProduct.Id, id1);
            }

            this.Close();
        }

        private void ButtonAddTag_Click(object sender, RoutedEventArgs e)
        {
            ListViewTagsAddWndw.Items.Add(ComboBoxTagsForAddProduct.SelectedItem.ToString());
            
        }
    }
}
