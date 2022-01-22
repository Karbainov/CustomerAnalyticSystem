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
            foreach (string Key in _mainWindow.GroupsIdAndGroups.Keys)
            {
                ComboBoxProductGroupAddWndw.Items.Add(Key);
            }          
        }

        private void FillingComboBoxTagsForAddProduct()
        {
            foreach (string Key in _mainWindow.TagsIdAndTags.Keys)
            {
                ComboBoxTagsForAddProduct.Items.Add(Key);
            }
        }

        private void ButtonAddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxProductNameAddWndw.Text != String.Empty && ComboBoxProductGroupAddWndw.SelectedIndex != -1)
            {
                foreach (var p in _mainWindow.stat.Products.Values)
                {
                    if (p.Name == TextBoxProductNameAddWndw.Text)
                    {
                        MessageBox.Show("Продукт с таким наименованием уже существует");
                        return;
                    }
                }

                ProductBaseModel product = new ProductBaseModel()
                {
                    Name = TextBoxProductNameAddWndw.Text,
                    Description = TextBoxProductDescriptionAddWndw.Text,
                    GroupName = ComboBoxProductGroupAddWndw.SelectedItem.ToString()
                };

                int id = _mainWindow.GroupsIdAndGroups[ComboBoxProductGroupAddWndw.SelectedItem.ToString()];

                ProductTagGroupService service = new ProductTagGroupService();
                service.AddProduct(product.Name, product.Description, id);
                _mainWindow.FillingListViewProducts();

                foreach (var item in ListViewTagsAddWndw.Items)
                {
                    string tag = item.ToString();
                    int id1 = _mainWindow.TagsIdAndTags[tag];
                    ProductTagGroupService service1 = new ProductTagGroupService();
                    int count = _mainWindow.ListViewProducts.Items.Count - 1;
                    _mainWindow.ListViewProducts.SelectedIndex = count;
                    ProductBaseModel newProduct = (ProductBaseModel)_mainWindow.ListViewProducts.SelectedItem;
                    service.AddProductTag(newProduct.Id, id1);
                }

                this.Close();
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
