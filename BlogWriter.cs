using System;

public abstract class BlogWriter : Writer
{
    public BlogWriter(string firstName, string lastName) : base(firstName, lastName)
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