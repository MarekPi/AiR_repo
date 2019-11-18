using System;
namespace Lab5
{
    public class Matrix
    {
        int[] _matrix;
        int _cols;
        int _rows;

        public Matrix(int cols, int rows, int[] matrix)
        {
            _cols = cols;
            _rows = rows;
            if (matrix.Length == _cols * _rows)
            {
                Console.WriteLine("JEST OK");
                _matrix = matrix;
            }
            else
            {
                Console.WriteLine(matrix.Length);
            }
        }

        public void PrintMatrix()
        {
            //foreach(int el in this._matrix)
            //{
            //    Console.Write("{0} ", el);
            //}
            //Console.WriteLine("\n");
            for (int i = 0; i<this._rows; i++)
            {
                for (int j = 0; j<this._cols; j++)
                {
                    Console.Write("{0} ", this._matrix[i + j]);
                }
                Console.Write("\n");
            }
        }
    }
}
