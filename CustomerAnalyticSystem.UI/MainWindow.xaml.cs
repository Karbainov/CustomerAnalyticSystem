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

        private void BtnGetCustomer_Click(object sender, RoutedEventArgs e)
        {
            var service = new CustomerService();
            var customerInfo = service.GetCustomerModel(Convert.ToInt32(TextBoxGetCustomerId.Text));

            TextBoxCustomerFirstName.Text = customerInfo.FirstName;
            TextBoxCustomerLastName.Text = customerInfo.LastName;
            TextBoxCustomerTypeName.Text = customerInfo.Name;
            foreach (ContactModel contact in customerInfo.Contacts)
            {
                Label lable = new Label();
                lable.Content = contact.ToString();
                StackPanelContacts.Children.Add(lable);
            }
        }
    }
}
