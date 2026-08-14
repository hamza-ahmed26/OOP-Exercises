using System;
using System.Collections.Generic;
namespace QuizProject
{
    internal class Question
    {
        public string QuestionText { get; private set; }
        public List<string> AnswerOptions { get; private set; }
        public string CorrectAnswer { get; private set; }

        public Question(string questionText, List<string> answerOptions, string correctAnswer)
        {
            QuestionText = questionText;
            AnswerOptions = answerOptions;
            CorrectAnswer = correctAnswer;
        }
    }
}