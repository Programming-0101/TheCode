using System;
using System.Collections.Generic;
using System.Linq;

namespace Topic.K.Examples
{
    public class MultipleChoiceMarker
    {
        private List<MultipleChoice> Key { get; set; }

        public MultipleChoiceMarker(List<MultipleChoice> key)
        {
            if (key == null)
                throw new Exception("Answer key cannot be null");
            this.Key = key;
        }

        public Mark MarkExam(List<MultipleChoice> examAnswers)
        {
            if (examAnswers == null)
                throw new Exception("Cannot mark null answers");
            if (examAnswers.Count != Key.Count)
                throw new Exception(
                        "The number of student answers does not match the number of items in the answer key");
            int possible = Key.Count;
            int earned = 0;
            // Calculate earned marks
            for (int index = 0; index < Key.Count; index++)
            {
                if (examAnswers[index] != null)
                    if (Key[index].Choice == examAnswers[index].Choice)
                        earned++;
            }
            Mark examMark = new Mark(earned, possible);
            return examMark;
        }

        public int Count
        {
            get
            {
                return Key.Count;
            }
        }
    }
}
