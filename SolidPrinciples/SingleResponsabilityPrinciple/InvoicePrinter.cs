using SolidPrinciples.InterfaceSegregationPrinciple;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.SingleResponsabilityPrinciple
{
    namespace Solid.SingleResponsabilityPrinciple
    {
        public class InvoicePrinter
        {
            //Tightly coupled
            //private PrintingSystem _printingSystem;

            //With an interface the class is loosed coupled
            private IInvoicePrint _printingSystem;
            

            public InvoicePrinter(IInvoicePrint printingSystem)
            {
                _printingSystem = printingSystem;
            }

            
            public void Print(Invoice invoice)
            {
                //printing logic
                _printingSystem.Print(invoice);
            }
        }
    }
}
