using System;

class FactoryClient
{
    internal void Main()
    {
        //CREATION - FACTORY PATTERN
        /*
        * Learning Reference
        * https://refactoring.guru/design-patterns/factory-method
        * https://www.javatpoint.com/factory-method-design-pattern
        */
        Console.WriteLine("CREATION - FACTORY PATTERN");
        Console.WriteLine(">> With user input");
        /* 
        * Client only knows about InvoiceCreator's GetInvoice/PerformAction, 
        * based on Type of Creator send as parameter
        */
        InvoiceCreater invoice = new InvoiceCreater();
        invoice.GetInvoice(invoiceType: EnumInvoiceType.WithHeader);
        invoice.GetInvoice(invoiceType: EnumInvoiceType.WithOutHeader);

        Console.WriteLine(Environment.NewLine + ">> WithOut user input");
        /* 
        * Client only knows about InvoiceCreator's PerformAction, 
        * based on Type of Creator created
        */
        AInvoiceCreater invoiceCreater;
        invoiceCreater = new InvoiceWithHeader();
        invoiceCreater.PerformAction();
        invoiceCreater = new InvoiceWithoutHeader();
        invoiceCreater.PerformAction();
        /*
        * New type of Invoice can be added later by just 
        * Creating Creator and Concreate Class
        * InvoiceWithoutHeaderCreater * InvoiceWithoutHeader
        */
    }
}