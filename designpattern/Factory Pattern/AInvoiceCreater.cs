abstract class AInvoiceCreater
{
    public abstract IInvoice FactoryMethod();

    public void PerformAction()
    {
        IInvoice invoice = FactoryMethod();
        invoice.Print();
    }
}