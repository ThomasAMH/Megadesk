using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Montoya
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox() {
            materialSearchCB.Items.AddRange(Enum.GetNames(typeof(MaterialType)));
            materialSearchCB.SelectedIndex = 0;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuView = (MainMenu)Tag;
            mainMenuView.Show();
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //get selected material
            MaterialType mType = (MaterialType) materialSearchCB.SelectedIndex;

            //loop through quotes
            
            for (int i = 0; i < LoadedQuotes.Quotes.Count; i++)
            { 
                //find by material
                if (LoadedQuotes.Quotes[i].quoteDesk.material == mType)
                {
                    //save quote
                    Console.WriteLine("Found it! :)");
                    Console.WriteLine(LoadedQuotes.Quotes[i]);

                   
                    //string custName = LoadedQuotes.Quotes[i].customerName.ToString();
                    string material = LoadedQuotes.Quotes[i].quoteDesk.material.ToString();
                    decimal price = (decimal)LoadedQuotes.Quotes[i].quoteAmount;

                    MessageBox.Show("Material: " + material + "\n" + "Total Price: $" + price);

                }
                
            }

            //display in a new page(Customer Name, quote date, desk specs, overall price)

        }
    }
}
