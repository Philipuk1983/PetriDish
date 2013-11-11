using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace PetriDishWin
{
    [TestFixture]
    public class MicrobeFixture
    {
        Microbe myMicrobe, myOtherMicrobe;
        MockMicrobeMin myMockMicrobeMin;
        MockMicrobeMax myMockMicrobeMax;

        [Test]
        public void Default_id_is_used()
        {
            myMicrobe = new Microbe();
            Assert.AreEqual(1, myMicrobe.microbeId);
        }

        [Test]
        public void Supplied_id_is_used()
        {
            myMicrobe = new Microbe(10);
            Assert.AreEqual(10, myMicrobe.microbeId);
        }

        [Test]
        public void Attributes_of_supplied_microbe_are_copied_and_new_attributes_are_different()
        {
            myMicrobe = new Microbe(1);
            for (int i = 1; i <= 100; i++)
            {
                myMicrobe.Mutate(1);
            }
            myOtherMicrobe = new Microbe(true,myMicrobe);
            Assert.AreEqual(myMicrobe.mutateResistance, myOtherMicrobe.mutateResistance);
            Assert.AreEqual(myMicrobe.mutateStrength, myOtherMicrobe.mutateStrength);
            Assert.AreEqual(myMicrobe.consumeResistance, myOtherMicrobe.consumeResistance);
            Assert.AreEqual(myMicrobe.consumeStrength, myOtherMicrobe.consumeStrength);
            Assert.AreEqual(myMicrobe.spreadChance, myOtherMicrobe.spreadChance);
            Assert.AreNotEqual(myMicrobe.rgbColour, myOtherMicrobe.rgbColour);
            Assert.AreNotEqual(myMicrobe.microbeId, myOtherMicrobe.microbeId);
        }

        [Test]
        public void Range_check_for_spread()
        {
            myMockMicrobeMin = new MockMicrobeMin();
            Assert.AreEqual(true, myMockMicrobeMin.CheckForSpread());

            myMockMicrobeMax = new MockMicrobeMax();
            Assert.AreEqual(false, myMockMicrobeMax.CheckForSpread());
        }

        [Test]
        public void Range_check_for_mutate()
        {
            myMockMicrobeMin = new MockMicrobeMin();
            Assert.AreEqual(true, myMockMicrobeMin.CheckForMutate());

            myMockMicrobeMax = new MockMicrobeMax();
            Assert.AreEqual(false, myMockMicrobeMax.CheckForMutate());
        }

        [Test]
        public void Range_check_for_consume()
        {
            myMockMicrobeMin = new MockMicrobeMin();
            Assert.AreEqual(false, myMockMicrobeMin.CheckForConsume(0));

            myMockMicrobeMax = new MockMicrobeMax();
            Assert.AreEqual(true, myMockMicrobeMax.CheckForConsume(myMockMicrobeMax.consumeResistance+1));
        }

        [Test]
        public void Range_check_new_species()
        {
            myMockMicrobeMin = new MockMicrobeMin();
            Assert.AreEqual(true, myMockMicrobeMin.CheckForNewSpecies());

            myMockMicrobeMax = new MockMicrobeMax();
            Assert.AreEqual(false, myMockMicrobeMax.CheckForNewSpecies());
        }

        [Test]
        public void Mutate_is_called_and_mutateResistance_is_reduced()
        {
            myMockMicrobeMin = new MockMicrobeMin();
            var initialResistance = myMockMicrobeMin.mutateResistance;
            myMockMicrobeMin.Mutate(1);
            Assert.AreEqual(initialResistance - 1, myMockMicrobeMin.mutateResistance);
        }


        public class MockMicrobeMin : Microbe
        {
            public override int RandomNumber(int min, int max)
            {
                return min;
            }

        }
        public class MockMicrobeMax : Microbe
        {
            public override int RandomNumber(int min, int max)
            {
                return max;
            }

        }

    }
}
