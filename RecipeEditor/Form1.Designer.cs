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
            this.recipeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.RestoreButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUD)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemBox
            // 
            this.ItemBox.FormattingEnabled = true;
            this.ItemBox.Location = new System.Drawing.Point(10, 10);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(143, 21);
            this.ItemBox.TabIndex = 0;
            this.ItemBox.Text = "Select an item";
            // 
            // RecipeBox
            // 
            this.RecipeBox.FormattingEnabled = true;
            this.RecipeBox.Location = new System.Drawing.Point(159, 12);
            this.RecipeBox.Name = "RecipeBox";
            this.RecipeBox.Size = new System.Drawing.Size(141, 368);
            this.RecipeBox.TabIndex = 1;
            // 
            // IngredientBox
            // 
            this.IngredientBox.FormattingEnabled = true;
            this.IngredientBox.Location = new System.Drawing.Point(306, 12);
            this.IngredientBox.Name = "IngredientBox";
            this.IngredientBox.Size = new System.Drawing.Size(140, 368);
            this.IngredientBox.TabIndex = 2;
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.Location = new System.Drawing.Point(10, 36);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.Size = new System.Drawing.Size(143, 20);
            this.AddRecipeButton.TabIndex = 3;
            this.AddRecipeButton.Text = "Add Recipe";
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // DelRecipeButton
            // 
            this.DelRecipeButton.Location = new System.Drawing.Point(10, 61);
            this.DelRecipeButton.Name = "DelRecipeButton";
            this.DelRecipeButton.Size = new System.Drawing.Size(143, 20);
            this.DelRecipeButton.TabIndex = 3;
            this.DelRecipeButton.Text = "Remove Recipe";
            this.DelRecipeButton.UseVisualStyleBackColor = true;
            this.DelRecipeButton.Click += new System.EventHandler(this.DelRecipeButton_Click);
            // 
            // DelIngredientButton
            // 
            this.DelIngredientButton.Location = new System.Drawing.Point(10, 111);
            this.DelIngredientButton.Name = "DelIngredientButton";
            this.DelIngredientButton.Size = new System.Drawing.Size(143, 20);
            this.DelIngredientButton.TabIndex = 3;
            this.DelIngredientButton.Text = "Remove Ingredient";
            this.DelIngredientButton.UseVisualStyleBackColor = true;
            this.DelIngredientButton.Click += new System.EventHandler(this.DelIngredientButton_Click);
            // 
            // AddIngredientButton
            // 
            this.AddIngredientButton.Location = new System.Drawing.Point(10, 86);
            this.AddIngredientButton.Name = "AddIngredientButton";
            this.AddIngredientButton.Size = new System.Drawing.Size(143, 20);
            this.AddIngredientButton.TabIndex = 3;
            this.AddIngredientButton.Text = "Add Ingredient";
            this.AddIngredientButton.UseVisualStyleBackColor = true;
            this.AddIngredientButton.Click += new System.EventHandler(this.AddIngredientButton_Click);
            // 
            // QuantityUD
            // 
            this.QuantityUD.Location = new System.Drawing.Point(503, 11);
            this.QuantityUD.Name = "QuantityUD";
            this.QuantityUD.Size = new System.Drawing.Size(81, 20);
            this.QuantityUD.TabIndex = 4;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(452, 13);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(46, 13);
            this.QuantityLabel.TabIndex = 5;
            this.QuantityLabel.Text = "Quantity";
            // 
            // recipeFileDialog
            // 
            this.recipeFileDialog.FileName = "craftbot.json";
            this.recipeFileDialog.Filter = "JSON files (*.json)|*.json";
            // 
            // RestoreButton
            // 
            this.RestoreButton.Location = new System.Drawing.Point(10, 136);
            this.RestoreButton.Name = "RestoreButton";
            this.RestoreButton.Size = new System.Drawing.Size(143, 20);
            this.RestoreButton.TabIndex = 3;
            this.RestoreButton.Text = "Restore File";
            this.RestoreButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(686, 390);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMEMT:  Recipe Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuantityUD)).EndInit();
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
        private System.Windows.Forms.OpenFileDialog recipeFileDialog;
        private System.Windows.Forms.Button RestoreButton;
    }
}

