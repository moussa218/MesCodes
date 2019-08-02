namespace Panier
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
            this.components = new System.ComponentModel.Container();
            this.gestionErreur = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nombreEtudiants = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.etudiantSerieux = new System.Windows.Forms.CheckBox();
            this.feminin = new System.Windows.Forms.RadioButton();
            this.masculin = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dateNaissEtudiant = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prenomEtudiant = new System.Windows.Forms.TextBox();
            this.nomEtudiant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nombreGarcons = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreFilles = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombreSerieux = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.moyenneAge = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gestionErreur)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gestionErreur
            // 
            this.gestionErreur.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(605, 330);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.nombreEtudiants);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ajouter);
            this.tabPage2.Controls.Add(this.etudiantSerieux);
            this.tabPage2.Controls.Add(this.feminin);
            this.tabPage2.Controls.Add(this.masculin);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dateNaissEtudiant);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.prenomEtudiant);
            this.tabPage2.Controls.Add(this.nomEtudiant);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(597, 304);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ajout";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // nombreEtudiants
            // 
            this.nombreEtudiants.AutoSize = true;
            this.nombreEtudiants.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreEtudiants.Location = new System.Drawing.Point(466, 19);
            this.nombreEtudiants.Name = "nombreEtudiants";
            this.nombreEtudiants.Size = new System.Drawing.Size(60, 24);
            this.nombreEtudiants.TabIndex = 23;
            this.nombreEtudiants.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sexe :";
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(292, 265);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(99, 23);
            this.ajouter.TabIndex = 21;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // etudiantSerieux
            // 
            this.etudiantSerieux.AutoSize = true;
            this.etudiantSerieux.Location = new System.Drawing.Point(166, 232);
            this.etudiantSerieux.Name = "etudiantSerieux";
            this.etudiantSerieux.Size = new System.Drawing.Size(101, 17);
            this.etudiantSerieux.TabIndex = 20;
            this.etudiantSerieux.Text = "Etudiant serieux";
            this.etudiantSerieux.UseVisualStyleBackColor = true;
            // 
            // feminin
            // 
            this.feminin.AutoSize = true;
            this.feminin.Location = new System.Drawing.Point(292, 198);
            this.feminin.Name = "feminin";
            this.feminin.Size = new System.Drawing.Size(61, 17);
            this.feminin.TabIndex = 19;
            this.feminin.Text = "Feminin";
            this.feminin.UseVisualStyleBackColor = true;
            // 
            // masculin
            // 
            this.masculin.AutoSize = true;
            this.masculin.Checked = true;
            this.masculin.Location = new System.Drawing.Point(166, 198);
            this.masculin.Name = "masculin";
            this.masculin.Size = new System.Drawing.Size(67, 17);
            this.masculin.TabIndex = 18;
            this.masculin.TabStop = true;
            this.masculin.Text = "Masculin";
            this.masculin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date naissance :";
            // 
            // dateNaissEtudiant
            // 
            this.dateNaissEtudiant.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNaissEtudiant.Location = new System.Drawing.Point(166, 149);
            this.dateNaissEtudiant.MaxDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateNaissEtudiant.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateNaissEtudiant.Name = "dateNaissEtudiant";
            this.dateNaissEtudiant.Size = new System.Drawing.Size(226, 20);
            this.dateNaissEtudiant.TabIndex = 16;
            this.dateNaissEtudiant.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Prenom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom :";
            // 
            // prenomEtudiant
            // 
            this.prenomEtudiant.Location = new System.Drawing.Point(166, 107);
            this.prenomEtudiant.Name = "prenomEtudiant";
            this.prenomEtudiant.Size = new System.Drawing.Size(226, 20);
            this.prenomEtudiant.TabIndex = 13;
            // 
            // nomEtudiant
            // 
            this.nomEtudiant.Location = new System.Drawing.Point(166, 57);
            this.nomEtudiant.Name = "nomEtudiant";
            this.nomEtudiant.Size = new System.Drawing.Size(226, 20);
            this.nomEtudiant.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre de garcons :";
            // 
            // nombreGarcons
            // 
            this.nombreGarcons.AutoSize = true;
            this.nombreGarcons.Location = new System.Drawing.Point(201, 45);
            this.nombreGarcons.Name = "nombreGarcons";
            this.nombreGarcons.Size = new System.Drawing.Size(13, 13);
            this.nombreGarcons.TabIndex = 1;
            this.nombreGarcons.Text = "0";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.moyenneAge);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.nombreSerieux);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.nombreFilles);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.nombreGarcons);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(597, 304);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Statistiques";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre de filles :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // nombreFilles
            // 
            this.nombreFilles.AutoSize = true;
            this.nombreFilles.Location = new System.Drawing.Point(201, 88);
            this.nombreFilles.Name = "nombreFilles";
            this.nombreFilles.Size = new System.Drawing.Size(13, 13);
            this.nombreFilles.TabIndex = 3;
            this.nombreFilles.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nombre d\'etudiants serieux :";
            // 
            // nombreSerieux
            // 
            this.nombreSerieux.AutoSize = true;
            this.nombreSerieux.Location = new System.Drawing.Point(201, 134);
            this.nombreSerieux.Name = "nombreSerieux";
            this.nombreSerieux.Size = new System.Drawing.Size(13, 13);
            this.nombreSerieux.TabIndex = 5;
            this.nombreSerieux.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Moyenne d\'age :";
            // 
            // moyenneAge
            // 
            this.moyenneAge.AutoSize = true;
            this.moyenneAge.Location = new System.Drawing.Point(201, 179);
            this.moyenneAge.Name = "moyenneAge";
            this.moyenneAge.Size = new System.Drawing.Size(13, 13);
            this.moyenneAge.TabIndex = 7;
            this.moyenneAge.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Panier.Properties.Resources.Test;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(401, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 150);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 345);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gestionErreur)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider gestionErreur;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label nombreEtudiants;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.CheckBox etudiantSerieux;
        private System.Windows.Forms.RadioButton feminin;
        private System.Windows.Forms.RadioButton masculin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateNaissEtudiant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prenomEtudiant;
        private System.Windows.Forms.TextBox nomEtudiant;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nombreGarcons;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label moyenneAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label nombreSerieux;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nombreFilles;
        private System.Windows.Forms.Panel panel1;
    }
}

