using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Esercitazione.Demo.Entities;

namespace Week2.Esercitazione.Demo.Companies
{
    public interface ICompany
    {
        int NumEmployees { get; set; }

        static List<Employee> Employees = new();

        void AddEmployee(Employee emp)
        {
            if(Employees.Count == NumEmployees)
            {
                Console.WriteLine("Errore, numero dipendenti massimo raggiunto");
                return;
            }
            Employees.Add(emp);
        }
        void AddEmployees(int num, Employee emp)
        {
            if (Employees.Count == NumEmployees)
            {
                Console.WriteLine("Errore, numero dipendenti massimo raggiunto");
                return;
            }
            if (Employees.Count + num > NumEmployees)
            {
                Console.WriteLine("Errore, numero dipendenti massimo raggiunto");
                return;
            }
            for (int i = 0; i < num; i++)
            {
                Employees.Add(emp);
            }
        }
    }
}
