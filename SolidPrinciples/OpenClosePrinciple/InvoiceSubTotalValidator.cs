using System;
using System.Collections.Generic;
using System.Text;
using SolidPrinciples.SingleResponsabilityPrinciple;

namespace SolidPrinciples.OpenClosePrinciple
{
    public class InvoiceSubTotalValidator : Validator
    {
        public bool Validate(Invoice invoice)
        {
            if (invoice.SubTotal < 0)
                return false;

            return true;
        }
    }
}
