using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyagerInMars.Abstract;

namespace VoyagerInMars.Concrete
{
   public class XYCoordinate:ICoordinate
    {
        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }
    }
}
