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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, int> TagsIdAndTags = new Dictionary<string, int>();
        public MainWindow()
        {
            InitializeComponent();
            FillingDictTags();
            FillingComboBoxTags();
            FillingListViewProducts();
        }

        private void FillingDictTags()
        {
            var service = new ProductTagGroupService();
            var tagList = service.GetAllTags();
            foreach (var t in tagList)
            {
                TagsIdAndTags.Add(t.Name, t.Id);
            }
        }

        private void FillingComboBoxTags()
        {
            var tags = new ProductTagGroupService();
            var listTags = tags.GetAllTags();
            foreach (var t in listTags)
            {
                ComboBoxTags.Items.Add(t);
            }
        }

        private void FillingListViewProducts()
        {
            ListViewProducts.Items.Clear();

            if (ComboBoxTags.SelectedIndex != -1)
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

        private void ComboBoxTags_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FillingListViewProducts();
        }
    }
}
