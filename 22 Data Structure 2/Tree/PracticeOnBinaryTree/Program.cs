using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOnBinaryTree
{
	public class BinaryTreeNode<T>
	{
		public T Value { get; set; }
		public BinaryTreeNode<T> Left { get; set; }
		public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T value)
        {
            Value = value;
			Left = null;
			Right = null;
        }

    }

	public class BinaryTree<T>
	{
		public BinaryTreeNode<T> Root { get; private set; }

        public BinaryTree()
        {
			Root = null;
        }

		public void Insert(T value)
		{
			var newNode = new BinaryTreeNode<T>(value);

			if(Root == null)
			{
				Root = newNode;
				return;
			}

			Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
			queue.Enqueue(Root);

			while (queue.Count > 0)
			{
				var current = queue.Dequeue();

				if (current.Left == null)
				{
					current.Left = newNode;
					break;
				}
				else
				{
					queue.Enqueue(current.Left);
				}

				if (current.Right == null)
				{
					current.Right = newNode;
					break;
				}
				else
				{
					queue.Enqueue(current.Right);
				}

			}
		}


		public void PrintTree()
		{
			PrintTree(this.Root, 0);
		}

		private void PrintTree(BinaryTreeNode<T> root, int space)
		{
			int COUNT = 10;  // Distance between levels to adjust the visual representation
			if (root == null)
				return;


			space += COUNT;
			PrintTree(root.Right, space); // Print right subtree first, then root, and left subtree last


			Console.WriteLine();
			for (int i = COUNT; i < space; i++)
				Console.Write(" ");
			Console.WriteLine(root.Value); // Print the current node after space


			PrintTree(root.Left, space); // Recur on the left child
		}

		public void PreOrderTraversal()
		{
			PreOrderTraversal(Root);
		}

		private void PreOrderTraversal(BinaryTreeNode<T> node)
		{

			if(node != null)
			{
                Console.Write(node.Value + "  ");
				PreOrderTraversal(node.Left);
				PreOrderTraversal(node.Right);
			}

		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var binaryTree = new BinaryTree<int>();

            Console.WriteLine("Print nodes of tree\n\n");

            binaryTree.Insert(1);
			binaryTree.Insert(2);
			binaryTree.Insert(3);
			binaryTree.Insert(4);
			binaryTree.Insert(5);
			binaryTree.Insert(6);

			binaryTree.PrintTree();

            Console.WriteLine("\n\nPreOrder traversal of the tree");

			binaryTree.PreOrderTraversal();

            Console.ReadKey();
		}
	}
}
