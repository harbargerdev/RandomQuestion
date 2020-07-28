using RandomQuestion.Core.Entities;
using System;
using System.Collections.Generic;

namespace RandomQuestion.Core.Utilities
{
    public interface IQuestionUtility
    {
        /// <summary>
        /// Method that randomizes questions from the question bank and assigns it to the Questions property
        /// </summary>
        /// <param name="questionaire">The questionaire to be randomized</param>
        void RandomizeQuestions(Questionaire questionaire);
    }

    public class QuestionUtility : IQuestionUtility
    {
        public void RandomizeQuestions(Questionaire questionaire)
        {
            // Verify inputs
            if (questionaire.QuestionCount == 0 
                || questionaire.QuestionBank.Questions == null
                || questionaire.QuestionBank.Questions.Count == 0)
                return;

            var random = new Random();
            var questions = new List<Question>();
            var initialList = new List<Question>(questionaire.QuestionBank.Questions);

            for (int i = 0; i < questionaire.QuestionCount; i++)
            {
                var position = random.Next(0, initialList.Count - 1);
                questions.Add(initialList[position]);
                initialList.RemoveAt(position);
            }
        }
    }
}
