class InvoiceWithoutHeaderCreater : AInvoiceCreater
{
    public override IInvoice FactoryMethod()
    {
        return new InvoiceWithoutHeader();
    }
}