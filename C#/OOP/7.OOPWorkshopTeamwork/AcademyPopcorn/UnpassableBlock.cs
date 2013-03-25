using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class UnpassableBlock : IndestructibleBlock
    {
        public UnpassableBlock(MatrixCoords topLeft, char symbol)
            : base(topLeft, symbol)
        {
        }
    }
}
