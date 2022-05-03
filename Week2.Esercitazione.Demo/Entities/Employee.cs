using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Esercitazione.Demo.Entities
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public DateTime DateOfBirth { get; set; }
        private int _age = 20;
        public int Age
        {
            get { return _age; }
            set { _age = DateTime.Now.Year - DateOfBirth.Year /* - (DateTime.Now.DayOfYear < DateOfBirth.DayOfYear ? 1 : 0)*/; }
        }
        public int ProductivityRate { get; set; }
        public int AbsenceRate { get; set; }

        public Employee()
        {
            
        }
    }
}



//{

//    public string Premio { get; private set; }
//    public string Benefici { get; set; }
//    public DateTime DataNascita { get; set; }
//    public DateTime DataAssunzione { get; set; }
//    public int TassoProduttivita { get; set; }
//    public int TassoAssenza { get; set; }
//    public int Eta
//    {
//        get { return Eta; }
//        set { Eta = DateTime.Now.Year - DataNascita.Year - (DateTime.Now.DayOfYear < DataNascita.DayOfYear ? 1 : 0); }
//    }
//    public int Anzianita
//    {
//        get { return Anzianita; }
//        set { Anzianita = DateTime.Now.Year - DataAssunzione.Year - (DateTime.Now.DayOfYear < DataAssunzione.DayOfYear ? 1 : 0); }
//    }

//    public Employee()
//    {

//    }

//    public void AttribuisciPremi(int Y, int W, int Z)
//    {
//        if (Anzianita > 43)
//        {
//            Premio = "ANZIANITA";
//        }
//        else if (TassoProduttivita >= W)
//        {
//            Premio = "BENESSERE_COLLETTIVO";
//        }
//        else if (Eta < Y && TassoAssenza < Z)
//        {
//            Premio = "PRESENZA";
//        }
//        else if (Eta < Y && TassoAssenza < Z)
//        {
//            Premio = "PRODUTTIVITA'";
//        }
//        else
//        {
//            Premio = "";
//        }
//    }
//    public void AddBenefit(string benefit)
//    {

//    }
