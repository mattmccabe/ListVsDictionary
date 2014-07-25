using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ListVsDictionary
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> lookupCounts = new List<int> { 1, 5, 10, 50, 100 };
			List<int> itemCounts = new List<int> { 1, 10, 100, 1000, 10000 };

			for (var i = 0; i < lookupCounts.Count; i++) {
				var lookupCount = lookupCounts [i];
				for (var j = 0; j < itemCounts.Count; j++) {
					var itemCount = itemCounts [j];
					List<Item> items = GetItemsWithLookups(itemCount, lookupCount);

					Console.WriteLine("{0} Items with {1} lookups", itemCount, lookupCount);

					ListTest (items, lookupCounts [j]);
					Console.WriteLine ("");
					DictionaryTest (items, lookupCounts [j]);
					Console.WriteLine ("");
					Console.WriteLine ("");
				}
			}
		}

		public static List<Item> GetItemsWithLookups(int itemCount, int lookupCount)
		{
			List<Item> items = new List<Item> (itemCount * 2);
			Random r = new Random ();
			while (itemCount > 0) {
				int rInt = r.Next (0, lookupCount);
				items.Add(new Item { Name = string.Format("Item {0}", itemCount), Id = itemCount, LookupId = rInt });
				itemCount--;
			}
			return items;
		}

		public static void DictionaryTest(List<Item> items, int lookupCount)
		{
			Console.Write ("\tDict==>");
			Stopwatch sw = new Stopwatch ();
			sw.Start ();

			Dictionary<int, Lookup> lookups = new Dictionary<int, Lookup> ();
			while (lookupCount > 0) {
				lookups.Add(lookupCount, new Lookup { Name = String.Format ("Lookup {0}", lookupCount), Id = lookupCount });
				lookupCount--;
			}
			sw.Stop ();
			Console.Write ("\tCreate:\t{0}", sw.Elapsed);

			sw.Reset();
			sw.Start ();
			for (var i = 0; i < items.Count; i++) {
				var item = items [i];
				var lookupId = item.LookupId;
				if (lookups.ContainsKey (lookupId)) {
					item.LookupName = lookups [lookupId].Name;
					lookups [lookupId].Count++;
				}
			}
			sw.Stop ();
			Console.Write ("\tDo lookup:\t{0}", sw.Elapsed);

		}


		public static void ListTest(List<Item> items, int lookupCount)
		{
			Console.Write ("\tList==>");

			Stopwatch sw = new Stopwatch ();
			sw.Start ();

			List<Lookup> lookups = new List<Lookup> (lookupCount * 2);
			while (lookupCount > 0) {
				lookups.Add(new Lookup { Name = String.Format ("Lookup {0}", lookupCount), Id = lookupCount });
				lookupCount--;
			}
			sw.Stop ();
			Console.Write ("\tCreate:\t{0}", sw.Elapsed);

			sw.Reset();
			sw.Start ();
			for (var i = 0; i < items.Count; i++) {
				var item = items [i];
				var lookupId = item.LookupId;
				for (var j = 0; j < lookups.Count; j++) {
					if (item.LookupId == lookups [j].Id) {
						item.LookupName = lookups [j].Name;
						lookups [j].Count++;
					}
				}
			}
			sw.Stop ();
			Console.Write ("\tDo lookup:\t{0}", sw.Elapsed);

		}
	}

	public class Item
	{
		public int LookupId{ get; set; }
		public string LookupName { get; set;}
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class Lookup
	{
		public string Name {get;set;}
		public int Id { get; set; }
		public int Count { get; set; }
	}
}
