using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetriDishWin
{
    public class TheGrid
    {
        public Microbe[,] grid { get; set; }
        private static Random rand = new Random();
        private int gridSize = 100;
        public TheGrid(int size, int microbeCount)
        {
            if(size >= 3 && size < 1000)
            {
                gridSize = size;
            }
            grid = new Microbe[gridSize, gridSize];
            if (microbeCount <= size * size)
            {
                PopulateGrid(microbeCount);
            }
            else
            {
                PopulateGrid(1);
            }
        }

        private void PopulateGrid(int microbeCount)
        {
            for (int i = 0; i < microbeCount; )
            {
                int randRow = rand.Next(0, gridSize);
                int randCol = rand.Next(0, gridSize);

                if (grid[randRow, randCol] == null)
                {
                    grid[randRow, randCol] = CreateNewMicrobe();
                    i++;
                }   
            }
        }

        private Microbe CreateNewMicrobe()
        {
            Microbe newMicrobe = new Microbe(rand.Next(1, int.MaxValue));
            return newMicrobe;
        }
    }
}