namespace ShoppingApplication
{
    partial class StoreForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxFilter = new System.Windows.Forms.GroupBox();
            this.rbnAll = new System.Windows.Forms.RadioButton();
            this.rbnKitchen = new System.Windows.Forms.RadioButton();
            this.rbnClothes = new System.Windows.Forms.RadioButton();
            this.rbnComputers = new System.Windows.Forms.RadioButton();
            this.rbnCars = new System.Windows.Forms.RadioButton();
            this.rbnPhonesGPS = new System.Windows.Forms.RadioButton();
            this.lstBoxItems = new System.Windows.Forms.ListBox();
            this.btnAddToTrolly = new System.Windows.Forms.Button();
            this.lstBoxTrolly = new System.Windows.Forms.ListBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnBuyItems = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(128, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(119, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for item name:";
            // 
            // grpBoxFilter
            // 
            this.grpBoxFilter.Controls.Add(this.rbnAll);
            this.grpBoxFilter.Controls.Add(this.rbnKitchen);
            this.grpBoxFilter.Controls.Add(this.rbnClothes);
            this.grpBoxFilter.Controls.Add(this.rbnComputers);
            this.grpBoxFilter.Controls.Add(this.rbnCars);
            this.grpBoxFilter.Controls.Add(this.rbnPhonesGPS);
            this.grpBoxFilter.Location = new System.Drawing.Point(261, 23);
            this.grpBoxFilter.Name = "grpBoxFilter";
            this.grpBoxFilter.Size = new System.Drawing.Size(189, 95);
            this.grpBoxFilter.TabIndex = 3;
            this.grpBoxFilter.TabStop = false;
            this.grpBoxFilter.Text = "Filter";
            // 
            // rbnAll
            // 
            this.rbnAll.AutoSize = true;
            this.rbnAll.Checked = true;
            this.rbnAll.Location = new System.Drawing.Point(108, 64);
            this.rbnAll.Name = "rbnAll";
            this.rbnAll.Size = new System.Drawing.Size(36, 17);
            this.rbnAll.TabIndex = 5;
            this.rbnAll.TabStop = true;
            this.rbnAll.Text = "All";
            this.rbnAll.UseVisualStyleBackColor = true;
            this.rbnAll.Click += new System.EventHandler(this.SetFilter);
            // 
            // rbnKitchen
            // 
            this.rbnKitchen.AutoSize = true;
            this.rbnKitchen.Location = new System.Drawing.Point(6, 64);
            this.rbnKitchen.Name = "rbnKitchen";
            this.rbnKitchen.Size = new System.Drawing.Size(61, 17);
            this.rbnKitchen.TabIndex = 4;
            this.rbnKitchen.Text = "Kitchen";
            this.rbnKitchen.UseVisualStyleBackColor = true;
            this.rbnKitchen.Click += new System.EventHandler(this.SetFilter);
            // 
            // rbnClothes
            // 
            this.rbnClothes.AutoSize = true;
            this.rbnClothes.Location = new System.Drawing.Point(108, 41);
            this.rbnClothes.Name = "rbnClothes";
            this.rbnClothes.Size = new System.Drawing.Size(60, 17);
            this.rbnClothes.TabIndex = 3;
            this.rbnClothes.Text = "Clothes";
            this.rbnClothes.UseVisualStyleBackColor = true;
            this.rbnClothes.Click += new System.EventHandler(this.SetFilter);
            // 
            // rbnComputers
            // 
            this.rbnComputers.AutoSize = true;
            this.rbnComputers.Location = new System.Drawing.Point(6, 41);
            this.rbnComputers.Name = "rbnComputers";
            this.rbnComputers.Size = new System.Drawing.Size(75, 17);
            this.rbnComputers.TabIndex = 2;
            this.rbnComputers.Text = "Computers";
            this.rbnComputers.UseVisualStyleBackColor = true;
            this.rbnComputers.Click += new System.EventHandler(this.SetFilter);
            // 
            // rbnCars
            // 
            this.rbnCars.AutoSize = true;
            this.rbnCars.Location = new System.Drawing.Point(108, 18);
            this.rbnCars.Name = "rbnCars";
            this.rbnCars.Size = new System.Drawing.Size(46, 17);
            this.rbnCars.TabIndex = 1;
            this.rbnCars.Text = "Cars";
            this.rbnCars.UseVisualStyleBackColor = true;
            this.rbnCars.Click += new System.EventHandler(this.SetFilter);
            // 
            // rbnPhonesGPS
            // 
            this.rbnPhonesGPS.AutoSize = true;
            this.rbnPhonesGPS.Location = new System.Drawing.Point(6, 18);
            this.rbnPhonesGPS.Name = "rbnPhonesGPS";
            this.rbnPhonesGPS.Size = new System.Drawing.Size(61, 17);
            this.rbnPhonesGPS.TabIndex = 0;
            this.rbnPhonesGPS.Text = "Phones";
            this.rbnPhonesGPS.UseVisualStyleBackColor = true;
            this.rbnPhonesGPS.Click += new System.EventHandler(this.SetFilter);
            // 
            // lstBoxItems
            // 
            this.lstBoxItems.FormattingEnabled = true;
            this.lstBoxItems.Location = new System.Drawing.Point(15, 157);
            this.lstBoxItems.Name = "lstBoxItems";
            this.lstBoxItems.Size = new System.Drawing.Size(438, 303);
            this.lstBoxItems.TabIndex = 6;
            // 
            // btnAddToTrolly
            // 
            this.btnAddToTrolly.Location = new System.Drawing.Point(15, 475);
            this.btnAddToTrolly.Name = "btnAddToTrolly";
            this.btnAddToTrolly.Size = new System.Drawing.Size(90, 29);
            this.btnAddToTrolly.TabIndex = 9;
            this.btnAddToTrolly.Text = "Add to Trolly";
            this.btnAddToTrolly.UseVisualStyleBackColor = true;
            this.btnAddToTrolly.Click += new System.EventHandler(this.btnAddToTrolly_Click);
            // 
            // lstBoxTrolly
            // 
            this.lstBoxTrolly.FormattingEnabled = true;
            this.lstBoxTrolly.Location = new System.Drawing.Point(481, 40);
            this.lstBoxTrolly.Name = "lstBoxTrolly";
            this.lstBoxTrolly.Size = new System.Drawing.Size(193, 381);
            this.lstBoxTrolly.TabIndex = 8;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(478, 23);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(35, 13);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Price",
            "Alphabetcal"});
            this.comboBox1.Location = new System.Drawing.Point(329, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(237, 128);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnBuyItems
            // 
            this.btnBuyItems.Location = new System.Drawing.Point(481, 432);
            this.btnBuyItems.Name = "btnBuyItems";
            this.btnBuyItems.Size = new System.Drawing.Size(80, 28);
            this.btnBuyItems.TabIndex = 11;
            this.btnBuyItems.Text = "Buy Items";
            this.btnBuyItems.UseVisualStyleBackColor = true;
            this.btnBuyItems.Click += new System.EventHandler(this.btnBuyItems_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(607, 484);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCost.TabIndex = 13;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(111, 475);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(126, 29);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "Add Item to Public List";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(570, 432);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(104, 28);
            this.btnDeleteItem.TabIndex = 15;
            this.btnDeleteItem.Text = "Delet Trolly Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bargain Finder";
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 516);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuyItems);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lstBoxTrolly);
            this.Controls.Add(this.btnAddToTrolly);
            this.Controls.Add(this.lstBoxItems);
            this.Controls.Add(this.grpBoxFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Name = "StoreForm";
            this.Text = "Bargain Finder";
            this.grpBoxFilter.ResumeLayout(false);
            this.grpBoxFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBoxFilter;
        private System.Windows.Forms.RadioButton rbnAll;
        private System.Windows.Forms.RadioButton rbnKitchen;
        private System.Windows.Forms.RadioButton rbnClothes;
        private System.Windows.Forms.RadioButton rbnComputers;
        private System.Windows.Forms.RadioButton rbnCars;
        private System.Windows.Forms.RadioButton rbnPhonesGPS;
        private System.Windows.Forms.ListBox lstBoxItems;
        private System.Windows.Forms.Button btnAddToTrolly;
        private System.Windows.Forms.ListBox lstBoxTrolly;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnBuyItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label label3;
    }
}