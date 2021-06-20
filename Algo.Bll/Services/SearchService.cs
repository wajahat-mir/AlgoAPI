using Algo.Bll.Interfaces;
using Algo.Bll.Models.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Bll.Services
{
    public class SearchService: ISearchService
    {
        public List<Vertex> BreadFirstSearch(int source, Dictionary<int, List<int>> adjacencyList)
        {
            List<Vertex> updatedVertices = new List<Vertex>();
            Dictionary<int, string> vertices = new Dictionary<int, string>();

            updatedVertices.Add(new Vertex(source, "grey"));
            vertices.Add(source, "grey");
            foreach (var vertex in adjacencyList.Keys)
            {
                if(vertex != source)
                {
                    updatedVertices.Add(new Vertex(vertex, "white"));
                    vertices.Add(vertex, "white");
                }
                    
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(source);
            if(adjacencyList != null && adjacencyList.Any())
            {
                while(queue.Count() != 0)
                {
                    int currentVertex = queue.Dequeue();
                    foreach(var vertex in adjacencyList[currentVertex])
                    {
                        if(vertices[vertex] == "white")
                        {
                            vertices[vertex] = "grey";
                            queue.Enqueue(vertex);

                            updatedVertices.Add(new Vertex(vertex, "grey"));
                        }
                    }
                    vertices[currentVertex] = "black";
                    updatedVertices.Add(new Vertex(currentVertex, "black"));
                }
            }

            return updatedVertices;
        }

        public List<Vertex> DepthFirstSearch(Dictionary<int, List<int>> adjacencyList)
        {
            List<Vertex> updatedVertices = new List<Vertex>();
            Dictionary<int, string> vertices = new Dictionary<int, string>();

            foreach (var vertex in adjacencyList.Keys)
            {
                updatedVertices.Add(new Vertex(vertex, "white"));
                vertices.Add(vertex, "white");
            }

            foreach (var vertex in adjacencyList.Keys)
            {
                if(vertices[vertex] == "white")
                {
                    DepthFirstSearch(adjacencyList, updatedVertices, vertices, vertex);
                }
            }

            return updatedVertices;
        }

        private void DepthFirstSearch(Dictionary<int, List<int>> adjacencyList, List<Vertex> updatedVertices, Dictionary<int, string> vertices, int vertex)
        {
            vertices[vertex] = "grey";
            updatedVertices.Add(new Vertex(vertex, "grey"));

            foreach (var adjacentVertex in adjacencyList[vertex])
            {
                if (vertices[adjacentVertex] == "white")
                {
                    DepthFirstSearch(adjacencyList, updatedVertices, vertices, adjacentVertex);
                }
            }
            vertices[vertex] = "black";
            updatedVertices.Add(new Vertex(vertex, "black"));
        }
    }
}
