namespace PrepareExo8
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tnom = new System.Windows.Forms.TextBox();
            this.tsolde = new System.Windows.Forms.NumericUpDown();
            this.tdateOuverture = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridLCE = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.idR = new System.Windows.Forms.NumericUpDown();
            this.tDepot = new System.Windows.Forms.NumericUpDown();
            this.tRetrait = new System.Windows.Forms.NumericUpDown();
            this.Sauvegarder = new System.Windows.Forms.Button();
            this.Charger = new System.Windows.Forms.Button();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOuvertureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcompletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compteEpargneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsolde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDepot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRetrait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteEpargneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tdateOuverture);
            this.groupBox1.Controls.Add(this.tsolde);
            this.groupBox1.Controls.Add(this.tnom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion des Compte Epargne";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Charger);
            this.groupBox2.Controls.Add(this.Sauvegarder);
            this.groupBox2.Controls.Add(this.dataGridLCE);
            this.groupBox2.Location = new System.Drawing.Point(38, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste Des Comptes Epargne";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tRetrait);
            this.groupBox3.Controls.Add(this.tDepot);
            this.groupBox3.Controls.Add(this.idR);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(38, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(713, 126);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operation Sur Compte";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solde :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Ouverture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom Nom";
            // 
            // tnom
            // 
            this.tnom.Location = new System.Drawing.Point(154, 96);
            this.tnom.Name = "tnom";
            this.tnom.Size = new System.Drawing.Size(183, 20);
            this.tnom.TabIndex = 3;
            // 
            // tsolde
            // 
            this.tsolde.Location = new System.Drawing.Point(154, 27);
            this.tsolde.Name = "tsolde";
            this.tsolde.Size = new System.Drawing.Size(183, 20);
            this.tsolde.TabIndex = 4;
            // 
            // tdateOuverture
            // 
            this.tdateOuverture.Location = new System.Drawing.Point(154, 63);
            this.tdateOuverture.Name = "tdateOuverture";
            this.tdateOuverture.Size = new System.Drawing.Size(183, 20);
            this.tdateOuverture.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Operation Retrait";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Operation Depot";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Numero Du Compte";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Deposer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(585, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(477, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Retrait";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridLCE
            // 
            this.dataGridLCE.AllowUserToAddRows = false;
            this.dataGridLCE.AllowUserToDeleteRows = false;
            this.dataGridLCE.AutoGenerateColumns = false;
            this.dataGridLCE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLCE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroDataGridViewTextBoxColumn,
            this.soldeDataGridViewTextBoxColumn,
            this.dateOuvertureDataGridViewTextBoxColumn,
            this.nomcompletDataGridViewTextBoxColumn});
            this.dataGridLCE.DataSource = this.compteEpargneBindingSource;
            this.dataGridLCE.Location = new System.Drawing.Point(17, 33);
            this.dataGridLCE.Name = "dataGridLCE";
            this.dataGridLCE.ReadOnly = true;
            this.dataGridLCE.RowHeadersVisible = false;
            this.dataGridLCE.Size = new System.Drawing.Size(643, 123);
            this.dataGridLCE.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // idR
            // 
            this.idR.Location = new System.Drawing.Point(154, 25);
            this.idR.Name = "idR";
            this.idR.Size = new System.Drawing.Size(139, 20);
            this.idR.TabIndex = 13;
            // 
            // tDepot
            // 
            this.tDepot.Location = new System.Drawing.Point(154, 57);
            this.tDepot.Maximum = new decimal(new int[] {
            90000000,
            0,
            0,
            0});
            this.tDepot.Name = "tDepot";
            this.tDepot.Size = new System.Drawing.Size(139, 20);
            this.tDepot.TabIndex = 14;
            this.tDepot.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // tRetrait
            // 
            this.tRetrait.Location = new System.Drawing.Point(154, 87);
            this.tRetrait.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.tRetrait.Name = "tRetrait";
            this.tRetrait.Size = new System.Drawing.Size(139, 20);
            this.tRetrait.TabIndex = 15;
            this.tRetrait.ValueChanged += new System.EventHandler(this.tRetrait_ValueChanged);
            // 
            // Sauvegarder
            // 
            this.Sauvegarder.Location = new System.Drawing.Point(487, 162);
            this.Sauvegarder.Name = "Sauvegarder";
            this.Sauvegarder.Size = new System.Drawing.Size(75, 23);
            this.Sauvegarder.TabIndex = 1;
            this.Sauvegarder.Text = "Sauvegarder";
            this.Sauvegarder.UseVisualStyleBackColor = true;
            this.Sauvegarder.Click += new System.EventHandler(this.Sauvegarder_Click);
            // 
            // Charger
            // 
            this.Charger.Location = new System.Drawing.Point(585, 162);
            this.Charger.Name = "Charger";
            this.Charger.Size = new System.Drawing.Size(75, 23);
            this.Charger.TabIndex = 2;
            this.Charger.Text = "Charger";
            this.Charger.UseVisualStyleBackColor = true;
            this.Charger.Click += new System.EventHandler(this.Charger_Click);
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soldeDataGridViewTextBoxColumn
            // 
            this.soldeDataGridViewTextBoxColumn.DataPropertyName = "solde";
            this.soldeDataGridViewTextBoxColumn.HeaderText = "solde";
            this.soldeDataGridViewTextBoxColumn.Name = "soldeDataGridViewTextBoxColumn";
            this.soldeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOuvertureDataGridViewTextBoxColumn
            // 
            this.dateOuvertureDataGridViewTextBoxColumn.DataPropertyName = "dateOuverture";
            this.dateOuvertureDataGridViewTextBoxColumn.HeaderText = "dateOuverture";
            this.dateOuvertureDataGridViewTextBoxColumn.Name = "dateOuvertureDataGridViewTextBoxColumn";
            this.dateOuvertureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomcompletDataGridViewTextBoxColumn
            // 
            this.nomcompletDataGridViewTextBoxColumn.DataPropertyName = "nomcomplet";
            this.nomcompletDataGridViewTextBoxColumn.HeaderText = "nomcomplet";
            this.nomcompletDataGridViewTextBoxColumn.Name = "nomcompletDataGridViewTextBoxColumn";
            this.nomcompletDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // compteEpargneBindingSource
            // 
            this.compteEpargneBindingSource.DataSource = typeof(PrepareExo8.CompteEpargne);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tsolde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDepot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRetrait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compteEpargneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker tdateOuverture;
        private System.Windows.Forms.NumericUpDown tsolde;
        private System.Windows.Forms.TextBox tnom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridLCE;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOuvertureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcompletDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource compteEpargneBindingSource;
        private System.Windows.Forms.NumericUpDown tRetrait;
        private System.Windows.Forms.NumericUpDown tDepot;
        private System.Windows.Forms.NumericUpDown idR;
        private System.Windows.Forms.Button Sauvegarder;
        private System.Windows.Forms.Button Charger;
    }
}

