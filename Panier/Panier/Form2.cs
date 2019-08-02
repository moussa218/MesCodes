using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Panier
{
    public partial class Form2 : Form
    {
        private BindingList<Produit> listeProduits;
        private string cheminImage;
        public Form2()
        {
            InitializeComponent();
            listeProduits = new BindingList<Produit>();


            grilleProduits.DataSource = listeProduits;

        }

        private void PrixUnitaireProduit_ValueChanged(object sender, System.EventArgs e)
        {
            prixTotalProduit.Text = (prixUnitaireProduit.Value * quantiteProduit.Value).ToString();
        }

        private void QuantiteProduit_ValueChanged(object sender, System.EventArgs e)
        {
            prixTotalProduit.Text = (prixUnitaireProduit.Value * quantiteProduit.Value).ToString();
        }

        private void AjouterProduit_Click(object sender, System.EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(nomProduit.Text))
            {
                MessageBox.Show("Veuillez saisir le nom du produit", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (typeProduit.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez saisir le type du produit", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            listeProduits.Add(new Produit()
            {
                Nom = nomProduit.Text,
                PrixUnitaire = Convert.ToInt32(prixUnitaireProduit.Value),
                Quantite = Convert.ToInt32(quantiteProduit.Value),
                Type = typeProduit.SelectedItem.ToString(),
                CheminImage = cheminImage
            });

            nomProduit.Text = string.Empty;
            prixUnitaireProduit.Value = prixUnitaireProduit.Minimum;
            quantiteProduit.Value = quantiteProduit.Minimum;
            typeProduit.SelectedIndex = -1;
            cheminImage = string.Empty;
        }

        private void imageProduit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Fichiers images | *.png; *.jpeg; *.bmp; *.jpg",
                Title = "Selectionner un image",
                Multiselect = false
            };
            DialogResult choix = openFileDialog.ShowDialog();

            if (choix == DialogResult.OK)
            {
                string chemin = openFileDialog.FileName;
                imageProduit.Image = System.Drawing.Image.FromFile(chemin);
                cheminImage = chemin;

            }
        }
    }
}
