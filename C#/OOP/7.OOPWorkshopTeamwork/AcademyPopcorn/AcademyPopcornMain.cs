using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            //ordinary ball
            Ball theBall = new Ball(new MatrixCoords(WorldRows / 3, 0),
                new MatrixCoords(-1, 1));
            //engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2 - 3), RacketLength);

            engine.AddObject(theRacket);

            /*1.The AcademyPopcorn class contains an IndestructibleBlock class. Use it to create side and ceiling walls to the game. 
             You can ONLY edit the AcademyPopcornMain.cs file.*/
            for (int row = startRow - 1; row < WorldRows; row++)
            {
                IndestructibleBlock leftWallBlock = new IndestructibleBlock(new MatrixCoords(row, startCol - 1), 
                    IndestructibleBlock.SymbolWall);
                engine.AddObject(leftWallBlock);
                IndestructibleBlock rightWallBlock = new IndestructibleBlock(new MatrixCoords(row, endCol), 
                    IndestructibleBlock.SymbolWall);
                engine.AddObject(rightWallBlock);
            }
            //create ceiling (using symbolTop = "_")
            for (int col = startCol - 1; col < WorldCols - 1; col++)
            {
                IndestructibleBlock topWallBlock = new IndestructibleBlock(new MatrixCoords(1, col), 
                    IndestructibleBlock.SymbolTop);
                engine.AddObject(topWallBlock);
            }

            TrailObject comet = new TrailObject(new MatrixCoords(WorldRows / 2, WorldCols / 4), new char[,] { { '*' } }, 8);
            engine.AddObject(comet);

            //7.Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.
            MeteoriteBall metBall = new MeteoriteBall(new MatrixCoords(WorldRows / 3, 0), 
                new MatrixCoords(-1, 1), 3);
            //engine.AddObject(metBall);

            //9.Test the UnpassableBlock and the UnstoppableBall by adding them to the engine in AcademyPopcornMain.cs file
            UnstoppableBall unstopBall = new UnstoppableBall(new MatrixCoords(WorldRows / 3, 0), new MatrixCoords(-1, 1));
            engine.AddObject(unstopBall);

            for (int i = 3; i < WorldCols - 2; i = i + 2)
            {
                UnpassableBlock unpassableBlock = new UnpassableBlock(new MatrixCoords(4, i), 'U');
                engine.AddObject(unpassableBlock);
            }

            for (int i = 2; i < WorldCols; i = i + 2)
            {
              ExplodingBlock bombBlock = new ExplodingBlock(new MatrixCoords(4, i), 'B');
              engine.AddObject(bombBlock);
            }

            for (int i = 2; i < WorldCols; i = i + 2)
            {
                GiftBlock giftBlock = new GiftBlock(new MatrixCoords(5, i), 'G');
                engine.AddObject(giftBlock);
            }
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            ShootingRacketEngine gameEngine = new ShootingRacketEngine(renderer, keyboard, 200);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootWithPlayerRacket();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
