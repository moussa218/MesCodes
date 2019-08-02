using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace PrepareExo8
{
    public partial class Form1 : Form
    {
      private  BindingList<CompteEpargne> listCE;
        public Form1()
        {
            InitializeComponent();
            listCE = new BindingList<CompteEpargne>();
            dataGridLCE.DataSource = listCE;
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listCE.Add(new CompteEpargne()
            {
                numero = listCE.Count() + 1,
                solde = Convert.ToDouble(tsolde.Value),
                dateOuverture = tdateOuverture.Value,
                nomcomplet = tnom.Text
            });
            tsolde.Value =tsolde.Minimum;
            tdateOuverture.Value = tdateOuverture.MinDate;
            tnom.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tsolde.Value = tsolde.Minimum;
            tdateOuverture.Value = tdateOuverture.MinDate;
            tnom.Text = string.Empty;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (tRetrait.Value != tRetrait.Minimum)
            {
                tDepot.ReadOnly = tDepot.Visible;    
            }
 
        }

        private void tRetrait_ValueChanged(object sender, EventArgs e)
        {
            bool trv = false;
            var element = listCE.Where(i => i.numero == idR.Value).FirstOrDefault();
            if (element != null)
            {
                var svg = element;
                listCE.Remove(element);
                svg.retirer(Convert.ToDouble(tRetrait.Value));
                listCE.Add(svg);
                trv = true;
            }
            if (trv == true)
            {
                MessageBox.Show("Retrait reussi avec success","merci de consolter pour voir les modification",MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("retrait avorter","verifier votre numero de compte",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool trv = false;
           var element= listCE.Where(i => i.numero == idR.Value).FirstOrDefault();
            if (element != null)
            {
                var svg = element;
                listCE.Remove(element);
                svg.deposer(Convert.ToDouble(tDepot.Value));
                listCE.Add(svg);
                trv = true;
            }
       
            if (trv == true)
            {
                MessageBox.Show("depot reussi avec success");
            }
            else
            {
                MessageBox.Show("depot avorter");
            }

        }

        private void Sauvegarder_Click(object sender, EventArgs e)
        {
            SaveFileDialog svg = new SaveFileDialog()
            {
                AddExtension = true,
                Filter = "FICHIER json |*.json",
                Title = "enregistrer le fichier"
            };
            DialogResult result = svg.ShowDialog();
            if (result == DialogResult.OK)
            {
                 var chemin = svg.FileName;
                string donnee = JsonConvert.SerializeObject(listCE,Formatting.Indented);
                System.IO.File.WriteAllText(chemin, donnee);
                MessageBox.Show("les information sauvegarder avec success");
            }
            


        }

        private void Charger_Click(object sender, EventArgs e)
        {
            OpenFileDialog charg = new OpenFileDialog() {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "Fichier json |*.json",
                Multiselect = false,
                Title = "Selectionner le fichier a charger"
            };
            var resultat = charg.ShowDialog();
            if (resultat == DialogResult.OK)
            {
                string chemin = charg.FileName;
                var donnee = System.IO.File.ReadAllText(chemin);
               var obj= JsonConvert.DeserializeObject<BindingList<CompteEpargne>>(donnee);
                foreach(CompteEpargne item in obj)
                {
                    listCE.Add(item);
                }
            }

        }
    }
}
