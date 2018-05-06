using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFTplot
{
    class FFT
    {
        static public int OperationCount = 0;

        //Вычисление N-точечного комплексного ДПФ 
        static public Complex[] dft(Complex[] x, int N)
        {
            //Создание матрицы поворотов
            Complex[,] W = new Complex[N, N];
            for (var i = 0; i < N; ++i) for (var j = 0; j < N; ++j) W[i, j] = new Complex(1, -2*Math.PI*i*j/N);
            
            Complex[] result = new Complex[N];
            var unit = new Complex(1, 0);
            for (var i = 0; i < N; ++i)
            {
                result[i] = new Complex();
                for (var j = 0; j < N; ++j)
                {
                    result[i] += x[j] * unit.Rotation(2 * Math.PI * i * j / N);
                    OperationCount += 2;
                }
            }

            return result;
        }

        //Вычисление N-точечного вещественного ДПФ 
        static public Complex[] dft(double[] x, int N)
        {
            Complex[] complexX = new Complex[N];
            for (var i = 0; i < N; ++i) complexX[i] = new Complex(x[i]); 
            return dft(complexX, N);
        }

        //Вычисление 54-точечного вещественного БПФ
        static public Complex[] fft54(double[] x)
        {
            Complex[] complexX = new Complex[54];
            for (var i = 0; i < 54; ++i) complexX[i] = new Complex(x[i]);
            return fft54(complexX);
        }

        //Вычисление двухточечного ДПФ
        static public Complex[] dft2(Complex[] x)
        {
            //Вычисляем 2-точечное ДПФ
            Complex[] result = new Complex[2];
            result[0] = x[0] + x[1];
            result[1] = x[0] + x[1] * new Complex(1, Math.PI);
            OperationCount += (2 + 1);

            return result;
        }

        //Вычисление трехточечного ДПФ
        static public Complex[] dft3(Complex[] x)
        {
            //Вычисляем 3-точечное ДПФ
            Complex[] result = new Complex[3];
            result[0] = x[0] + x[1] + x[2];
            result[1] = x[0] + x[1] * new Complex(1, 2 * Math.PI / 3) + x[2] * new Complex(1, 4 * Math.PI / 3);
            result[2] = x[0] + x[1] * new Complex(1, 4 * Math.PI / 3) + x[2] * new Complex(1, 8 * Math.PI / 3);
            OperationCount += (6 + 4);

            return result;
        }

        //Вычисление 6-точечного БПФ 
        static public Complex[] fft6(Complex[] vector)  
        {
            //Создание двумерного массива исходных значений
            Complex[,] x = new Complex[3, 2];
            for (var i = 0; i < 3; ++i) for (var j = 0; j < 2; ++j) x[i, j] = vector[2 * i + j];

            //Итоговый массив
            Complex[,] result = new Complex[3, 2];

            //3-точечные ДПФ cтолбцов
            for (var s = 0; s < 2; ++s)
            {
                Complex[] tempIn = new Complex[3];
                for (var r = 0; r < 3; ++r)
                {
                    tempIn[r] = x[r, s];
                }

                Complex[] tempOut = new Complex[3];
                tempOut = FFT.dft3(tempIn);

                for (var r = 0; r < 3; ++r)
                {
                    result[r, s] = tempOut[r];
                }
            }

            for (var i = 0; i < 3; ++i) for (var j = 0; j < 2; ++j) result[i, j] = result[i, j] * new Complex(1, Math.PI * i * j / 3);
            OperationCount += 3 * 2;

            //2-точечные ДПФ cтрок
            for (var r = 0; r < 3; ++r)
            {
                Complex[] tempIn = new Complex[2];
                for (var s = 0; s < 2; ++s)
                {
                    tempIn[s] = result[r, s];
                }

                Complex[] tempOut = new Complex[2];
                tempOut = FFT.dft2(tempIn);

                for (var s = 0; s < 2; ++s)
                {
                    result[r, s] = tempOut[s];
                }
            }

            Complex[] resultVector = new Complex[6];
            for (var j = 0; j < 2; ++j) for (var i = 0; i < 3; ++i) resultVector[3 * j + i] = result[i, j];


            return resultVector;
        }

        //Вычисление 9-точечного БПФ 
        static public Complex[] fft9(Complex[] vector)
        {
            //Создание двумерного массива исходных значений
            Complex[,] x = new Complex[3, 3];
            for (var i = 0; i < 3; ++i) for (var j = 0; j < 3; ++j) x[i, j] = vector[3 * i + j];

            //Итоговый массив
            Complex[,] result = new Complex[3, 3];

            //3-точечные ДПФ cтолбцов
            for (var s = 0; s < 3; ++s)
            {
                Complex[] tempIn = new Complex[3];
                for (var r = 0; r < 3; ++r)
                {
                    tempIn[r] = x[r, s];
                }

                Complex[] tempOut = new Complex[3];
                tempOut = FFT.dft3(tempIn);

                for (var r = 0; r < 3; ++r)
                {
                    result[r, s] = tempOut[r];
                }
            }

            for (var i = 0; i < 3; ++i) for (var j = 0; j < 3; ++j) result[i, j] = result[i, j] * new Complex(1, 2 * Math.PI * i * j / 9);
            OperationCount += 3 * 3;

            //3-точечные ДПФ cтрок
            for (var r = 0; r < 3; ++r)
            {
                Complex[] tempIn = new Complex[3];
                for (var s = 0; s < 3; ++s)
                {
                    tempIn[s] = result[r, s];
                }

                Complex[] tempOut = new Complex[3];
                tempOut = FFT.dft3(tempIn);

                for (var s = 0; s < 3; ++s)
                {
                    result[r, s] = tempOut[s];
                }
            }

            Complex[] resultVector = new Complex[9];
            for (var j = 0; j < 3; ++j) for (var i = 0; i < 3; ++i) resultVector[3 * j + i] = result[i, j];


            return resultVector;
        }

        //Вычисление 54-точечного БПФ 
        static public Complex[] fft54(Complex[] vector)
        {
            //Создание двумерного массива исходных значений
            Complex[,] x = new Complex[9, 6];
            for (var i = 0; i < 9; ++i) for (var j = 0; j < 6; ++j) x[i, j] = vector[6 * i + j];

            //Итоговый вектор
            Complex[,] result = new Complex[9,6];

            //9-точечные БПФ cтолбцов
            for (var s = 0; s < 6; ++s)
            {
                Complex[] tempIn = new Complex[9];
                for (var r = 0; r < 9; ++r)
                {
                    tempIn[r] = x[r, s];
                }

                Complex[] tempOut = new Complex[9];
                tempOut = FFT.fft9(tempIn);

                for (var r = 0; r < 9; ++r)
                {
                    result[r, s] = tempOut[r];
                }
            }

            for (var i = 0; i < 9; ++i) for (var j = 0; j < 6; ++j) result[i, j] = result[i, j] * new Complex(1, 2 * Math.PI * i * j / 54);
            OperationCount += 9 * 6;

            //6-точечные БПФ cтрок
            for (var r = 0; r < 9; ++r)
            {
                Complex[] tempIn = new Complex[6];
                for (var s = 0; s < 6; ++s)
                {
                    tempIn[s] = result[r, s];
                }

                Complex[] tempOut = new Complex[6];
                tempOut = FFT.fft6(tempIn);

                for (var s = 0; s < 6; ++s)
                {
                    result[r, s] = tempOut[s];
                }
            }

            Complex[] resultVector = new Complex[54];
            for (var j = 0; j < 6; ++j) for (var i = 0; i < 9; ++i) resultVector[9 * j + i] = result[i, j];
            
            
            return resultVector;
        }

    }
}
