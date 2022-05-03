using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Esercitazione.Demo.Benefits
{
    public class PostoBenefit : BenefitDecorator
    {
        public string CodicePostoAuto { get; set; }

        public PostoBenefit(Benefit benefit, string codicePostoAuto) : base(benefit)
        {
            CodicePostoAuto = codicePostoAuto;
        }

        public override string Stampa()
        {
            return base.Stampa() + $"con codice {CodicePostoAuto} |";
        }
    }
}
