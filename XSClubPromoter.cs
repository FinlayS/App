public class XSClubPromoter : Promoter, IBodyBuilder, IVlogger
{
    public XSClubPromoter(string firstName, string lastName, string phone) : base(firstName, lastName, phone)
    {
    }
    public override void Promote()
    {

    }

    public void Vlog()
    {
        throw new System.NotImplementedException();
    }

    public void Workout()
    {
        throw new System.NotImplementedException();
    }
}