namespace Problema_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sale venta1 = new RetailSale { Importe = 1000 };
            Sale venta2 = new WholesaleSale { Importe = 1000 };

            Console.WriteLine(Problema5.ObtenerImporteFinal(venta1));
            Console.WriteLine(Problema5.ObtenerImporteFinal(venta2));
        }
    }
}
