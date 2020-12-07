using System;
using System.Collections.Generic;
using System.Text;

namespace DZ3
{
    public class Description
    {
        public int episodeNumber { get; private set; }
        public TimeSpan epTime { get; private set; }
        public string epName { get; private set; }

        public Description(int episodeNumber, TimeSpan epTime, string epName)
        {
            this.episodeNumber = episodeNumber;
            this.epTime = epTime;
            this.epName = epName;
        }

        public override string ToString()
        {
            return $"{episodeNumber},{epTime},{epName}";
        }
    }
}