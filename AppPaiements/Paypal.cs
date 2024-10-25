using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal : Paiement
    {
        public string Courriel { get; set; }

        public Paypal(string description, double montant, string email) : base(description, montant)
        {
            Courriel = email;
        }
        public override void AfficherDetails()
        {
            Console.WriteLine($"les infos sont :{Description},{Montant}, {Courriel}");
        }
    }
}
