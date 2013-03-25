namespace UnstoppableMickey
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    
    public class Engine
    {
        // Fields
        private IVisualizer visualizer;
        private IGameController gameController;
        private List<GameObject> allObjects;
        private List<MovingObject> movingObjects;
        private List<GameObject> staticObjects;
        private List<TextObject> textObjects;
        private Mickey mickey;
        private CatsNumber catsNumber;
        private Points points;
        private GameSpeed gameSpeed;
        private int sleepTime = 500;
        private bool isGameOver = false;
        private bool initialVisualization = true;

        // Constructors
        public Engine(IVisualizer visualizer, IGameController gameController, GameSpeed gameSpeed = GameSpeed.Slowest)
        {
            this.visualizer = visualizer;
            this.gameController = gameController;
            this.allObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();
            this.staticObjects = new List<GameObject>();
            this.textObjects = new List<TextObject>();
            this.gameSpeed = gameSpeed;
        }

        // Methods
        // Filter the type of object and call a specific method for adding object
        public virtual void AddObject(object obj)
        {
            if (obj is MovingObject)
            {
                this.AddMovingObject(obj as MovingObject);
            }
            else if (obj is TextObject)
            {
                this.AddTextObject(obj as TextObject);
            }
            else
            {
                if (obj is Mickey)
                {
                    this.AddMickey(obj);
                }
                else
                {
                    this.AddStaticObject(obj);
                }
            }
        }

        private void AddMickey(object obj)
        {
            this.mickey = obj as Mickey;
            this.AddStaticObject(obj);
        }

        private void AddStaticObject(object obj)
        {
            this.staticObjects.Add(obj as GameObject);
            this.allObjects.Add(obj as GameObject);
        }

        private void AddMovingObject(MovingObject obj)
        {
            this.movingObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        private void AddTextObject(TextObject obj)
        {
            this.textObjects.Add(obj);

            if (obj is Points)
            {
                this.AddPoints(obj);
            }
            else if (obj is CatsNumber)
            {
                this.AddCatsNumber(obj);
            }
        }

        private void AddCatsNumber(TextObject obj)
        {
            this.catsNumber = obj as CatsNumber;
        }

        private void AddPoints(TextObject obj)
        {
            this.points = obj as Points;
        }

        public virtual void MoveMickeyLeft()
        {
            List<string> unallowedMoves = CollisionHandler.UnallowedMoves(this.mickey, this.staticObjects);
            if (!unallowedMoves.Contains("Left"))
            {
                this.mickey.MoveLeft();
            }
        }

        public virtual void MoveMickeyRight()
        {
            List<string> unallowedMoves = CollisionHandler.UnallowedMoves(this.mickey, this.staticObjects);
            if (!unallowedMoves.Contains("Right"))
            {
                this.mickey.MoveRight();
            }
        }

        public virtual void MoveMickeyUp()
        {
            List<string> unallowedMoves = CollisionHandler.UnallowedMoves(this.mickey, this.staticObjects);
            if (!unallowedMoves.Contains("Up"))
            {
                this.mickey.MoveUp();
            }
        }

        public virtual void MoveMickeyDown()
        {
            List<string> unallowedMoves = CollisionHandler.UnallowedMoves(this.mickey, this.staticObjects);
            if (!unallowedMoves.Contains("Down"))
            {
                this.mickey.MoveDown();
            }
        }

        // For adding set of cats after certain period of time
        public void AddNewCats()
        {
            this.AddObject(Factory.CreateObject(Factory.ObjectType.Cat, new Position(2, 2), Position.RandomDirection()));
            this.AddObject(Factory.CreateObject(Factory.ObjectType.Cat, new Position(2, 39), Position.RandomDirection()));
            this.AddObject(Factory.CreateObject(Factory.ObjectType.Cat, new Position(29, 2), Position.RandomDirection()));
            this.AddObject(Factory.CreateObject(Factory.ObjectType.Cat, new Position(29, 39), Position.RandomDirection()));
        }

        public virtual void Run()
        {
            // Initial number of cats
            this.catsNumber.Value = 4;

            while (!this.isGameOver)
            {
                Thread.Sleep(this.sleepTime / (int)this.gameSpeed);

                // Add points after each loop
                this.points.Value += 1;

                // Check for adding set of new cats
                if (this.points.Value % 100 == 0)
                {
                    // Add set of cats
                    this.AddNewCats();

                    // Change the number of cats in the game field
                    this.catsNumber.Value += 4;
                }

                this.gameController.Command();

                // Handle moving objects collisions
                CollisionHandler.MovingObjectCollisions(this.movingObjects, this.staticObjects);

                // Hanfe end of game
                this.isGameOver = CollisionHandler.IsGameOver(this.mickey, this.movingObjects);

                // Clear
                this.visualizer.Clear(this.allObjects);

                // Visualize any object type
                if (this.initialVisualization)
                {
                    foreach (var obj in this.allObjects)
                    {
                        obj.UpdatePosition();
                        this.visualizer.Visualize(obj);
                    }

                    // After first visualization, engine will change visualization only of moving, text and controlled objects
                    this.initialVisualization = false;
                }
                else
                {
                    // Visualize only moving objects
                    foreach (var obj in this.movingObjects)
                    {
                        obj.UpdatePosition();
                        this.visualizer.Visualize(obj);
                    }

                    // Visualize only text objects
                    foreach (var obj in this.textObjects)
                    {
                        this.visualizer.VisualizeText(obj);
                    }

                    // Visualize only controlled object
                    this.visualizer.Visualize(this.mickey);
                }
            }

            // Visualize end of game
            this.visualizer.EndOfGame();
        }
    }
}
