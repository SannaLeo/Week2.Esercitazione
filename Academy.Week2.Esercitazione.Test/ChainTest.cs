using System;
using Week2.Esercitazione.Demo.Entities;
using Week2.Esercitazione.Demo.Handlers;
using Xunit;

namespace Week2.Esercitazione.Test
{
    public class ChainTest
    {
        [Fact]
        public void ShouldHaveParoductivityValueForEmployeeAge20AndProductivity50()
        {
            //Come utente mi aspetto che un impiegato di età 20 anni e tasso di produttività 
            //pari a 50 abbia un premio produttivita di 300. Dato un gestore del premio prod con valore
            //Y=25 
            //W=40

            //ARRANGE
            //Creo il dipendente con le caratteristiche che mi aspetto
            Employee emp = new()
            {
                DateOfBirth = new DateTime(2002, 1, 1),
                ProductivityRate = 50
            };

            //creo il gestore della rischiesta sfruttando i parametri Y e W
            int Y = 25;
            int W = 40;

            IHandler productivityHandler = new ProdHandler(Y, W);
            double premio = productivityHandler.Handle(emp);

            //ASSERT
            //Verifico che il premio sia uguale a 300

            Assert.Equal(300.0, premio);
        }

        [Fact]
        public void ShouldHaveParoductivityValueForEmployeeAge30AndAbsenceRate30()
        {
            //Come utente mi aspetto che un impiegato di eta < 30
            //e un tasso di assenza pari a 30
            //abbia un premio produttivita di 180.
            //Dato un gestore del premio presenza con valore
            //Y=35 
            //Z<40

            //ARRANGE
            //Creo il dipendente con le caratteristiche che mi aspetto
            Employee emp = new()
            {
                DateOfBirth = new DateTime(2002, 1, 1),
                ProductivityRate = 50,
                AbsenceRate = 30
            };

            //creo il gestore della rischiesta sfruttando i parametri Y e W
            int Y = 25;
            int Z = 40;

            IHandler productivityHandler = new AbsenceHandler(Y, Z);
            double premio = productivityHandler.Handle(emp);

            //ASSERT
            //Verifico che il premio sia uguale a 300

            Assert.Equal(180.0, premio);
        }
    }
}
