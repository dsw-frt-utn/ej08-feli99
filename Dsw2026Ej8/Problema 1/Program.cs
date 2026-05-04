namespace Problema_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string etiqueta = ProductHelper.ObtenerEtiquetaProducto(1001, "Mouse", 15000);
            Console.WriteLine(etiqueta);
        }
    }
}
