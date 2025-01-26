using System;

namespace WindowsFormsApp1
{
   public class Desk
   {
      // Attributes
      public double _width { get; private set; }
      public double _depth { get; private set; }
      public int _drawerNum { get; private set; }
      public string _material { get; private set; }

      // Constructor
      public Desk(double width, double depth, int drawerNum, string material)
      {
         _width = width;
         _depth = depth;
         _drawerNum = drawerNum;
         _material = material;
      }

      // Methods
      // Getters and Setters
      public void setWidth(double width) { _width = width; }
      public double getWidth() { return _width; }

      public void setDepth(double depth) { _depth = depth; }
      public double getDepth() { return _depth; }

      public void setDrawerNum(int drawerNum) { _drawerNum = drawerNum; }
      public int getDrawerNum() { return _drawerNum; }

      public void setMaterial(string material) { _material = material; }
      public string getMaterial() { return _material; }

      // Validation Methods
      public bool widthValidate(double width)
      {
         return 24.0 <= width && width <= 96.0;
      }

      public bool depthValidate(double depth)
      {
         return 12 <= depth && depth <= 48;
      }

      public bool drawerNumValidate(int drawerNum)
      {
         return 0 <= drawerNum && drawerNum <= 7;
      }

      public bool materialValidate(string material)
      {
         material = material.ToUpper();
         return material == "LAMINATE" || material == "OAK" || material == "ROSEWOOD" || material == "VENEER" || material == "PINE";
      }
   }
}
