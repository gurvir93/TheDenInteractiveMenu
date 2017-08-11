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
using System.IO;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow: Window
    {
        public static mainMenu uc_mainmenu;
        public static menuInfo_template item_info;
        public MainWindow()
        {
            InitializeComponent();
            uc_mainmenu = new mainMenu(this);

        }

        private void image_clicked(object sender, MouseButtonEventArgs e)
        {
            intro_image.Visibility = Visibility.Collapsed;
            addMainMenuToStack();
        }

        public void addMainMenuToStack()
        {
            stack_mainMenu.Children.Add(uc_mainmenu);
        }

        public void addItemInfoToStack(menuInfo_template item_info)
        {
            stack_mainMenu.Children.Add(item_info);
        }

        public void removeMainMenuFromStack()
        {
            stack_mainMenu.Children.Remove(uc_mainmenu);
        }

        public void removeItemInfoFromStack(menuInfo_template item_info)
        {
            stack_mainMenu.Children.Remove(item_info);
        }
    }
}
