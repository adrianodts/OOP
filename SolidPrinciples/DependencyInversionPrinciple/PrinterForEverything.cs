using SolidPrinciples.InterfaceSegregationPrinciple;
using SolidPrinciples.SingleResponsabilityPrinciple;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.DependencyInversionPrinciple
{
    /*********************************************
     DIP - Dependency Inversion Principle
     Object should be loosely coupled and injection should happen at runtime     
    /*********************************************/

    public class PrinterForEverything
    {
        //Tightly coupled because we are referencing the class

        //private PrintingSystem _printingSystem;
        //private PrintGeneric _printGeneric;


        //With interfaces, the class PrinterForEverything is loosed coupled

        private IInvoicePrint _printingSystem; 
        private IPrintWithLogo _printingGeneric;
        private IPrintAll _printAll;

        //Injecting interfaces to make this class loosed coupled
        public PrinterForEverything(IInvoicePrint printingSystem, IPrintWithLogo printingGeneric, IPrintAll printAll)
        {
            _printingSystem = printingSystem;
            _printingGeneric = printingGeneric;
            _printAll = printAll;
        }
        

        //We can print everything without knowing the implementation 

        public void Print(Invoice invoice)
        {
            //printing logic
            _printingSystem.Print(invoice);
        }

        public void PrintWithLogo(Invoice invoice)
        {
            //PrintWithLogo logic
            _printingGeneric.PrintWithLogo(invoice);
        }

        public void PrintAll(Invoice invoice)
        {
            //printAll logic
            _printAll.Print(invoice);
            _printAll.PrintWithLogo(invoice);
        }
    }
}
