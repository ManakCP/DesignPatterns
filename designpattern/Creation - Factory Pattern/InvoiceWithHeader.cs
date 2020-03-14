using System;

class InvoiceWithHeader : AInvoiceCreater
{
    internal override void Print()
    {
        this.subject = "Invoice with header!!";
    }
}