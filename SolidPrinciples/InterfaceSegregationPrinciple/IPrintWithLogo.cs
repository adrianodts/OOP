using SolidPrinciples.SingleResponsabilityPrinciple;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    public interface IPrintWithLogo
    {
        void PrintWithLogo(Invoice invoice);
    }
}
