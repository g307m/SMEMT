namespace RecipeEditor
{
    partial class CraftbotMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemBox = new System.Windows.Forms.ComboBox();
            this.RecipeBox = new System.Windows.Forms.ListBox();
            this.IngredientBox = new System.Windows.Forms.ListBox();
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.DelRecipeButton = new System.Windows.Forms.Button();
            this.DelIngredientButton = new System.Windows.Forms.Button();
            this.AddIngredientButton = new System.Windows.Forms.Button();
            this.QuantityUD = new System.Windows.Forms.NumericUpDown();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.RestoreButton = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimeUD = new System.Windows.Forms.NumericUpDown();
            this.ProductQuantityLabel = new System.Windows.Forms.Label();
            this.ProductQuantityUD = new System.Windows.Forms.NumericUpDown();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            this.saveCheckBox = new System.Windows.Forms.CheckBox();
            this.debugPanel = new System.Windows.Forms.Panel();
            this.englishDebugLabel = new System.Windows.Forms.Label();
            this.cultureLabel = new System.Windows.Forms.Label();
            this.BackBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityUD)).BeginInit();
            this.debugPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemBox
            // 
            this.ItemBox.FormattingEnabled = true;
            this.ItemBox.Location = new System.Drawing.Point(10, 25);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(143, 21);
            this.ItemBox.TabIndex = 0;
            this.ItemBox.Text = "Select an item";
            // 
            // RecipeBox
            // 
            this.RecipeBox.FormattingEnabled = true;
            this.RecipeBox.Location = new System.Drawing.Point(159, 51);
            this.RecipeBox.Name = "RecipeBox";
            this.RecipeBox.Size = new System.Drawing.Size(141, 329);
            this.RecipeBox.TabIndex = 1;
            this.RecipeBox.SelectedIndexChanged += new System.EventHandler(this.RecipeBox_SelectedIndexChanged);
            // 
            // IngredientBox
            // 
            this.IngredientBox.FormattingEnabled = true;
            this.IngredientBox.Location = new System.Drawing.Point(306, 51);
            this.IngredientBox.Name = "IngredientBox";
            this.IngredientBox.Size = new System.Drawing.Size(140, 329);
            this.IngredientBox.Sorted = true;
            this.IngredientBox.TabIndex = 2;
            this.IngredientBox.SelectedIndexChanged += new System.EventHandler(this.IngredientBox_SelectedIndexChanged);
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.Location = new System.Drawing.Point(10, 51);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(143, 20);
            this.AddRecipeButton.TabIndex = 3;
            this.AddRecipeButton.Text = "Add Recipe";
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // DelRecipeButton
            // 
            this.DelRecipeButton.Location = new System.Drawing.Point(10, 76);
            this.DelRecipeButton.Name = "DelRecipeButton";
            this.DelRecipeButton.Size = new System.Drawing.Size(143, 20);
            this.DelRecipeButton.TabIndex = 3;
            this.DelRecipeButton.Text = "Remove Recipe";
            this.DelRecipeButton.UseVisualStyleBackColor = true;
            this.DelRecipeButton.Click += new System.EventHandler(this.DelRecipeButton_Click);
            // 
            // DelIngredientButton
            // 
            this.DelIngredientButton.Location = new System.Drawing.Point(10, 127);
            this.DelIngredientButton.Name = "DelIngredientButton";
            this.DelIngredientButton.Size = new System.Drawing.Size(143, 20);
            this.DelIngredientButton.TabIndex = 3;
            this.DelIngredientButton.Text = "Remove Ingredient";
            this.DelIngredientButton.UseVisualStyleBackColor = true;
            this.DelIngredientButton.Click += new System.EventHandler(this.DelIngredientButton_Click);
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Location = new System.Drawing.Point(10, 102);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(143, 20);
            this.AddIngredientButton.TabIndex = 3;
            this.AddIngredientButton.Text = "Add Ingredient";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // QuantityUD
            // 
            this.QuantityUD.Location = new System.Drawing.Point(542, 56);
            this.QuantityUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityUD.Name = "QuantityUD";
            this.QuantityUD.Size = new System.Drawing.Size(81, 20);
            this.QuantityUD.TabIndex = 4;
            this.QuantityUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityUD.ValueChanged += new System.EventHandler(this.QuantityUD_ValueChanged);
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(451, 58);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 5;
            this.QuantityLabel.Text = "Quantity";
            // 
            // RestoreButton
            // 
            this.RestoreButton.Location = new System.Drawing.Point(10, 151);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(143, 20);
            this.RestoreButton.TabIndex = 3;
            this.RestoreButton.Text = "Restore File";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(451, 84);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(53, 13);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "Time (-3s)";
            // 
            // TimeUD
            // 
            this.TimeUD.Location = new System.Drawing.Point(542, 83);
            this.TimeUD.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.TimeUD.Name = "TimeUD";
            this.TimeUD.Size = new System.Drawing.Size(81, 20);
            this.TimeUD.TabIndex = 6;
            this.TimeUD.ValueChanged += new System.EventHandler(this.TimeUD_ValueChanged);
            // 
            // ProductQuantityLabel
            // 
            this.ProductQuantityLabel.AutoSize = true;
            this.ProductQuantityLabel.Location = new System.Drawing.Point(451, 31);
            this.ProductQuantityLabel.Name = "ProductQuantityLabel";
            this.ProductQuantityLabel.Size = new System.Drawing.Size(86, 13);
            this.ProductQuantityLabel.TabIndex = 9;
            this.ProductQuantityLabel.Text = "Product Quantity";
            // 
            // ProductQuantityUD
            // 
            this.ProductQuantityUD.Location = new System.Drawing.Point(542, 29);
            this.ProductQuantityUD.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.ProductQuantityUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProductQuantityUD.Name = "ProductQuantityUD";
            this.ProductQuantityUD.Size = new System.Drawing.Size(81, 20);
            this.ProductQuantityUD.TabIndex = 8;
            this.ProductQuantityUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ProductQuantityUD.ValueChanged += new System.EventHandler(this.ProductQuantityUD_ValueChanged);
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Location = new System.Drawing.Point(158, 28);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(49, 13);
            this.ProductsLabel.TabIndex = 10;
            this.ProductsLabel.Text = "Products";
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Location = new System.Drawing.Point(304, 28);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(59, 13);
            this.IngredientsLabel.TabIndex = 11;
            this.IngredientsLabel.Text = "Ingredients";
            // 
            // saveCheckBox
            // 
            this.saveCheckBox.AutoSize = true;
            this.saveCheckBox.Checked = true;
            this.saveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveCheckBox.Location = new System.Drawing.Point(10, 177);
            this.saveCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.saveCheckBox.Name = "saveCheckBox";
            this.saveCheckBox.Size = new System.Drawing.Size(86, 17);
            this.saveCheckBox.TabIndex = 12;
            this.saveCheckBox.Text = "Save on Exit";
            this.saveCheckBox.UseVisualStyleBackColor = true;
            this.saveCheckBox.Visible = false;
            this.saveCheckBox.CheckedChanged += new System.EventHandler(this.SaveCheckBox_CheckedChanged);
            // 
            // debugPanel
            // 
            this.debugPanel.Controls.Add(this.englishDebugLabel);
            this.debugPanel.Controls.Add(this.cultureLabel);
            this.debugPanel.Location = new System.Drawing.Point(453, 111);
            this.debugPanel.Margin = new System.Windows.Forms.Padding(2);
            this.debugPanel.Name = "debugPanel";
            this.debugPanel.Size = new System.Drawing.Size(224, 269);
            this.debugPanel.TabIndex = 13;
            this.debugPanel.Visible = false;
            // 
            // englishDebugLabel
            // 
            this.englishDebugLabel.AutoSize = true;
            this.englishDebugLabel.Location = new System.Drawing.Point(2, 17);
            this.englishDebugLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.englishDebugLabel.Name = "englishDebugLabel";
            this.englishDebugLabel.Size = new System.Drawing.Size(65, 13);
            this.englishDebugLabel.TabIndex = 1;
            this.englishDebugLabel.Text = "english label";
            // 
            // cultureLabel
            // 
            this.cultureLabel.AutoSize = true;
            this.cultureLabel.Location = new System.Drawing.Point(2, 3);
            this.cultureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cultureLabel.Name = "cultureLabel";
            this.cultureLabel.Size = new System.Drawing.Size(83, 13);
            this.cultureLabel.TabIndex = 0;
            this.cultureLabel.Text = "english probably";
            // 
            // BackBox
            // 
            this.BackBox.BackColor = System.Drawing.Color.Transparent;
            this.BackBox.Location = new System.Drawing.Point(0, 0);
            this.BackBox.Name = "BackBox";
            this.BackBox.Size = new System.Drawing.Size(1176, 887);
            this.BackBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BackBox.TabIndex = 15;
            this.BackBox.TabStop = false;
            // 
            // CraftbotMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1224, 887);
            this.Controls.Add(this.debugPanel);
            this.Controls.Add(this.saveCheckBox);
            this.Controls.Add(this.IngredientsLabel);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.ProductQuantityLabel);
            this.Controls.Add(this.ProductQuantityUD);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TimeUD);
            this.Controls.Add(this.RestoreButton);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.QuantityUD);
            this.Controls.Add(this.AddIngredientButton);
            this.Controls.Add(this.DelIngredientButton);
            this.Controls.Add(this.DelRecipeButton);
            this.Controls.Add(this.AddRecipeButton);
            this.Controls.Add(this.IngredientBox);
            this.Controls.Add(this.RecipeBox);
            this.Controls.Add(this.ItemBox);
            this.Controls.Add(this.BackBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CraftbotMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMEMT:  Recipe Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityUD)).EndInit();
            this.debugPanel.ResumeLayout(false);
            this.debugPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ItemBox;
        private System.Windows.Forms.ListBox RecipeBox;
        private System.Windows.Forms.ListBox IngredientBox;
        private System.Windows.Forms.Button AddRecipeButton;
        private System.Windows.Forms.Button DelRecipeButton;
        private System.Windows.Forms.Button DelIngredientButton;
        private System.Windows.Forms.Button AddIngredientButton;
        private System.Windows.Forms.NumericUpDown QuantityUD;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Button RestoreButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.NumericUpDown TimeUD;
        private System.Windows.Forms.Label ProductQuantityLabel;
        private System.Windows.Forms.NumericUpDown ProductQuantityUD;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Label IngredientsLabel;
        private System.Windows.Forms.CheckBox saveCheckBox;
        private System.Windows.Forms.Panel debugPanel;
        private System.Windows.Forms.Label cultureLabel;
        private System.Windows.Forms.Label englishDebugLabel;
        private System.Windows.Forms.PictureBox BackBox;
    }
}

