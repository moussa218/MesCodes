using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Compte_Bancaire
{
    public partial class pageLCCR : Form

    {
        BindingList<CompteEpargne> liseCE = null;
        BindingList<CompteCredit> liseCCR = null;
        BindingList<CompteCourant> liseCCO = null;
        public pageLCCR()
        {
            InitializeComponent();
            liseCE = new BindingList<CompteEpargne>();
            liseCCR = new BindingList<CompteCredit>();
            liseCCO = new BindingList<CompteCourant>();
            dataGridLCE.DataSource = liseCE;
            dataGridLCCR.DataSource = liseCCR;
            dataGridLCCO.DataSource = liseCCO;
        }

        private void pageCCR_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterCE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nomcomplet.Text))
            {
                MessageBox.Show("nom invalide", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                liseCE.Add(new CompteEpargne()
                {
                    numero=liseCE.Count()+1,
                    solde=Convert.ToInt32(solde.Value),
                    dateOuverture=dateouverture.Value,
                    nomcomplet=nomcomplet.Text
                 });
            numero.Value = numero.Minimum;
            solde.Value = numero.Minimum;
            dateouverture.Value = dateouverture.MinDate;
            nomcomplet.Text = string.Empty;
         }

        private void pageCE_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ajoutCCO_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nomc.Text))
            {
                MessageBox.Show("veulliez donner un nom valide", "error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            liseCCO.Add(new CompteCourant()
            {
                numero=liseCCO.Count()+1,
                solde=Convert.ToInt32(sdle.Value),
                dateOuverture=dateouvert.Value,
                decouvert=Convert.ToInt32(decouvert.Value),
                nomcomplet=nomc.Text
            });
            numb.Value = numb.Minimum;
            sdle.Value = sdle.Minimum;
            dateouvert.Value = dateouvert.MinDate;
            decouvert.Value = decouvert.Minimum;
            nomc.Text = string.Empty;

        }

        private void decouvert_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAjoutCCR_Click(object sender, EventArgs e)
        {
            bool ret = true;
            if (string.IsNullOrWhiteSpace(nomcpl.Text))
            {
                ret = false;
                MessageBox.Show("donner un nom correct", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ret == true)
            {
                liseCCR.Add(new CompteCredit()
                {
                    numero = liseCCR.Count() + 1,
                    solde = Convert.ToInt32(soldde.Value),
                    dateOuverture = dateouv.Value,
                    duree = Convert.ToInt32(duree.Value),
                    dateTerme = dateTerme.Value,
                    nomcomplet = nomcpl.Text
                });
                num.Value = 0;
                soldde.Value = soldde.Minimum;
                dateouv.Value = dateouv.MinDate;
                dateTerme.Value = dateTerme.MinDate;
                duree.Value = duree.Value;
                nomcpl.Text = string.Empty;
            }
        }

        private void dateouv_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRech_Click(object sender, EventArgs e)
        {
          
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            int type = typeCompte.SelectedIndex;
            BindingList<CompteEpargne> lcepagn = new BindingList<CompteEpargne>();
            if (type==0)
            {
                CompteEpargne r = liseCE.Where(ce => ce.numero ==numRech.Value).FirstOrDefault();
                if (r != null)
                {
                    
                    if (typeOperation.SelectedIndex==0)
                    {
                        
                        r.solde += Convert.ToInt32(montant.Value);
                        lcepagn.Add(r);
                        dataGridResultat.DataSource = lcepagn;
                        
                       
                        
                   
                    }
                    if (typeOperation.SelectedIndex == 1)
                    {
                       
                        r.solde -= Convert.ToInt32(montant.Value);
                        lcepagn.Add(r);
                        dataGridResultat.DataSource = lcepagn;




                    }
                    num.Value = num.Minimum;



                }
                else
                {
                    MessageBox.Show("ce numero de compte n existe pas", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
             
            if (type == 1)
            {
                CompteEpargne r = liseCCO.Where(ce => ce.numero == numRech.Value).FirstOrDefault();
                if (r != null)
                {
                    //depot
                    if (typeOperation.SelectedIndex == 0)
                    {
                      
                        r.solde += Convert.ToInt32(montant.Value);
                        lcepagn.Add(r);
                        dataGridResultat.DataSource = lcepagn;

                        MessageBox.Show("depot reussi", "merci", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    // retrait
                    if (typeOperation.SelectedIndex == 1)
                    {
                      
                        r.solde -= Convert.ToInt32(montant.Value);
                        lcepagn.Add(r);
                        dataGridResultat.DataSource = lcepagn;

                        MessageBox.Show("retrait reussi", "merci", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    num.Value = num.Minimum;



                }
                else
                {
                    MessageBox.Show("ce numero de compte n existe pas", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
             
            if (type == 2)
            {
                CompteEpargne r = liseCCR.Where(ce => ce.numero == numRech.Value).FirstOrDefault();
                if (r != null)
                {
                    //depot
                    if (typeOperation.SelectedIndex == 0)
                    {
                       
                        r.solde += Convert.ToInt32(montant.Value);
                        lcepagn.Add(r);
                        dataGridResultat.DataSource = lcepagn;

                        MessageBox.Show("depot reussi", "merci", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    // retrait
                    if (typeOperation.SelectedIndex == 1)
                    {
                      
                        r.solde -= Convert.ToInt32(montant.Value);
                        lcepagn.Add(r);
                        dataGridResultat.DataSource = lcepagn;

                        MessageBox.Show("retrait reussi", "merci", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    num.Value = num.Minimum;



                }
                else
                {
                    MessageBox.Show("ce numero de compte n existe pas", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
             
        }

        private void montant_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
