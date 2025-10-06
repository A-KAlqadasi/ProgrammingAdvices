using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollections
{
	public class SimpleCollection<T> : ICollection<T>
	{
		private List<T> list = new List<T>();

		public int Count => list.Count;

		public bool IsReadOnly => false;

		public void Add(T item)
		{
			list.Add(item);
		}

		public void Clear()
		{
			list.Clear();
		}

		public bool Contains(T item)
		{
			return list.Contains(item);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			list.CopyTo(array, arrayIndex);
		}

		public IEnumerator<T> GetEnumerator()
		{
			for (int i=0;i<list.Count; i++)
			{
				yield return list[i];
			}
		}

		public bool Remove(T item)
		{
			return list.Remove(item);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			SimpleCollection<string> shoppingCart = new SimpleCollection<string>();
			shoppingCart.Add("Apple");
			shoppingCart.Add("Banana");
			shoppingCart.Add("Carrot");


			Console.WriteLine($"Items in cart: {shoppingCart.Count}");

			if (shoppingCart.Contains("Banana"))
			{
				shoppingCart.Remove("Banana");
				Console.WriteLine("Banana removed from the cart.");
			}


			Console.WriteLine("Final items in the cart:");
			foreach (var item in shoppingCart)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}
	}
}
