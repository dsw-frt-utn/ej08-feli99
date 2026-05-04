using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_5
{
    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Importe; //sin descuento
        }
    }
}
