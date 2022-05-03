using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Esercitazione.Demo.Entities;

namespace Week2.Esercitazione.Demo.Handlers
{
    public class ProdHandler : IHandler
    {
        public int Y { get; set; }
        int W { get; set; }
        public ProdHandler(int y, int w)
        {
            Y = y;
            W = w;
        }

        public double Handle(Employee employee)
        {
            if(employee.Age < Y && employee.ProductivityRate > W)
            {
                return 300;
            }
            else
            {
                return 0;
            }
        }
    }
}
