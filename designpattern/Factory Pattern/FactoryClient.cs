using System;

class FactoryClient
{
    internal void Main()
    {
        //CREATION - FACTORY PATTERN
        /*
        * Ref - https://refactoring.guru/design-patterns/factory-method
        */
        Console.WriteLine("CREATION - FACTORY PATTERN");
        Console.WriteLine(">> With user input");
        /* 
        * Client only knows about InvoiceCreator's GetInvoice/PerformAction, 
        * based on Type of Creator send as parameter
        */
        InvoiceCreater invoice = new InvoiceCreater();
        invoice.GetInvoice(invoiceType: "withheader");
        invoice.GetInvoice(invoiceType: "withoutheader");
        invoice.GetInvoice(invoiceType: "invalid");

        Console.WriteLine(Environment.NewLine + ">> WithOut user input");
        /* 
        * Client only knows about InvoiceCreator's PerformAction, 
        * based on Type of Creator created
        */
        AInvoiceCreater invoiceCreater;
        invoiceCreater = new InvoiceWithHeaderCreater();
        invoiceCreater.PerformAction();
        invoiceCreater = new InvoiceWithoutHeaderCreater();
        invoiceCreater.PerformAction();
        /*
        * New type of Invoice can be added later by just 
        * Creating Creator and Concreate Class
        * InvoiceWithoutHeaderCreater * InvoiceWithoutHeader
        */
    }
}