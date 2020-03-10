using System;

class InvoiceWithoutHeader : AInvoiceCreater
{ 
    internal override void Print()
    {
        Console.WriteLine("Invoice with out header!!");
    }
}