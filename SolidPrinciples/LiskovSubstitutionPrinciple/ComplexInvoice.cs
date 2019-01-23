using SolidPrinciples.SingleResponsabilityPrinciple;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.LiskovSubstitutionPrinciple
{
    /*********************************************
     LSP - Liskov Substitution Principle
     The parent cannot replace the child object seamlessly
    /*********************************************/

    //First step is remove the inheritance
    public class ComplexInvoice //: Invoice
    {

        public decimal SubTotal { get; set; }
        public decimal TaxRate { get; set; }

        public decimal SecondTaxRate { get; set; }

        //Second step is remove the substitution method

        //public new decimal CalculateTax()
        //{
        //    return (SubTotal * TaxRate / 100) + (SubTotal * SecondTaxRate / 100);
        //}

        public decimal CalculateTax()
        {
            return (SubTotal * TaxRate / 100) + (SubTotal * SecondTaxRate / 100);
        }

        public decimal CalculateTotal()
        {
            return SubTotal + CalculateTax();
        }

        //Third step is to create a class called ComplexInvoiceModifier that substitutes the InvoiceModifier

        //This problem could be solved with an interface too
        // 1 - first create an interface and declare a comom method 
        // 2 - second create the ComplexInvoice e InvoiceModifier classes that implements the interface
    }
}
