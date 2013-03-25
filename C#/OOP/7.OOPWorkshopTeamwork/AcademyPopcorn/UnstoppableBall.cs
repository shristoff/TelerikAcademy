/*8.Implement an UnstoppableBall and an UnpassableBlock. The UnstopableBall only bounces off UnpassableBlocks and 
 will destroy any other block it passes through. The UnpassableBlock should be indestructible. 
 Hint: Take a look at the RespondToCollision method, the GetCollisionGroupString method and the CollisionData class.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class UnstoppableBall : Ball
    {
        public new const string CollisionGroupString = "unstoppableBall";

        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {
            base.body[0, 0] = '0';
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket" || otherCollisionGroupString == "unpassableBlock" ||
                otherCollisionGroupString == "indestructibleBlock" || otherCollisionGroupString == "block";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            foreach (string item in collisionData.hitObjectsCollisionGroupStrings)
            {
                if (item.Equals("indestructibleBlock") || (item.Equals("unpassableBlock") || item.Equals("racket")))
                {
                    base.RespondToCollision(collisionData);
                }
            }
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }
    }
}
