using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetriDishWin
{
    public class GridController
    {
        public TheGrid gameGrid;
        private static Random rand = new Random();

        public GridController()
        {

        }
        public GridController(int gridSize, int microbeCount)
        {
            gameGrid = new TheGrid(gridSize, microbeCount);
        }

        public void GridCycle()
        {
            for (int row = 0; row < gameGrid.grid.GetLength(0); row++)
            {
                for (int col = 0; col < gameGrid.grid.GetLength(1); col++)
                {
                    if (gameGrid.grid[row, col] != null)
                    {
                        ProcessCell(row, col);
                    }
                }
            }
        }

        public virtual void ProcessCell(int row, int col)
        {
            gameGrid.grid[row, col].CheckForMutate();

            if (gameGrid.grid[row, col].CheckForNewSpecies())
            {
                CreateNewSpecies(row, col);
            }
            if (gameGrid.grid[row, col].CheckForSpread())
            {
                SpreadRandomDirection(row, col);
            }
        }

        public void CreateNewSpecies(int row, int col)
        {
            Microbe newSpecies = new Microbe(true, gameGrid.grid[row, col]);
            newSpecies.Mutate(15);
            gameGrid.grid[row, col] = newSpecies;
        }

        public void SpreadRandomDirection(int row, int col)
        {
            var destinationRow = row;
            var destinationCol = col;
            var direction = rand.Next(0,4);
            if (direction == 0) //north
            {
                if (row != 0)
                {
                    destinationRow--;
                }
            }
            if (direction == 1) //east
            {
                if (col != gameGrid.grid.GetLength(1) - 1)
                {
                    destinationCol++;
                }
            }
            if (direction == 2) //south
            {
                if (row != gameGrid.grid.GetLength(0) - 1)
                {
                    destinationRow++;
                }
            }
            if (direction == 3) //west
            {
                if (col != 0)
                {
                    destinationCol--;
                }
            }
            if (gameGrid.grid[destinationRow, destinationCol] == null)
            {
                SpreadToCell(row, col, destinationRow, destinationCol);
            }
            else
            {
                AttemptConsumeCell(row, col, destinationRow, destinationCol);
            }
        }

        public virtual void AttemptConsumeCell(int row, int col, int destinationRow, int destinationCol)
        {
            var consumeStrength = gameGrid.grid[row, col].consumeStrength;
            var isConsumed = gameGrid.grid[destinationRow, destinationCol].CheckForConsume(consumeStrength);
            if (isConsumed)
            {
                SpreadToCell(row, col, destinationRow, destinationCol);
            }
        }

        public virtual void SpreadToCell(int row, int col, int destinationRow, int destinationCol)
        {
            gameGrid.grid[destinationRow, destinationCol] = gameGrid.grid[row, col];
        }

    }
}
