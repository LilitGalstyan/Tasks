using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrixx
    {
        static Random rnd = new Random();
        public int[,] matrix;
        private int firstSize;
        private int secondSize;

        public Matrixx(int firstSize, int secondSize)
        {
            this.firstSize = firstSize;
            this.secondSize = secondSize;
            matrix = new int[firstSize, secondSize];
        }

        public static void MatrixRandom(Matrixx a)
        {
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    a.matrix[i, j] = rnd.Next(1, 10);
                }
            }
        }

        public static void Print(Matrixx a)
        {
            for (int i = 0; i < a.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < a.matrix.GetLength(1); j++)
                {
                    Console.Write($"{a.matrix[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }

        public static Matrixx operator +(Matrixx a, Matrixx b)
        {
            Matrixx result = new Matrixx(a.firstSize, b.secondSize);

            if (a.firstSize != b.firstSize || a.secondSize != b.secondSize)
            {
                Console.WriteLine("Wrong matrix size!\n");
            }
            else
            {
                Console.WriteLine("The sum of two matrix is \n");
                for (int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix.GetLength(1); j++)
                    {
                        result.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
                    }
                }
            }
            return result;
        }

        public static Matrixx operator -(Matrixx a, Matrixx b)
        {
            Matrixx result = new Matrixx(a.firstSize, b.secondSize);

            if (a.firstSize != b.firstSize || a.secondSize != b.secondSize)
            {
                Console.WriteLine("Wrong matrix size!\n");
            }
            else
            {
                Console.WriteLine("The substraction of two matrix is \n");
                for (int i = 0; i < a.matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < a.matrix.GetLength(1); j++)
                    {
                        result.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                    }
                }
            }
            return result;
        }

        public static Matrixx operator *(Matrixx a, Matrixx b)
        {
            Matrixx result = new Matrixx(a.firstSize, b.secondSize);

            if (a.secondSize != b.firstSize)
            {
                Console.WriteLine("Wrong matrix size!\n");
            }
            else
            {
                Console.WriteLine("The multiplication of two matrix is\n");
                for (int i = 0; i < a.firstSize; i++)
                {
                    for (int j = 0; j < b.secondSize; j++)
                    {
                        for (int k = 0; k < a.secondSize; k++)
                        {
                            result.matrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                        }
                    }
                }
            }
            return result;
        }

        public static Matrixx operator *(Matrixx a, int b)
        {
            Matrixx result = new Matrixx(a.firstSize, a.secondSize);
            Console.WriteLine("The scalar multiplication is\n");
            for (int i = 0; i < a.firstSize; i++)
            {
                for (int j = 0; j < a.secondSize; j++)
                {
                    result.matrix[i, j] = a.matrix[i, j] * b;
                }
            }
            return result;
        }
    }
}
