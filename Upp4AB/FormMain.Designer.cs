namespace Upp4
{
    partial class FormMain
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
            this.grbAddRecipe = new System.Windows.Forms.GroupBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.cmbFoodCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtNameRecipe = new System.Windows.Forms.TextBox();
            this.lblNameRecipe = new System.Windows.Forms.Label();
            this.lblListRecipe = new System.Windows.Forms.Label();
            this.lblListCategory = new System.Windows.Forms.Label();
            this.lblListNumIngredients = new System.Windows.Forms.Label();
            this.lstRecipe = new System.Windows.Forms.ListBox();
            this.btnEditStart = new System.Windows.Forms.Button();
            this.btnEditFinish = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grbAddRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAddRecipe
            // 
            this.grbAddRecipe.Controls.Add(this.btnAddRecipe);
            this.grbAddRecipe.Controls.Add(this.txtDescription);
            this.grbAddRecipe.Controls.Add(this.btnAddIngredient);
            this.grbAddRecipe.Controls.Add(this.cmbFoodCategory);
            this.grbAddRecipe.Controls.Add(this.lblCategory);
            this.grbAddRecipe.Controls.Add(this.txtNameRecipe);
            this.grbAddRecipe.Controls.Add(this.lblNameRecipe);
            this.grbAddRecipe.Location = new System.Drawing.Point(12, 12);
            this.grbAddRecipe.Name = "grbAddRecipe";
            this.grbAddRecipe.Size = new System.Drawing.Size(413, 528);
            this.grbAddRecipe.TabIndex = 0;
            this.grbAddRecipe.TabStop = false;
            this.grbAddRecipe.Text = "Add new recipe";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(6, 484);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(400, 29);
            this.btnAddRecipe.TabIndex = 6;
            this.btnAddRecipe.Text = "Add recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 106);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 372);
            this.txtDescription.TabIndex = 5;
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Location = new System.Drawing.Point(247, 71);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(159, 29);
            this.btnAddIngredient.TabIndex = 4;
            this.btnAddIngredient.Text = "Add Ingredients";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // cmbFoodCategory
            // 
            this.cmbFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFoodCategory.FormattingEnabled = true;
            this.cmbFoodCategory.Location = new System.Drawing.Point(81, 72);
            this.cmbFoodCategory.Name = "cmbFoodCategory";
            this.cmbFoodCategory.Size = new System.Drawing.Size(151, 28);
            this.cmbFoodCategory.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 75);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 20);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // txtNameRecipe
            // 
            this.txtNameRecipe.Location = new System.Drawing.Point(124, 35);
            this.txtNameRecipe.Name = "txtNameRecipe";
            this.txtNameRecipe.Size = new System.Drawing.Size(282, 27);
            this.txtNameRecipe.TabIndex = 1;
            // 
            // lblNameRecipe
            // 
            this.lblNameRecipe.AutoSize = true;
            this.lblNameRecipe.Location = new System.Drawing.Point(6, 35);
            this.lblNameRecipe.Name = "lblNameRecipe";
            this.lblNameRecipe.Size = new System.Drawing.Size(112, 20);
            this.lblNameRecipe.TabIndex = 0;
            this.lblNameRecipe.Text = "Name of recipe";
            // 
            // lblListRecipe
            // 
            this.lblListRecipe.AutoSize = true;
            this.lblListRecipe.Location = new System.Drawing.Point(454, 30);
            this.lblListRecipe.Name = "lblListRecipe";
            this.lblListRecipe.Size = new System.Drawing.Size(49, 20);
            this.lblListRecipe.TabIndex = 1;
            this.lblListRecipe.Text = "Name";
            // 
            // lblListCategory
            // 
            this.lblListCategory.AutoSize = true;
            this.lblListCategory.Location = new System.Drawing.Point(628, 30);
            this.lblListCategory.Name = "lblListCategory";
            this.lblListCategory.Size = new System.Drawing.Size(69, 20);
            this.lblListCategory.TabIndex = 2;
            this.lblListCategory.Text = "Category";
            // 
            // lblListNumIngredients
            // 
            this.lblListNumIngredients.AutoSize = true;
            this.lblListNumIngredients.Location = new System.Drawing.Point(837, 30);
            this.lblListNumIngredients.Name = "lblListNumIngredients";
            this.lblListNumIngredients.Size = new System.Drawing.Size(159, 20);
            this.lblListNumIngredients.TabIndex = 3;
            this.lblListNumIngredients.Text = "Number of ingredients";
            // 
            // lstRecipe
            // 
            this.lstRecipe.FormattingEnabled = true;
            this.lstRecipe.ItemHeight = 20;
            this.lstRecipe.Location = new System.Drawing.Point(454, 61);
            this.lstRecipe.Name = "lstRecipe";
            this.lstRecipe.Size = new System.Drawing.Size(558, 424);
            this.lstRecipe.TabIndex = 4;
            // 
            // btnEditStart
            // 
            this.btnEditStart.Location = new System.Drawing.Point(454, 496);
            this.btnEditStart.Name = "btnEditStart";
            this.btnEditStart.Size = new System.Drawing.Size(135, 29);
            this.btnEditStart.TabIndex = 5;
            this.btnEditStart.Text = "Edit-Begin";
            this.btnEditStart.UseVisualStyleBackColor = true;
            this.btnEditStart.Click += new System.EventHandler(this.btnEditStart_Click);
            // 
            // btnEditFinish
            // 
            this.btnEditFinish.Location = new System.Drawing.Point(595, 496);
            this.btnEditFinish.Name = "btnEditFinish";
            this.btnEditFinish.Size = new System.Drawing.Size(135, 29);
            this.btnEditFinish.TabIndex = 6;
            this.btnEditFinish.Text = "Edit-Finish";
            this.btnEditFinish.UseVisualStyleBackColor = true;
            this.btnEditFinish.Click += new System.EventHandler(this.btnEditFinish_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(736, 496);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 29);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(877, 496);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 29);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 551);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditFinish);
            this.Controls.Add(this.btnEditStart);
            this.Controls.Add(this.lstRecipe);
            this.Controls.Add(this.lblListNumIngredients);
            this.Controls.Add(this.lblListCategory);
            this.Controls.Add(this.lblListRecipe);
            this.Controls.Add(this.grbAddRecipe);
            this.Name = "FormMain";
            this.Text = "Apu Recipe Book By Ruimin Ma";
            this.grbAddRecipe.ResumeLayout(false);
            this.grbAddRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbAddRecipe;
        private Label lblNameRecipe;
        private Button btnAddRecipe;
        private TextBox txtDescription;
        private Button btnAddIngredient;
        private ComboBox cmbFoodCategory;
        private Label lblCategory;
        private TextBox txtNameRecipe;
        private Label lblListRecipe;
        private Label lblListCategory;
        private Label lblListNumIngredients;
        private ListBox lstRecipe;
        private Button btnEditStart;
        private Button btnEditFinish;
        private Button btnDelete;
        private Button btnClear;
    }
}