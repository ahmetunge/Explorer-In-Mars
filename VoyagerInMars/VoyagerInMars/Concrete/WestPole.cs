using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyagerInMars.Abstract;

namespace VoyagerInMars.Concrete
{
    public class WestPole : IPole
    {
        public char GetLetter()
        {
            return 'W';
        }

        public int GoXCoordinate(int xCoordinate)
        {
            return xCoordinate - 1;
        }

        public int GoYCoordinate(int yCoordinate)
        {
            return yCoordinate;
        }

        public IPole TurnLeft()
        {
            SouthPole southPole = new SouthPole();

            return southPole;
        }

        public IPole TurnRight()
        {
            NorthPole northPole = new NorthPole();
            return northPole;
        }
    }
}
