using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabStationsProblem
{
    internal class Solution
    {
        public double SumWidth { get; set; }
        public List<Experiment> Experiments { get; set; }
        private double Profits { get; set; } = new double();
        private int nodeCounter = 0;

        public Solution(List<Experiment> experiments, double sumWidth)
        {
            Experiments = experiments;
            SumWidth = sumWidth;
        }

        public List<Experiment> GetOptimalList()
        {
            FillProfits();
            Experiments.Sort((a, b) => b.Profit.CompareTo(a.Profit));
            SortedSet<Node> nodes = new SortedSet<Node>(new NodeComparer());
            var node = GetNode(0, new List<int>());
            if (node.Id is not null)
            {
                nodes.Add(node);
            }
            Node resultNode = new Node();
            while (true)
            {
                Node maxNode = nodes.Max;
                if (maxNode.I >= Experiments.Count)
                {
                    resultNode = maxNode;
                    break;
                }
                var firstNode = GetNode(maxNode.I + 1, maxNode.ExpList);
                if (firstNode.Id is not null)
                {
                    nodes.Add(firstNode);
                }
                List<int> list = new List<int>(maxNode.ExpList);
                list.Add(maxNode.I);
                var secondNode = GetNode(maxNode.I + 1, list);
                if (secondNode.Id is not null)
                {
                    nodes.Add(secondNode);
                }
                nodes.Remove(maxNode);
            }
            List<Experiment> optimalList = new List<Experiment>();
            foreach (var item in resultNode.ExpList)
            {
                optimalList.Add(Experiments[item]);
            }
            return optimalList;
        }

        private void FillProfits()
        {
            for (int i = 0; i < Experiments.Count; i++)
            {
                Experiments[i].SetProfit();
            }
        }

        private Node GetNode(int i, List<int> expNums)
        {
            double filledRank = 0;
            double filledWidth = 0;
            foreach (var num in expNums)
            {
                filledRank += Experiments[num].Rank;
                filledWidth += Experiments[num].Width;
            }
            if (filledWidth > SumWidth)
            {
                return new Node();
            }
            double result = 0;
            if (i >= Experiments.Count)
            {
                result = filledRank;
            }
            else
            {
                result = filledRank + Experiments[i].Profit * (SumWidth - filledWidth);
            }
            nodeCounter++;
            return new Node(nodeCounter, i, expNums, result);
        }
    }
}
