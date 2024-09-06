using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IseseisevToo_VsevolodTsarevTARpv23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ülesanne 1: Summa ja korrutis ruutmassiivis
            int[,] matrix = new int[10, 10];
            Random random = new Random();

            Console.WriteLine("Maatriks täidetakse juhuslike arvudega (1 kuni 5):");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = random.Next(1, 6); // Juhuslik arv vahemikus 1 kuni 5
                    Console.Write(matrix[i, j] + " "); // Väljasta maatriksi elemendid
                }
                Console.WriteLine();
            }

            var (sum, product) = MatrixOperations.CalculateSumAndProduct(matrix);
            Console.WriteLine("Maatriksi summa: " + sum);
            Console.WriteLine("Maatriksi korrutis: " + product);

            // Ülesanne 2: Kolmnurkade võrdlemine
            Console.WriteLine("Sisesta kolmnurkade arv: ");
            int triangleCount = int.Parse(Console.ReadLine());
            Triangle[] triangles = new Triangle[triangleCount];

            for (int i = 0; i < triangleCount; i++)
            {
                Console.WriteLine($"Sisesta kolmnurga {i + 1} küljed:");
                Console.Write("Külg A: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Külg B: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Külg C: ");
                double c = double.Parse(Console.ReadLine());

                triangles[i] = new Triangle(a, b, c);
            }

            var maxPerimeterTriangle = TriangleOperations.GetTriangleWithMaxPerimeter(triangles);
            var maxAreaTriangle = TriangleOperations.GetTriangleWithMaxPindala(triangles);

            Console.WriteLine("Kolmnurk maksimaalse ümbermõõduga: " + maxPerimeterTriangle.Perimeter());
            Console.WriteLine("Kolmnurk maksimaalse pindalaga: " + maxAreaTriangle.Pindala());

            // Ülesanne 3: Perekonnanimede sorteerimine
            Console.WriteLine("Sisesta perekonnanimede arv: ");
            int nameCount = int.Parse(Console.ReadLine());
            string[] names = new string[nameCount];

            for (int i = 0; i < nameCount; i++)
            {
                Console.Write($"Sisesta perekonnanimi {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            string[] sortedNames = NameSorter.SortNames(names);

            Console.WriteLine("Sorteeritud perekonnanimede loend:");
            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
