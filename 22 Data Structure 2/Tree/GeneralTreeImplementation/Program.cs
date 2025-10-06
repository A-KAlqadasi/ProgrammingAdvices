using System;
using System.Collections.Generic;
using System.Net.Http.Headers;


namespace GeneralTreeImplementation
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

		public bool Remove(TreeNode<T> node)
		{
			return Children.Remove(node);
		}

		public TreeNode<T> Find(T value)
		{
			if (EqualityComparer<T>.Default.Equals(this.Value, value))
				return this;

			foreach (var node in Children)
			{
				var found = node.Find(value);
				if(found != null) 
					return found;
			}
			return null;
		}


    }

	public class Tree<T>
	{
		public TreeNode<T> Root { get; private set; }

        public Tree(T nodeValue)
        {
			Root = new TreeNode<T>(nodeValue);
        }

		public void PrintTree(string indent =" ")
		{
			PrintTree(this.Root, indent);
		}
		private static void PrintTree<T>(TreeNode<T> node, string indent = " ")
		{
			Console.WriteLine(indent + node.Value);
			foreach (var child in node.Children)
			{
				PrintTree(child, indent + "  ");
			}
		}

		public TreeNode<T> Find(T value)
		{
			return Root?.Find(value);
		}

		public bool Remove(TreeNode<T> node)
		{
			return Root.Remove(node);
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var companyTree = new Tree<string>("CEO(Abdulkareem)");

			var finance = new TreeNode<string>("CFO(Mozzah)");
			var tech = new TreeNode<string>("CTO(Mozzah)");
			var marketing = new TreeNode<string>("CMO(Mozzah)");

			companyTree.Root.AddChild(finance);
			companyTree.Root.AddChild(tech);
			companyTree.Root.AddChild(marketing);

			finance.AddChild(new TreeNode<string>("Accountant(Yousuf)"));

			tech.AddChild(new TreeNode<string>("UX Designer(Yousuf Alhammadi)"));
			tech.AddChild(new TreeNode<string>("Developer(Waleed)"));
			marketing.AddChild(new TreeNode<string>("Social media manager"));
			
			
			companyTree.PrintTree();

            Console.WriteLine("\n\nFinding Accountant(Yousuf)...");
			if(companyTree.Find("Accountant(Yousuf)") != null)
                Console.WriteLine("Found :-)");
			else
                Console.WriteLine("Not Found :-(");

			Console.WriteLine("\n\nFinding DBA...");
			if (companyTree.Find("DBA") != null)
				Console.WriteLine("Found:-)");
			else
				Console.WriteLine("Not Found :-(");

			Console.ReadKey();
		}

		
	}
}
