using System;
using System.Collections.Generic;
using System.Text;

namespace Problema_3
{
    internal class Product
    {
        

        public string Description { get; set; }
    
    public void CambiarDescripcion(string nuevaDescripcion)
        {
            Description = nuevaDescripcion;
        }
    }
}
