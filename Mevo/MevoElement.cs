using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mevo
{

    public class MevoElement
    {
        public MevoElementType Type;
        public MevoPoint Position;
        public List<MevoElementType> Passengers = new List<MevoElementType>();
    }
}
