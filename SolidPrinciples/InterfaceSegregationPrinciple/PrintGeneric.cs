using System;
using System.Collections.Generic;
using System.Text;
using SolidPrinciples.SingleResponsabilityPrinciple;

namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    public class PrintGeneric : IPrintAll
    {
        public void Print(Invoice invoice)
        {
            //Logic for printing Invoice
        }

        public void PrintWithLogo(Invoice invoice)
        {
            //Logic for printing Invoice with logo
        }
    }
}
