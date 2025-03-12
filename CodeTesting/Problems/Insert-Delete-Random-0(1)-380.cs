using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Insert_Delete_Random_0_1__380
    {
        public class RandomizeSet
        {
            List<int> randomizeSet;
            public RandomizeSet()
            {
                randomizeSet = new List<int>();
            }


            public bool Insert(int val)
            {
                if(!randomizeSet.Contains(val))
                {
                    randomizeSet.Add(val);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool Remove(int val)
            {
                if(randomizeSet.Contains(val))
                {
                    randomizeSet.Remove(val);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public int GetRandom()
            {
                Random random = new Random();
                int randomIndex = random.Next(randomizeSet.Count);
                return randomizeSet[randomIndex];
            }

        }
    }
}
