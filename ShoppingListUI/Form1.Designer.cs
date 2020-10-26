namespace ShoppingListUI
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadShoppingList = new System.Windows.Forms.Button();
            this.checkedShoppingList = new System.Windows.Forms.CheckedListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadShoppingList
            // 
            this.btnLoadShoppingList.Location = new System.Drawing.Point(296, 47);
            this.btnLoadShoppingList.Name = "btnLoadShoppingList";
            this.btnLoadShoppingList.Size = new System.Drawing.Size(148, 49);
            this.btnLoadShoppingList.TabIndex = 1;
            this.btnLoadShoppingList.Text = "Load shopping list";
            this.btnLoadShoppingList.UseVisualStyleBackColor = true;
            this.btnLoadShoppingList.Click += new System.EventHandler(this.BtnLoadShoppingList_Click);
            // 
            // checkedShoppingList
            // 
            this.checkedShoppingList.FormattingEnabled = true;
            this.checkedShoppingList.Location = new System.Drawing.Point(83, 37);
            this.checkedShoppingList.Name = "checkedShoppingList";
            this.checkedShoppingList.Size = new System.Drawing.Size(207, 312);
            this.checkedShoppingList.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(195, 352);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(49, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total :";
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(296, 111);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(148, 49);
            this.btnAddNewItem.TabIndex = 5;
            this.btnAddNewItem.Text = "Add new item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(296, 180);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(148, 41);
            this.btnRemoveItem.TabIndex = 6;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 472);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.checkedShoppingList);
            this.Controls.Add(this.btnLoadShoppingList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnLoadShoppingList;
        private System.Windows.Forms.CheckedListBox checkedShoppingList;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}

