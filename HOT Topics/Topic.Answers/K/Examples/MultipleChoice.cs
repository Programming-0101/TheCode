using System;
using System.Linq;

namespace Topic.K.Examples
{
    public class MultipleChoice
    {
        // ![](94FE4E90AD15B1F0EA92DC623228E628.png)
        public enum Answer { NOT_ANSWERED, A, B, C, D, E }

        public Answer Choice { get; set; }
        public MultipleChoice(Answer choice)
        {
            Choice = choice;
        }
        public MultipleChoice()
        {
        }
    }
}
