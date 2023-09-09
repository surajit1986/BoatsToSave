using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoatsToASavePpl
{
    internal class BoatsToSavePpl
    {
        //This problem will work if no constarint given that a boat can carry max 2 ppl.
        public int MinBoatCountToSavePpl(int[] weigths, int capacity)
        {
            int count = 0;
            int totalWeight = 0;

            while (count < weigths.Length)
            {
                totalWeight += weigths[count];
            }

            if (totalWeight == 0)
            {
                return 0;
            }
            else if (totalWeight < capacity)
            {
                return 1;
            }
            else
            {
                count = (totalWeight % capacity);
                if (count == 0)
                {
                    return (totalWeight / capacity);
                }
                else
                {
                    int remain = totalWeight / capacity;
                    return (remain + count);
                }
            }

        }

        public int MinBoatsWithCapacity(int[] weigths, int capacity)
        {
            Array.Sort(weigths);

            int lightW = 0;
            int heavyW = weigths.Length -1;
            int boats = 0;

            while (heavyW >= lightW)
            {
                if ((weigths[heavyW]+ weigths[lightW])<= capacity) { 
                   
                    heavyW--;
                    lightW++;
                }
                else
                {
                    heavyW--;
                    
                }
                boats++;
            }

            return boats;
        }
    }
}
