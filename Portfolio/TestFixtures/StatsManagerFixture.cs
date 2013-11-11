using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace PetriDishWin
{
    [TestFixture]
    public class StatsManagerFixture
    {
        public StatsManager stats;
        public TheGrid grid;
        public Microbe microbe1, microbe2;
        
        [Test]
        public void Finds_id_and_count_of_the_most_common_microbe_in_a_given_grid()
        {
            stats = new StatsManager();
            microbe1 = new Microbe(1);
            microbe2 = new Microbe(2);
            grid = new TheGrid(3, 0);
            grid.grid[0, 0] = microbe1;
            grid.grid[0, 1] = microbe1;
            grid.grid[0, 2] = microbe2;

            stats.AnalyseGrid(grid.grid);
            Assert.AreEqual(1, stats.topDog.microbeId);
            Assert.AreEqual(2, stats.topDogCount);
        }
    }
}
