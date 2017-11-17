using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSTry
{
    public partial class Form1 : Form
    {
        private int[] processID;
        private Random random;
        private int number, current;
        private DiskScheduling diskScheduling;
        private string alg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diskScheduling = new DiskScheduling();

            processID = new int[10];
            random = new Random();
            
            for(int i = 0; i < processID.Length; i++)
            {
                number = random.Next(0, 100);
                processID[i] = number;
                arrayBox.AppendText(processID[i]+"\n");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            alg = "FCFS";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void radioSTF_CheckedChanged(object sender, EventArgs e)
        {
            alg = "STF";
        }

        private void radioElevator_CheckedChanged(object sender, EventArgs e)
        {
            alg = "Elevator";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(killBox.Text == "")
            {
                strategy();
            }
            else
            {
                if(trackBar.Value < current)
                {
                    trackBar.Value++;
                }
                else if(trackBar.Value > current)
                {
                    trackBar.Value--;
                }
                else if(trackBar.Value == current)
                {
                    strategy();
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        public void strategy()
        {
            diskScheduling.SetAlgorithm(alg, current);
            current = diskScheduling.SchedulingOperation(processID);
            processID = diskScheduling.GetPIDArray();

            killBox.ResetText();
            killBox.AppendText("" + current);
            arrayBox.ResetText();
            for (int i = 0; i < processID.Length; i++)
            {
                arrayBox.AppendText(processID[i] + "\n");
            }
        }
    }
}
