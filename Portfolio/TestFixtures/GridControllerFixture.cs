using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Rhino.Mocks;

namespace PetriDishWin
{
    [TestFixture]
    public class GridControllerFixture
    {
        GridController mockController, controller;
        Microbe newMicrobe;

        [Test]
        public void The_entire_grid_is_cycled_once()
        {
            mockController = MockRepository.GenerateMock<GridController>(3, 3);
            mockController.Expect(x => x.ProcessCell(Arg<int>.Is.Anything, Arg<int>.Is.Anything)).Repeat.Times(3);

            mockController.GridCycle();
            mockController.VerifyAllExpectations(); 
        }

        [Test]
        public void Create_new_species()
        {
            controller = new GridController(3, 9);
            int originalMicrobeId = controller.gameGrid.grid[1, 1].microbeId;
            controller.CreateNewSpecies(1, 1);
            Assert.AreNotEqual(originalMicrobeId, controller.gameGrid.grid[1, 1].microbeId);
        }

        [Test]
        public void Attempt_to_consume_random_direction()
        {
            mockController = MockRepository.GenerateMock<GridController>(3, 9);
            mockController.Expect(x => x.AttemptConsumeCell(Arg<int>.Is.Anything, Arg<int>.Is.Anything, Arg<int>.Is.Anything, Arg<int>.Is.Anything)).Repeat.Once();

            mockController.SpreadRandomDirection(1, 1);

            mockController.VerifyAllExpectations(); 
        }

        [Test]
        public void Spread_to_random_direction()
        {
            newMicrobe = new Microbe();
            mockController = MockRepository.GenerateMock<GridController>(3, 0);
            mockController.gameGrid.grid[1, 1] = newMicrobe;
            mockController.Expect(x => x.SpreadToCell(Arg<int>.Is.Anything, Arg<int>.Is.Anything, Arg<int>.Is.Anything, Arg<int>.Is.Anything)).Repeat.Once();

            mockController.SpreadRandomDirection(1, 1);

            mockController.VerifyAllExpectations(); 
        }

        [Test]
        public void Spread_to_given_cell()
        {
            controller = new GridController(3, 0);
            newMicrobe = new Microbe();
            controller.gameGrid.grid[1, 1] = newMicrobe;
            controller.SpreadToCell(1, 1, 2, 1);
            Assert.AreEqual(newMicrobe, controller.gameGrid.grid[2, 1]);
        }



    }
}
