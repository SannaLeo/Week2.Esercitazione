using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Esercitazione.Demo.Benefits
{
    public class Benefit
    {
        public string Name { get; set; } = "Nessun Benefit";

        public virtual string Stampa()
        {
            return $"| {Name} ";
        }
    }
}
