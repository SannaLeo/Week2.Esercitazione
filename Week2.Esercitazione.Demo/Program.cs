using System;
using Week2.Esercitazione.Demo;
using Week2.Esercitazione.Demo.Companies;
using Week2.Esercitazione.Demo.Entities;

Console.WriteLine("Inserisci il numero di Dipendenti dell'azienda ");
int ndip;
if (!int.TryParse(Console.ReadLine(), out ndip))
{
    Console.WriteLine("Errore");
    return;
}
CompanyFactory factory = new CompanyFactory();
ICompany company = factory.GetCompany(ndip);
Employee emp = new();
