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

    public class MevoUiSquare : MevoUiElement
    {

        private Polygon _Poly;
        public override UIElement Element => _Poly;

        public MevoUiSquare(MevoElement elem)
        {
            _Poly = new Polygon();
            _Poly.Stroke = Brushes.Black;
            _Poly.StrokeThickness = 2;

            _Poly.Points.Add(new Point(elem.Position.X - SideLength / 2, elem.Position.Y - SideLength / 2));
            _Poly.Points.Add(new Point(elem.Position.X + SideLength / 2, elem.Position.Y - SideLength / 2));
            _Poly.Points.Add(new Point(elem.Position.X + SideLength / 2, elem.Position.Y + SideLength / 2));
            _Poly.Points.Add(new Point(elem.Position.X - SideLength / 2, elem.Position.Y + SideLength / 2));
        }
    }
}
