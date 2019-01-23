using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.SingleResponsabilityPrinciple
{
    /*********************************************
     SRF - Single Responsability Principle
     Concerned about single focused pourpose     
    /*********************************************/
    public class Invoice
    {
        public decimal SubTotal { get; set; }
        public decimal TaxRate { get; set; }

        public decimal CalculateTax()
        {
            return SubTotal * TaxRate / 100;
        }
        public decimal CalculateTotal()
        {
            return SubTotal + CalculateTax();
        }

        // This class represents methods that are not your responsibility
        // A new class called InvoicePrinter will be created to solve the 
        // problem of SRF - Single Responsability Principle

        //public void Print(Invoice invoice)
        //{
        //    //printing logic
        //}
    }
}
