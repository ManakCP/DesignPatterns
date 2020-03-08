using System;

class InvoiceWithHeader : IInvoice
{
    public void Print()
    {
        Console.WriteLine("Invoice with header!!");
    }
}