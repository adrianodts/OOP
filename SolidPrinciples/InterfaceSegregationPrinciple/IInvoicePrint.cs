using SolidPrinciples.SingleResponsabilityPrinciple;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    /*********************************************
     ISP - Intercace Segregation Principle
     An interface should not force any method to class wich is implementing it     
    /*********************************************/
    public interface IInvoicePrint
    {
        void Print(Invoice invoice);

        // If a class that implements the IInvoicePrint does not need to implement 
        // the  PrintWithLogo method, the interface should not force it, so to solve this problem,
        // another interface will be created called IPrintWithLogo with the method PrintWithLogo()
        // follow this role we are not forcing a method implementation and segregating interfaces

        //void PrintWithLogo(Invoice invoice);
    }
}
