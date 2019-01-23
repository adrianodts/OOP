using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.InterfaceSegregationPrinciple
{
    public interface IPrintAll : IInvoicePrint, IPrintWithLogo
    {
    }
}
