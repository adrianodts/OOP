using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using SolidPrinciples.SingleResponsabilityPrinciple;

namespace SolidPrinciples.OpenClosePrinciple
{
    public class InvoiceTaxRateValidator : Validator
    {
        public bool Validate(Invoice invoice)
        {
            if (invoice.TaxRate < 0)
                return false;

            return true;
        }
    }
}
