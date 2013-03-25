namespace UnstoppableMickey
{
    using System;
    using System.Collections.Generic;

    public class UnstoppableMickey
    {
        public static void Main()
        {
            IVisualizer visualizer = new ConsoleVisualizer();
            IGameController keyboard = new KeyboardController();
            Engine engine = new Engine(visualizer, keyboard, GameSpeed.Normal);

            InitializeGamePlayersAndResults(engine);

            InitializeGameMap(engine);

            AttachEvents(engine, keyboard);

            try
            {
                engine.Run();
            }
            catch (ForbiddenKeyException fke)
            {
                Console.Clear();
                Console.WriteLine(fke.Message);
            }
        }

        private static void AttachEvents(Engine engine, IGameController gameController)
        {
            gameController.OnMoveLeft += (sender, eventInfo) =>
            {
                engine.MoveMickeyLeft();
            };

            gameController.OnMoveRight += (sender, eventInfo) =>
            {
                engine.MoveMickeyRight();
            };

            gameController.OnMoveUp += (sender, eventInfo) =>
            {
                engine.MoveMickeyUp();
            };

            gameController.OnMoveDown += (sender, eventInfo) =>
            {
                engine.MoveMickeyDown();
            };

            gameController.ForbiddenKey += (sender, eventInfo) =>
            {
                throw new ForbiddenKeyException();
            };
        }

        private static void InitializeGamePlayersAndResults(Engine engine)
        {
            Console.Title = "UnstoppableMickey © Team Mickey Mouse";

            // Controlled object
            engine.AddObject(Factory.CreateObject(Factory.ObjectType.Mickey, new Position(16, 15)));
            
            // Initial moving objects
            engine.AddObject(Factory.CreateObject(Factory.ObjectType.Cat, new Position(2, 2), Position.RandomDirection()));
            engine.AddObject(Factory.CreateObject(Factory.ObjectType.Cat, new Position(2, 39), Position.RandomDirection()));
            engine.AddObject(Factory.CreateObject(Factory.ObjectType.Cat, new Position(29, 2), Position.RandomDirection()));
            engine.AddObject(Factory.CreateObject(Factory.ObjectType.Cat, new Position(29, 39), Position.RandomDirection()));

            // Result objects
            CatsNumber catsNumber = new CatsNumber(new Position(31, 32), "Cats", ConsoleColor.Yellow);           
            Points points = new Points(new Position(31, 1), "Points", ConsoleColor.Green);
            engine.AddObject(catsNumber);
            engine.AddObject(points);
        }

        private static void InitializeGameMap(Engine engine)
        {
            // Vertical walls
            for (int i = 1; i <= 30; i++)
            {
                Wall leftWall = new Wall(new Position(i, 1));
                Wall rightWall = new Wall(new Position(i, 40));
                engine.AddObject(leftWall);
                engine.AddObject(rightWall);
            }

            // Horizontal walls (ROW 1 and ROW 30)
            for (int i = 2; i <= 40; i++)
            {
                Wall topWall = new Wall(new Position(1, i));
                Wall bottomWall = new Wall(new Position(30, i));
                engine.AddObject(topWall);
                engine.AddObject(bottomWall);
            }
            
            // Internal blocks
            foreach (var block in Map.GetMap())
            {
                engine.AddObject(block);
            }
        }
    }
}
