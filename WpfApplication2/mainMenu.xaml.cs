using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
//using System.Linq;
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
    /// Interaction logic for mainMenu.xaml
    /// </summary>
    public partial class mainMenu : UserControl
    {
        string name, description, ingredients, category, allergy, filter;
        double price;
        double totalOrderPrice = 0;
        string[,] item_summary;
        int[] num_of_category;
        int checkbox_counter = 0;
        MainWindow mWin = null;
        parser myParser = new parser();
        string item_image;

        int[] filter_array = new int[6];



        public ObservableCollection<aOrder> Orders;

        public mainMenu(MainWindow mWindow)
        {
            InitializeComponent();


            for (int i = 0; i < filter_array.Length; i++)
            {
                filter_array[i] = 1;
            }

            Orders = new ObservableCollection<aOrder>();
            listbox_order.DataContext = Orders;

            item_summary = myParser.getInfo();
            num_of_category = myParser.getNums();
            mWin = mWindow;
            int col_all = 0;
            int col_special = 0;
            int col_beverage = 0;
            int col_appetizer = 0;
            int col_salad = 0;
            int col_pizza = 0;
            int col_burger = 0;
            int col_poutine = 0;
            int col_dessert = 0;
            int row_all = 0;
            int row_special = 0;
            int row_beverage = 0;
            int row_appetizer = 0;
            int row_salad = 0;
            int row_pizza = 0;
            int row_burger = 0;
            int row_poutine = 0;
            int row_dessert = 0;
            //double numOfCols = (double)(myParser.item_summary.GetLength(0) / 2);

            for (int i = 0; i < num_of_category.Length; i++)
            {
                for (int j = 0; j < Math.Ceiling(((double)(num_of_category[i])) / 2); j++)
                {
                    ColumnDefinition cd = new ColumnDefinition();
                    cd.Width = new GridLength(350);

                    if (i == 0)
                    {
                        menu_specials.ColumnDefinitions.Add(cd);
                    }
                    else if (i == 1)
                    {
                        menu_beverages.ColumnDefinitions.Add(cd);
                    }
                    else if (i == 2)
                    {
                        menu_appetizers.ColumnDefinitions.Add(cd);
                    }
                    else if (i == 3)
                    {
                        menu_salads.ColumnDefinitions.Add(cd);
                    }
                    else if (i == 4)
                    {
                        menu_pizza.ColumnDefinitions.Add(cd);
                    }
                    else if (i == 5)
                    {
                        menu_burgers.ColumnDefinitions.Add(cd);
                    }
                    else if (i == 6)
                    {
                        menu_poutine.ColumnDefinitions.Add(cd);
                    }
                    else if (i == 7)
                    {
                        menu_desserts.ColumnDefinitions.Add(cd);
                    }
                    else if (i == 8)
                    {
                        menu_all.ColumnDefinitions.Add(cd);
                    }
                }

            }

            for (int i = 0; i < myParser.item_summary.GetLength(0); i++)
            {
                name = myParser.item_summary[i, 0];
                description = myParser.item_summary[i, 1];
                price = Math.Round(Double.Parse(myParser.item_summary[i, 2]), 2);
                ingredients = myParser.item_summary[i, 3];
                category = myParser.item_summary[i, 4];
                allergy = myParser.item_summary[i, 5];
                filter = myParser.item_summary[i, 6];
				item_image = myParser.item_summary[i, 7];

                menuItem_template item_info = new menuItem_template(mWin, this, name, description, price, ingredients, category, allergy, filter, item_image);
                this.menu_all.Children.Add(item_info);

                Grid.SetRow(item_info, row_all);
                Grid.SetColumn(item_info, col_all);

                if (row_all == 1)
                {
                    row_all = 0;
                    col_all++;
                }
                else
                {
                    row_all++;
                }
            }

            for (int i = 0; i < myParser.item_summary.GetLength(0); i++)
            {
                name = myParser.item_summary[i, 0];
                description = myParser.item_summary[i, 1];
                price = Math.Round(Double.Parse(myParser.item_summary[i, 2]), 2);
                ingredients = myParser.item_summary[i, 3];
                category = myParser.item_summary[i, 4];
                allergy = myParser.item_summary[i, 5];
                filter = myParser.item_summary[i, 6];
				item_image = myParser.item_summary[i, 7];

                menuItem_template item_info = new menuItem_template(mWin, this, name, description, price, ingredients, category, allergy, filter, item_image);

                if (category.Contains("special"))
                {
                    this.menu_specials.Children.Add(item_info);
                    Grid.SetRow(item_info, row_special);
                    Grid.SetColumn(item_info, col_special);

                    if (row_special == 1)
                    {
                        row_special = 0;
                        col_special++;
                    }
                    else
                    {
                        row_special++;
                    }

                }
                else if (category.Contains("beverage"))
                {
                    this.menu_beverages.Children.Add(item_info);
                    Grid.SetRow(item_info, row_beverage);
                    Grid.SetColumn(item_info, col_beverage);

                    if (row_beverage == 1)
                    {
                        row_beverage = 0;
                        col_beverage++;
                    }
                    else
                    {
                        row_beverage++;
                    }
                }
                else if (category.Contains("appetizer"))
                {
                    this.menu_appetizers.Children.Add(item_info);
                    Grid.SetRow(item_info, row_appetizer);
                    Grid.SetColumn(item_info, col_appetizer);

                    if (row_appetizer == 1)
                    {
                        row_appetizer = 0;
                        col_appetizer++;
                    }
                    else
                    {
                        row_appetizer++;
                    }
                }
                else if (category.Contains("salad"))
                {
                    this.menu_salads.Children.Add(item_info);
                    Grid.SetRow(item_info, row_salad);
                    Grid.SetColumn(item_info, col_salad);

                    if (row_salad == 1)
                    {
                        row_salad = 0;
                        col_salad++;
                    }
                    else
                    {
                        row_salad++;
                    }
                }
                else if (category.Contains("pizza"))
                {
                    this.menu_pizza.Children.Add(item_info);
                    Grid.SetRow(item_info, row_pizza);
                    Grid.SetColumn(item_info, col_pizza);

                    if (row_pizza == 1)
                    {
                        row_pizza = 0;
                        col_pizza++;
                    }
                    else
                    {
                        row_pizza++;
                    }
                }
                else if (category.Contains("burger"))
                {
                    this.menu_burgers.Children.Add(item_info);
                    Grid.SetRow(item_info, row_burger);
                    Grid.SetColumn(item_info, col_burger);

                    if (row_burger == 1)
                    {
                        row_burger = 0;
                        col_burger++;
                    }
                    else
                    {
                        row_burger++;
                    }
                }
                else if (category.Contains("poutine"))
                {
                    this.menu_poutine.Children.Add(item_info);
                    Grid.SetRow(item_info, row_poutine);
                    Grid.SetColumn(item_info, col_poutine);

                    if (row_poutine == 1)
                    {
                        row_poutine = 0;
                        col_poutine++;
                    }
                    else
                    {
                        row_poutine++;
                    }
                }
                else if (category.Contains("dessert"))
                {
                    this.menu_desserts.Children.Add(item_info);
                    Grid.SetRow(item_info, row_dessert);
                    Grid.SetColumn(item_info, col_dessert);

                    if (row_dessert == 1)
                    {
                        row_dessert = 0;
                        col_dessert++;
                    }
                    else
                    {
                        row_dessert++;
                    }
                }
            }
        }

        private void is_expanded(object sender, RoutedEventArgs e)
        {
            listbox_order.Visibility = Visibility.Collapsed;
        }

        private void is_collapsed(object sender, RoutedEventArgs e)
        {
            listbox_order.Visibility = Visibility.Visible;
        }

        private void is_clicked(object sender, RoutedEventArgs e)
        {
        }

        private void searchBar_clicked(object sender, RoutedEventArgs e)
        {
            textbox_searchBar.Text = "";
        }

        
        private void button_order_Click(object sender, RoutedEventArgs e)
        {
            OrderConfirmUC checkConfirm = new OrderConfirmUC(this);
            mWin.stack_infoScreen.Children.Clear();
            mWin.stack_confirmationControl.Children.Clear();
            mWin.stack_callServerConfirm.Children.Clear();
            mWin.stack_helpOverlay.Children.Clear();
            if (mWin.stack_infoScreen.Children.Capacity > 0)
            {
                mWin.stack_infoScreen.Children.Capacity--;
            }
            mWin.stack_confirmationControl.Children.Add(checkConfirm);
        }

        public void order_button_confirmation(Boolean isConfirmed)
        {
            aOrder old_order;
            if (isConfirmed)
            {
                ObservableCollection<aOrder> old_orders = Orders;
                List<aOrder> new_orders = new List<aOrder>();

                for (int i = 0; i < old_orders.Count; i++)
                {
                    old_order = (aOrder)old_orders[i];
                    new_orders.Add(new aOrder() { Quantity = old_order.Quantity, DishName = old_order.DishName, Price = old_order.Price, Ingredients = old_order.Ingredients, Visibility = old_order.Visibility, Button = "Collapsed", Disable_colour = "#EEE0E5" });
                    //MessageBox.Show(old_order.DishName);

                }
                Orders.Clear();

                for (int i = 0; i < new_orders.Count; i++)
                {
                    Orders.Add(new_orders[i]);
                }

                //string[] str = { "asd", "asd"};
                //string[] str2 = { "Collapsed", "Collapsed", "Collapsed", "Collapsed", "Collapsed" };
                //Orders.Add(new aOrder() { Quantity = 1, DishName = "asdf", Price = 12, Ingredients = str, Visibility = str2, Button = "Collapsed", Disable_colour = "Green" });


            }
            mWin.stack_confirmationControl.Children.Clear();
        }

        
        public void openInfoScreen(MainWindow mWindow, string name, double price, string description, string ingredients, string allergy, string item_image_temp2)
        {
            Console.WriteLine(item_image_temp2);
            menuInfo_template item_info_screen = new menuInfo_template(mWindow, this, name, price, description, ingredients, allergy, item_image_temp2);
            mWin.stack_infoScreen.Children.Clear();
            mWin.stack_confirmationControl.Children.Clear();
            mWin.stack_callServerConfirm.Children.Clear();
            mWin.stack_helpOverlay.Children.Clear();

            if (mWin.stack_infoScreen.Children.Capacity > 0)
            {
                mWin.stack_infoScreen.Children.Capacity--;
            }
            mWin.stack_infoScreen.Children.Add(item_info_screen);
        }

        public void infoScreen_BackButton_Confirmation()
        {
            mWin.stack_infoScreen.Children.Clear();
            if (mWin.stack_infoScreen.Children.Capacity > 0)
            {
                mWin.stack_infoScreen.Children.Capacity--;
            }
        }

        private void update_Order_Total(double price)
        {
            totalOrderPrice += price;
            label_price_total.Content = totalOrderPrice.ToString("C2");
        }

        public void addItemToOrderMenu(int quantity, string dishName, double dishPrice)
        {
            // listbox_order.Items.Add(new aOrder() { Quantity = quantity, DishName = dishName, Price = dishPrice.ToString() });
            //update_Order_Total(dishPrice);
            string[] modifications = new string[7];
            string[] visibMods = new string[7];

            for (int i = 0; i < modifications.Length; i++)
            {
                modifications[i] = "";
                visibMods[i] = "Collapsed";
            }

            Orders.Add(new aOrder() { Quantity = quantity, DishName = dishName, Price = (dishPrice * quantity), Ingredients = modifications, Visibility = visibMods });
            update_Order_Total(dishPrice * quantity);
        }

        public void addItemToOrderMenu(int quantity, string dishName, double dishPrice, bool[] defaultIngredients, bool[] ingredientsBool, string[] ingredientName)
        {
            // listbox_order.Items.Add(new aOrder() { Quantity = quantity, DishName = dishName, Price = dishPrice.ToString() });
            //update_Order_Total(dishPrice);

            //Orders.Add(new aOrder() { Quantity = quantity, DishName = dishName, Price = dishPrice });
            string modification = "";
            string[] modifications = new string[ingredientsBool.Length];
            string[] visibMods = new string[ingredientsBool.Length];
            int changes = 0;

            for (int i = 0; i < modifications.Length; i++)
            {
                modifications[i] = "";
                visibMods[i] = "Collapsed";
            }

            for (int i = 0; i < ingredientsBool.Length; i++)
            {
                if (defaultIngredients[i] != ingredientsBool[i])
                {
                    if (defaultIngredients[i] == true)
                    {
                        modification += "No ";
                    }
                    else
                    {
                        modification += "Add ";
                    }
                    modification += ingredientName[i];
                    modifications[changes] = modification;
                    modification = "";
                    visibMods[changes] = "Visible";
                    changes++;
                }
            }
            Orders.Add(new aOrder() { Quantity = quantity, DishName = dishName, Price = (dishPrice * quantity), Ingredients = modifications, Visibility = visibMods });
            update_Order_Total(dishPrice * quantity);
        }


        public class aOrder
        {
            public int Quantity { get; set; }
            public string DishName { get; set; }
            public double Price { get; set; }

            public string[] Ingredients { get; set; }
            public string[] Visibility { get; set; }

            public string Button { get; set; }

            public string Disable_colour { get; set; }
        }

        private void x_button_Click(object sender, RoutedEventArgs e)
        {
            Button cmd = (Button)sender;
            if (cmd.DataContext is aOrder)
            {
                aOrder deleteme = (aOrder)cmd.DataContext;
                update_Order_Total(-deleteme.Price);
                Orders.Remove(deleteme);
            }
        }

        private void filter_unchecked(object sender, RoutedEventArgs e)
        {
            tabcontrol_Main.SelectedIndex = 8;
            string local_filter = ((CheckBox)(sender)).Content.ToString();

            if (local_filter.Contains("Vegetarian"))
            {
                filter_array[0] = 0;
            }
            else if (local_filter.Contains("Vegan"))
            {
                filter_array[1] = 0;
            }
            else if (local_filter.Contains("Chicken"))
            {
                filter_array[2] = 0;
            }
            else if (local_filter.Contains("Beef"))
            {
                filter_array[3] = 0;
            }
            else if (local_filter.Contains("Sea Food"))
            {
                filter_array[4] = 0;
            }
            else if (local_filter.Contains("Pork"))
            {
                filter_array[5] = 0;
            }
            update_all_items(filter_array);
        }

        private void filter_checked(object sender, RoutedEventArgs e)
        {
            if (checkbox_counter < 6)
            {
                checkbox_counter++;
                //return;
            }
            else
            {
                tabcontrol_Main.SelectedIndex = 8;
                string local_filter = ((CheckBox)(sender)).Content.ToString();

                //MessageBox.Show("Filter checked");
                if (local_filter.Contains("Vegetarian"))
                {
                    filter_array[0] = 1;
                }
                else if (local_filter.Contains("Vegan"))
                {
                    filter_array[1] = 1;
                }
                else if (local_filter.Contains("Chicken"))
                {
                    filter_array[2] = 1;
                }
                else if (local_filter.Contains("Beef"))
                {
                    filter_array[3] = 1;
                }
                else if (local_filter.Contains("Sea Food"))
                {
                    filter_array[4] = 1;
                }
                else if (local_filter.Contains("Pork"))
                {
                    filter_array[5] = 1;
                }
                update_all_items(filter_array);
            }

        }

        private void tabClicked(object sender, SelectionChangedEventArgs e)
        {
            if (mWin != null)
            {
                mWin.stack_infoScreen.Children.Clear();
                mWin.stack_confirmationControl.Children.Clear();
                mWin.stack_callServerConfirm.Children.Clear();
                mWin.stack_helpOverlay.Children.Clear();
                if (mWin.stack_infoScreen.Children.Capacity > 0)
                {
                    mWin.stack_infoScreen.Children.Capacity--;
                }
            }
        }

        public void update_all_items(int[] filterArray)
        {
            //MessageBox.Show("Update all Items called");
            num_of_category = myParser.getNums();
            item_summary = myParser.getInfo();
            double temp = Math.Ceiling(((double)(num_of_category[8])) / 2);
            menu_all.Children.Clear();
            menu_all.ColumnDefinitions.Clear();
            int local_counter = 0;

            for (int i = 0; i < myParser.item_summary.GetLength(0); i++)
            {
                filter = myParser.item_summary[i, 6];


                if (filter == "veggie" && filterArray[0] == 1)
                {
                    local_counter++;
                }
                else if (filter == "vegan" && filterArray[1] == 1)
                {
                    local_counter++;
                }
                else if (filter == "chicken" && filterArray[2] == 1)
                {
                    local_counter++;
                }
                else if (filter == "beef" && filterArray[3] == 1)
                {
                    local_counter++;
                }
                else if (filter == "seafood" && filterArray[4] == 1)
                {
                    local_counter++;
                }
                else if (filter == "peanut" && filterArray[5] == 1)
                {
                    local_counter++;
                }
                else if (filter == "none")
                {
                    local_counter++;
                }
            }
            double counter_temp = (double)local_counter;
            double temp2 = counter_temp / 2;
            //MessageBox.Show(Math.Ceiling(temp2).ToString());
            for (int i = 0; i < Math.Ceiling(temp2); i++)
            {
                ColumnDefinition cd = new ColumnDefinition();
                cd.Width = new GridLength(350);
                this.menu_all.ColumnDefinitions.Add(cd);
            }

            int row = 0;
            int col = 0;
            for (int i = 0; i < myParser.item_summary.GetLength(0); i++)
            {
                name = myParser.item_summary[i, 0];
                description = myParser.item_summary[i, 1];
                price = Math.Round(Double.Parse(myParser.item_summary[i, 2]), 2);
                ingredients = myParser.item_summary[i, 3];
                category = myParser.item_summary[i, 4];
                allergy = myParser.item_summary[i, 5];
                filter = myParser.item_summary[i, 6];
				item_image = myParser.item_summary[i, 7];

                menuItem_template item_info = new menuItem_template(mWin, this, name, description, price, ingredients, category, allergy, filter, item_image);

                if (filter == "veggie" && filterArray[0] == 1)
                {
                    this.menu_all.Children.Add(item_info);
                    Grid.SetRow(item_info, row);
                    Grid.SetColumn(item_info, col);

                    if (row == 1)
                    {
                        row = 0;
                        col++;
                    }
                    else
                    {
                        row++;
                    }
                }
                else if (filter == "vegan" && filterArray[1] == 1)
                {
                    this.menu_all.Children.Add(item_info);
                    Grid.SetRow(item_info, row);
                    Grid.SetColumn(item_info, col);

                    if (row == 1)
                    {
                        row = 0;
                        col++;
                    }
                    else
                    {
                        row++;
                    }
                }
                else if (filter == "chicken" && filterArray[2] == 1)
                {
                    this.menu_all.Children.Add(item_info);
                    Grid.SetRow(item_info, row);
                    Grid.SetColumn(item_info, col);

                    if (row == 1)
                    {
                        row = 0;
                        col++;
                    }
                    else
                    {
                        row++;
                    }
                }
                else if (filter == "beef" && filterArray[3] == 1)
                {
                    this.menu_all.Children.Add(item_info);
                    Grid.SetRow(item_info, row);
                    Grid.SetColumn(item_info, col);

                    if (row == 1)
                    {
                        row = 0;
                        col++;
                    }
                    else
                    {
                        row++;
                    }
                }
                else if (filter == "seafood" && filterArray[4] == 1)
                {
                    this.menu_all.Children.Add(item_info);
                    Grid.SetRow(item_info, row);
                    Grid.SetColumn(item_info, col);

                    if (row == 1)
                    {
                        row = 0;
                        col++;
                    }
                    else
                    {
                        row++;
                    }
                }
                else if (filter == "peanut" && filterArray[5] == 1)
                {
                    this.menu_all.Children.Add(item_info);
                    Grid.SetRow(item_info, row);
                    Grid.SetColumn(item_info, col);

                    if (row == 1)
                    {
                        row = 0;
                        col++;
                    }
                    else
                    {
                        row++;
                    }
                }
				else if (filter == "none")
                {
                    this.menu_all.Children.Add(item_info);
                    Grid.SetRow(item_info, row);
                    Grid.SetColumn(item_info, col);

                    if (row == 1)
                    {
                        row = 0;
                        col++;
                    }
                    else
                    {
                        row++;
                    }
                }
            }
        }

        private void button_search_clicked(object sender, RoutedEventArgs e)
        {
            string search_str = textbox_searchBar.Text;
            search_items(search_str);
        }

        public void search_items(string keyword)
        {
            tabcontrol_Main.SelectedIndex = 8;
            num_of_category = myParser.getNums();
            item_summary = myParser.getInfo();
            double temp = Math.Ceiling(((double)(num_of_category[8])) / 2);
            menu_all.Children.Clear();
            menu_all.ColumnDefinitions.Clear();
            int local_counter = 0;

            for (int i = 0; i < myParser.item_summary.GetLength(0); i++)
            {
                name = myParser.item_summary[i, 0];
                if (name.ToLower().Contains(keyword.ToLower()))
                {
                    local_counter++;
                }
                
            }
            double counter_temp = (double)local_counter;
            double temp2 = counter_temp / 2;
            //MessageBox.Show(Math.Ceiling(temp2).ToString());
            for (int i = 0; i < Math.Ceiling(temp2); i++)
            {
                ColumnDefinition cd = new ColumnDefinition();
                cd.Width = new GridLength(350);
                this.menu_all.ColumnDefinitions.Add(cd);
            }

            int row = 0;
            int col = 0;
            for (int i = 0; i < myParser.item_summary.GetLength(0); i++)
            {
                name = myParser.item_summary[i, 0];
                description = myParser.item_summary[i, 1];
                price = Math.Round(Double.Parse(myParser.item_summary[i, 2]), 2);
                ingredients = myParser.item_summary[i, 3];
                category = myParser.item_summary[i, 4];
                allergy = myParser.item_summary[i, 5];
                filter = myParser.item_summary[i, 6];
				item_image = myParser.item_summary[i, 7]; 

                menuItem_template item_info = new menuItem_template(mWin, this, name, description, price, ingredients, category, allergy, filter, item_image);

                if (name.ToLower().Contains(keyword.ToLower()))
                {
                    this.menu_all.Children.Add(item_info);
                    Grid.SetRow(item_info, row);
                    Grid.SetColumn(item_info, col);

                    if (row == 1)
                    {
                        row = 0;
                        col++;
                    }
                    else
                    {
                        row++;
                    }
                }
                
            }
        }

        private void searchbox_enter_pressed(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Return)
            {
                string search_str = textbox_searchBar.Text;
                search_items(search_str);
            }
        }

        private void button_help_Click(object sender, RoutedEventArgs e)
        {
            helpOverlayUC helpButton = new helpOverlayUC(this);
            mWin.stack_confirmationControl.Children.Clear();
            mWin.stack_callServerConfirm.Children.Clear();
            mWin.stack_helpOverlay.Children.Clear();
            
            if (mWin.stack_infoScreen.Children.Capacity > 0)
            {
                helpButton.set_image(new BitmapImage(new Uri(@"InfoMenuHelp.jpg", UriKind.RelativeOrAbsolute)));
            }
            else
            {
                helpButton.set_image(new BitmapImage(new Uri(@"MainMenuHelp.jpg", UriKind.RelativeOrAbsolute)));
            }
            mWin.stack_helpOverlay.Children.Add(helpButton);
        }

        public void turnOffHelpScreen()
        {
            mWin.stack_helpOverlay.Children.Clear();
        }

        private void button_server_Click(object sender, RoutedEventArgs e)
        {
            CallServerConfirmUC callServer = new CallServerConfirmUC(this);
            mWin.stack_infoScreen.Children.Clear();
            mWin.stack_confirmationControl.Children.Clear();
            mWin.stack_callServerConfirm.Children.Clear();
            mWin.stack_helpOverlay.Children.Clear();
            if (mWin.stack_infoScreen.Children.Capacity > 0)
            {
                mWin.stack_infoScreen.Children.Capacity--;
            }
            mWin.stack_callServerConfirm.Children.Add(callServer);
        }

        public void turnOffServerConfirmNotification()
        {
            mWin.stack_callServerConfirm.Children.Clear();
        }
    }
}