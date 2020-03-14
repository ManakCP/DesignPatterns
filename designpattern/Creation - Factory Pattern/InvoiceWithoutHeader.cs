using System;

class InvoiceWithoutHeader : AInvoiceCreater
{ 
    internal override void Print()
    {
        this.subject = "Invoice with out header!!";       
    }
}