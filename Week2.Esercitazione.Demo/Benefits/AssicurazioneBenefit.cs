using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Esercitazione.Demo.Benefits
{
    public class AssicurazioneBenefit : BenefitDecorator
    {
        public string CodiceCliente { get; set; }
        public AssicurazioneBenefit(Benefit benefit, string codiceCliente) : base(benefit)
        {
            CodiceCliente = codiceCliente;
        }

        public override string Stampa()
        {
            return base.Stampa() + $" con codice {CodiceCliente} |";
        }
    }
}
