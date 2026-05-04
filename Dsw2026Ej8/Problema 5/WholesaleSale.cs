using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_5
{
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Importe * 0.9m;  //descuento
        }
    }
}
