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
    /// Interaction logic for ItemUC.xaml
    /// </summary>
    public partial class menuItem_template : UserControl
    {
        private string imageSource;
        private string dishName;
        private double dishPrice;
        private string dishDescription;
        public MainWindow mWind;
        public mainMenu mMenu;
        private string ingred;
        private string allergy;
        public string item_image_temp;
        
		public string ImageSource
        {
            get { return this.imageSource; }
            set
            {
                DishImage.Source = new BitmapImage(new Uri(value, UriKind.Relative));
            }
        }

        public string DishNameMethod
        {
            get { return this.dishName; }
            set
            {
                dishName = value;
                DishName.Text = dishName;
            }
        }

        public double DishPriceMethod
        {
            get { return this.dishPrice; }
            set
            {
                dishPrice = value;
                DishPrice.Content = dishPrice.ToString("C2");
            }
        }

        public string DishDescriptionMethod
        {
            get { return this.dishDescription; }
            set
            {
                dishDescription = value;
                Description.Text = dishDescription;
            }
        }

        public menuItem_template(MainWindow mWindow, mainMenu mainMenu, string name, string description, double price, string ingredients, string category, string allergy, string filter, string itemImage)
        {
            InitializeComponent();
            mMenu = mainMenu;
            mWind = mWindow;
            DishDescriptionMethod = description;
            DishNameMethod = name;
            DishPriceMethod = price;
            ingred = ingredients;
			item_image_temp = "Image/ItemImage/";
            item_image_temp += itemImage;
            ImageSource = item_image_temp;
            this.allergy = allergy;
        }

        private void Info_Button_Click(object sender, RoutedEventArgs e)
        {
            mMenu.openInfoScreen(mWind, DishNameMethod, DishPriceMethod, DishDescriptionMethod, ingred, allergy, item_image_temp);
            //mWind.removeMainMenuFromStack();
            //menuInfo_template item_info_screen = new menuInfo_template(mWind, DishNameMethod, DishDescriptionMethod, ingred, allergy);
            //mWind.addItemInfoToStack(item_info_screen);
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            mMenu.addItemToOrderMenu(1, this.DishName.Text, DishPriceMethod);
        }




    }
}
