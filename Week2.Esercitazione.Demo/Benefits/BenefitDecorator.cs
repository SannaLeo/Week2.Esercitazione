using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Esercitazione.Demo.Benefits
{
    public class BenefitDecorator : Benefit
    {
        public Benefit BenefitWrapped { get; set; }

        public BenefitDecorator(Benefit benefit)
        {
            BenefitWrapped = benefit;
        }
        public override string Stampa()
        {
            return base.Stampa();
        }
    }
}
