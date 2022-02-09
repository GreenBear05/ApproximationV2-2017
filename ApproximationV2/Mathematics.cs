using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApproximationV2
{
    /// <summary>
    /// Mathematics - класс отвечаюший за арехметические действия
    /// </summary>
    public class Mathematics
    {
        private static float K, B, Si, Y1, Y2, maxX, minX;

     

        public static string Matdata()
        {
            string kbsi = "";
            kbsi = Convert.ToString("  K = " + K +"  B = "+ B + " δ = "+ Si);
            return kbsi;
        }
     
        /// <summary>
        /// Mathematics - конструктор ктороный выполняет арехм действия
        /// </summary>
        /// <param name="points">масив точек</param>
        public Mathematics(List<DotInfo> points)
        {
            float sumX, sumY,sumYX,sumkvX, sumYY; // переменные локальных вычислений
            sumX = 0;
            sumY = 0;
            sumYX = 0;
            sumkvX = 0;
            sumYY = 0;
            maxX = points[0].X;
            minX = points[0].X;
            foreach (var item in points)
            {
                sumX += item.X;
                sumY += item.Y;
                sumYX += item.X * item.Y;
                sumkvX += (float)Math.Pow(item.X, 2);

                if (maxX < item.X)
                {
                    maxX = item.X;
                }
                if (minX > item.X)
                {
                    minX = item.X;

                }

            }
            K = ((sumX * sumY) - points.Count * (sumYX))/((float)Math.Pow(sumX, 2) - points.Count*(sumkvX));
            B = (1.0f / points.Count) * (sumY - K * sumX);
            Y1 = K * maxX + B;
            Y2 = K * minX + B;
            sumYY = Y1 + Y2 - sumY;
            Si = (float)Math.Sqrt((float)Math.Pow(sumYY, 2) / (points.Capacity - 1));
        }
        public static float Matdata_Y1()
        {
            
            return Y1;
            
        }
        public static float Matdata_Y2()
        {
            
            return  Y2;
        }
        public static float Matdata_maxX()
        {
            return maxX;
            
        }
        public static float Matdata_minX()
        {
            
            return minX;
           
        }
    }
}
