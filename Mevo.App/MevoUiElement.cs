using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mevo.App
{

    public abstract class MevoUiElement
    {

        public static int SideLength = 10;

        public abstract UIElement Element { get; }

        public static MevoUiElement CreateElement(MevoElement elem)
        {
            if (elem.Type == MevoElementType.CIRCLE)
                return new MevoUiCircle(elem);
            if (elem.Type == MevoElementType.TRIANGLE)
                return new MevoUiTriangle(elem);
            return new MevoUiSquare(elem);
        }
    }
}
