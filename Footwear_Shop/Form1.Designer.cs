namespace Footwear_Shop
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
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelProductList = new System.Windows.Forms.Label();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.numericQuantity = new System.Windows.Forms.NumericUpDown();
            this.labelSelectedProductss = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(45, 77);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(340, 324);
            this.listBoxProducts.TabIndex = 1;
            // 
            // buttonSell
            // 
            this.buttonSell.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.Location = new System.Drawing.Point(455, 300);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(116, 32);
            this.buttonSell.TabIndex = 2;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(455, 353);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 32);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // labelProductList
            // 
            this.labelProductList.AutoSize = true;
            this.labelProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductList.Location = new System.Drawing.Point(42, 32);
            this.labelProductList.Name = "labelProductList";
            this.labelProductList.Size = new System.Drawing.Size(99, 18);
            this.labelProductList.TabIndex = 4;
            this.labelProductList.Text = "Product list:";
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.BackColor = System.Drawing.Color.Lime;
            this.buttonLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadData.Location = new System.Drawing.Point(455, 42);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(116, 32);
            this.buttonLoadData.TabIndex = 5;
            this.buttonLoadData.Text = "Load Stock";
            this.buttonLoadData.UseVisualStyleBackColor = false;
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.BackColor = System.Drawing.Color.Yellow;
            this.buttonSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveData.Location = new System.Drawing.Point(455, 97);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(116, 32);
            this.buttonSaveData.TabIndex = 6;
            this.buttonSaveData.Text = "Save Stock";
            this.buttonSaveData.UseVisualStyleBackColor = false;
            // 
            // numericQuantity
            // 
            this.numericQuantity.Location = new System.Drawing.Point(455, 244);
            this.numericQuantity.Name = "numericQuantity";
            this.numericQuantity.Size = new System.Drawing.Size(120, 22);
            this.numericQuantity.TabIndex = 7;
            // 
            // labelSelectedProductss
            // 
            this.labelSelectedProductss.AutoSize = true;
            this.labelSelectedProductss.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedProductss.Location = new System.Drawing.Point(452, 211);
            this.labelSelectedProductss.Name = "labelSelectedProductss";
            this.labelSelectedProductss.Size = new System.Drawing.Size(203, 18);
            this.labelSelectedProductss.TabIndex = 9;
            this.labelSelectedProductss.Text = "Number of selected products:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.labelSelectedProductss);
            this.Controls.Add(this.numericQuantity);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.labelProductList);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.listBoxProducts);
            this.Name = "Form1";
            this.Text = "Footwear Shop";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelProductList;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button buttonSaveData;
        private System.Windows.Forms.NumericUpDown numericQuantity;
        private System.Windows.Forms.Label labelSelectedProductss;
    }
}

