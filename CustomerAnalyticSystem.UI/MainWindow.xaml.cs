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
using CustomerAnalyticSystem.BLL.Models;

namespace CustomerAnalyticSystem.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            //OrderInfoByOrderIdModel keks = new();
            //OrderInfoByOrderIdService test = new();
            //keks = test.GetOrderInfoByOrderId(Convert.ToInt32( TextBoxOrderId.Text));
            //TextBoxInformationAboutOrder.Text = keks.OrderId + "Order" + keks.CustomerId + "Customer id" + "\n";
            //foreach(var c in keks.Items)
            //{
            //    TextBoxInformationAboutOrder.Text += $"({c.ProductId} prodId \t {c.Mark} \t {c.Mark} = Mark \n";
            //}
            var temp = new OrderCheckStatusService();
            var listOrder = temp.GetBaseOrderModel();
            foreach(var c in listOrder)
            {
                Button newOrder = new();
                newOrder.Name = Convert.ToString(c.Id);
                newOrder.Click += ButtonOrder_Click;
                newOrder.Content = $"{c.Date}, {c.CustomerId}";
                //StackPanelAllOrders.Children.Add(newOrder);
            }
        }

        private void ButtonOrder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

