using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUPUIS_JAYSON_TD1
{
    public class Menu
    {
        Library librairie = new Library();
        public Menu() { }

        string choix = " ";
        public void lancement()
        {
            while(choix.Length > 0)
            {
                Console.WriteLine("Que voulez vous faire : ");
                Console.WriteLine("1 : Ajouter un media ");
                Console.WriteLine("2 : Supprimer un media");
                Console.WriteLine("3 : Rechercher un livre");
                Console.WriteLine("4 : Rechercher un emprunteur");
                Console.WriteLine("5 : Emprunter un livre");
                Console.WriteLine("6 : Rendre un livre");
                Console.WriteLine("Aucune saisie : rien");

                choix = Console.ReadLine();

                switch(choix){
                    case "1":
                        ajoutMedia();
                        break;
                }
            }
        }

        private void ajoutMedia()
        {
            Console.WriteLine("Quel est le nom du media a ajouter");
            string nomMedia = Console.ReadLine();
            Console.WriteLine("Quel est la reference du media a ajouter");
            int referenceMedia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quel est le nombre de ce media disponible");
            int quantiteMedia = Convert.ToInt32(Console.ReadLine());

            Media mediaAAjouter = new Media(nomMedia, referenceMedia, quantiteMedia);
            librairie.AddMedia(mediaAAjouter);

        }
    }

}
