/*Implement a MeteoriteBall. It should inherit the Ball class and should leave a trail of TrailObject objects. 
 Each trail objects should last for 3 "turns". Other than that, the Meteorite ball should behave the same way as the normal ball. 
 You must NOT edit any existing .cs file. Test the MeteoriteBall by replacing the normal ball in the AcademyPopcornMain.cs file.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        public new const string CollisionGroupString = "meteoriteBall";
        private readonly char[,] trailObjectBody = new char[,] { { '.' } };
        private readonly int trailObjectLifetime;

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed, int trailObjectLifetime)
            : base(topLeft, speed)
        {
            this.trailObjectLifetime = trailObjectLifetime;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<TrailObject> comet = new List<TrailObject>();

            TrailObject trailObject = new TrailObject(this.TopLeft, this.trailObjectBody, this.trailObjectLifetime);
            comet.Add(trailObject);

            return comet;
        }
    }
}
