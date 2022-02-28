namespace FridgeDB
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
            this.Food = new System.Windows.Forms.Label();
            this.ListFood = new System.Windows.Forms.ListBox();
            this.FoodName = new System.Windows.Forms.Label();
            this.listFoodNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Food
            // 
            this.Food.AutoSize = true;
            this.Food.Location = new System.Drawing.Point(163, 84);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(31, 13);
            this.Food.TabIndex = 0;
            this.Food.Text = "Food";
            // 
            // ListFood
            // 
            this.ListFood.FormattingEnabled = true;
            this.ListFood.Location = new System.Drawing.Point(154, 177);
            this.ListFood.Name = "ListFood";
            this.ListFood.Size = new System.Drawing.Size(120, 95);
            this.ListFood.TabIndex = 1;
            this.ListFood.SelectedIndexChanged += new System.EventHandler(this.ListFood_SelectedIndexChanged);
            // 
            // FoodName
            // 
            this.FoodName.AutoSize = true;
            this.FoodName.Location = new System.Drawing.Point(417, 84);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(62, 13);
            this.FoodName.TabIndex = 2;
            this.FoodName.Text = "Food Name";
            // 
            // listFoodNames
            // 
            this.listFoodNames.FormattingEnabled = true;
            this.listFoodNames.Location = new System.Drawing.Point(420, 177);
            this.listFoodNames.Name = "listFoodNames";
            this.listFoodNames.Size = new System.Drawing.Size(120, 95);
            this.listFoodNames.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listFoodNames);
            this.Controls.Add(this.FoodName);
            this.Controls.Add(this.ListFood);
            this.Controls.Add(this.Food);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Food;
        private System.Windows.Forms.ListBox ListFood;
        private System.Windows.Forms.Label FoodName;
        private System.Windows.Forms.ListBox listFoodNames;
    }
}

