using System;

abstract class AInvoiceCreater
{
    protected string subject;
    internal abstract void Print();

    public void PerformAction()
    {
        this.Print();
        Console.WriteLine(subject);
    }
}