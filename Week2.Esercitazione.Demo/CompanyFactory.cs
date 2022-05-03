using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Esercitazione.Demo.Companies;

namespace Week2.Esercitazione.Demo
{
    public class CompanyFactory
    {
        public ICompany GetCompany(int numDipendenti)
        {
            ICompany company = null;
            if(numDipendenti <= 0)
            {
                return null;
            }
            if(numDipendenti <= 20)
            {
                company = new SmallCompany();
            }
            else if(numDipendenti <= 100)
            {
                company = new AverageCompany();
            }
            else if(numDipendenti <= 500)
            {
                company = new BigCompany();
            }
            else
            {
                company = new MultinationalComplany();
            }
            company.NumEmployees = numDipendenti;
            return company;
        }
    }
}
