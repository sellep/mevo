using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mevo
{

    public class MevoUtils
    {
        public static Random Rand = new Random();
        public static double Deg2Rad(double deg) => deg * 2 * Math.PI / 360;
    }
}
