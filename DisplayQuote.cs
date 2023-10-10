using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Montoya
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuView = (MainMenu)Tag;
            mainMenuView.Show();
            Close();
        }

        private void ModifyQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteView = (AddQuote)Tag;
            addQuoteView.Show();
            this.Close();
        }

        private void SaveQuote_Click(object sender, EventArgs e)
        {
            //Only create the desk and quote object once the data has been reviewed by the user
            Desk userDesk = new Desk();
            userDesk.deskDepth = AddQuote.userDepth;
            userDesk.deskWidth = AddQuote.userWidth;
            userDesk.deskDrawerCount = AddQuote.userDrawers;
            userDesk.material = AddQuote.userMaterial;

            DeskQuote preparedDeskQuote = new DeskQuote();
            preparedDeskQuote.quoteDesk = userDesk;

            preparedDeskQuote.rushOrderDays = AddQuote.userRushOrderDays;
            preparedDeskQuote.quoteAmount = AddQuote.price;

            //LoadedQuotes.Quotes.Add(preparedDeskQuote);
            FileHandler.WriteQuoteToFile(preparedDeskQuote);
            MainMenu mainMenuView = new MainMenu();
            mainMenuView.Show();
            Close();

        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            //Load in data and get quote
            Height.Text = AddQuote.userHeight.ToString();
            Width.Text = AddQuote.userWidth.ToString();
            Depth.Text = AddQuote.userDepth.ToString();
            Drawers.Text = AddQuote.userDrawers.ToString();
            Material.Text = AddQuote.userMaterial.ToString();
            RushDays.Text = AddQuote.userRushOrderDays.ToString();
            InvoiceNumber.Text = AddQuote.userInvoiceNum.ToString();
            Header.Text += AddQuote.userCustomerName.ToString();
            Notes.Text = AddQuote.userNotes.ToString();

            SubtotalAmount.Text = "";
            SubtotalAmount.Text += AddQuote.price.ToString();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
