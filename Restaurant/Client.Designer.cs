namespace Restaurant
{
    partial class Client
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
            this.lblTableNum = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblPriceTXT = new System.Windows.Forms.Label();
            this.lblCookTimeTXT = new System.Windows.Forms.Label();
            this.MenuCategory = new System.Windows.Forms.ComboBox();
            this.MenuMeal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblSubPriceText = new System.Windows.Forms.Label();
            this.lblCookingTime = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblMealPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTableNum
            // 
            this.lblTableNum.AutoSize = true;
            this.lblTableNum.Location = new System.Drawing.Point(55, 58);
            this.lblTableNum.Name = "lblTableNum";
            this.lblTableNum.Size = new System.Drawing.Size(102, 17);
            this.lblTableNum.TabIndex = 0;
            this.lblTableNum.Text = "Table Number:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(58, 106);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(121, 17);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Choose Category:";
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(58, 153);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(94, 17);
            this.lblFood.TabIndex = 2;
            this.lblFood.Text = "Choose Meal:";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(142, 390);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(123, 43);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblPriceTXT
            // 
            this.lblPriceTXT.AutoSize = true;
            this.lblPriceTXT.Location = new System.Drawing.Point(58, 338);
            this.lblPriceTXT.Name = "lblPriceTXT";
            this.lblPriceTXT.Size = new System.Drawing.Size(80, 17);
            this.lblPriceTXT.TabIndex = 4;
            this.lblPriceTXT.Text = "Total Price:";
            // 
            // lblCookTimeTXT
            // 
            this.lblCookTimeTXT.AutoSize = true;
            this.lblCookTimeTXT.Location = new System.Drawing.Point(58, 302);
            this.lblCookTimeTXT.Name = "lblCookTimeTXT";
            this.lblCookTimeTXT.Size = new System.Drawing.Size(98, 17);
            this.lblCookTimeTXT.TabIndex = 5;
            this.lblCookTimeTXT.Text = "Cooking Time:";
            // 
            // MenuCategory
            // 
            this.MenuCategory.FormattingEnabled = true;
            this.MenuCategory.Location = new System.Drawing.Point(186, 106);
            this.MenuCategory.Name = "MenuCategory";
            this.MenuCategory.Size = new System.Drawing.Size(134, 24);
            this.MenuCategory.TabIndex = 6;
            this.MenuCategory.SelectedIndexChanged += new System.EventHandler(this.MenuCategory_SelectedIndexChanged);
            // 
            // MenuMeal
            // 
            this.MenuMeal.FormattingEnabled = true;
            this.MenuMeal.Location = new System.Drawing.Point(186, 153);
            this.MenuMeal.Name = "MenuMeal";
            this.MenuMeal.Size = new System.Drawing.Size(134, 24);
            this.MenuMeal.TabIndex = 7;
            this.MenuMeal.Text = "Select Category";
            this.MenuMeal.SelectedIndexChanged += new System.EventHandler(this.MenuMeal_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 11;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(189, 57);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(0, 17);
            this.lblTable.TabIndex = 12;
            // 
            // lblSubPriceText
            // 
            this.lblSubPriceText.AutoSize = true;
            this.lblSubPriceText.Location = new System.Drawing.Point(61, 268);
            this.lblSubPriceText.Name = "lblSubPriceText";
            this.lblSubPriceText.Size = new System.Drawing.Size(78, 17);
            this.lblSubPriceText.TabIndex = 13;
            this.lblSubPriceText.Text = "Meal Price:";
            // 
            // lblCookingTime
            // 
            this.lblCookingTime.AutoSize = true;
            this.lblCookingTime.Location = new System.Drawing.Point(186, 302);
            this.lblCookingTime.Name = "lblCookingTime";
            this.lblCookingTime.Size = new System.Drawing.Size(0, 17);
            this.lblCookingTime.TabIndex = 14;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(186, 337);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 17);
            this.lblTotalPrice.TabIndex = 15;
            // 
            // lblMealPrice
            // 
            this.lblMealPrice.AutoSize = true;
            this.lblMealPrice.Location = new System.Drawing.Point(186, 267);
            this.lblMealPrice.Name = "lblMealPrice";
            this.lblMealPrice.Size = new System.Drawing.Size(0, 17);
            this.lblMealPrice.TabIndex = 16;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 506);
            this.Controls.Add(this.lblMealPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblCookingTime);
            this.Controls.Add(this.lblSubPriceText);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuMeal);
            this.Controls.Add(this.MenuCategory);
            this.Controls.Add(this.lblCookTimeTXT);
            this.Controls.Add(this.lblPriceTXT);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblTableNum);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableNum;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblPriceTXT;
        private System.Windows.Forms.Label lblCookTimeTXT;
        private System.Windows.Forms.ComboBox MenuCategory;
        private System.Windows.Forms.ComboBox MenuMeal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblSubPriceText;
        private System.Windows.Forms.Label lblCookingTime;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblMealPrice;
    }
}