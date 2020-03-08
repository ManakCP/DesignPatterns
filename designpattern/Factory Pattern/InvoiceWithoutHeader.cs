using System;

class InvoiceWithoutHeader : IInvoice
{
    public void Print()
    {
        Console.WriteLine("Invoice with out header!!");
    }
}