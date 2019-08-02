using System.Drawing;

namespace Panier
{
    public class Produit
    {
        public string Nom { get; set; }
        public string Type { get; set; }
        public int PrixUnitaire { get; set; }
        public int Quantite { get; set; }
        public int PrixTotal => PrixUnitaire * Quantite;
        public string CheminImage { get; set; }
        public Image ImageProduit
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(CheminImage))
                {
                    return Image.FromFile(CheminImage).GetThumbnailImage(50, 50, null, System.IntPtr.Zero);
                }

                return null;
            }
        }
    }
}
