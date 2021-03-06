using System;

namespace Quiz.Messages
{
    public class QuizStartedEvent
    {
        public Guid QuizId { get; }

        public QuizModel QuizModel { get; }

        public QuizStartedEvent(Guid quizId, QuizModel quizModel)
        {
            QuizId = quizId;
            QuizModel = quizModel;
        }
    }
}