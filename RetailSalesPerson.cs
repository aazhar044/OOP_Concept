using System;

class RetailSalesPerson : Salesman,SelfDeveloping
{
    public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
    {
    }

  public override void sell()
    {
         Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to buy this Pen!", this.FullName));
    }
    public void Develop()
    {
        System.Console.WriteLine("I developed my self by watching the videos");

    }
}