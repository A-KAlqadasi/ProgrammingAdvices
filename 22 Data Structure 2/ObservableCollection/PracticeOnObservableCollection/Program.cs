using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Web;

namespace PracticeOnObservableCollection
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ObservableCollection<string> oCNames = new ObservableCollection<string>();
			oCNames.CollectionChanged += OCNames_CollectionChanged;

			oCNames.Add("Ali");
			oCNames.Add("Ahmed");
			oCNames.Add("Mohammed");
			oCNames.Add("Waleed");

			oCNames.RemoveAt(0);
			oCNames.Move(0, 2);
			oCNames[1] = "Replaced Name";

            Console.WriteLine("Final collection names:");
            foreach (string s in oCNames)
			{
                Console.WriteLine(s);
            }


			Console.ReadKey();
		}

		private static void OCNames_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
		{
            Console.WriteLine("\nCollection Changed.");
            switch (e.Action)
			{
				case NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Adding");
					foreach(string item in e.NewItems)
					{
                        Console.WriteLine("New Item: "+ item);
                    }
                    break;
				case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Removing");
					foreach(string item in e.OldItems)
					{
                        Console.WriteLine("Removed Item: "+ item);
					}
					break;
				case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Replace");
					foreach(string item in e.OldItems)
					{
                        Console.Write($"Old item: {item} - ");
                    }

					foreach(string item in e.NewItems)
					{
                        Console.Write($"With: {item}");
                    }
                    break;
				case NotifyCollectionChangedAction.Move:
					Console.WriteLine("Move");
                    Console.WriteLine($"from index: {e.OldStartingIndex}  To index: {e.NewStartingIndex}");
                    break;
				
			}

			
		}
	}
}
