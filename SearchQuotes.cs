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
            MaterialType searchByMatType = (MaterialType) materialSearchCB.SelectedIndex;
            
            //set up 'none found' alert
            bool foundMatch = false;

            //loop through quotes
            for (int i = 0; i < LoadedQuotes.Quotes.Count; i++)
            { 
                //find by material
                if (LoadedQuotes.Quotes[i].quoteDesk.material == searchByMatType)
                {
                 //display quote

                    string custName = LoadedQuotes.Quotes[i].customerName;
                    string quoteDate = LoadedQuotes.Quotes[i].invoiceDate.ToString();
                    double deskWidth = LoadedQuotes.Quotes[i].quoteDesk.deskWidth;
                    double deskDepth = LoadedQuotes.Quotes[i].quoteDesk.deskDepth;
                    int deskDrawerCount = LoadedQuotes.Quotes[i].quoteDesk.deskDrawerCount;
                    string material = LoadedQuotes.Quotes[i].quoteDesk.material.ToString();
                    double price = LoadedQuotes.Quotes[i].quoteAmount;
                    
                    //set found to true so the none found won't display
                    foundMatch = true;

                    MessageBox.Show("Customer Name: " + custName + "\n"
                        + "Order Date of Quote:" + quoteDate + "\n"
                        + "Width: " + deskWidth + "\n"
                        + "Depth: " + deskDepth + "\n"
                        + "Number of Drawers: " + deskDrawerCount + "\n"
                        + "Material: " + material + "\n" 
                        + "Total Price: $" + price);

                }
                
            }

            //if no matches display a message box
            if (foundMatch == false)
            {
                MessageBox.Show("No Matches Found");
            }

        }
    }
}
