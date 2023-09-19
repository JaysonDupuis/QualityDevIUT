using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUPUIS_JAYSON_TD1
{
    public class Livre : Media
    {
        public string auteur;

        public Livre(string auteur, string titre, int reference, int nombreExemplaireDispo) : base(titre, reference, nombreExemplaireDispo)
        {
            this.auteur = auteur;
        }

        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Auteur du livre : " + auteur);
        }
    }
}
