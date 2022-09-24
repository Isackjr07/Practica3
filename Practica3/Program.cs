using System;

namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            int lados;
            double perimetro, medida;

            Console.WriteLine("Cuantos lados tiene el poligono: ");
            lados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dame la medida de uno de sus lados: ");
            medida = Convert.ToDouble(Console.ReadLine());

            perimetro = lados * medida;

            Console.WriteLine("El perimetro es :{0} ",perimetro);

        }
    }
}
