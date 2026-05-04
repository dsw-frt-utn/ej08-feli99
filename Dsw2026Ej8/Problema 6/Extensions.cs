using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Problema_6
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
            {
                return "SIN CODIGO";
            }
            else
            {
                return code.Trim().ToUpper().Replace(" " , "-");

            }
        }
    }
}
