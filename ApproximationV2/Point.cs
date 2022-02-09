using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproximationV2
{
    /// <summary>
    /// Point структура которая хронит переменные для массива List<>
    /// </summary>
    public struct Point
    {
        public float X, Y;

        public Point(float x, float y) //Конструктор 
        {
            X = x;
            Y = y;
        } 
    }
   
}
