using System;
using System.Collections.Generic;

namespace Petanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Point petanca = new Point(0, 0);

            List<Point> equipaA = new List<Point>();
            List<Point> equipaB = new List<Point>();

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                equipaA.Add(new Point(rnd.Next(20),rnd.Next(20)));
                equipaB.Add(new Point(rnd.Next(20),rnd.Next(20)));
            }

            pontosPetanca(petanca,equipaA,equipaB);       
        }

        static void pontosPetanca(Point petanca, List<Point> equipaA, List<Point> equipaB)
        {
            Point closestA = new Point();
            foreach(Point p in equipaA)
            {
                if(distanceBetweenPoints(petanca,closestA) > distanceBetweenPoints(petanca,p))
                    closestA = p;
            }

            Point closestB = new Point();
            foreach(Point p in equipaB)
            {
                if(distanceBetweenPoints(petanca,closestB) > distanceBetweenPoints(petanca,p))
                    closestB = p;
            }

            if(distanceBetweenPoints(petanca, closestA) < distanceBetweenPoints(petanca, closestB))
            {
                Console.WriteLine("Ganha Equipa A");
            }
            else
            {
                Console.WriteLine("Ganha Equipa B");
            }
        }
        static double distanceBetweenPoints(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }

        class Point
        {
            public Point(){}
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public int x { get; set; }
            public int y { get; set; }
        }
    }
}
