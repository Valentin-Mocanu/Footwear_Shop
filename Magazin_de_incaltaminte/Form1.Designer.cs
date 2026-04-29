namespace MagazinIncaltaminteGUI
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
            this.listBoxProduse = new System.Windows.Forms.ListBox();
            this.buttonVinde = new System.Windows.Forms.Button();
            this.buttonAdauga = new System.Windows.Forms.Button();
            this.produseStoc = new System.Windows.Forms.Label();
            this.buttonIncarcaDate = new System.Windows.Forms.Button();
            this.buttonSalveazaDate = new System.Windows.Forms.Button();
            this.numCantitate = new System.Windows.Forms.NumericUpDown();
            this.produseAlese = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantitate)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProduse
            // 
            this.listBoxProduse.FormattingEnabled = true;
            this.listBoxProduse.ItemHeight = 16;
            this.listBoxProduse.Location = new System.Drawing.Point(45, 77);
            this.listBoxProduse.Name = "listBoxProduse";
            this.listBoxProduse.Size = new System.Drawing.Size(307, 324);
            this.listBoxProduse.TabIndex = 1;
            // 
            // buttonVinde
            // 
            this.buttonVinde.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonVinde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVinde.Location = new System.Drawing.Point(455, 300);
            this.buttonVinde.Name = "buttonVinde";
            this.buttonVinde.Size = new System.Drawing.Size(116, 32);
            this.buttonVinde.TabIndex = 2;
            this.buttonVinde.Text = "Vinde";
            this.buttonVinde.UseVisualStyleBackColor = false;
            // 
            // buttonAdauga
            // 
            this.buttonAdauga.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdauga.Location = new System.Drawing.Point(455, 353);
            this.buttonAdauga.Name = "buttonAdauga";
            this.buttonAdauga.Size = new System.Drawing.Size(116, 32);
            this.buttonAdauga.TabIndex = 3;
            this.buttonAdauga.Text = "Adauga";
            this.buttonAdauga.UseVisualStyleBackColor = false;
            // 
            // produseStoc
            // 
            this.produseStoc.AutoSize = true;
            this.produseStoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produseStoc.Location = new System.Drawing.Point(42, 32);
            this.produseStoc.Name = "produseStoc";
            this.produseStoc.Size = new System.Drawing.Size(137, 18);
            this.produseStoc.TabIndex = 4;
            this.produseStoc.Text = "Produse pe stoc:";
            // 
            // buttonIncarcaDate
            // 
            this.buttonIncarcaDate.BackColor = System.Drawing.Color.Lime;
            this.buttonIncarcaDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIncarcaDate.Location = new System.Drawing.Point(455, 42);
            this.buttonIncarcaDate.Name = "buttonIncarcaDate";
            this.buttonIncarcaDate.Size = new System.Drawing.Size(116, 32);
            this.buttonIncarcaDate.TabIndex = 5;
            this.buttonIncarcaDate.Text = "Incarca stoc";
            this.buttonIncarcaDate.UseVisualStyleBackColor = false;
            // 
            // buttonSalveazaDate
            // 
            this.buttonSalveazaDate.BackColor = System.Drawing.Color.Yellow;
            this.buttonSalveazaDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalveazaDate.Location = new System.Drawing.Point(455, 97);
            this.buttonSalveazaDate.Name = "buttonSalveazaDate";
            this.buttonSalveazaDate.Size = new System.Drawing.Size(116, 32);
            this.buttonSalveazaDate.TabIndex = 6;
            this.buttonSalveazaDate.Text = "Salveaza stoc";
            this.buttonSalveazaDate.UseVisualStyleBackColor = false;
            // 
            // numCantitate
            // 
            this.numCantitate.Location = new System.Drawing.Point(455, 244);
            this.numCantitate.Name = "numCantitate";
            this.numCantitate.Size = new System.Drawing.Size(120, 22);
            this.numCantitate.TabIndex = 7;
            // 
            // produseAlese
            // 
            this.produseAlese.AutoSize = true;
            this.produseAlese.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produseAlese.Location = new System.Drawing.Point(452, 211);
            this.produseAlese.Name = "produseAlese";
            this.produseAlese.Size = new System.Drawing.Size(185, 18);
            this.produseAlese.TabIndex = 9;
            this.produseAlese.Text = "Numarul de produse alese:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.produseAlese);
            this.Controls.Add(this.numCantitate);
            this.Controls.Add(this.buttonSalveazaDate);
            this.Controls.Add(this.buttonIncarcaDate);
            this.Controls.Add(this.produseStoc);
            this.Controls.Add(this.buttonAdauga);
            this.Controls.Add(this.buttonVinde);
            this.Controls.Add(this.listBoxProduse);
            this.Name = "Form1";
            this.Text = "Magazin de incaltaminte";
            ((System.ComponentModel.ISupportInitialize)(this.numCantitate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxProduse;
        private System.Windows.Forms.Button buttonVinde;
        private System.Windows.Forms.Button buttonAdauga;
        private System.Windows.Forms.Label produseStoc;
        private System.Windows.Forms.Button buttonIncarcaDate;
        private System.Windows.Forms.Button buttonSalveazaDate;
        private System.Windows.Forms.NumericUpDown numCantitate;
        private System.Windows.Forms.Label produseAlese;
    }
}

