using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace PetriDishWin
{
    public class Microbe
    {
        public int microbeId { get; private set; }
        public int mutateResistance { get; private set; }
        public int mutateStrength { get; private set; }
        public int consumeResistance { get; private set; }
        public int consumeStrength { get; private set; }
        public int spreadChance { get; private set; }
        public static int mutationFactor = 1;
        public static int evolutionFactor = 1;
        public Color rgbColour { get; private set; }
        private static Random rand = new Random();

        public Microbe(int microbeId = 1)
        {
            this.microbeId = microbeId;
            mutateResistance = 50;
            mutateStrength = 1;
            consumeResistance = 50;
            consumeStrength = 100;
            spreadChance = 50;
            rgbColour = GetNewColour();
        }

        public Microbe(bool newSpecies, Microbe clone)
        {
            microbeId = RandomNumber(1, int.MaxValue - 1);
            rgbColour = GetNewColour();
            mutateResistance = clone.mutateResistance;
            mutateStrength = clone.mutateStrength;
            consumeResistance = clone.consumeResistance;
            consumeStrength = clone.consumeStrength;
            spreadChance = clone.spreadChance;
        }

        public bool CheckForSpread()
        {
            var spreadResult = RandomNumber(0, 100);
            if (spreadChance >= spreadResult)
            {
                return true;
            }
            return false;
        }

        public bool CheckForMutate()
        {
            var mutateResult = RandomNumber(0,50*mutateResistance); 
            if (mutateResult == 0)
            {
                Mutate(1*mutationFactor);
                return true;
            }
            return false;
        }

        public bool CheckForConsume(int consumeStrength)
        {
            var consumeResult = RandomNumber(0, consumeStrength);
            if (consumeResistance >= consumeResult)
            {
                return false;
            }
            return true;
        }
        public bool CheckForNewSpecies()
        {
            if (mutateStrength*evolutionFactor > RandomNumber(0,10000000))
            {
                return true;
            }
            return false;
        }

        public void Mutate(int times)
        {
            for (int x = 0; x < times; x++)
            {
                var selectedMutation = RandomNumber(0, 9);
                switch (selectedMutation)
                {
                    case 0:
                        Mutation1();
                        break;
                    case 1:
                        Mutation2();
                        break;
                    case 2:
                        Mutation3();
                        break;
                    case 3:
                        Mutation4();
                        break;
                    case 4:
                        Mutation5();
                        break;
                    case 5:
                        Mutation6();
                        break;
                    case 6:
                        Mutation7();
                        break;
                    case 7:
                        Mutation8();
                        break;
                    case 8:
                        Mutation9();
                        break;
                    case 9:
                        Mutation10();
                        break;
                    default:
                        break;
                }
            }
            
            if (mutateStrength < 0) { mutateStrength = 0; }
        }
        private void Mutation1()
        {
            if (mutateResistance > 1)
            {
                mutateResistance--;
            }
        }
        private void Mutation2()
        {
            if (spreadChance< 100)
            {
                spreadChance++;
            }
        }
        private void Mutation3()
        {
            if (consumeStrength < 500)
            {
                consumeStrength++;
            } 
        }
        private void Mutation4()
        {
            if (consumeResistance < 250)
            {
                consumeResistance++;
            }
        }
        private void Mutation5()
        {
            if (mutateResistance < 100)
            {
                mutateResistance++;
            }
        }
        private void Mutation6()
        {
            if (spreadChance > 1)
            {
                spreadChance--;
            }
        }
        private void Mutation7()
        {
            if (consumeStrength > 2)
            {
                consumeStrength--;
            } 
        }
        private void Mutation8()
        {
            if (consumeStrength > 2)
            {
                if (consumeResistance > 1)
                {
                    consumeResistance--;
                }
            }
        }
        private void Mutation9()
        {
            mutateStrength++;
        }
        private void Mutation10()
        {
            mutateStrength--;
        }


        public virtual int RandomNumber(int min, int max)
        {
            return rand.Next(min, max + 1);
        }

        private Color GetNewColour()
        {
            return Color.FromArgb(0xFF, rand.Next(256), rand.Next(256), rand.Next(256));
        }
    }
}
