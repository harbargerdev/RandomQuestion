using System.Collections.Generic;

namespace RandomQuestion.Core.Entities
{
    public class Questionaire
    {
        public QuestionBank QuestionBank { get; set; }
        public List<Question> Questions { get; set; }
        public int QuestionCount { get; set; }
    }
}
