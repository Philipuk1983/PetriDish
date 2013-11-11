using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetriDishWin
{
    public class StatsManager
    {
        public Microbe topDog{get;private set;}
        public int topDogCount;

        public void AnalyseGrid(Microbe[,] grid)
        {
            Dictionary<Microbe, int> dic = new Dictionary<Microbe, int>();
            foreach (Microbe x in grid)
            {
                if (x != null)
                {
                    if (dic.ContainsKey(x))
                    {
                        dic[x] += 1;
                    }
                    else
                    {
                        dic.Add(x, 1);
                    }
                }
            }
            topDog = dic.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            topDogCount = dic[topDog];
        }
    }
}
