using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Esercitazione.Demo.Benefits
{
    internal class AutoBenefit : BenefitDecorator
    {
        public string NTarga { get; set; }
        public string Modello { get; set; }

        public AutoBenefit(Benefit benefit, string ntarga, string modello) : base(benefit)
        {
            NTarga = ntarga;
            Modello = modello;
        }
        public override string Stampa()
        {
            return base.Stampa() + $" con targa {NTarga} e modello {Modello} |";
        }
    }
}
