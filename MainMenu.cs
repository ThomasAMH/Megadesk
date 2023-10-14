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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteView = new AddQuote();
            addQuoteView.Tag = this;
            addQuoteView.Show(this);
            Hide();
        }
        private void ViewAllQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes ViewAllQuotesView = new ViewAllQuotes();
            ViewAllQuotesView.Tag = this;
            ViewAllQuotesView.Show(this);
            Hide();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes SearchQuotesView = new SearchQuotes();
            SearchQuotesView.Tag = this;
            SearchQuotesView.Show(this);
            Hide();
        }

        private void mainExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
