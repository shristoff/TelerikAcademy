using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class IndestructibleBlock : Block
    {
        public new const string CollisionGroupString = "indestructibleBlock";
        public const char SymbolWall = '|';
        public const char SymbolTop = '_';

        public IndestructibleBlock(MatrixCoords upperLeft, char symbol)
            : base(upperLeft)
        {
            this.body[0, 0] = symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            //no any respond to collision as it is an indestructible Block
        }

        public override string GetCollisionGroupString()
        {
            return IndestructibleBlock.CollisionGroupString;
        }
    }
}
