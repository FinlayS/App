using System;

public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
{
    public XSClubPromoter(string firstName, string lastName, long cellPhone) : base(firstName, lastName, cellPhone)
    {
    }
    protected override void ShareWithInnerCircle()
    {
        Console.WriteLine("I share with my FB dudes");
    }

    protected override void UsePaidAds()
    {
        Console.WriteLine("I buy my own ads");
    }

    public void Vlog()
    {
        Console.WriteLine("I Vlog XS Club");
    }

    public void Workout()
    {
        Console.WriteLine("I workout");
    }
}