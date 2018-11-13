using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyagerInMars.Abstract;

namespace VoyagerInMars.Concrete
{
    public class EastPole : IPole
    {
        public char GetLetter()
        {
            return 'E';
        }

        public int GoXCoordinate(int xCoordinate)
        {
            return xCoordinate + 1;
        }

        public int GoYCoordinate(int yCoordinate)
        {
            return yCoordinate;
        }

        public IPole TurnLeft()
        {
            NorthPole northPole = new NorthPole();

            return northPole;
        }

        public IPole TurnRight()
        {
            SouthPole southPole = new SouthPole();

            return southPole;
        }
    }
}
