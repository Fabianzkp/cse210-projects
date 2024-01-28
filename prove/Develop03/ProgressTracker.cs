namespace ScriptureApp
{
    public class ProgressTracker
    {
        private int totalWords;
        private int wordsHidden;

        public ProgressTracker(int totalWords)
        {
            this.totalWords = totalWords;
            wordsHidden = 0;
        }

        public void UpdateProgress(int wordsHidden)
        {
            this.wordsHidden += wordsHidden;
        }

        public double GetProgressPercentage()
        {
            return (double)wordsHidden / totalWords * 100;
        }
    }
}
