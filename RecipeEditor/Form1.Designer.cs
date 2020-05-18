namespace RecipeEditor
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemBox
            // 
            this.ItemBox.FormattingEnabled = true;
            this.ItemBox.Location = new System.Drawing.Point(13, 12);
            this.ItemBox.Margin = new System.Windows.Forms.Padding(4);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(189, 24);
            this.ItemBox.TabIndex = 0;
            this.ItemBox.Text = "Select an item";
            // 
            // RecipeBox
            // 
            this.RecipeBox.FormattingEnabled = true;
            this.RecipeBox.ItemHeight = 16;
            this.RecipeBox.Location = new System.Drawing.Point(212, 31);
            this.RecipeBox.Margin = new System.Windows.Forms.Padding(4);
            this.RecipeBox.Name = "RecipeBox";
            this.RecipeBox.Size = new System.Drawing.Size(187, 436);
            this.RecipeBox.TabIndex = 1;
            this.RecipeBox.SelectedIndexChanged += new System.EventHandler(this.RecipeBox_SelectedIndexChanged);
            // 
            // IngredientBox
            // 
            this.IngredientBox.FormattingEnabled = true;
            this.IngredientBox.ItemHeight = 16;
            this.IngredientBox.Location = new System.Drawing.Point(408, 31);
            this.IngredientBox.Margin = new System.Windows.Forms.Padding(4);
            this.IngredientBox.Name = "IngredientBox";
            this.IngredientBox.Size = new System.Drawing.Size(185, 436);
            this.IngredientBox.Sorted = true;
            this.IngredientBox.TabIndex = 2;
            this.IngredientBox.SelectedIndexChanged += new System.EventHandler(this.IngredientBox_SelectedIndexChanged);
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.Location = new System.Drawing.Point(13, 44);
            this.AddRecipeButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(191, 25);
            this.AddRecipeButton.TabIndex = 3;
            this.AddRecipeButton.Text = "Add Recipe";
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // DelRecipeButton
            // 
            this.DelRecipeButton.Location = new System.Drawing.Point(13, 75);
            this.DelRecipeButton.Margin = new System.Windows.Forms.Padding(4);
            this.DelRecipeButton.Name = "DelRecipeButton";
            this.DelRecipeButton.Size = new System.Drawing.Size(191, 25);
            this.DelRecipeButton.TabIndex = 3;
            this.DelRecipeButton.Text = "Remove Recipe";
            this.DelRecipeButton.UseVisualStyleBackColor = true;
            this.DelRecipeButton.Click += new System.EventHandler(this.DelRecipeButton_Click);
            // 
            // DelIngredientButton
            // 
            this.DelIngredientButton.Location = new System.Drawing.Point(13, 137);
            this.DelIngredientButton.Margin = new System.Windows.Forms.Padding(4);
            this.DelIngredientButton.Name = "DelIngredientButton";
            this.DelIngredientButton.Size = new System.Drawing.Size(191, 25);
            this.DelIngredientButton.TabIndex = 3;
            this.DelIngredientButton.Text = "Remove Ingredient";
            this.DelIngredientButton.UseVisualStyleBackColor = true;
            this.DelIngredientButton.Click += new System.EventHandler(this.DelIngredientButton_Click);
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Location = new System.Drawing.Point(13, 106);
            this.AddIngredientButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(191, 25);
            this.AddIngredientButton.TabIndex = 3;
            this.AddIngredientButton.Text = "Add Ingredient";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // QuantityUD
            // 
            this.QuantityUD.Location = new System.Drawing.Point(723, 62);
            this.QuantityUD.Margin = new System.Windows.Forms.Padding(4);
            this.QuantityUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityUD.Name = "QuantityUD";
            this.QuantityUD.Size = new System.Drawing.Size(108, 22);
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
            this.QuantityLabel.Location = new System.Drawing.Point(601, 64);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(61, 17);
            this.QuantityLabel.TabIndex = 5;
            this.QuantityLabel.Text = "Quantity";
            // 
            // RestoreButton
            // 
            this.RestoreButton.Location = new System.Drawing.Point(13, 167);
            this.RestoreButton.Margin = new System.Windows.Forms.Padding(4);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(191, 25);
            this.RestoreButton.TabIndex = 3;
            this.RestoreButton.Text = "Restore File";
            this.RestoreButton.UseVisualStyleBackColor = true;
            this.RestoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(601, 97);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(73, 17);
            this.TimeLabel.TabIndex = 7;
            this.TimeLabel.Text = "Time (-3s)";
            // 
            // TimeUD
            // 
            this.TimeUD.Location = new System.Drawing.Point(723, 95);
            this.TimeUD.Margin = new System.Windows.Forms.Padding(4);
            this.TimeUD.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.TimeUD.Name = "TimeUD";
            this.TimeUD.Size = new System.Drawing.Size(108, 22);
            this.TimeUD.TabIndex = 6;
            this.TimeUD.ValueChanged += new System.EventHandler(this.TimeUD_ValueChanged);
            // 
            // ProductQuantityLabel
            // 
            this.ProductQuantityLabel.AutoSize = true;
            this.ProductQuantityLabel.Location = new System.Drawing.Point(601, 31);
            this.ProductQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductQuantityLabel.Name = "ProductQuantityLabel";
            this.ProductQuantityLabel.Size = new System.Drawing.Size(114, 17);
            this.ProductQuantityLabel.TabIndex = 9;
            this.ProductQuantityLabel.Text = "Product Quantity";
            // 
            // ProductQuantityUD
            // 
            this.ProductQuantityUD.Location = new System.Drawing.Point(723, 29);
            this.ProductQuantityUD.Margin = new System.Windows.Forms.Padding(4);
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
            this.ProductQuantityUD.Size = new System.Drawing.Size(108, 22);
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
            this.ProductsLabel.Location = new System.Drawing.Point(212, 11);
            this.ProductsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(64, 17);
            this.ProductsLabel.TabIndex = 10;
            this.ProductsLabel.Text = "Products";
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Location = new System.Drawing.Point(404, 11);
            this.IngredientsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(78, 17);
            this.IngredientsLabel.TabIndex = 11;
            this.IngredientsLabel.Text = "Ingredients";
            // 
            // saveCheckBox
            // 
            this.saveCheckBox.AutoSize = true;
            this.saveCheckBox.Checked = true;
            this.saveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveCheckBox.Location = new System.Drawing.Point(13, 199);
            this.saveCheckBox.Name = "saveCheckBox";
            this.saveCheckBox.Size = new System.Drawing.Size(108, 21);
            this.saveCheckBox.TabIndex = 12;
            this.saveCheckBox.Text = "Save on Exit";
            this.saveCheckBox.UseVisualStyleBackColor = true;
            this.saveCheckBox.CheckedChanged += new System.EventHandler(this.saveCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(915, 480);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMEMT:  Recipe Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductQuantityUD)).EndInit();
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
    }
}

