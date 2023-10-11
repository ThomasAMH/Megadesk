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
            materialSearch.Items.AddRange(Enum.GetNames(typeof(MaterialType)));
            materialSearch.SelectedIndex = 0;
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuView = (MainMenu)Tag;
            mainMenuView.Show();
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //get material selected
            MaterialType mType = (MaterialType) materialSearch.SelectedIndex;
            MessageBox.Show("Selected Index: " + mType.ToString());

            //get list of quotes

            //loop through quotes and search for material

            //send quote that fit params to an array

            //display array in a new page(desk quote w/ customer Name, quote date, desk specs, and overall quote)

        }
    }
}
