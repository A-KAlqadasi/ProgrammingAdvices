using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnGraphWithMatrix
{
	public class Graph
	{
		public enum enGraphDirectionType { unDirected =1, Directed =2 }

		private int[,] _adjacencyMatrix;

		private Dictionary<string, int> _dictionaryVerticies;

		private int _NumberOfVerticies;

		private enGraphDirectionType _GraphDirection;

        public Graph(List<string> verticies , enGraphDirectionType graphDirection)
        {
            _GraphDirection = graphDirection;
			_NumberOfVerticies = verticies.Count;
			_adjacencyMatrix = new int[_NumberOfVerticies, _NumberOfVerticies];

			_dictionaryVerticies = new Dictionary<string, int>();
			for (int i = 0; i < _NumberOfVerticies; i++)
			{
				_dictionaryVerticies[verticies[i]] = i;
			}

        }

		public void AddEdge(string source, string distination, int weight)
		{
			if(_dictionaryVerticies.ContainsKey(source)  && _dictionaryVerticies.ContainsKey(distination))
			{
				int sourceIndex = _dictionaryVerticies[source];
				int distinationIndex= _dictionaryVerticies[distination];
				_adjacencyMatrix[sourceIndex,distinationIndex] = weight;
				if(_GraphDirection == enGraphDirectionType.unDirected)
					_adjacencyMatrix[distinationIndex,sourceIndex] = weight;
			}
			else
			{
                Console.WriteLine($"\n\nIgnored: Invalid vertex. {source} => {distination}");
            }
		}
		
		public void DisplayGraph(string message)
		{
            Console.WriteLine("\n"+ message + "\n");

            Console.Write("   ");
            foreach (var source in _dictionaryVerticies.Keys)
			{
                Console.Write(source+"  ");
            }
            Console.WriteLine();
            foreach (var source in _dictionaryVerticies)
			{
                Console.Write(source.Key+ "  ");
				for (int i = 0; i < _NumberOfVerticies; i++)
				{
					Console.Write(_adjacencyMatrix[source.Value,i] + "  ");
                }
                Console.WriteLine();
            }

		}

		public bool IsEdge(string source , string distination)
		{
			if(_dictionaryVerticies.ContainsKey(source) && _dictionaryVerticies.ContainsKey(distination))
			{
				int sourceIndex = _dictionaryVerticies[source];
				int distinationIndex = _dictionaryVerticies[distination];
				return _adjacencyMatrix[sourceIndex, distinationIndex] > 0;
			}
			return false;
		}

		public void Remove(string source , string distination)
		{
			if (_dictionaryVerticies.ContainsKey(source) && _dictionaryVerticies.ContainsKey(distination))
			{
				int sourceIndex = _dictionaryVerticies[source];
				int distinationIndex = _dictionaryVerticies[distination];
				_adjacencyMatrix[sourceIndex, distinationIndex] = 0;
				_adjacencyMatrix[distinationIndex, sourceIndex] = 0; // for undirected

			}
			else
			{
				Console.WriteLine($"\n\nIgnored: Invalid vertex. {source} => {distination}");
			}
		}

		public int GetOutDegree(string vertex)
		{
			int degree = 0;
			if (_dictionaryVerticies.ContainsKey(vertex))
			{
				int vertexIndex = _dictionaryVerticies[vertex];

				for (int i = 0; i < _NumberOfVerticies; i++)
				{
						if (_adjacencyMatrix[vertexIndex, i] > 0)
							degree++;
				}
				
			}
			return degree;
		}
		public int GetInDegree(string vertex)
		{
			int degree = 0;
			if (_dictionaryVerticies.ContainsKey(vertex))
			{
				int vertexIndex = _dictionaryVerticies[vertex];

				for (int i = 0; i < _NumberOfVerticies; i++)
				{
					if (_adjacencyMatrix[i, vertexIndex] > 0)
						degree++;
				}

			}
			return degree;
		}

	}

	internal class Program
	{
		static void Main(string[] args)
		{
			List<string> verticies = new List<string>() { "A","B","C","D","E"};

			Graph graph1 = new Graph(verticies,Graph.enGraphDirectionType.unDirected);

			graph1.AddEdge("A", "B", 3);
			graph1.AddEdge("A", "C", 2);
			graph1.AddEdge("B", "D", 4);
			graph1.AddEdge("C", "D", 5);
			graph1.AddEdge("B", "E", 7);
			graph1.AddEdge("D", "E", 6);

			graph1.DisplayGraph("graph matrix implementation (Undirected graph)");


			Console.ReadKey();
		}
	}
}
