using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrixx firtsMatrix = new Matrixx(3, 3);
            Matrixx.MatrixRandom(firtsMatrix);
            Console.WriteLine("The first matrix is\n");
            Matrixx.Print(firtsMatrix);

            Matrixx secondMatrix = new Matrixx(3, 3);
            Matrixx.MatrixRandom(secondMatrix);
            Console.WriteLine("The second matrix is\n");
            Matrixx.Print(secondMatrix);

            Matrixx.Print(firtsMatrix + secondMatrix);
            Matrixx.Print(firtsMatrix - secondMatrix);
            Matrixx.Print(firtsMatrix * secondMatrix);
            Matrixx.Print(firtsMatrix * 5);

            Console.ReadLine();
        }
    }
}
