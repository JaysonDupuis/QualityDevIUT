using System;

namespace Tp_gestion
{
    class Program
    {
        static void Main(string[] args)
        {
            Media livre = new Media("lelivre", 7, 10);
            livre.AfficherInfos();
            livre += 2;
            livre.AfficherInfos();
            livre -= 4;
            livre.AfficherInfos();
        }
    }

    class Media
    {
        private string titre;

        private int reference;

        private int nombreExemplaireDispo;

        public Media(string titre, int reference, int nombreExemplaireDispo)
        {
            this.titre = titre;
            this.reference = reference;
            this.nombreExemplaireDispo = nombreExemplaireDispo;
        }

        public static Media operator +(Media mediaAModifier, int aAjouter)
        {
            if (aAjouter <= 0)
            {
                throw new ArgumentException("Le nombre que vous avez tenter d'ajouter est inferieur ou égal a 0");
            }
            mediaAModifier.nombreExemplaireDispo += aAjouter;
            return mediaAModifier;
        }

        public static Media operator -(Media mediaAModifier, int aRetirer)
        {
            if (mediaAModifier.nombreExemplaireDispo <= aRetirer)
            {
                throw new ArgumentException("Vous avez tenté de retirer plus de livre que vous n'en avez de disponible");
            }
            mediaAModifier.nombreExemplaireDispo -= aRetirer;
            return mediaAModifier;
        }
        public virtual void AfficherInfos()
        {
            Console.WriteLine("Titre du média : " + titre);
            Console.WriteLine("Reference du média : " + reference);
            Console.WriteLine("Nombre d'exemplaire disponible du média : " + nombreExemplaireDispo);

        }
    }

    class Livre : Media
    {
        private string auteur;

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
    class DVD : Media
    {
        private int duree;
        public DVD(int duree, string titre, int reference, int nombreExemplaireDispo) : base(titre, reference, nombreExemplaireDispo)
        {
            this.duree = duree;
        }
        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Durée du film : " + duree);
        }
    }
    class CD : Media
    {
        private string artiste;

        public CD(string artiste, string titre, int reference, int nombreExemplaireDispo) : base(titre, reference, nombreExemplaireDispo)
        {
            this.artiste = artiste;
        }
        public override void AfficherInfos()
        {
            base.AfficherInfos();
            Console.WriteLine("Artiste : " + artiste);
        }
    }

    class Tools
    {

    }



}
