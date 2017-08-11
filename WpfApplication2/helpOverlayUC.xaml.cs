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
    /// Interaction logic for helpOverlayUC.xaml
    /// </summary>
    public partial class helpOverlayUC : UserControl
    {
        mainMenu mMenu;
        public helpOverlayUC(mainMenu mainMenu)
        {
            InitializeComponent();
            mMenu = mainMenu;
        }

        private void image_clicked(object sender, MouseButtonEventArgs e)
        {
            mMenu.turnOffHelpScreen();
        }

        public void set_image(ImageSource image)
        {
            helpImageOverlay.Source = image;
        }
    }
}
