using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoyagerInMars.Abstract
{
   public interface IPole
    {
        int GoXCoordinate(int xCoordinate);

        int GoYCoordinate(int yCoordinate);
        Char GetLetter();
        IPole TurnRight();

        IPole TurnLeft();
    }
}
