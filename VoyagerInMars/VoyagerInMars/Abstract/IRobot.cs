using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoyagerInMars.Concrete;

namespace VoyagerInMars.Abstract
{
   public interface IRobot
    {
        void Move(string command);

      string GetLastLocation();
    }
}
