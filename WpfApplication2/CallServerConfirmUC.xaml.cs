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
    /// Interaction logic for CallServerConfirmUC.xaml
    /// </summary>
    public partial class CallServerConfirmUC : UserControl
    {
        mainMenu mMenu;

        public CallServerConfirmUC(mainMenu mainMenu)
        {
            InitializeComponent();
            mMenu = mainMenu;
        }

        private void Button_Click_ok(object sender, RoutedEventArgs e)
        {
            mMenu.turnOffServerConfirmNotification();
        }
    }
}
