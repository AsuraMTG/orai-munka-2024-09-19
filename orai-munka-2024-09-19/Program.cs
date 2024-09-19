using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_munka_2024_09_19
{
    
    class Program
    { 
        public struct Point
        {
            public Point(double x, double y)
            {
                X = x; Y = y;
            }
            public double X { get; }
            public double Y { get; }
            public override string ToString() => $"(x:{X}, y:{Y})";
        }
        public static void foci()   
        {
            string[] numbers = new string[1006];
            string[] megfelel = new string[1006];
            for (int i = 0; i < numbers.Length; i++)
            {
                int hatE = 0;
                
                numbers[i] = i.ToString();
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    hatE += numbers[i][j];
                }
                if (hatE == 6)
                {
                    megfelel[i] += hatE;
                }
            }
            for (int i = 0; i < megfelel.Length; i++)
            {
                if (megfelel[i] != "")
                {
                    Console.WriteLine($"{numbers[i]}");
                }
            }
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            var aCoords = new Point(Convert.ToDouble(rnd.Next(0, 101)), Convert.ToDouble(rnd.Next(0, 101)));
            var bCoords = new Point(Convert.ToDouble(rnd.Next(0, 101)), Convert.ToDouble(rnd.Next(0, 101)));

            double aMinusBX = aCoords.X - bCoords.X;
            double aMinusBY = aCoords.Y - bCoords.Y;

            double pitagorasz = Math.Sqrt(aMinusBX) + Math.Sqrt(aMinusBY);

            Console.WriteLine($"{aCoords} | {bCoords} | {aMinusBX} | {aMinusBY} | {Math.Sqrt(pitagorasz)}");


            foci();
            Console.ReadKey();
        }
    }
}
