using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_5
{
    public class Sale
    {
       public decimal Importe { get; set ; }

        public virtual decimal CalculateTotal()
        {
            return Importe;
        }
    }
}
