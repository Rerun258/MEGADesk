using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public class DeskQuote
   {
      // Attributes
      private string _name;
      private DateTime _quoteDate;
      public Desk desk;
      private double _price;
      private int _rushDays;

      // Constructors
      public DeskQuote(string name, Desk desk, int rushDays)
      {
         _name = name;
         this.desk = desk;
         _rushDays = rushDays;
         _quoteDate = DateTime.Now;
         _price = setPrice(desk.getWidth(), desk.getDepth(), desk.getDrawerNum(), desk.getMaterial(), _rushDays); // Added missing semicolon
      }

      // Methods
      public string getName() { return _name; }
      public DateTime getQuoteDate() { return _quoteDate; }
      public double getPrice() { return _price; }
      public int getRushDays() { return _rushDays; }

      // get price
      private double setPrice(double width, double depth, int drawerNum, string material, int orderTimeLine)
      {
         const double BASE_PRICE = 200;
         const double AREA_THRESHOLD = 1000;
         const double AREA_COST = 1;
         const double DRAWER_COST = 50;

         // Calculate surface area
         double surfaceArea = width * depth;

         // Base price
         double totalPrice = BASE_PRICE;

         // Add surface area cost if applicable
         if (surfaceArea > AREA_THRESHOLD)
         {
            totalPrice += (surfaceArea - AREA_THRESHOLD) * AREA_COST;
         }

         // Add drawer cost
         totalPrice += drawerNum * DRAWER_COST;

         // Add material cost
         switch (material.ToUpper())
         {
            case "OAK":
               totalPrice += 200;
               break;
            case "LAMINATE":
               totalPrice += 100;
               break;
            case "PINE":
               totalPrice += 50;
               break;
            case "ROSEWOOD":
               totalPrice += 300;
               break;
            case "VENEER":
               totalPrice += 125;
               break;
            default:
               throw new ArgumentException("Invalid material");
         }

         // Add rush order cost based on size and timeline
         if (orderTimeLine == 3)
         {
            if (surfaceArea < 1000)
            {
               totalPrice += 60;
            }
            else if (surfaceArea <= 2000)
            {
               totalPrice += 70;
            }
            else
            {
               totalPrice += 80;
            }
         }
         else if (orderTimeLine == 5)
         {
            if (surfaceArea < 1000)
            {
               totalPrice += 40;
            }
            else if (surfaceArea <= 2000)
            {
               totalPrice += 50;
            }
            else
            {
               totalPrice += 60;
            }
         }
         else if (orderTimeLine == 7)
         {
            if (surfaceArea < 1000)
            {
               totalPrice += 30;
            }
            else if (surfaceArea <= 2000)
            {
               totalPrice += 35;
            }
            else
            {
               totalPrice += 40;
            }
         }

         return totalPrice;
      }
   }
}
