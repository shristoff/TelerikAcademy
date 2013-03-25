/*12.Implement a GiftBlock class. It should be a block, which "drops" a Gift object when it is destroyed. 
  You must NOT edit any existing .cs file. Test the Gift and GiftBlock classes by adding them through the AcademyPopcornMain.cs file.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class GiftBlock : Block
    {
         public GiftBlock(MatrixCoords topLeft, char symbol)
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
                List<Gift> gifts = new List<Gift>();

                gifts.Add(new Gift(this.topLeft, new char[,]{{ '+' }} ));
      
                return gifts;
            }
            else
                return base.ProduceObjects();
        }
    }
}
