using SolidPrinciples.SingleResponsabilityPrinciple;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.LiskovSubstitutionPrinciple
{
    public class InvoiceModifier
    {
        private Invoice _invoice;

        public InvoiceModifier(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void SetSubTotal(decimal subtotal)
        {
            _invoice.SubTotal = subtotal;
        }

        public void SetTaxRate(decimal taxRate)
        {
            _invoice.TaxRate = taxRate;
        }

        public Invoice GenerateInvoice()
        {
            return _invoice;
        }

    }
}
