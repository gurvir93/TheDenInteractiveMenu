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
    /// Interaction logic for menuInfo_template.xaml
    /// </summary>
    /// 
    public partial class menuInfo_template : UserControl
    {
        private string dishName;
        private string dishDescription;
        private double dishPrice;
        private string allergies;
        private bool[] defaultIngredient = new bool[] {true, true, false, false, false };
        mainMenu mMenu;
        MainWindow main_window;
        string[] ingred;
		string imageSource;

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
            get 
            { 
                return this.dishName; 
            }
            set
            {
                dishName = value;
                DishName.Content = dishName;
            }
        }

        public string DishDescriptionMethod
        {
            get
            {
                return this.dishDescription;
            }
            set
            {
                dishDescription = value;
                DishDescription.Text = dishDescription;
            }
        }

        public string DishAllergyMethod
        {
            get
            {
                return this.allergies;
            }
            set
            {
                allergies = value;
                list_of_allergy.Content = allergies;
            }
        }

        
        public menuInfo_template(MainWindow mWindow, mainMenu mainMenu, string name, double dPrice, string description, string ingredients, string allergy, string itemImage)
        {
            InitializeComponent();
            DishNameMethod = name;
            dishPrice = dPrice;
            infoScreen_price.Content = dPrice.ToString("C2");
            DishDescriptionMethod = description;
            DishAllergyMethod = allergy;
            mMenu = mainMenu;
            main_window = mWindow;
            ingred = ingredients.Split(',');
			ImageSource = itemImage;

            for (int i = 0; i < ingred.Length; i++)
            {
                list_of_ingredients.Items.Add(new add_checkboxs() { button_name = ingred[i] , is_checked = defaultIngredient[i]});
            }
        }

        public class add_checkboxs
        {
            public string button_name { get; set; }
            public bool is_checked { get; set; }
        }


        private void item_info_back_Button_Click(object sender, RoutedEventArgs e)
        {
            //main_window.removeItemInfoFromStack(this);
            //main_window.addMainMenuToStack();
            mMenu.infoScreen_BackButton_Confirmation();
            quantity_text.Text = "1";
        }

        private void increase_quantity_button_Click(object sender, RoutedEventArgs e)
        {
            int quantity;
            quantity = int.Parse(quantity_text.Text.ToString());
            quantity++;
            quantity_text.Text = quantity.ToString();
        }

        private void decrease_quantity_button_Click(object sender, RoutedEventArgs e)
        {
            int quantity;
            quantity = int.Parse(quantity_text.Text.ToString());
            if(quantity <= 1)
            {
                quantity = 1;
            }
            else
            {
                quantity--;
            }
            quantity_text.Text = quantity.ToString();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            //mMenu.addItemToOrderMenu(int.Parse(quantity_text.Text), dishName, dishPrice);
            bool[] currentIngredients = new bool[defaultIngredient.Length];
            for (int i = 0; i < defaultIngredient.Length; i++ )
            {
                currentIngredients[i] = ((add_checkboxs)list_of_ingredients.Items.GetItemAt(i)).is_checked;
            }

            mMenu.addItemToOrderMenu(int.Parse(quantity_text.Text), dishName, dishPrice, defaultIngredient, currentIngredients, ingred);
            quantity_text.Text = "1";
            item_info_back_Button_Click(null, null);
        }
    }
}
