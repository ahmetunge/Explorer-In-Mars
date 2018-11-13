using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyagerInMars.Abstract;

namespace VoyagerInMars.Concrete
{
    public class NorthPole : IPole
    {
        public char GetLetter()
        {
            return 'N';
        }

        public int GoXCoordinate(int xCoordinate)
        {
            return xCoordinate;
        }

        public int GoYCoordinate(int yCoordinate)
        {
            return yCoordinate + 1;
        }

        public IPole TurnLeft()
        {
            WestPole westPole = new WestPole();

            return westPole;
        }

        public IPole TurnRight()
        {
            EastPole eastPole = new EastPole();

            return eastPole;
        }
    }
}
