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
            this.shoppingListBox = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loadShoppingList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // shoppingListBox
            // 
            this.shoppingListBox.FormattingEnabled = true;
            this.shoppingListBox.ItemHeight = 20;
            this.shoppingListBox.Location = new System.Drawing.Point(93, 37);
            this.shoppingListBox.Name = "shoppingListBox";
            this.shoppingListBox.Size = new System.Drawing.Size(191, 304);
            this.shoppingListBox.TabIndex = 0;
            this.shoppingListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // loadShoppingList
            // 
            this.loadShoppingList.Location = new System.Drawing.Point(114, 347);
            this.loadShoppingList.Name = "loadShoppingList";
            this.loadShoppingList.Size = new System.Drawing.Size(148, 37);
            this.loadShoppingList.TabIndex = 1;
            this.loadShoppingList.Text = "Load Shopping List";
            this.loadShoppingList.UseVisualStyleBackColor = true;
            this.loadShoppingList.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 472);
            this.Controls.Add(this.loadShoppingList);
            this.Controls.Add(this.shoppingListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox shoppingListBox;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button loadShoppingList;
    }
}

