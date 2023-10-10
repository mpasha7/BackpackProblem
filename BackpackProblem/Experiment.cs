using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackProblem
{
    internal class Experiment
    {
        public string Title { get; set; }
        public int rank { get; set; }
        public int Rank 
        {
            get => rank;
            set 
            {
                if (value <= 5 && value >= 1)
                {
                    rank = value;
                }
                else if (value < 1)
                {
                    Console.WriteLine($"Значение ранга для задачи \"{Title}\" выходит за нижний предел");
                    rank = 1;
                }
                else
                {
                    Console.WriteLine($"Значение ранга для задачи \"{Title}\" выходит за верхний предел");
                    rank = 5;
                }
            }
        }
        public LabStationWidth Width { get; set; }

        

    }
}
