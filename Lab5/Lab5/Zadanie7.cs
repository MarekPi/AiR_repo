using System;
using System.Linq;

namespace Lab5
{
    public class Matrix
    {
        private int[] _matrix;
        int _cols;
        int _rows;

        public Matrix(int rows, int cols)
        {
            _cols = cols;
            _rows = rows;
            _matrix = new int[_cols * _rows];
        }

        public Matrix(int rows, int cols, int[] matrix)
        {
            _cols = cols;
            _rows = rows;
            _matrix = new int[_cols * _rows];


            if(_cols*_rows >= matrix.Length)
            {
                int i = 0;
                while (i < matrix.Length)
                {
                    _matrix[i] = matrix[i];
                    i++;
                }
                for (int zero_i = i; zero_i < _cols * _rows; zero_i++)
                {
                    _matrix[zero_i] = 0;
                }
            }
            else if (_cols * _rows < matrix.Length)
            {
                int i = 0;
                while (i < _matrix.Length)
                {
                    _matrix[i] = matrix[i];
                    i++;
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i<this._rows; i++)
            {
                for (int j = 0; j<this._cols; j++)
                {
                    Console.Write("{0} ", this._matrix[i*_cols + j]); //i*_cols; liczba pelnych wierszy + aktualny numer kolumny
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public int ColSize()
        {
            return this._cols;
        }

        public int RowSize()
        {
            return this._rows;
        }

        //numerujemy kolumny i wiersze od 0 !
        public void AddElem(int row, int col, int value)
        {
            if(row <= this._rows && col <= this._cols)
            {
                this._matrix[row * _cols + col] = value;
            }
            else
            {
                Console.WriteLine("Podane wymiary: {0}, {1} są spoza tabeli!", row, col);
            }
        }

        public Matrix AddMatrix(Matrix mat_b)
        {
            Matrix result = new Matrix(Math.Max(this._rows, mat_b._rows), Math.Max(this._cols, mat_b._cols));

            for(int i = 0; i < this._rows; i++)
            {
                for (int j = 0; j < this._cols; j++)
                {
                    //Console.WriteLine("{0} {1} {2}",i,j,this._cols);
                    result._matrix[i * result._cols + j] += this._matrix[i * this._cols + j];
                }
            }
            for (int i = 0; i < mat_b._rows; i++)
            {
                for (int j = 0; j < mat_b._cols; j++)
                {
                    //Console.WriteLine("{0} {1} {2}",i,j,this._cols);
                    result._matrix[i * result._cols + j] += mat_b._matrix[i * mat_b._cols + j];
                }
            }
            return result;
        }


    }

    public class Zadanie7
    {
        public Zadanie7()
        {
            int[] tab = { 1, 2, 3, 4, 5 };
            int[] tab2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix m = new Matrix(2, 2, tab);
            Matrix m2 = new Matrix(3, 4, tab2);
            m.AddElem(1, 1, 10);
            m.PrintMatrix();
            m2.PrintMatrix();
            Console.WriteLine("Col size: {0}", m.ColSize());
            Console.WriteLine("Row size: {0}\n", m.RowSize());

            Matrix m3;
            m3 = m.AddMatrix(m2);
            m3.PrintMatrix();
            Matrix m4;
            m4 = m2.AddMatrix(m);
            m4.PrintMatrix();
        }

    }
}
