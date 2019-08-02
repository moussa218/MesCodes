namespace Panier
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nomProduit = new System.Windows.Forms.TextBox();
            this.prixUnitaireProduit = new System.Windows.Forms.NumericUpDown();
            this.quantiteProduit = new System.Windows.Forms.NumericUpDown();
            this.prixTotalProduit = new System.Windows.Forms.TextBox();
            this.typeProduit = new System.Windows.Forms.ComboBox();
            this.ajouterProduit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.imageProduit = new System.Windows.Forms.PictureBox();
            this.grilleProduits = new System.Windows.Forms.DataGridView();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageProduitDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixUnitaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prixUnitaireProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleProduits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.nomProduit, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.prixUnitaireProduit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.quantiteProduit, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.prixTotalProduit, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.typeProduit, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.ajouterProduit, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.imageProduit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grilleProduits, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix unitaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // nomProduit
            // 
            this.nomProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nomProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomProduit.Location = new System.Drawing.Point(323, 43);
            this.nomProduit.Name = "nomProduit";
            this.nomProduit.Size = new System.Drawing.Size(314, 26);
            this.nomProduit.TabIndex = 5;
            // 
            // prixUnitaireProduit
            // 
            this.prixUnitaireProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prixUnitaireProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixUnitaireProduit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.prixUnitaireProduit.Location = new System.Drawing.Point(323, 83);
            this.prixUnitaireProduit.Maximum = new decimal(new int[] {
            900000,
            0,
            0,
            0});
            this.prixUnitaireProduit.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.prixUnitaireProduit.Name = "prixUnitaireProduit";
            this.prixUnitaireProduit.Size = new System.Drawing.Size(314, 26);
            this.prixUnitaireProduit.TabIndex = 6;
            this.prixUnitaireProduit.ThousandsSeparator = true;
            this.prixUnitaireProduit.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.prixUnitaireProduit.ValueChanged += new System.EventHandler(this.PrixUnitaireProduit_ValueChanged);
            // 
            // quantiteProduit
            // 
            this.quantiteProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantiteProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiteProduit.Location = new System.Drawing.Point(323, 123);
            this.quantiteProduit.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quantiteProduit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantiteProduit.Name = "quantiteProduit";
            this.quantiteProduit.Size = new System.Drawing.Size(314, 26);
            this.quantiteProduit.TabIndex = 7;
            this.quantiteProduit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantiteProduit.ValueChanged += new System.EventHandler(this.QuantiteProduit_ValueChanged);
            // 
            // prixTotalProduit
            // 
            this.prixTotalProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prixTotalProduit.Enabled = false;
            this.prixTotalProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prixTotalProduit.Location = new System.Drawing.Point(323, 163);
            this.prixTotalProduit.Name = "prixTotalProduit";
            this.prixTotalProduit.Size = new System.Drawing.Size(314, 26);
            this.prixTotalProduit.TabIndex = 8;
            // 
            // typeProduit
            // 
            this.typeProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeProduit.FormattingEnabled = true;
            this.typeProduit.Items.AddRange(new object[] {
            "Jus de fruit",
            "Produit laitier",
            "Boisson gazeuse"});
            this.typeProduit.Location = new System.Drawing.Point(323, 203);
            this.typeProduit.Name = "typeProduit";
            this.typeProduit.Size = new System.Drawing.Size(314, 28);
            this.typeProduit.TabIndex = 9;
            // 
            // ajouterProduit
            // 
            this.ajouterProduit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ajouterProduit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ajouterProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouterProduit.Location = new System.Drawing.Point(517, 243);
            this.ajouterProduit.Name = "ajouterProduit";
            this.ajouterProduit.Size = new System.Drawing.Size(120, 34);
            this.ajouterProduit.TabIndex = 10;
            this.ajouterProduit.Text = "Ajouter";
            this.ajouterProduit.UseVisualStyleBackColor = false;
            this.ajouterProduit.Click += new System.EventHandler(this.AjouterProduit_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(3, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(163, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 44);
            this.button3.TabIndex = 12;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(323, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // imageProduit
            // 
            this.imageProduit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageProduit.Image = global::Panier.Properties.Resources.DefaultProductImage;
            this.imageProduit.Location = new System.Drawing.Point(3, 43);
            this.imageProduit.Name = "imageProduit";
            this.tableLayoutPanel1.SetRowSpan(this.imageProduit, 5);
            this.imageProduit.Size = new System.Drawing.Size(154, 194);
            this.imageProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageProduit.TabIndex = 14;
            this.imageProduit.TabStop = false;
            this.imageProduit.Click += new System.EventHandler(this.imageProduit_Click);
            // 
            // grilleProduits
            // 
            this.grilleProduits.AllowUserToAddRows = false;
            this.grilleProduits.AllowUserToDeleteRows = false;
            this.grilleProduits.AutoGenerateColumns = false;
            this.grilleProduits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grilleProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleProduits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.imageProduitDataGridViewImageColumn,
            this.nomDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.prixUnitaireDataGridViewTextBoxColumn,
            this.quantiteDataGridViewTextBoxColumn,
            this.prixTotalDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.grilleProduits, 4);
            this.grilleProduits.DataSource = this.produitBindingSource;
            this.grilleProduits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grilleProduits.Location = new System.Drawing.Point(3, 333);
            this.grilleProduits.Name = "grilleProduits";
            this.grilleProduits.ReadOnly = true;
            this.grilleProduits.RowHeadersVisible = false;
            this.grilleProduits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grilleProduits.Size = new System.Drawing.Size(794, 150);
            this.grilleProduits.TabIndex = 15;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataSource = typeof(Panier.Produit);
            // 
            // imageProduitDataGridViewImageColumn
            // 
            this.imageProduitDataGridViewImageColumn.DataPropertyName = "ImageProduit";
            this.imageProduitDataGridViewImageColumn.HeaderText = "ImageProduit";
            this.imageProduitDataGridViewImageColumn.Image = global::Panier.Properties.Resources.DefaultProductImage;
            this.imageProduitDataGridViewImageColumn.Name = "imageProduitDataGridViewImageColumn";
            this.imageProduitDataGridViewImageColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixUnitaireDataGridViewTextBoxColumn
            // 
            this.prixUnitaireDataGridViewTextBoxColumn.DataPropertyName = "PrixUnitaire";
            this.prixUnitaireDataGridViewTextBoxColumn.HeaderText = "PrixUnitaire";
            this.prixUnitaireDataGridViewTextBoxColumn.Name = "prixUnitaireDataGridViewTextBoxColumn";
            this.prixUnitaireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantiteDataGridViewTextBoxColumn
            // 
            this.quantiteDataGridViewTextBoxColumn.DataPropertyName = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.HeaderText = "Quantite";
            this.quantiteDataGridViewTextBoxColumn.Name = "quantiteDataGridViewTextBoxColumn";
            this.quantiteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixTotalDataGridViewTextBoxColumn
            // 
            this.prixTotalDataGridViewTextBoxColumn.DataPropertyName = "PrixTotal";
            this.prixTotalDataGridViewTextBoxColumn.HeaderText = "PrixTotal";
            this.prixTotalDataGridViewTextBoxColumn.Name = "prixTotalDataGridViewTextBoxColumn";
            this.prixTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prixUnitaireProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantiteProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilleProduits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nomProduit;
        private System.Windows.Forms.NumericUpDown prixUnitaireProduit;
        private System.Windows.Forms.NumericUpDown quantiteProduit;
        private System.Windows.Forms.TextBox prixTotalProduit;
        private System.Windows.Forms.ComboBox typeProduit;
        private System.Windows.Forms.Button ajouterProduit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox imageProduit;
        private System.Windows.Forms.DataGridView grilleProduits;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn imageProduitDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixUnitaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixTotalDataGridViewTextBoxColumn;
    }
}