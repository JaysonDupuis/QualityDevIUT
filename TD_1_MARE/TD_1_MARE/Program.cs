using System;
using TD_1_MARE;

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
}
