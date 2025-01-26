namespace WindowsFormsApp1
{
   partial class AddQuote
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.addQuoteButton = new System.Windows.Forms.Button();
         this.nameTextBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.nameLable = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.materialTextBox = new System.Windows.Forms.TextBox();
         this.drawersTextBox = new System.Windows.Forms.TextBox();
         this.depthTextBox = new System.Windows.Forms.TextBox();
         this.widthTextBox = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label11 = new System.Windows.Forms.Label();
         this.orderDaysTextBox = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // addQuoteButton
         // 
         this.addQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addQuoteButton.Location = new System.Drawing.Point(328, 394);
         this.addQuoteButton.Name = "addQuoteButton";
         this.addQuoteButton.Size = new System.Drawing.Size(145, 44);
         this.addQuoteButton.TabIndex = 0;
         this.addQuoteButton.Text = "Add Quote";
         this.addQuoteButton.UseVisualStyleBackColor = true;
         this.addQuoteButton.Click += new System.EventHandler(this.addQuoteButton_Click);
         // 
         // nameTextBox
         // 
         this.nameTextBox.Location = new System.Drawing.Point(171, 48);
         this.nameTextBox.Name = "nameTextBox";
         this.nameTextBox.Size = new System.Drawing.Size(172, 22);
         this.nameTextBox.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(27, 82);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(41, 16);
         this.label1.TabIndex = 2;
         this.label1.Text = "Width";
         // 
         // nameLable
         // 
         this.nameLable.AutoSize = true;
         this.nameLable.Location = new System.Drawing.Point(27, 56);
         this.nameLable.Name = "nameLable";
         this.nameLable.Size = new System.Drawing.Size(44, 16);
         this.nameLable.TabIndex = 3;
         this.nameLable.Text = "Name";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(27, 166);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(55, 16);
         this.label2.TabIndex = 4;
         this.label2.Text = "Material";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(27, 138);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(122, 16);
         this.label3.TabIndex = 5;
         this.label3.Text = "Number of Drawers";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(27, 110);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(43, 16);
         this.label4.TabIndex = 6;
         this.label4.Text = "Depth";
         // 
         // materialTextBox
         // 
         this.materialTextBox.Location = new System.Drawing.Point(171, 160);
         this.materialTextBox.Name = "materialTextBox";
         this.materialTextBox.Size = new System.Drawing.Size(172, 22);
         this.materialTextBox.TabIndex = 7;
         // 
         // drawersTextBox
         // 
         this.drawersTextBox.Location = new System.Drawing.Point(171, 132);
         this.drawersTextBox.Name = "drawersTextBox";
         this.drawersTextBox.Size = new System.Drawing.Size(172, 22);
         this.drawersTextBox.TabIndex = 8;
         // 
         // depthTextBox
         // 
         this.depthTextBox.Location = new System.Drawing.Point(171, 104);
         this.depthTextBox.Name = "depthTextBox";
         this.depthTextBox.Size = new System.Drawing.Size(172, 22);
         this.depthTextBox.TabIndex = 9;
         // 
         // widthTextBox
         // 
         this.widthTextBox.Location = new System.Drawing.Point(171, 76);
         this.widthTextBox.Name = "widthTextBox";
         this.widthTextBox.Size = new System.Drawing.Size(172, 22);
         this.widthTextBox.TabIndex = 10;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(359, 166);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(300, 16);
         this.label6.TabIndex = 12;
         this.label6.Text = "Options: laminate, oak, rosewood, veneer, or pine";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(359, 138);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(210, 16);
         this.label7.TabIndex = 13;
         this.label7.Text = "Options: Between 0 and 7 Drawers";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(359, 110);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(213, 16);
         this.label8.TabIndex = 14;
         this.label8.Text = "Options: Between 12 and 48 inches";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.Location = new System.Drawing.Point(359, 82);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(213, 16);
         this.label9.TabIndex = 15;
         this.label9.Text = "Options: Between 24 and 96 inches";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.Location = new System.Drawing.Point(359, 196);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(281, 16);
         this.label10.TabIndex = 18;
         this.label10.Text = "Options: 3, 5, 7 or 14 days (Respectivly Priced)";
         // 
         // label11
         // 
         this.label11.AutoSize = true;
         this.label11.Location = new System.Drawing.Point(27, 194);
         this.label11.Name = "label11";
         this.label11.Size = new System.Drawing.Size(99, 16);
         this.label11.TabIndex = 17;
         this.label11.Text = "Days to Recive";
         // 
         // orderDaysTextBox
         // 
         this.orderDaysTextBox.Location = new System.Drawing.Point(171, 188);
         this.orderDaysTextBox.Name = "orderDaysTextBox";
         this.orderDaysTextBox.Size = new System.Drawing.Size(172, 22);
         this.orderDaysTextBox.TabIndex = 16;
         // 
         // AddQuote
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.label10);
         this.Controls.Add(this.label11);
         this.Controls.Add(this.orderDaysTextBox);
         this.Controls.Add(this.label9);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.widthTextBox);
         this.Controls.Add(this.depthTextBox);
         this.Controls.Add(this.drawersTextBox);
         this.Controls.Add(this.materialTextBox);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.nameLable);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.nameTextBox);
         this.Controls.Add(this.addQuoteButton);
         this.Name = "AddQuote";
         this.Text = "Form2";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button addQuoteButton;
      private System.Windows.Forms.TextBox nameTextBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label nameLable;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox materialTextBox;
      private System.Windows.Forms.TextBox drawersTextBox;
      private System.Windows.Forms.TextBox depthTextBox;
      private System.Windows.Forms.TextBox widthTextBox;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label11;
      private System.Windows.Forms.TextBox orderDaysTextBox;
   }
}