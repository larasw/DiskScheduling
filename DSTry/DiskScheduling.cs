using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSTry
{
    class DiskScheduling
    {
        private ISchedAlgorithm schedule;
        private int[] processID;
        private int currentProcess;

        public void SetAlgorithm(String algChosen, int cur)
        {
            this.currentProcess = cur;
            switch (algChosen)
            {
                case "FCFS":
                    schedule = new FCFS();
                    break;
                case "STF":
                    schedule = new STF(cur);
                    break;
                case "Elevator":
                    schedule = new Elevator(cur);
                    break;
                default:
                    schedule = null;
                    break;
            }
        }

        public int SchedulingOperation(int[] processID)
        {
            currentProcess = schedule.Algorithm(processID);
            this.processID = schedule.GetPIDArray();

            return currentProcess;
        }

        public int[] GetPIDArray()
        {
            return processID;
        }
    }
}
