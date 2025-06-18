using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Distance
    {
        double dis1;
        double dis2;
        double dis3;

        public Distance(int dis1, int dis2)
        {
            this.dis1 = dis1;
            this.dis2 = dis2;
        }

        public void CalculateDistance()
        {
            dis3 = dis1 + dis2;
            Console.WriteLine($"Addition is : {dis3}");
        }

    }
}
