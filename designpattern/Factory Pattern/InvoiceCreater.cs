using System;

class InvoiceCreater
{
    AInvoiceCreater aInvoiceCreater;
    internal void GetInvoice(string invoiceType)
    {
        if (invoiceType.ToLower() == "withheader")
        {
            aInvoiceCreater = new InvoiceWithHeaderCreater();
            aInvoiceCreater.PerformAction();
        }else if (invoiceType.ToLower() == "withoutheader")
        {
            aInvoiceCreater = new InvoiceWithoutHeaderCreater();
            aInvoiceCreater.PerformAction();
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}