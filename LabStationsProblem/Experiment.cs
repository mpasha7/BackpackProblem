using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabStationsProblem
{
    public class Experiment
    {
        public string Title { get; set; }
        public int Rank { get; set; }
        public double Width { get; set; }
        public double Profit { get; set; }

        public void SetProfit()
        {
            Profit = Rank / Width;
        }
    }

}
