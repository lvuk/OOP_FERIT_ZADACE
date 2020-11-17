﻿using System;
using Episode1;
using Description1;
using System.IO;
using TvUtilites1;

namespace Program

{
	class Program
	{

		public static void RunDz1()
        {
			Episode ep1, ep2;
			ep1 = new Episode();
			ep2 = new Episode(10, 64.39, 8.7);
			int viewers = 10;
			for (int i = 0; i < viewers; i++)
			{
				ep1.AddView(TvUtilities.GenerateRandomScore());
				Console.WriteLine(ep1.GetMaxScore());
			}
			if (ep1.GetAverageScore() > ep2.GetAverageScore())
			{
				Console.WriteLine($"Viewers: {ep1.GetViewerCount()}");
			}
			else
			{
				Console.WriteLine($"Viewers: {ep2.GetViewerCount()}");
			}
		}
		

		public static void RunDz2()
        {
			Description description = new Description(1, TimeSpan.FromMinutes(45), "Pilot");
			Console.WriteLine(description);
			Episode episode = new Episode(10, 88.64, 9.78, description);
			Console.WriteLine(episode);

			string fileName = "shows.tv";
			string[] episodesInputs = File.ReadAllLines(fileName);
			Episode[] episodes = new Episode[episodesInputs.Length];
			for (int i = 0; i < episodes.Length; i++)
			{
				episodes[i] = TvUtilities.Parse(episodesInputs[i]);
			}

			Console.WriteLine("Episodes:");
			Console.WriteLine(string.Join<Episode>(Environment.NewLine, episodes));
			TvUtilities.Sort(episodes);
			Console.WriteLine("Sorted episodes:");
			string sortedEpisodesOutput = string.Join<Episode>(Environment.NewLine, episodes);
			Console.WriteLine(sortedEpisodesOutput);
			File.WriteAllText("sorted.tv", sortedEpisodesOutput);
		}

		static void Main(string[] args)
		{
			//RunDz1();
			RunDz2();
		}
	}
}
