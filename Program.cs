using System;

namespace Matrix_Determinant
{
    class Program
    {
        static void Main(string[] args)
        {
        int[,] array = new int[3,3] { {1,3,4 }, {2,4,6 }, {3,5,9 } };
            int sumaIz1 = array[0,0] + array[1,1]+ array[2,2];
            int sumaIz2 = array[0,1] + array[1,2]+ array[2,0];
            int sumaIz3 = array[0,2] + array[1,0]+ array[2,1];
            int sumaDer1 = array[0,2] + array[1,1]+ array[2,0];
            int sumaDer2 = array[0,0] + array[1,2]+ array[2,1];
            int sumaDer3 = array[0,1] + array[1,0]+ array[2,2];
            int sumaTotalizquierda = sumaIz1 + sumaIz2 + sumaIz3;
            int sumaTotalDerecha = sumaDer1 + sumaDer2 + sumaDer3;
            int determinante = sumaTotalizquierda - sumaTotalDerecha;
            Console.WriteLine("el determinante de la matriz es: " + determinante);
        }
    }
}
