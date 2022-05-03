using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Esercitazione.Demo.Entities;

namespace Week2.Esercitazione.Demo.Handlers
{
    public interface IHandler
    {
        public double Handle(Employee employee);
    }
}
