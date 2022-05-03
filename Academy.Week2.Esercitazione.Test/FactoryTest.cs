using Xunit;
using Week2.Esercitazione.Demo;
using Week2.Esercitazione.Demo.Companies;

namespace Week2.Esercitazione.Test
{
    public class FactoryTest
    {
        [Fact]
        public void ShouldCreateSmallCompanyTenEmployees()
        {
            //Mi aspetto che la creazione di un'azienda di piccole dimensioni nel caso in cui 
            // il numero di dipendenti sia pari a 10
            

            //ARRANGE
            //dichiaro una variabile con il numero di dipendenti
            int numdip = 10;


            //ACT
            //richiamo il metodo di creazione della nostra azienda
            CompanyFactory companyFactory = new();

            ICompany smallcompany = companyFactory.GetCompany(numdip);


            //ASSERT
            //
            Assert.Equal(smallcompany.GetType().Name, "SmallCompany");

        }

        [Fact]
        public void ShouldCreateMediumCompanyFiftyEmployees()
        {
            int numdip = 50;

            CompanyFactory companyFactory = new();
            ICompany mediumCompany = companyFactory.GetCompany(numdip);
            Assert.Equal(mediumCompany.GetType().Name, "AverageCompany");
        }

        [Fact]
        public void ShouldCreateNullCompanyNegativeEmployees()
        {
            int numdip = -2;
            CompanyFactory companyFactory = new();
            ICompany mediumCompany = companyFactory.GetCompany(numdip);
            Assert.Null(mediumCompany);
        }
    }
}