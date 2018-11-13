using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyagerInMars.Abstract;

namespace VoyagerInMars.Concrete
{
   public class BaseRobot:IRobot
    {
        private IPole _pole;
        ICoordinate _robotLocationCoordinate;
        ICoordinate _rectangleCornerCoordinate;
        public BaseRobot(IPole pole, ICoordinate robotLocationCoordinate,ICoordinate rectangleCornerCoordinate)
        {
            _pole = pole;
            _robotLocationCoordinate=robotLocationCoordinate;
            _rectangleCornerCoordinate=rectangleCornerCoordinate;
        }


        private int _robotXCoordinate;
        private int _robotYCoordinate;
        Char _poleLetter;

        public ICoordinate RobotLocationCoordinate { get; }

        public void Move(string command)
        {
            XYCoordinate robotCoordinate =(XYCoordinate) _robotLocationCoordinate;

            _robotXCoordinate = robotCoordinate.XCoordinate;
            _robotYCoordinate = robotCoordinate.YCoordinate;
            foreach (var c in command)
            {
                if (c == 'R')
                {
                    _pole = _pole.TurnRight();
                }
                else if (c == 'L')
                {
                    _pole = _pole.TurnLeft();
                }

                else if (c == 'M')
                {
                    _robotXCoordinate = _pole.GoXCoordinate(_robotXCoordinate);
                    _robotYCoordinate = _pole.GoYCoordinate(_robotYCoordinate);
                }
            }

           _poleLetter = _pole.GetLetter();
            

        }


        public string GetLastLocation()
        {
            XYCoordinate rectangleCornerCordinate = (XYCoordinate)_rectangleCornerCoordinate;

            if (rectangleCornerCordinate.XCoordinate < _robotXCoordinate)
                _robotXCoordinate = rectangleCornerCordinate.XCoordinate;
            if (rectangleCornerCordinate.YCoordinate < _robotYCoordinate)
                _robotYCoordinate = rectangleCornerCordinate.YCoordinate;

            string location = _robotXCoordinate.ToString() + " " + _robotYCoordinate.ToString() + " " + _poleLetter;

            return location;
        }
    }
}
