using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mevo
{

    public class MevoUniverse
    {
        public ulong Tick;
        public MevoUniverseConfig Config;
        public List<MevoElement> Elements = new List<MevoElement>();

        public int Width;
        public int Height;
        public int SpawnRadius;

        public MevoPoint CenterOfMass;

        public void Initialize(MevoUniverseConfig conf)
        {
            Config = conf;
            Width = conf.InitWidth;
            Height = conf.InitHeight;
            SpawnRadius = conf.SpawnRadiusInit;
            CenterOfMass = new MevoPoint { X = Width / 2, Y = Height / 2 };

            SpawnElement(MevoElementType.CIRCLE);
            SpawnElement(MevoElementType.TRIANGLE);
            SpawnElement(MevoElementType.SQUARE);
        }

        private void SpawnElement(MevoElementType type)
        {
            MevoElement elem = new MevoElement();
            elem.Type = type;
            elem.Position = GetSpawnPoint();
            Elements.Add(elem);
        }

        private MevoPoint GetSpawnPoint()
        {
            double radius = MevoUtils.Rand.NextDouble() * SpawnRadius;

            double radian = MevoUtils.Deg2Rad(MevoUtils.Rand.Next(360));

            MevoPoint pnt = new MevoPoint();
            pnt.X = CenterOfMass.X + (int) (radius * Math.Cos(radian));
            pnt.Y = CenterOfMass.Y + (int) (radius * Math.Sin(radian));
            return pnt;
        }

        private void ComputeCenterOfMass()
        {
            
        }
    }
}
