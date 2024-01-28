using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ScriptureApp
{
    public class Scripture
    {
        private List<Word> words;
        private int hiddenWordCount;
        private ProgressTracker progressTracker;

        public bool AllWordsHidden => hiddenWordCount == words.Count;

        public ScriptureReference Reference { get; }
        public string Text => string.Join(" ", words.Select(w => w.IsHidden ? "_____" : w.Text));

        public Scripture(string reference, string text, ProgressTracker progressTracker)
        {
            Reference = new ScriptureReference(reference);
            InitializeWords(text);
            this.progressTracker = progressTracker;
        }

        private void InitializeWords(string text)
        {
            string[] wordArray = text.Split(' ');
            words = wordArray.Select(word => new Word(word)).ToList();
            hiddenWordCount = 0;
        }

        public void HideRandomWords()
        {
            Random random = new Random();
            int wordsToHide = Math.Min(2, words.Count - hiddenWordCount);

            for (int i = 0; i < wordsToHide; i++)
            {
                int randomIndex = random.Next(words.Count);
                if (!words[randomIndex].IsHidden)
                {
                    words[randomIndex].IsHidden = true;
                    hiddenWordCount++;
                }
            }

            // Update progress tracker
            progressTracker.UpdateProgress(wordsToHide);
        }

        public void Display()
        {
            Console.Clear();
            Console.WriteLine($"{Reference.Reference}: {Text}    Progress: {progressTracker.GetProgressPercentage():F2}%");
        }
    }
}
