using System;


namespace DZ3
{
    public class Episode
    {
        private int viewerCount;
        private double gradeSum;
        private double maxGrade;
        Description description;

    public Episode(int viewerCount, double gradeSum, double maxGrade)
        {

            this.viewerCount = viewerCount;
            this.gradeSum = gradeSum;
            this.maxGrade = maxGrade;
        }

        public Episode()
        {
            viewerCount = 0;
            gradeSum = 0;
            maxGrade = 0;
            description = null;
        }

        public Episode(int viewerCount, double gradeSum, double maxGrade, Description description)
        {
            this.description = description;
            this.viewerCount = viewerCount;
            this.gradeSum = gradeSum;
            this.maxGrade = maxGrade;
        }

        public Description Description { get => description; }

         
    public void AddView(double randNum)
        {
            viewerCount++;
            gradeSum += randNum;
            if (randNum > maxGrade)
                maxGrade = randNum;

        }

        public int GetViewerCount()
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
        public override string ToString()
        {
            return $"{viewerCount}, {gradeSum}, {maxGrade}, {description}";
        }

        public static bool operator >(Episode epOne, Episode epTwo)
        {
            return epOne.GetAverageScore() > epTwo.GetAverageScore();
        }
        public static bool operator <(Episode epOne, Episode epTwo)
        {
            return epOne.GetAverageScore() < epTwo.GetAverageScore();
        }
    }
}
