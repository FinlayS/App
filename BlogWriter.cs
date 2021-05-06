using System;

public class BlogWriter : Writer
{
    public BlogWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }
    public override void Write()
    {
        Console.WriteLine("I blog with my pen");
    }

    public override void Vlog()
    {
        Console.WriteLine("I Vlog with my go pro");
    }

}