/*10.Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed. 
 You must NOT edit any existing .cs file. Hint: what does an explosion "produce"? */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplosionFragment : MovingObject
    {
        public ExplosionFragment(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, new char[,] { { ',' } }, speed )
        { 
        }

        public override void Update()
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }
    }
}
