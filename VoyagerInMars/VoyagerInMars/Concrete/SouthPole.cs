using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyagerInMars.Abstract;

namespace VoyagerInMars.Concrete
{
    public class SouthPole : IPole
    {
        public char GetLetter()
        {
            return 'S';
        }

        public int GoXCoordinate(int xCoordinate)
        {
            return xCoordinate;
        }

        public int GoYCoordinate(int yCoordinate)
        {
            return yCoordinate - 1;
        }

        public IPole TurnLeft()
        {
            EastPole eastPole = new EastPole();

            return eastPole;
        }

        public IPole TurnRight()
        {
            WestPole westPole = new WestPole();
            return westPole;
        }
    }
}
