using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class CarteCredit : Paiement
    {
        public int NumeroCarte { get; set; }

        public CarteCredit(string description, double montant, int carte  ) : base(description, montant)
        {
            NumeroCarte = carte;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"les informations  sont :{Description},{Montant}, {NumeroCarte}");
        }
    }
}
