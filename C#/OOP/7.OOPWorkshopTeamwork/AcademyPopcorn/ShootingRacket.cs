﻿//4.Inherit the Engine class. Create a method ShootPlayerRacket. Leave it empty for now.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class ShootingRacket : Racket
    {
        private bool isShooting = false;

        public ShootingRacket(MatrixCoords topLeft, int width)
            : base(topLeft, width)
        {
        }

        public void Shoot()
        {
            this.isShooting = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.isShooting)
            {
                this.isShooting = false;

                List<Bullet> bullets = new List<Bullet>();

                Bullet bullet = new Bullet(
                    new MatrixCoords(this.TopLeft.Row - 2, this.TopLeft.Col + this.Width / 2));

                bullets.Add(bullet);

                return bullets;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
