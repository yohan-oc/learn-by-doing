using System;
namespace Opencast.LearnByDoing.Puzzle01
{
	public static class Puzzle01
	{
		public static void Run()
		{
            string[] lines = File.ReadAllLines("Puzzle01/puzzle_bonus.csv");

            var clientIdSetCache = new HashSet<string>(StringComparer.Ordinal);

            var duplicates = new List<string>();

			for(int i=0; i < lines.Length; i++)
			{
                var splitLine = lines[i].Split(",");

                string serialNo = splitLine[0];
				string clientId = splitLine[1];

				if (clientIdSetCache.Contains(clientId))
				{
					//Console.WriteLine("Duplicate row: " + serialNo);
					duplicates.Add(lines[i]);
					break;
				}
				else
				{
                    clientIdSetCache.Add(clientId);
				}
            }

			Console.WriteLine("Size of the dictionary: " + string.Join(", ", duplicates));
        }
	}
}

