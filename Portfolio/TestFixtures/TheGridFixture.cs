using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Mocks;

namespace PetriDishWin
{
    [TestFixture]
    public class TheGridFixture
    {
        TheGrid myGrid;
        [Test]
        public void The_grid_is_constructed_and_populated_with_given_values()
        {
            var gridSize = 5;
            var microbeCount = 5;
            myGrid = new TheGrid(gridSize, microbeCount);
            var rowLength = myGrid.grid.GetLength(0);
            var colLength = myGrid.grid.GetLength(1);
            Assert.AreEqual(gridSize, rowLength);
            Assert.AreEqual(gridSize, colLength);

            var actualCount = 0;
            foreach (var cell in myGrid.grid)
            {
                if (cell != null)
                {
                    actualCount++;
                }
            }
            Assert.AreEqual(microbeCount, actualCount);
            
        }

        [Test]
        public void The_grid_is_constructed_and_populated_with_default_values()
        {
            var gridSize = 1;
            var microbeCount = 20;
            var defaultSize = 100;
            var defaultMicrobeCount = 1;
            myGrid = new TheGrid(gridSize, microbeCount);
            var rowLength = myGrid.grid.GetLength(0);
            var colLength = myGrid.grid.GetLength(1);
            Assert.AreEqual(defaultSize, rowLength);
            Assert.AreEqual(defaultSize, colLength);

            var actualCount = 0;
            foreach (var cell in myGrid.grid)
            {
                if (cell != null)
                {
                    actualCount++;
                }
            }
            Assert.AreEqual(defaultMicrobeCount, actualCount);
        }

    }
}
