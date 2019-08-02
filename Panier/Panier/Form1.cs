using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Panier
{
    public partial class Form1 : Form
    {
        private List<Etudiant> listeEtudiants;

        public Form1()
        {
            InitializeComponent();
            listeEtudiants = new List<Etudiant>();
            nombreEtudiants.Text = $"{listeEtudiants.Count} etudiant(s)";
        }

        private void ajouter_Click(object sender, System.EventArgs e)
        {
            bool valeurOk = true;
            gestionErreur.Clear();

            if (string.IsNullOrWhiteSpace(nomEtudiant.Text))
            {
                gestionErreur.SetError(nomEtudiant, "Le nom est invalide");
                valeurOk = false;
            }

            if (string.IsNullOrWhiteSpace(prenomEtudiant.Text))
            {
                gestionErreur.SetError(prenomEtudiant, "Le prenom est invalide");
                valeurOk = false;
            }

            if (valeurOk == false)
            {
                return;
            }


            Etudiant etudiant = new Etudiant
            {
                Nom = nomEtudiant.Text,
                Prenom = prenomEtudiant.Text,
                DateNaissance = dateNaissEtudiant.Value,
                Sexe = feminin.Checked ? 'F' : 'M',
                Serieux = etudiantSerieux.Checked
            };

            listeEtudiants.Add(etudiant);

            nombreEtudiants.Text = $"{listeEtudiants.Count} etudiant(s)";
            nombreGarcons.Text = listeEtudiants.Count(n => n.Sexe == 'M').ToString();
            nombreFilles.Text = listeEtudiants.Count(n => n.Sexe == 'F').ToString();
            nombreSerieux.Text = listeEtudiants.Count(n => n.Serieux == true).ToString();
            moyenneAge.Text = listeEtudiants.Average(n => n.Age).ToString();

            nomEtudiant.Text = string.Empty;
            prenomEtudiant.Text = string.Empty;
            dateNaissEtudiant.Value = dateNaissEtudiant.MaxDate;
            masculin.Checked = true;
            etudiantSerieux.Checked = false;

        }

        private void label6_Click(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, System.EventArgs e)
        {

        }
    }
}
