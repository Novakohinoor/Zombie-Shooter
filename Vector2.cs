using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombie_gampeplay_work
{
      public class Vector
    {
        
        public float X 
        { 
          get;
          set;
        }
        public float Y
        { 
          get;
          set;
        }

        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }
        public static Vector operator +(Vector first, Vector second)
        {
            return new Vector(first.X + second.X, first.Y + second.Y);   //to change the position of the player based on the direction and the keyisup event
        }
        
         
    }
}
