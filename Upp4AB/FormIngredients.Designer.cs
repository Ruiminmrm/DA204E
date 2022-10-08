namespace Upp4
{
    partial class FormIngredients
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
            this.lblNumIngredients = new System.Windows.Forms.Label();
            this.lblCurrNumber = new System.Windows.Forms.Label();
            this.grbIngredient = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.txtNameIngredient = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.grbIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumIngredients
            // 
            this.lblNumIngredients.AutoSize = true;
            this.lblNumIngredients.Location = new System.Drawing.Point(12, 30);
            this.lblNumIngredients.Name = "lblNumIngredients";
            this.lblNumIngredients.Size = new System.Drawing.Size(159, 20);
            this.lblNumIngredients.TabIndex = 0;
            this.lblNumIngredients.Text = "Number of ingredients";
            // 
            // lblCurrNumber
            // 
            this.lblCurrNumber.AutoSize = true;
            this.lblCurrNumber.Location = new System.Drawing.Point(376, 30);
            this.lblCurrNumber.Name = "lblCurrNumber";
            this.lblCurrNumber.Size = new System.Drawing.Size(107, 20);
            this.lblCurrNumber.TabIndex = 1;
            this.lblCurrNumber.Text = "lblCurrNumber";
            // 
            // grbIngredient
            // 
            this.grbIngredient.Controls.Add(this.btnDelete);
            this.grbIngredient.Controls.Add(this.btnEdit);
            this.grbIngredient.Controls.Add(this.btnAdd);
            this.grbIngredient.Controls.Add(this.lstIngredients);
            this.grbIngredient.Controls.Add(this.txtNameIngredient);
            this.grbIngredient.Location = new System.Drawing.Point(12, 63);
            this.grbIngredient.Name = "grbIngredient";
            this.grbIngredient.Size = new System.Drawing.Size(474, 350);
            this.grbIngredient.TabIndex = 2;
            this.grbIngredient.TabStop = false;
            this.grbIngredient.Text = "Ingredient";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(375, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(375, 61);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 29);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(375, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 20;
            this.lstIngredients.Location = new System.Drawing.Point(6, 59);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(363, 284);
            this.lstIngredients.TabIndex = 1;
            // 
            // txtNameIngredient
            // 
            this.txtNameIngredient.Location = new System.Drawing.Point(6, 26);
            this.txtNameIngredient.Name = "txtNameIngredient";
            this.txtNameIngredient.Size = new System.Drawing.Size(363, 27);
            this.txtNameIngredient.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(18, 419);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(463, 29);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 469);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grbIngredient);
            this.Controls.Add(this.lblCurrNumber);
            this.Controls.Add(this.lblNumIngredients);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormIngredients";
            this.Text = "FormIngredients";
            this.grbIngredient.ResumeLayout(false);
            this.grbIngredient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumIngredients;
        private Label lblCurrNumber;
        private GroupBox grbIngredient;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private ListBox lstIngredients;
        private TextBox txtNameIngredient;
        private Button btnOk;
        private Recipe recipe;
    }
}