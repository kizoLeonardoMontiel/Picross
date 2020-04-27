using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picross
{
    class Grid
    {
        int[][] values;

        public Grid(int sizeX, int sizeY, int[][] values)
        {
            //Get grid values from the provided matrix
            for (int i = 0; i <= sizeX; i++)
            {
                for (int j = 0; j <= sizeY; j++)
                {
                    this.values[i][j] = values[i][j];
                }
            }


            if (sizeX == 10 && sizeY == 10)
            {
                //Medium grid

            }

            else if (sizeX == 15 && sizeY == 15)
            {
                //Hard grid 

            }
            else
            {
                //Invalid Grid

            }
        }
    }
}
