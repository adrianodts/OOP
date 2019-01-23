using System;
using System.Collections.Generic;
using System.Text;
using SolidPrinciples.SingleResponsabilityPrinciple;

namespace SolidPrinciples.OpenClosePrinciple
{
    public class InvoiceTotalValidator : Validator
    {
        public bool Validate(Invoice invoice)
        {
            if (invoice.CalculateTotal() < 0)
                return false;

            return true;
        }
    }
}
