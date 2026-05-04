using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Problema_3
{
    internal class Problema3
    {
        public static string CompararCopias(int originalValue, Product product)
        {
            int copiarValor = originalValue;

            copiarValor++;

            Product copiarProduct = product;

            copiarProduct.CambiarDescripcion("Producto Modificado");

            return $"{originalValue}-{copiarValor}-{product.Description}";
        }
    }
}
