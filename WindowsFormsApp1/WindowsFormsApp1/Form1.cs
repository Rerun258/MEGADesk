using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void addQuoteButton_Click(object sender, EventArgs e)
      {
         AddQuote viewAddQuoteForm = new AddQuote();
         viewAddQuoteForm.Tag = this;
         viewAddQuoteForm.Show();
         Hide();

      }

      private void viewQuotesButton_Click(object sender, EventArgs e)
      {
         foreach (var quote in DeskQuoteStorage.DeskQuotes)
         {
            // Display or process the quotes
            Console.WriteLine($"Name: {quote.getName()}, Price: {quote.getPrice()}");
         }
      }


      private void searchQuoteButton_Click(object sender, EventArgs e)
      {
         // Implement search functionality here
         // Example:
         string searchMaterial = "oak"; // Replace with actual search input
         var quotes = DeskQuoteStorage.DeskQuotes.Where(q => q.desk.getMaterial().Equals(searchMaterial, StringComparison.OrdinalIgnoreCase)).ToList();
         foreach (var quote in quotes)
         {
            // Display or process the search results
            Console.WriteLine($"Name: {quote.getName()}, Price: {quote.getPrice()}");
         }
      }

      private void exitButton_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
   }
}
