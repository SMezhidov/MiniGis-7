using System;
using System.Collections.Generic;
namespace MiniGis.Core
{
    public static class Analysis
    {
        /// <summary>
        /// Алгоритм пересечение двух отрезков
        /// взято отсюда https://www.e-olymp.com/ru/blogs/posts/25
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static bool IsSegmentsIntersects(Node a, Node b, Node c, Node d)
        {
            double ABx, ABy, ACx, ACy, ADx, ADy;
            double CAx, CAy, CBx, CBy, CDx, CDy;
            double ACxAB, ADxAB, CAxCD, CBxCD;

            if (!RectanglesIntersects(
                Math.Min(a.X, b.X), Math.Min(a.Y, b.Y), Math.Max(a.X, b.X), Math.Max(a.Y, b.Y),
                Math.Min(c.X, d.X), Math.Min(c.Y, d.Y), Math.Max(c.X, d.X), Math.Max(c.Y, d.Y)))
                return false;

            ACx = c.X - a.X;
            ACy = c.Y - a.Y;
            ABx = b.X - a.X;
            ABy = b.Y - a.Y;
            ADx = d.X - a.X;
            ADy = d.Y - a.Y;

            CAx = a.X - c.X;
            CAy = a.Y - c.Y;
            CBx = b.X - c.X;
            CBy = b.Y - c.Y;
            CDx = d.X - c.X;
            CDy = d.Y - c.Y;

            ACxAB = ACx * ABy - ACy * ABx;
            ADxAB = ADx * ABy - ADy * ABx;

            CAxCD = CAx * CDy - CAy * CDx;
            CBxCD = CBx * CDy - CBy * CDx;

            return ACxAB * ADxAB <= 0 && CAxCD * CBxCD <= 0;
        }

        static bool RectanglesIntersects(
            double aMinX, double aMinY, double aMaxX, double aMaxY,
            double bMinX, double bMinY, double bMaxX, double bMaxY)
        {
            if ((bMinX - aMaxX) * (bMaxX - aMinX) > 0)
                return false;
            if ((bMinY - aMaxY) * (bMaxY - aMinY) > 0)
                return false;

            return true;
        }
        public static bool PointInsidePolygon (List<Node> nodes, Node point)  //CyberForum (метод луча)
        {
            bool result = false;
            for(int i = 0, j = nodes.Count-1; i < nodes.Count; j = i++)
            {
                if ((((nodes[i].Y <= point.Y) && (point.Y < nodes[j].Y)) || ((nodes[j].Y <= point.Y) && (point.Y < nodes[i].Y))) &&
                (point.X > (nodes[j].X - nodes[i].X) * (point.Y - nodes[i].Y) / (nodes[j].Y - nodes[i].Y) + nodes[i].X))
                    result = !result;
            }
            return result;
        }
    }
}
