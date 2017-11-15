using System;

namespace Matriz
{
    class Mat
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Ingresa cuantas Filas tendra tu matriz");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa cuantas Columnas tendra tu matriz");
            int c = int.Parse(Console.ReadLine());

            int[,] Mat = new int[f, c];

            Llena(Mat);
            Console.WriteLine("el mayor es:" + mayor(Mat));
            Console.WriteLine("el mayor es:" + menor(Mat));
            Console.ReadKey();
        }

        static void Llena(int[,] Mat)
        {
            for (int a = 0; a < Mat.GetLength(0); a++)
            {
                for (int b = 0; b < Mat.GetLength(1); b++)
                {
                    Console.WriteLine("Ingresa dato para la pocision" + (a + 1) + "," + (b + 1));
                    Mat[a, b] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("La suma: " + suma(Mat));
        }

        static int suma(int[,] Mat)
        {
            int r=0;
            for (int a = 0; a < Mat.GetLength(0); a++)
            {
                r+= Mat[a, a];
            }
            return r;
        }

        static int menor(int[,] Mat)
        {
            int r = 0;
            for (int a = 0; a < Mat.GetLength(0); a++)
            {
                r += Mat[a, a];
            }
            return r;
        }

        static int mayor(int[,] Mat)
        {
            int r=Mat[0,0];
            foreach (int item in Mat)
            {
                if (item > r)
                    r = item;
            }

            return r;
        }

    }
}


