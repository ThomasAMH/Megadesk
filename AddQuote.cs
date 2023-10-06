using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Montoya
{
    public partial class AddQuote : Form
    {
        public static double userHight;
        public static double userWidth;
        public static double userDepth;
        public static double userDrawers;
        public static string userMaterial;
        public static int userRushOrderDays;
        public static string userInvoiceNum;
        public static string userCustomerName;
        public static string userNotes;
        public static double price;
        public AddQuote()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuView = (MainMenu)Tag;
            mainMenuView.Show();
            Close();
        }


        private void validateWidth(object sender, CancelEventArgs e)
        {
            try { _ = double.Parse(WidthTextbox.Text); }
            catch
            {
                WidthLabel.BackColor = Color.Red;
                DiplayQuoteButton.Enabled = false;
                return;
            }
            if (double.Parse(WidthTextbox.Text) < Validator.WIDTH_MIN || double.Parse(WidthTextbox.Text) > Validator.WIDTH_MAX)
            {
                WidthLabel.BackColor = Color.Red;
                DiplayQuoteButton.Enabled = false;
            }
            else
            {
                WidthLabel.BackColor = SystemColors.Control;
                DiplayQuoteButton.Enabled = true;
            }
        }
        private void validateDepth(object sender, CancelEventArgs e)
        {

        }
        private void DepthTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            //Validate the depth text box's input
            if (char.IsControl((char)e.KeyValue))
            {
                DepthLabel.BackColor = Color.Red;
                DiplayQuoteButton.Enabled = false;
                return;
            }

            else if (!char.IsDigit((char)e.KeyValue))
            {
                DepthLabel.BackColor = Color.Red;
                DiplayQuoteButton.Enabled = false;
                return;
            }

            DepthLabel.BackColor = SystemColors.Control;
            DiplayQuoteButton.Enabled = true;
        }

        private void SaveButton_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void DiplayQuoteButton_Click(object sender, EventArgs e)
        {
            userHight = double.Parse(HeightTextBox.Text);
            userWidth = double.Parse(WidthTextbox.Text); ;
            userDepth = double.Parse(DepthTextbox.Text); ;
            userDrawers = int.Parse(DrawersCombobox.Text); ;
            userMaterial = MaterialCombobox.Text;
            userRushOrderDays = int.Parse(HeightTextBox.Text); ;
            userInvoiceNum = InvoiceNumTextbox.Text;
            userCustomerName = BillToNameTextbox.Text;
            userNotes = NotesTextbox.Text;
            //price = CalculatePrice();

            DisplayQuote DisplayQuoteView = new DisplayQuote();
            DisplayQuoteView.Tag = this;
            DisplayQuoteView.Show(this);
            Hide();
        }
    }
}
