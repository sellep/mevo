using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Mevo.App
{

    public class MevoUiTriangle : MevoUiElement
    {

        private Polygon _Poly;
        public override UIElement Element => _Poly;

        public MevoUiTriangle(MevoElement triangle)
        {
            _Poly = new Polygon();
            _Poly.StrokeThickness = 2;
            _Poly.Stroke = Brushes.Black;

            double topLength = (SideLength / 2) / Math.Cos(MevoUtils.Deg2Rad(30));
            double bottomLength = Math.Sqrt(topLength * topLength - (SideLength / 2) * (SideLength / 2));

            _Poly.Points.Add(new Point(triangle.Position.X, triangle.Position.Y - topLength));
            _Poly.Points.Add(new Point(triangle.Position.X - SideLength / 2, triangle.Position.Y + bottomLength));
            _Poly.Points.Add(new Point(triangle.Position.X + SideLength / 2, triangle.Position.Y + bottomLength));
        }
    }
}
