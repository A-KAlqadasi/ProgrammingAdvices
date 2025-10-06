using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;


class Program
{
	static void Main(string[] args)
	{
		// Creating an ObservableCollection
		ObservableCollection<string> Items = new ObservableCollection<string>();
		// Subscribing to the CollectionChanged event
		Items.CollectionChanged += Items_CollectionChanged;


		// Modifying the ObservableCollection
		Items.Add("Item 1");
		Items.Add("Item 2");
		Items.Add("Item 3");


		Items.RemoveAt(1);
		Items.Insert(0, "New Item");
		Items[1] = "Replaced Item"; // Replace action
		Items.Move(0, 2); // Move action


		// Printing the Final Collection
		Console.WriteLine("\nFinal Collection:");
		foreach (var item in Items)
		{
			Console.WriteLine(item);
		}
		Console.ReadKey();
	}


	// CollectionChanged Event Handler
	static void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		Console.WriteLine("\nCollection Changed:");
		

		// Handling Collection Changes
		switch (e.Action)
		{
			case NotifyCollectionChangedAction.Add:
				Console.WriteLine("Added:");
				foreach (var newItem in e.NewItems)
				{
					Console.WriteLine("- " + newItem);
				}
				break;

			case NotifyCollectionChangedAction.Remove:
				Console.WriteLine("Removed:");
				foreach (var oldItem in e.OldItems)
				{
					Console.WriteLine("- " + oldItem);
				}
				break;


			case NotifyCollectionChangedAction.Replace:
				Console.WriteLine("Replaced:");
				foreach (var oldItem in e.OldItems)
				{
					Console.WriteLine("- " + oldItem);
				}
				Console.WriteLine("With:");
				foreach (var newItem in e.NewItems)
				{
					Console.WriteLine("- " + newItem);
				}
				break;


			case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				Console.WriteLine("Moved:");
				Console.WriteLine($"- From index {e.OldStartingIndex} to index {e.NewStartingIndex}");
				break;
		}
	}
}