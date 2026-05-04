namespace Problema_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.Description = "Producto Original";

            string resultado = Problema3.CompararCopias(5, p);
            Console.WriteLine(resultado);

        }
    }
}
