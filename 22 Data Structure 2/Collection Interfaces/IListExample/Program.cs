using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IListExample
{
	public class SimpleList<T> : IList<T>
	{
		private List<T> list = new List<T> ();
		public T this[int index] { get => list[index]; set => list[index] = value; }

		public int Count => list.Count;

		public bool IsReadOnly => false;

		public void Add(T item)=> list.Add(item);

		public void Clear()=> list.Clear();

		public bool Contains(T item) => list.Contains(item);

		public void CopyTo(T[] array, int arrayIndex)=> list.CopyTo(array, arrayIndex);
		public IEnumerator<T> GetEnumerator()
		{
			for (int i = 0; i < list.Count; i++)
				yield return list[i];

		}

		public int IndexOf(T item)=>list.IndexOf(item);

		public void Insert(int index, T item)=> list.Insert(index, item);

		public bool Remove(T item)=> list.Remove(item);
		public void RemoveAt(int index)=> list.RemoveAt(index);

		IEnumerator IEnumerable.GetEnumerator()=> GetEnumerator();
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			SimpleList<string> myList = new SimpleList<string>();
			myList.Add("First");
			myList.Add("Second");
			myList.Insert(1, "Inserted");


			Console.WriteLine("List after adding and inserting:");
			foreach (var item in myList)
			{
				Console.WriteLine(item);
			}


			myList.RemoveAt(1); // Removes "Inserted"
			myList[0] = "Updated First"; // Update the first item


			Console.WriteLine("\nList after removing and updating:");
			//foreach (var item in myList)
			//{
			//	Console.WriteLine(item);
			//}

			for (int i = 0; i < myList.Count; i++)
			{
				Console.WriteLine(myList[i]);
            }

			Console.ReadKey();
		}
	}
}
