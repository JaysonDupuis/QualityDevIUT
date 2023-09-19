﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUPUIS_JAYSON_TD1
{
    public class DVD : Media
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
}
