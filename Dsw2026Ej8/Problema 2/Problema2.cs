using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_2
{
    internal class Problema2
    {
        public static string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total;
            if (quantity <= 0)
            {
                total = 0;
            }
            else
            {
                total = quantity * unitPrice;
            }

            var venta = new
            {
                _Code = productCode,
                _Description = productDescription,
                _Quantity = quantity,
                _Total = total,

            };

            return $"{venta._Code}-{venta._Description}-{venta._Total:C}";

        }

       
    }
}
