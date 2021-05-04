using System;

public abstract class Promoter
{

    private string _firstName;
    private string _lastName;

    public string FullName
    {
        get
        {
            return string.Format("{0} {1}", this._firstName, this._lastName);
        }

    }
    public Promoter(string firstName, string lastName, string phone)
    {
        this._firstName = firstName;
        this._lastName = lastName;
    }

    public abstract void Promote();
}