using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Carsalesman carsalesman=new Carsalesman("Marry", "Tom");
            carsalesman.sell();
            RetailSalesPerson retailSalesPerson = new RetailSalesPerson("Harry", "Mat");
            retailSalesPerson.sell();
            WebDeveloper webDeveloper = new WebDeveloper();
            webDeveloper.Develop();
            retailSalesPerson.Develop();
        }

    }
}
