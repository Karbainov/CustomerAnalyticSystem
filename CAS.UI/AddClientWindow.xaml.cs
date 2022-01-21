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
using System.Windows.Shapes;

namespace CustomerAnalyticSystem.UI
{
    /// <summary>
    /// Interaction logic for ClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        MainWindow _mainWindow;
        public AddClientWindow(MainWindow mainWindow)
        {
            InitializeComponent();
        }
    }
}
