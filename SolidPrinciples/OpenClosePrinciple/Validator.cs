using System;
using System.Collections.Generic;
using System.Text;
using SolidPrinciples.SingleResponsabilityPrinciple;

namespace SolidPrinciples.OpenClosePrinciple
{
    public interface Validator
    {
        bool Validate(Invoice invoice);
    }
}
