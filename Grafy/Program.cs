using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class Node
    {
        int index;
        List<Node> neighbours;

        public Node(int index)
        {
            this.index = index;
            neighbours = new List<Node>();
        }

        public void AddNeighbour(Node neighbour)
        {
            if (neighbours.Contains(neighbour))
            {
                Console.WriteLine("This neighbour is already present.");
            }
            else
            {
                neighbours.Add(neighbour);
            }
            
        }

        public void AddNeighbours(List<Node> newNeighbours)
        {
            foreach (Node neighbour in newNeighbours)
            {
                AddNeighbour(neighbour);
            }
            //neighbours.AddRange(newNeighbours);
        }

        public void PrintNeighbours()
        {
            Console.Write("Neighbours of node " + index + ": ");
            foreach (Node neighbour in neighbours)
            {
                Console.Write(neighbour.index + ": ");
                
            }
            Console.WriteLine();

        }


    }
}
