using System;

namespace Episode1
{
    public class Episode
    {
        private int viewerCount;
        private double gradeSum;
        private double maxGrade;
       
        public Episode(int viewerCount, double gradeSum, double maxGrade)
        {
            this.viewerCount = viewerCount;
            this.gradeSum = gradeSum;
            this.maxGrade = maxGrade;

        }

        public Episode()
        {
        }

        public void AddView(double randNum)
        {
            viewerCount++;
            gradeSum += randNum;
            if (randNum > maxGrade)
                maxGrade = randNum;

        }

        public double GetViewerCount()
        {
            return viewerCount;
        }

        public double GetAverageScore()
        {
            return gradeSum / viewerCount;
        }

        public double GetMaxScore()
        {
            return maxGrade;
        }
    }
}
