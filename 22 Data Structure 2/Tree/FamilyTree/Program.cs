using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FamilyTree
{

	public class TreeNode<T>
	{
		public T Value { get; set; }

		public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
			this.Value = value;
			Children = new List<TreeNode<T>>();
        }

		public void AddChild(TreeNode<T> node)
		{
			Children.Add(node);
		}

		public TreeNode<T> Find(T value)
		{
			if(EqualityComparer<T>.Default.Equals(this.Value, value))
				return this;

			foreach (var node in Children)
			{
				var find = node.Find(value);
				if (find != null)
					return find;
			}
			return null;

		}

    }

	public class Tree<T>
	{
		public TreeNode<T> Root { get; private set; }

        public Tree(T rootValue)
        {
			Root = new TreeNode<T>(rootValue);
        }

		public void PrintTree(string indent = " ")
		{
			PrintTree(this.Root, indent);
		}

		private static void PrintTree<T>(TreeNode<T> node, string indent = " ")
		{
            Console.WriteLine(indent+ node.Value);
			foreach (var child in node.Children)
			{
				PrintTree(child, indent + "  ");
			}
        }

		public TreeNode<T> Find(T value)
		{
			return Root?.Find(value);
		}

    }

	internal class Program
	{
		static void Main(string[] args)
		{
			var familyTree = new Tree<string>("Yousef");

			var yousefChild1 = new TreeNode<string>("Shawqi");
			var yousefChild2 = new TreeNode<string>("Baleigh");
			var yousefChild3 = new TreeNode<string>("Ramzi");
			var yousefChild4 = new TreeNode<string>("Haithem");


			familyTree.Root.AddChild(yousefChild1);
			familyTree.Root.AddChild(yousefChild2);
			familyTree.Root.AddChild(yousefChild3);
			familyTree.Root.AddChild(yousefChild4);

			yousefChild1.AddChild(new TreeNode<string>("Abdulkareem"));
			yousefChild1.AddChild(new TreeNode<string>("Ebrahim"));

			yousefChild2.AddChild(new TreeNode<string>("Ahmed"));
			yousefChild2.AddChild(new TreeNode<string>("Raghad"));
			yousefChild2.AddChild(new TreeNode<string>("Kinan"));

			yousefChild3.AddChild(new TreeNode<string>(""));

			yousefChild4.AddChild(new TreeNode<string>("Yousef"));
			yousefChild4.AddChild(new TreeNode<string>("Younes"));
			yousefChild4.AddChild(new TreeNode<string>("Laith"));

			familyTree.PrintTree();

            Console.WriteLine("\n\n Find Abdulkareem");
			if(familyTree.Find("Abdulkareem") != null)
                Console.WriteLine("Found:-)");
			else
                Console.WriteLine("Not Found:-(");

			Console.WriteLine("\n\n Find Mohammed");
			if (familyTree.Find("Mohammed") != null)
				Console.WriteLine("Found:-)");
			else
				Console.WriteLine("Not Found:-(");

			Console.ReadKey();
		}
	
	}
}
