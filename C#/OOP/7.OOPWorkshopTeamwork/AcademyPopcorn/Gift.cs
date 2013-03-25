/*11.Implement a Gift class. It should be a moving object, which always falls down.
 The gift shouldn't collide with any ball, but should collide (and be destroyed) with the racket.
 You must NOT edit any existing .cs file. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class Gift : MovingObject
    {
        public new const string CollisionGroupString = "gift";

        public Gift(MatrixCoords topLeft, char[,] body)
            : base(topLeft, body, new MatrixCoords(1, 0))
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override string GetCollisionGroupString()
        {
            return "gift";
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
                List<ShootingRacket> racket = new List<ShootingRacket>();

                ShootingRacket shootingRacket = new ShootingRacket(
                    new MatrixCoords(this.TopLeft.Row + 1, this.TopLeft.Col - 3), 6);
                racket.Add(shootingRacket);

                return racket;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
