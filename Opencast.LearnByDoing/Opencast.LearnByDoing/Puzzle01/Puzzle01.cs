using System;
namespace Opencast.LearnByDoing.Puzzle01
{
	public static class Puzzle01
	{
		public static void Run()
		{
            string[] lines = File.ReadAllLines("Puzzle01/puzzle_bonus.csv");

            var clientIdSetCache = new Dictionary<string, string>(StringComparer.Ordinal);

            List<string> duplicateSerialNumbers = new();

			for(int i=0; i < lines.Length; i++)
			{
                var splitLine = lines[i].Split(",");
                string serialNo = splitLine[0];
                string clientId = splitLine[1];

				if (clientIdSetCache.ContainsKey(clientId))
				{
                    duplicateSerialNumbers.Add(clientIdSetCache[clientId]);
                    duplicateSerialNumbers.Add(serialNo);
                    break;
				}
				else
				{
                    clientIdSetCache.Add(clientId, serialNo);
				}
            }

			Console.WriteLine("Duplicate serial numbers: " + string.Join(", ", duplicateSerialNumbers));
        }
	}
}

