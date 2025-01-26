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
   public partial class AddQuote : Form
   {
      public AddQuote()
      {
         InitializeComponent();
      }

      private void addQuoteButton_Click(object sender, EventArgs e)
      {
         // Reset the colors to starting colors to indicate that text in the boxes are correct
         materialTextBox.BackColor = SystemColors.Control;
         widthTextBox.BackColor = SystemColors.Control;
         depthTextBox.BackColor = SystemColors.Control;
         drawersTextBox.BackColor = SystemColors.Control;

         //Attributes
         string name = nameTextBox.Text;
         double width;
         double depth;
         int drawer;
         string material = materialTextBox.Text.ToLower();
         string[] approvedMaterials = new string[] { "laminate", "oak", "rosewood", "veneer", "pine" };
         int orderTimeLine;

         // Validity Tests
         bool isWidthValid = double.TryParse(widthTextBox.Text, out width) && (width <= 96 && width >= 24);
         bool isDepthValid = double.TryParse(depthTextBox.Text, out depth) && (depth <= 48 && depth >= 12);
         bool isDrawerValid = int.TryParse(drawersTextBox.Text, out drawer) && (drawer <= 7 && drawer >= 0);
         bool isMaterialValid = approvedMaterials.Contains(material);
         bool isOrderTimeLineValid = int.TryParse(orderDaysTextBox.Text, out orderTimeLine) && 
            (orderTimeLine == 3 || orderTimeLine == 5 || orderTimeLine == 7 || orderTimeLine == 14);

         //More Validity tests
         if (!isWidthValid)
         {
            
            widthTextBox.BackColor = Color.Red;
            
         }
         if (!isDrawerValid) 
         {
            
            drawersTextBox.BackColor = Color.Red;
            
         }
         if (!isDepthValid) 
         {
            
            depthTextBox.BackColor = Color.Red;
            
         }
         if (!isOrderTimeLineValid)
         {
            orderDaysTextBox.BackColor = Color.Red;
         }
         if (!isWidthValid || !isDrawerValid || !isDepthValid || !isOrderTimeLineValid)
         {
            _ = MessageBox.Show("Please enter valid numerical values for width, depth, and drawers.");
            return;
         }
         if (!isMaterialValid)
         {
            materialTextBox.BackColor = Color.Red;
            _ = MessageBox.Show("incorrect material.");
            return;

         }
         

         // make a new desk
         Desk newDesk = new Desk(width, depth, drawer, material);

         //put the desk into a quote
         DeskQuote newQuote = new DeskQuote(name, newDesk, orderTimeLine);

         //Add Quote to a list
         DeskQuoteStorage.DeskQuotes.Add(newQuote);

         //Signal Quote price and return to Form1
         MessageBox.Show($"the Quote is ${newQuote.getPrice()}");

         Form1 firstForm = (Form1)Tag;
         firstForm.Show();
         Close();
         //DeskQuote()


      }
   }
}
