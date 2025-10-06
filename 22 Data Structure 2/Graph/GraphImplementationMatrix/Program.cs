using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GraphImplementationMatrix.Graph;

namespace GraphImplementationMatrix
{
	public class Graph
	{
		public enum enGraphDirectionType { unDirected=1, Directed=2 }

		private int[,] _adjacencyMatrix;

		private Dictionary<string, int> _vertexDictionary;

		private int _NumberOfVerticies;

		private enGraphDirectionType _GraphDirectionType = enGraphDirectionType.unDirected;

		public Graph(List<string> verticies, enGraphDirectionType graphDirectionType)
		{

			_GraphDirectionType = graphDirectionType;

			_NumberOfVerticies = verticies.Count;

			_adjacencyMatrix = new int[_NumberOfVerticies, _NumberOfVerticies];

			_vertexDictionary = new Dictionary<string, int>();
			for (int i = 0; i < _NumberOfVerticies; i++)
			{
				_vertexDictionary[verticies[i]] = i;
			}

		}

		public void AddEdge(string source, string distination, int weight )
		{
			if(_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(distination))
			{
				int sourceIndex = _vertexDictionary[source];
				int distinationIndex = _vertexDictionary[distination];

				_adjacencyMatrix[sourceIndex,distinationIndex] = weight;

				if(_GraphDirectionType == enGraphDirectionType.unDirected)
					_adjacencyMatrix[distinationIndex,sourceIndex] = weight;

			}
			else
			{
                Console.WriteLine($"\n\nIgnored:Invalid vertices. {source} ==> {distination}\n\n");
            }
		}

		public void DisplayGraph(string message)
		{
            Console.WriteLine("\n"+message+"\n");
            // print the first row
            Console.Write("   ");
            foreach (var key in _vertexDictionary.Keys)
			{
                Console.Write(key+"  ");
            }
            Console.WriteLine();
            foreach (var source in _vertexDictionary)
			{
                Console.Write(source.Key+ "  ");

				for (int i = 0; i < _NumberOfVerticies; i++)
				{
					Console.Write(_adjacencyMatrix[source.Value,i]+ "  ");
                }
                Console.WriteLine();

            }

        }

		public bool IsEdge(string source, string distination)
		{
			if(_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(distination))
			{
				int sourceIndex = _vertexDictionary[source];
				int distinationIndex = _vertexDictionary[distination];
				return _adjacencyMatrix[sourceIndex, distinationIndex] > 0;
			}
			return false;
		}

		public void RemoveEdge(string source, string distination)
		{
			if (_vertexDictionary.ContainsKey(source) && _vertexDictionary.ContainsKey(distination))
			{
				int sourceIndex = _vertexDictionary[source];
				int distinationIndex = _vertexDictionary[distination];

				_adjacencyMatrix[sourceIndex,distinationIndex] = 0;
				_adjacencyMatrix[distinationIndex,sourceIndex ] = 0;

			}
			else
                Console.WriteLine("\nInvalid verticies");
        }

		public int GetInDegree(string vertex)
		{
			int inDegrees = 0;

			int vertexIndex = _vertexDictionary[vertex];
			for (int i = 0; i < _NumberOfVerticies; i++)
			{
				if (_adjacencyMatrix[i, vertexIndex] > 0)
					inDegrees++;
			}
			return inDegrees;
		}

		public int GetOutDegree(string vertex)
		{
			int outDegrees = 0;

			int vertexIndex = _vertexDictionary[vertex];
			for (int i = 0; i < _NumberOfVerticies; i++)
			{
				if (_adjacencyMatrix[vertexIndex,i] > 0)
					outDegrees++;
			}
			return outDegrees;
		}

	}

	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a list of vertices with string labels
			List<string> vertices = new List<string> { "A", "B", "C", "D", "E" };


			//Example 1 in Slides: Undirected Graph
			// Create a new graph object with the specified vertices
			Graph graph1 = new Graph(vertices, enGraphDirectionType.unDirected);

			// Add some edges with default weights=1 between vertices
			graph1.AddEdge("A", "B", 1);
			graph1.AddEdge("A", "C", 1);
			graph1.AddEdge("B", "D", 1);
			graph1.AddEdge("C", "D", 1);
			graph1.AddEdge("B", "E", 1);
			graph1.AddEdge("D", "E", 1);



			// Display the adjacency matrix with weights to visualize the graph
			graph1.DisplayGraph("Adjacency Matrix for Example1 (Undirected Graph):");

			Console.WriteLine("\n------------------------------\n");

			//Example 2 in Slides: Directed Graph
			// Create a new graph object with the specified vertices
			Graph graph2 = new Graph(vertices, enGraphDirectionType.Directed);

			// Add some edges with weights between vertices
			graph2.AddEdge("A", "A", 1);
			graph2.AddEdge("A", "B", 1);
			graph2.AddEdge("A", "C", 1);
			graph2.AddEdge("B", "E", 1);
			graph2.AddEdge("D", "B", 1);
			graph2.AddEdge("D", "C", 1);
			graph2.AddEdge("D", "E", 1);

			// Display the adjacency matrix with weights to visualize the graph
			graph2.DisplayGraph("Adjacency Matrix for Example2 (Directed Graph):");


			// Get and display the Indegree (number of edges) of vertex 'D'
			Console.WriteLine("\nInDegree of vertex D: " + graph2.GetInDegree("D"));

			// Get and display the Outdegree (number of edges) of vertex 'D'
			Console.WriteLine("\nOutDegree of vertex D: " + graph2.GetOutDegree("D"));

			Console.WriteLine("\n------------------------------\n");

			//Example 3 in Slides: Weighted Graph
			// Create a new graph object with the specified vertices
			Graph graph3 = new Graph(vertices, enGraphDirectionType.unDirected);

			// Add some edges with weights between vertices
			graph3.AddEdge("A", "B", 5);
			graph3.AddEdge("A", "C", 3);
			graph3.AddEdge("B", "D", 12);
			graph3.AddEdge("C", "D", 10);
			graph3.AddEdge("B", "E", 2);
			graph3.AddEdge("D", "E", 7);

			// Display the adjacency matrix with weights to visualize the graph
			graph3.DisplayGraph("Adjacency Matrix for Example3 (Weighted Graph):");


			// Check if there is an edge between 'A' and 'B' and display the result
			Console.WriteLine("\nIs there an edge between A and B in Graph3? " + graph3.IsEdge("A", "B"));


			// Check if there is an edge between 'A' and 'B' and display the result
			Console.WriteLine("\nIs there an edge between B and C in Graph3? " + graph3.IsEdge("B", "C"));


			// Check if there is an edge between 'A' and 'A' and display the result
			Console.WriteLine("\nIs there an edge between E and D in Graph3? " + graph3.IsEdge("E", "D"));

			// Check if there is an edge between 'A' and 'A' and display the result
			Console.WriteLine("\nIs there an edge between A and A in Graph3? " + graph3.IsEdge("A", "A"));


			// Get and display the Indegree (number of edges) of vertex 'A'
			Console.WriteLine("\nInDegree of vertex A: " + graph3.GetInDegree("A"));

			// Get and display the Indegree (number of edges) of vertex 'A'
			Console.WriteLine("\nOutDegree of vertex A: " + graph3.GetOutDegree("A"));

			Console.WriteLine("\n------------------------------\n");


			Console.WriteLine("\nRemoveing Edge between E and D:");
			// Remove the edge between 'E' and 'D'
			graph3.RemoveEdge("E", "D");

			// Display the updated adjacency matrix after removing the edge
			graph3.DisplayGraph("After Removeing Edge between E and D:");


			// Check if there is an edge between 'A' and 'A' and display the result
			Console.WriteLine("\nIs there an edge between E and D in Graph3? " + graph3.IsEdge("E", "D"));


			Console.ReadKey();
		}
	}
}
