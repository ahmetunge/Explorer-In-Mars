using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyagerInMars.Abstract;

namespace VoyagerInMars.Concrete
{
    public class Opportunity : BaseRobot
    {
        public Opportunity(IPole pole, ICoordinate robotLocationCoordinate, ICoordinate rectangleCornerCoordinate) : base(pole, robotLocationCoordinate, rectangleCornerCoordinate)
        {
        }
    }
}
