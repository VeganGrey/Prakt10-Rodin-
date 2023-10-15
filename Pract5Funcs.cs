using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract5
{
    internal class Pract5Funcs
    {
        /// <summary>
        /// Заполняет двумерный целочисленный массив случайными значениями
        /// </summary>
        /// <param name="arr">Двумерный целочисленный массив</param>
        /// <param name="min">Минимальное значение</param>
        /// <param name="max">Максимальное значение</param>
        public static void FillArr(ref int[,] arr, int min, int max)
        {
            Random rnd = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++) 
                    arr[i, j] = rnd.Next(min, max);
        }

        /// <summary>
        /// Возвращает номера столбцов, произведение отрицательных элементов которых является положительным числом
        /// </summary>
        /// <param name="arr">Двумерный целочисленный массив</param>
        /// <returns>Коллекция номеров столбцов</returns>
        public static List<int> GetNegativesMult(int[,] arr)
        {
            List<int> cols = new List<int>();
            int count;

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                count = 0;
                for (int j = 0; j < arr.GetLength(0); j++)
                    if (arr[j, i] < 0) count++;
                
                if (count > 0 && count % 2 == 0) cols.Add(i);
            }

            return cols;
        }
    }
}
