using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MiniGis.Core
{
    public class Polygon : PolyLine
    {
        public Brush OwnBrush
        {
            get;
            set;
        } = new SolidBrush(Color.White);
        public Polygon()
        {
            _objectType = MapObjectType.Polygon;
        }

        internal override void Paint(PaintEventArgs e)
        {
            List<System.Drawing.Point> points = new List<System.Drawing.Point>();

            foreach (Node node in _nodes)
            {
                System.Drawing.Point point = Layer.Map.MapToScreen(node);
                points.Add(point);
            }
            System.Drawing.Point[] pointsArray = points.ToArray();
            Pen pen;
            pen = (Pen)OwnPen.Clone();
            if (Selected)
            {
                pen.Color = Color.Yellow;
                pen.Width++;
            }
            e.Graphics.FillPolygon(OwnBrush, pointsArray);
            e.Graphics.DrawPolygon(pen, pointsArray);
        }
        internal override bool IsIntersects(Node searchpoint, double quad)
        {
            //1. Проверка на пересечение с границей
            Node p1 = new Node(searchpoint.X - quad, searchpoint.Y + quad);
            Node p2 = new Node(searchpoint.X + quad, searchpoint.Y + quad);
            Node p3 = new Node(searchpoint.X + quad, searchpoint.Y - quad);
            Node p4 = new Node(searchpoint.X - quad, searchpoint.Y - quad);

            Node begin;
            Node end;

            for (int i = 0; i < NodeCount - 1; i++)
            {
                begin = _nodes[i];
                end = _nodes[i + 1];
                if (Analysis.IsSegmentsIntersects(begin, end, p1, p2))
                    return true;
                if (Analysis.IsSegmentsIntersects(begin, end, p2, p3))
                    return true;
                if (Analysis.IsSegmentsIntersects(begin, end, p3, p4))
                    return true;
                if (Analysis.IsSegmentsIntersects(begin, end, p4, p1))
                    return true;
            }
            begin = _nodes[NodeCount - 1];
            end = _nodes[0];
            if (Analysis.IsSegmentsIntersects(begin, end, p1, p2))
                return true;
            if (Analysis.IsSegmentsIntersects(begin, end, p2, p3))
                return true;
            if (Analysis.IsSegmentsIntersects(begin, end, p3, p4))
                return true;
            if (Analysis.IsSegmentsIntersects(begin, end, p4, p1))
                return true;
            //2. Принадлежность точки полигону
             return Analysis.PointInsidePolygon(_nodes, searchpoint);
            //return false;
        }
    }
}
