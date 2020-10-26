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
            this.loadShoppingList = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.checkedShoppingList = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // loadShoppingList
            // 
            this.loadShoppingList.Location = new System.Drawing.Point(296, 54);
            this.loadShoppingList.Name = "loadShoppingList";
            this.loadShoppingList.Size = new System.Drawing.Size(148, 42);
            this.loadShoppingList.TabIndex = 1;
            this.loadShoppingList.Text = "Load Shopping List";
            this.loadShoppingList.UseVisualStyleBackColor = true;
            this.loadShoppingList.Click += new System.EventHandler(this.Button1_Click);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(296, 102);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(148, 42);
            this.addItem.TabIndex = 2;
            this.addItem.Text = "Add New Item";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // checkedShoppingList
            // 
            this.checkedShoppingList.FormattingEnabled = true;
            this.checkedShoppingList.Location = new System.Drawing.Point(83, 37);
            this.checkedShoppingList.Name = "checkedShoppingList";
            this.checkedShoppingList.Size = new System.Drawing.Size(207, 312);
            this.checkedShoppingList.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(465, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 472);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedShoppingList);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.loadShoppingList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button loadShoppingList;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.CheckedListBox checkedShoppingList;
        private System.Windows.Forms.TextBox textBox1;
    }
}

