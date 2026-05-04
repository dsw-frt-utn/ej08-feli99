using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Problema_1
{
    public static partial class ProductHelper
    {
       public static string ObtenerEtiquetaProducto(long code,string description,decimal price)
        {
            return $"[{code}] {description} - {price}";
        }
    }
    



}
