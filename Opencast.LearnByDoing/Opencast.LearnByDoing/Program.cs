using System.Diagnostics;
using Opencast.LearnByDoing.Puzzle01;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Learn by Doing!");

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Puzzle01.Run();

stopwatch.Stop();
Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds} ms");