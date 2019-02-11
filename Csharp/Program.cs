using System;

namespace Park
{
    public class Matrix
    {
        private int[,] matrix;

        protected int GetValue(int i,int j)
        {
            return matrix[i, j];
        }

        protected void PutValue(int i, int j, int result)
        {
            matrix[i, j] = result;
        }

        public Matrix() : this(1, 0, 0, 1)
        {

        }

        public Matrix(int a, int b, int c, int d)
        {
            matrix = new int[2, 2]{ { a, b }, { c, d } };
        }

        static public Matrix Multiply(Matrix a, Matrix b)
        {
            Matrix result = new Matrix();
            result.PutValue(0, 0, a.GetValue(0, 0) * b.GetValue(0, 0) + a.GetValue(0, 1) * b.GetValue(1, 0));
            result.PutValue(0, 1, a.GetValue(0, 0) * b.GetValue(0, 1) + a.GetValue(0, 1) * b.GetValue(1, 1));
            result.PutValue(1, 0, a.GetValue(1, 0) * b.GetValue(0, 0) + a.GetValue(1, 1) * b.GetValue(1, 0));
            result.PutValue(1, 1, a.GetValue(1, 0) * b.GetValue(0, 1) + a.GetValue(1, 1) * b.GetValue(1, 1));
            return result;

        }

        public void ShowMatrix()
        {
            Console.WriteLine("{0} {1}", matrix[0, 0], matrix[0, 1]);
            Console.WriteLine("{0} {1}", matrix[1, 0], matrix[1, 1]);
        }
    }

    class MainApp
    {
        static void Main(String[] args)
        {
            Matrix matrixA = new Matrix(3, 2, 1, 4);
            Matrix matrixB = new Matrix(9, 2, 1, 7);
            Matrix E = new Matrix();

            matrixA.ShowMatrix();
            matrixB.ShowMatrix();
            E.ShowMatrix();

            Console.WriteLine();
            Matrix.Multiply(E, matrixB).ShowMatrix();
            Matrix.Multiply(matrixB, E).ShowMatrix();
            Matrix.Multiply(matrixA, E).ShowMatrix();
            Matrix.Multiply(matrixA, matrixB).ShowMatrix();
        }

    }
}