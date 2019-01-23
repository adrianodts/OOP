using SolidPrinciples.SingleResponsabilityPrinciple;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.LiskovSubstitutionPrinciple
{
    public class ComplexInvoiceModifier 
    {
        private ComplexInvoice _complexInvoice;

        public ComplexInvoiceModifier(ComplexInvoice complexInvoice)
        {
            _complexInvoice = complexInvoice;
        }

        public void SetSubTotal(decimal subtotal)
        {
            _complexInvoice.SubTotal = subtotal;
        }

        public void SetTaxRate(decimal taxRate)
        {
            _complexInvoice.TaxRate = taxRate;
        }

        public ComplexInvoice GenerateInvoice()
        {
            return _complexInvoice;
        }
    }
}
