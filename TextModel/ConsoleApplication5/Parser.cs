using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    public class Parser
    {
        private SeparatorContainer separatorContainer;
        private ISentenceItemFactory wordFactory;

        protected ISentenceItemFactory WordFactory
        {
            get { return wordFactory; }
            set { wordFactory = value; }
        }
        private ISentenceItemFactory punctuationFactory;

        protected ISentenceItemFactory PunctuationFactory
        {
            get { return punctuationFactory; }
            set { punctuationFactory = value; }
        }

        protected SeparatorContainer SeparatorContainer
        {
            get { return separatorContainer; }
            set { separatorContainer = value; }
        }



        public Text Parse(TextReader reader)
        {
            var orderedSentenceSeparators = SeparatorContainer.SentenceSeparators().OrderByDescending(x => x.Length);
            int bufferlength = 10000;
            Text textResult = new Text();
            StringBuilder buffer = new StringBuilder(bufferlength);

            buffer.Clear();
            string currentString = reader.ReadLine();
            while (currentString != null)
            {
                int firstSentenceSeparatorOccurence = -1;
                string firstSentenceSeparator = orderedSentenceSeparators.FirstOrDefault(
                    x =>
                    {
                        firstSentenceSeparatorOccurence = currentString.IndexOf(x);
                        return firstSentenceSeparatorOccurence >= 0;
                    });
                if (firstSentenceSeparator != null)
                {
                    buffer.Append(currentString.Substring(0, firstSentenceSeparatorOccurence + firstSentenceSeparator.Length));
                    textResult.Sentences.Add(this.ParseSentence(buffer.ToString()));
                    buffer.Clear();
                    buffer.Append(currentString.Substring(firstSentenceSeparatorOccurence + firstSentenceSeparator.Length + 1, currentString.Length));
                }
                else
                {
                    buffer.Append(" ");
                    buffer.Append(currentString);
                }
                currentString = reader.ReadLine();
            }
        }

        protected ISentence ParseSentence(string source)
        {
        }

        public Parser(SeparatorContainer separatorContainer)
        {
            this.SeparatorContainer = separatorContainer;
            this.WordFactory = new WordFactory();
            this.PunctuationFactory = new PunctuationFactory(this.SeparatorContainer);
        }
        
    }
}
