using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Esercitazione.Demo.Benefits
{
    internal class RestaurantBenefit : BenefitDecorator
    {
        public string NTessera { get; set; }
        public int NTicketMensili { get; set; }
        public RestaurantBenefit(Benefit benefit, string tessera, int ticketm) : base(benefit)
        {
            NTessera = tessera;
            NTicketMensili = ticketm;
        }

        public override string Stampa()
        {
            return base.Stampa() + $" con n. {NTessera} e {NTicketMensili} pasti |";
        }
    }
}
