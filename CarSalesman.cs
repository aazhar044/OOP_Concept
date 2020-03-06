using System;

public class Carsalesman : Salesman
{
    public Carsalesman(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void sell()
    {
         Console.WriteLine(string.Format("Hi my name is {0}. I would recommend you to buy this Car!", this.FullName));
    }
}