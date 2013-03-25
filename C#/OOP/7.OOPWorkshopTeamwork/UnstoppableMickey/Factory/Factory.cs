namespace UnstoppableMickey
{
    using System;

    // Design pattern: Factory method
    public class Factory
    {
        public enum ObjectType
        {
            Wall,
            Block,
            Cat,
            Mickey,
            CatsNumber,
            Points
        }

        // This method will create object by given args
        public static object CreateObject(ObjectType objType, params object[] items)
        {
            switch (objType)
            {
                case ObjectType.Wall:
                    return new Wall((Position)items[0]);
                case ObjectType.Block:
                    return new Block((Position)items[0]);
                case ObjectType.Cat:
                    return new Cat((Position)items[0], (Position)items[1]);
                case ObjectType.Mickey:
                    return new Mickey((Position)items[0]);
                case ObjectType.CatsNumber:
                    return new CatsNumber((Position)items[0], items[1].ToString(), (ConsoleColor)items[2]);
                case ObjectType.Points:
                    return new CatsNumber((Position)items[0], items[1].ToString(), (ConsoleColor)items[2]);
                default:
                    throw new ArgumentException("The object type " + objType + " is not recognized.");
            }
        }
    }
}
