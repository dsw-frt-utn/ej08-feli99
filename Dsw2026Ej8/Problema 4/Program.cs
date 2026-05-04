namespace Problema_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double promedio1 = Problema4.CalcularPromedio(8, 9, 10);
            Console.WriteLine("Promedio1:"+promedio1);

            double promedio2 = Problema4.CalcularPromedio(8, null, 10);
            Console.WriteLine("Promedio2:"+promedio2);

            double promedio3 = Problema4.CalcularPromedio(0, 0, 0);
            Console.WriteLine("Promedio3:"+promedio3);
        }
    }
}
