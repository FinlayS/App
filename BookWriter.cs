using System;

public class BookWriter : Writer
{
    public BookWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Write()
    {
        Console.WriteLine("I blog with my iMacBook");
    }
    public override void Vlog()
    {
        Console.WriteLine("I blog with my iPhoneBook");
    }
}