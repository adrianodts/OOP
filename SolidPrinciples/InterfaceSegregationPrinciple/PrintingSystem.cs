using System;
using System.Collections.Generic;
using System.Text;
using SolidPrinciples.SingleResponsabilityPrinciple;

namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    public class PrintingSystem : IInvoicePrint
    {
        public void Print(Invoice invoice)
        {
            //Logic to print the invoice
        }
    }
}
