using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUPUIS_JAYSON_TD1
{
    public class Emprunt
    {
        public String emprunteur { get; set; }
        public Media mediaEmprunte {  get; set; }

        public Emprunt(Media mediaEmprunte, String emprunteur)
        {
            this.emprunteur = emprunteur;
            this.mediaEmprunte = mediaEmprunte;
        }
    }
}
