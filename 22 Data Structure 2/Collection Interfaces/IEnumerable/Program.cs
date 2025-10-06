using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerables
{
	public class CustomCollection<T> : IEnumerable<T>
	{
		private List<T> items = new List<T>();

		public IEnumerator<T> GetEnumerator()
		{
			for (int i =0;i<items.Count;i++)
			{
				/*
				 yield return
				 Usage: The yield return statement is used within an iterator block to provide a value 
				  to the enumerator object and then pauses the execution of the iterator block 
				  until the next element is requested.
				 Functionality: When a yield return statement is executed, 
				  it returns the current value to the caller but remembers the current location 
				  in code for the next call. The next time the iterator is accessed, 
				  it resumes execution from the state it was left in, 
				  immediately after the last yield return statement.

				*/
				yield return items[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
		 	return GetEnumerator();
		}

		public void Add(T item)
		{
			items.Add(item);
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			CustomCollection<int> items = new CustomCollection<int>();
			items.Add(1);
			items.Add(2);
			items.Add(3);
			
			foreach(var item in items)
			{
				Console.WriteLine(item);
            }


			Console.ReadKey();
		}
	}
}
