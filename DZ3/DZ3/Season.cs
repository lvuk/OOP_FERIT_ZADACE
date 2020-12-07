using System;
using System.Collections.Generic;
using System.Text;

namespace DZ3
{
    public class Season
    {
        Episode[] episodes;
        int seasonNum;

        public Season(int seasonNum, Episode[] episodes)
        {
            this.episodes = episodes;
            this.seasonNum = seasonNum;
        }

        public int Length { get => episodes.Length; }
        public Episode this[int episodeNumber]
        {
            get { return episodes[episodeNumber]; }
            set { episodes[episodeNumber] = value; }
        }

        private TimeSpan GetTotalDuration(Episode[] episodes)
        {
            TimeSpan totalDuration = new TimeSpan();

            foreach (var episode in episodes)
            {
                totalDuration += episode.Description.epTime;
            }

            return totalDuration;
        }

        private int GetTotalViewers(Episode[] episodes)
        {
            int totalViewers = 0;
            foreach (var episode in episodes)
            {
                totalViewers += episode.GetViewerCount();
            }

            return totalViewers;
        }

            public override string ToString()
        {
            string separator = "===================================";
            
            string episodes = string.Join<Episode>(Environment.NewLine, this.episodes);

            string season = $"Season:{seasonNum}";

            string viewers = $"Total viewers: {GetTotalViewers(this.episodes)}";

            string duration = $"Total duration: {GetTotalDuration(this.episodes)}";

            return season + "\n" + separator + "\n" + "Report:" + "\n" + separator + "\n" + viewers + "\n" + duration + "\n" + separator + "\n";

        }
    }
}
