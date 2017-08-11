using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WpfApplication2
{
    public class parser
    {
        string filename = "database.txt";
        public string[,] item_summary;
        public int num_specials = 0;
        public int num_beverages = 0;
        public int num_appetizers = 0;
        public int num_salads = 0;
        public int num_pizza = 0;
        public int num_burgers = 0;
        public int num_poutines = 0;
        public int num_desserts = 0;
        public int num_all_items = 0;
        public int[] num_category = new int[9];

        public parser()
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("Database not found");
                return;
            }
            else
            {
                StreamReader sr = new StreamReader(filename);
                string linetemp;
                int con = 0;
                while ((linetemp = sr.ReadLine()) != null)
                {
                    if (linetemp.Contains("EOF"))
                    {
                        break;
                    }
                    con++;
                }
                num_all_items = con;
                StreamReader sr2 = new StreamReader(filename);
                item_summary = new string[con, 8];
                string[] temp;
                string line;
                int index = 0;

                while ((line = sr2.ReadLine()) != null)
                {
                    temp = line.Split(';');
                    if (temp[0].Contains("EOF"))
                    {
                        break;
                    }

                    if (temp[4].Contains("special"))
                    {
                        num_specials++;
                    }
                    else if (temp[4].Contains("beverage"))
                    {
                        num_beverages++;
                    }
                    else if (temp[4].Contains("appetizer"))
                    {
                        num_appetizers++;
                    }
                    else if (temp[4].Contains("salad"))
                    {
                        num_salads++;
                    }
                    else if (temp[4].Contains("pizza"))
                    {
                        num_pizza++;
                    }
                    else if (temp[4].Contains("burger"))
                    {
                        num_burgers++;
                    }
                    else if (temp[4].Contains("poutine"))
                    {
                        num_poutines++;
                    }
                    else if (temp[4].Contains("dessert"))
                    {
                        num_desserts++;
                    }

                    for (int i = 0; i < temp.Length; i++)
                    {
                        item_summary[index, i] = temp[i];
                    }
                    index++;
                }
                sr.Close();
                sr2.Close();
            }
        }

        public string[,] getInfo()
        {
            return item_summary;
        }

        public int[] getNums()
        {
            num_category[0] = num_specials;
            num_category[1] = num_beverages;
            num_category[2] = num_appetizers;
            num_category[3] = num_salads;
            num_category[4] = num_pizza;
            num_category[5] = num_burgers;
            num_category[6] = num_poutines;
            num_category[7] = num_desserts;
            num_category[8] = num_all_items;
            return num_category;
        }

    }
}
