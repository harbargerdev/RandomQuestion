using System;
using System.Collections.Generic;

namespace RandomQuestion.Core.Entities
{
    public class QuestionBank
    {
        public Guid QuestionBankId { get; set; }
        public List<Question> Questions { get; set; }
        public bool IsPublic { get; set; }
    }
}
