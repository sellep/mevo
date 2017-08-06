using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace Mevo.App
{

    public class MevoUiCircle : MevoUiElement
    {

        public override UIElement Element => new Polygon();

        public MevoUiCircle(MevoElement elem)
        {

        }
    }
}
