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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for OrderConfirmUC.xaml
    /// </summary>
    public partial class OrderConfirmUC : UserControl
    {
        mainMenu mMenu;
        public OrderConfirmUC(mainMenu mainMenu)
        {
            InitializeComponent();
            mMenu = mainMenu;
        }

        private void Button_Click_Yes(object sender, RoutedEventArgs e)
        {
            mMenu.order_button_confirmation(true);
        }

        private void Button_Click_No(object sender, RoutedEventArgs e)
        {
            mMenu.order_button_confirmation(false);
        }
    }
}
