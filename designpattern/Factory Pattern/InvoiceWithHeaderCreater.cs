class InvoiceWithHeaderCreater : AInvoiceCreater
{
    public override IInvoice FactoryMethod()
    {
        return new InvoiceWithHeader();
    }
}