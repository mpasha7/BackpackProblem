using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabStationsProblem
{
    public struct Node
    {
        public int? Id = null;
        public int I;
        public List<int> ExpList;
        public double Result;

        public Node(int id, int i, List<int> expList, double result)
        {
            Id = id;
            I = i;
            ExpList = expList;
            Result = result;
            
        }
    }

    public class NodeComparer : IComparer<Node>
    {
        public int Compare(Node x, Node y)
        {
            if (x.Id == y.Id)
            {
                return 0;
            }
            int a = x.Result.CompareTo(y.Result);
            if (a != 0)
            {
                return a;
            }
            int b = x.ExpList.Count.CompareTo(y.ExpList.Count);
            if (b != 0)
            {
                return b;
            }
            int c = x.I.CompareTo(y.I);
            if (c != 0)
            {
                return c;
            }

            int sumX = 0;
            foreach (int item in x.ExpList)
            {
                sumX += item;
            }
            int sumY = 0;
            foreach (int item in y.ExpList)
            {
                sumY += item;
            }
            return sumY.CompareTo(sumX);
        }
    }
}
