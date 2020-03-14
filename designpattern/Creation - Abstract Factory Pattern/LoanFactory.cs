abstract class LoanFactory
{
    public abstract IBank GetBank();
    public abstract ALoan GetLoan();
}