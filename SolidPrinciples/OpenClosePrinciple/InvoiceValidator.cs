using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidPrinciples.SingleResponsabilityPrinciple;

namespace SolidPrinciples.OpenClosePrinciple
{
    /*********************************************
     OCP - Open Close Principle
     Open for extension and closed for modification
    /*********************************************/
    public class InvoiceValidator
    {
        //  Theres nothing wrong with the method Validate(), 
        //  but if we want to implement others validations rules, 
        //  we will break OCP.

        /*
        public bool Validate(Invoice invoice)
        {
            if (invoice.SubTotal < 0)
                return false;
            if (invoice.TaxRate < 0)
                return false;

            return true;
        } 
        */

        //  To unbreak the open close principle:
        //  It will be created an interface with a commom method called Validate() 
        //      Validator

        //  Three classes for each validation rule; Theese classes will implement the interface.
        //      InvoiceSubTotalValidator
        //      InvoiceTaxRateValidator
        //      InvoiceTotalValidator

        //  Finally change this class to acept a list of validators to be tested.
        //      List<Validator> _validators;


        private List<Validator> _validators;
        public InvoiceValidator(List<Validator> validators)
        {
            _validators = validators;
        }

        public bool Validate(Invoice invoice)
        {
            return _validators.All(v => v.Validate(invoice));
        }
    }
}
