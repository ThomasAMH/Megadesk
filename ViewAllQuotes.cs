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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenuView = (MainMenu)Tag;
            mainMenuView.Show();
            Close();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            // Loop through quotes and populate the DataGridView
            foreach (var quote in LoadedQuotes.Quotes)
            {
                int rowIndex = dataGridViewQuotes.Rows.Add();
                DataGridViewRow row = dataGridViewQuotes.Rows[rowIndex];

                // Populate the cells in the row with data
                row.Cells["customerName"].Value = quote.customerName;
                row.Cells["invoiceDate"].Value = quote.invoiceDate;
                row.Cells["quoteAmount"].Value = "$" + quote.quoteAmount;
                row.Cells["rushOrderDays"].Value = quote.rushOrderDays + " Days";
                row.Cells["deskDepth"].Value = quote.quoteDesk.deskDepth + " in";
                row.Cells["deskWidth"].Value = quote.quoteDesk.deskWidth + " in";
                row.Cells["deskDrawerCount"].Value = quote.quoteDesk.deskDrawerCount;
                row.Cells["deskMaterial"].Value = quote.quoteDesk.material;
            }
        }
    }
}
