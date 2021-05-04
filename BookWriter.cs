using System;

public abstract class BookWriter : Writer
{
    public BookWriter(string firstName, string lastName) : base(firstName, lastName)
    {
    }

    public override void Write()
    {
        throw new NotImplementedException();
    }
    public override void Vlog()
    {
        throw new NotImplementedException();
    }
}