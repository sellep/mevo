using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mevo
{

    public static class MevoGeometry
    {

        public static void AddElement(MevoUniverse uni, MevoElement elem)
        {
            do
            {
                elem.Position = GetNewSpawn(uni);
            } while (SpawnValid(elem.Position, uni));

            uni.Elements.Add(elem);
        }

        private static bool SpawnValid(MevoPoint p, MevoUniverse uni)
        {
            return true;
        }

        private static MevoPoint GetNewSpawn(MevoUniverse uni)
        {
            double radius = MevoUtils.Rand.NextDouble() * uni.SpawnRadius;

            double radian = MevoUtils.Deg2Rad(MevoUtils.Rand.Next(360));

            MevoPoint pnt = new MevoPoint();
            pnt.X = uni.CenterOfMass.X + (int)(radius * Math.Cos(radian));
            pnt.Y = uni.CenterOfMass.Y + (int)(radius * Math.Sin(radian));
            return pnt;
        }
    }
}
