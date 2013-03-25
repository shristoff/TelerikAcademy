/*10.Implement an ExplodingBlock. It should destroy all blocks around it when it is destroyed. 
 You must NOT edit any existing .cs file. Hint: what does an explosion "produce"? */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class ExplodingBlock : Block
    {
        public ExplodingBlock(MatrixCoords topLeft, char symbol)
            : base(topLeft)
        {
            this.body[0,0] = symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
            this.ProduceObjects();
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.IsDestroyed)
            {
                List<ExplosionFragment> fragments = new List<ExplosionFragment>();

                fragments.Add(new ExplosionFragment(topLeft, new MatrixCoords(-1, -1)));
                fragments.Add(new ExplosionFragment(topLeft, new MatrixCoords(1, 1)));
                fragments.Add(new ExplosionFragment(topLeft, new MatrixCoords(-1, 1)));
                fragments.Add(new ExplosionFragment(topLeft, new MatrixCoords(1, -1)));

                return fragments;
            }
            else
                return base.ProduceObjects();
        }
    }
}
