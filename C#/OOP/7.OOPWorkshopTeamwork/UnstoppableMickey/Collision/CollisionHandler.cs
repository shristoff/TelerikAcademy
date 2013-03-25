namespace UnstoppableMickey
{
    using System;
    using System.Collections.Generic;

    public static class CollisionHandler
    {
        // Check all moving objects if are in collision with static objects
        public static void MovingObjectCollisions(List<MovingObject> movingObjects, List<GameObject> staticObjects)
        {
            foreach (var movingObject in movingObjects)
            {
                // Label
                CheckCollisionWithOtherNeighbors:

                foreach (var staticObject in staticObjects)
                {
                    if (movingObject.CanCollideWith(staticObject.GetObjectType()))
                    {
                        Position movingObjectNextPosition = movingObject.Position + movingObject.Direction;
                        Position staticObjectCurrentPosition = staticObject.Position;
                        if (InSamePosition(movingObjectNextPosition, staticObjectCurrentPosition))
                        {
                            // Change direction of current moving object
                            movingObject.Direction = Position.RandomDirection();

                            // Check if the new direction is valid
                            goto CheckCollisionWithOtherNeighbors;
                        }
                    }
                }
            }
        }

        // This method returns list of all allowed moves for controlled object.
        public static List<string> UnallowedMoves(GameObject controlledObject, List<GameObject> staticObjects)
        {
            List<string> unallowedMoves = new List<string>();
            int contObjRow = controlledObject.Position.Row;
            int contObjCol = controlledObject.Position.Col;

            foreach (var staticObject in staticObjects)
            {
                if (controlledObject.CanCollideWith(staticObject.GetObjectType()))
                {
                    // Check controlled object can move to the down
                    if (InSamePosition(new Position(contObjRow + 1, contObjCol), staticObject.Position))
                    {
                        unallowedMoves.Add("Down");
                    }

                    // Check controlled object can move to the up
                    if (InSamePosition(new Position(contObjRow - 1, contObjCol), staticObject.Position))
                    {
                        unallowedMoves.Add("Up");
                    }

                    // Check controlled object can move to the right
                    if (InSamePosition(new Position(contObjRow, contObjCol + 1), staticObject.Position))
                    {
                        unallowedMoves.Add("Right");
                    }

                    // Check controlled object can move to the left
                    if (InSamePosition(new Position(contObjRow, contObjCol - 1), staticObject.Position))
                    {
                        unallowedMoves.Add("Left");
                    }
                }
            }

            return unallowedMoves;
        }

        // Check if position of Mickey are equal to positions of Cats
        public static bool IsGameOver(Mickey controlledObject, List<MovingObject> movingObjects)
        {
            foreach (var movingObject in movingObjects)
            {
                if (InSamePosition(controlledObject.Position, movingObject.Position))
                {
                    return true;
                }
            }

            return false;
        }

        // Check if two Positions are equal
        private static bool InSamePosition(Position firstPosition, Position secondPosition)
        {
            if (firstPosition.Equals(secondPosition))
            {
                return true;
            }

            return false;
        }
    }
}
