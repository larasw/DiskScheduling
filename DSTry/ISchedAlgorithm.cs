using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSTry
{
    interface ISchedAlgorithm
    {
        int Algorithm(int[] alg);
        int[] GetPIDArray();
    }

    class FCFS : ISchedAlgorithm
    {
        private int kill;
        private int[] pidArray;
        public int Algorithm(int[] alg)
        {
            Console.WriteLine("FCFS");
            for(int i = 0; i < alg.Length; i++)
            {
                if(i != alg.Length - 1)
                {
                    if(i == 0)
                    {
                        kill = alg[i];
                    }
                    alg[i] = alg[i + 1];
                }
                else
                {
                    alg[i] = new Random().Next(0, 100);
                }
            }
            this.pidArray = alg;
            Console.WriteLine(kill);
            return kill;
        }

        public int[] GetPIDArray()
        {
            return pidArray;
        }
    }

    class STF : ISchedAlgorithm
    {
        private int current, min, kill, indexMin;
        private int[] pidArray, delta;

        public STF(int cur)
        {
            this.current = cur;
        }

        public int Algorithm(int[] alg)
        {
            Console.WriteLine("STF");
            delta = new int[alg.Length];
            for (int i=0; i<alg.Length ; i++)
            {
                //Delta
                if (alg[i] < current)
                {
                    delta[i] = current - alg[i];
                }
                else if (alg[i] > current)
                {
                    delta[i] = alg[i] - current;
                }

                //Min
                if (i == 0 || delta[i] < min)
                {
                    min = delta[i];
                    indexMin = i;
                }

                kill = alg[indexMin];
            }

            for (int i = 0; i < alg.Length; i++)
            {
                if (i == alg.Length - 1)
                {
                    alg[i] = new Random().Next(0, 100);
                }
                else if (i >= indexMin)
                {
                    alg[i] = alg[i + 1];
                }
            }
            Console.WriteLine("" + kill);
            this.pidArray = alg;
            return kill;
        }
        public int[] GetPIDArray()
        {
            return pidArray;
        }
    }

    class Elevator : ISchedAlgorithm
    {
        private int current;
        private int[] pidArray;

        public Elevator(int cur)
        {
            this.current = cur;
        }

        public int Algorithm(int[] alg)
        {
            Console.WriteLine("Elevator");
            this.pidArray = alg;
            return 0;
        }
        public int[] GetPIDArray()
        {
            return pidArray;
        }
    }
}
