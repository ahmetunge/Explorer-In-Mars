using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyagerInMars.Abstract;

namespace VoyagerInMars.Concrete
{
   public class Curious:BaseRobot,IRobot
    {
        public Curious(IPole pole, ICoordinate robotLocationCoordinate,ICoordinate rectangleCornerCoordinate) : base(pole, robotLocationCoordinate, rectangleCornerCoordinate)
        {

        }
    }
}
