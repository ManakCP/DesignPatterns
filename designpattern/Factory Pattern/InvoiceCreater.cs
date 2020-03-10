using System;

class InvoiceCreater
{
    AInvoiceCreater aInvoiceCreater;
    internal void GetInvoice(EnumInvoiceType invoiceType)
    {
        if (invoiceType == EnumInvoiceType.WithHeader)
        {
            aInvoiceCreater = new InvoiceWithHeader();
            aInvoiceCreater.PerformAction();
        }
        else if (invoiceType == EnumInvoiceType.WithOutHeader)
        {
            aInvoiceCreater = new InvoiceWithoutHeader();
            aInvoiceCreater.PerformAction();
        }
    }
}