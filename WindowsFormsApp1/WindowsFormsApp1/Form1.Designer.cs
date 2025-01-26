namespace WindowsFormsApp1
{
   partial class Form1
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
         this.exitButton = new System.Windows.Forms.Button();
         this.searchQuoteButton = new System.Windows.Forms.Button();
         this.viewQuotesButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // addQuoteButton
         // 
         this.addQuoteButton.AutoSize = true;
         this.addQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.addQuoteButton.Location = new System.Drawing.Point(28, 57);
         this.addQuoteButton.Name = "addQuoteButton";
         this.addQuoteButton.Size = new System.Drawing.Size(194, 39);
         this.addQuoteButton.TabIndex = 0;
         this.addQuoteButton.Text = "Add New Quote";
         this.addQuoteButton.UseVisualStyleBackColor = true;
         this.addQuoteButton.Click += new System.EventHandler(this.addQuoteButton_Click);
         // 
         // exitButton
         // 
         this.exitButton.AutoSize = true;
         this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.exitButton.Location = new System.Drawing.Point(28, 241);
         this.exitButton.Name = "exitButton";
         this.exitButton.Size = new System.Drawing.Size(194, 39);
         this.exitButton.TabIndex = 1;
         this.exitButton.Text = "Exit";
         this.exitButton.UseVisualStyleBackColor = true;
         this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
         // 
         // searchQuoteButton
         // 
         this.searchQuoteButton.AutoSize = true;
         this.searchQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.searchQuoteButton.Location = new System.Drawing.Point(28, 178);
         this.searchQuoteButton.Name = "searchQuoteButton";
         this.searchQuoteButton.Size = new System.Drawing.Size(194, 39);
         this.searchQuoteButton.TabIndex = 2;
         this.searchQuoteButton.Text = "Search Quotes";
         this.searchQuoteButton.UseVisualStyleBackColor = true;
         this.searchQuoteButton.Click += new System.EventHandler(this.searchQuoteButton_Click);
         // 
         // viewQuotesButton
         // 
         this.viewQuotesButton.AutoSize = true;
         this.viewQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.viewQuotesButton.Location = new System.Drawing.Point(28, 119);
         this.viewQuotesButton.Name = "viewQuotesButton";
         this.viewQuotesButton.Size = new System.Drawing.Size(194, 39);
         this.viewQuotesButton.TabIndex = 3;
         this.viewQuotesButton.Text = "View Quotes";
         this.viewQuotesButton.UseVisualStyleBackColor = true;
         this.viewQuotesButton.Click += new System.EventHandler(this.viewQuotesButton_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.viewQuotesButton);
         this.Controls.Add(this.searchQuoteButton);
         this.Controls.Add(this.exitButton);
         this.Controls.Add(this.addQuoteButton);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button addQuoteButton;
      private System.Windows.Forms.Button exitButton;
      private System.Windows.Forms.Button searchQuoteButton;
      private System.Windows.Forms.Button viewQuotesButton;
   }
}

