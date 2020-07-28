using System;

namespace RandomQuestion.Core.Entities
{
    public class Question
    {
        public Guid QuestionId { get; set; }
        public Guid QuestionBankId { get; set; }
        public string QuestionText { get; set; }
    }
}
