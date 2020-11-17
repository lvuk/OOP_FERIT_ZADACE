using System;
using System.Collections.Generic;
using System.Text;
using Episode1;
using Description1;


namespace TvUtilites1
{
    public class TvUtilities
    {
        public static double GenerateRandomScore()
        {
            Random random = new Random();
            return random.NextDouble() * 10;
        }
        public static void Sort(Episode[] episodes)
        {
            int i, j;
            Episode temp;
            for(i = 0; i < episodes.Length; i++ )
                for (j = i; i < episodes.Length - i - 1; j++)
                    if(episodes[j] < episodes[j + 1])
                    {
                        temp = episodes[j];
                        episodes[j] = episodes[j + 1];
                        episodes[j + 1] = temp;
                    }
        }

        public static Episode Parse(string text)
        {
            string[] parameteres = text.Split(',');

            int viewerCount = int.Parse(parameteres[0]);
            double gradeSum = double.Parse(parameteres[1]);
            double maxGrade = double.Parse(parameteres[2]);
            int episodeNumber = int.Parse(parameteres[3]);
            TimeSpan epTime = TimeSpan.Parse(parameteres[4]);
            string epName = parameteres[5];

            Description description = new Description(episodeNumber, epTime, epName);
            Episode episode = new Episode(viewerCount, gradeSum, maxGrade, description);

            return episode;
             
        }
    }
}
