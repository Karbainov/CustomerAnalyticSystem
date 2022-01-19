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
        public MainWindow()
        {
            InitializeComponent();
            CustomerService custServe = new CustomerService();
            List<CustomerModel> customers = custServe.GetAllCustomerModels();

            //foreach (CustomerModel customer in customers)
            //{
            //    Button btn = new Button();
            //    btn.Name = Convert.ToString("qwe" + customer.Id);
            //    btn.Content = $"{customer.LastName} {customer.FirstName}";
            //    StackPanelAllCustomers.Children.Add(btn);
            //}
        }

        private void ButtonAccept_Click(object sender, RoutedEventArgs e)
        {
            var temp = new OrderCheckStatusService();
            var listOrder = temp.GetBaseOrderModel();
            foreach(var c in listOrder)
            {
                Button newOrder = new();
                newOrder.Name = $"q_{c.Id}";
            }
                //ListViewLoans.Items.Add(newOrder)
                //newOrder.Content = $"{c.Date}, {c.CustomerId}";
                //newOrder.Click += ButtonOrder_Click;
        }

        private void ButtonOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonOpenOrder_Click(object sender, RoutedEventArgs e)
        {
            
            ListViewOrders.Items.Add(м);
            
        }
    }
}

