using System;
using System.Collections.Generic;
namespace QuizProject
{
    internal class Quiz
    {
        public string QuizName { get; private set; }
        public int NumberOfQuestions { get; private set; }
        public double Score { get; private set; }
        public List<Question> Questions { get; private set; }

        public Quiz(string quizName)
        {
            QuizName = quizName;
            NumberOfQuestions = 0;
            Score = 0;
            Questions = new List<Question>();
        }

        public void CreateQuestion(string questionText, List<string> answerOptions, string correctAnswer)
        {
            Question newQuestion = new Question(questionText, answerOptions, correctAnswer);
            Questions.Add(newQuestion);
            NumberOfQuestions = Questions.Count;
        }

        public void TakeQuiz(List<Question> questions)
        {
            int correctCount = 0;

            foreach (var question in questions)
            {
                Console.WriteLine(question.QuestionText);

                for (int i = 0; i < question.AnswerOptions.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + question.AnswerOptions[i]);
                }

                Console.Write("Your answer (number): ");
                string userInput = Console.ReadLine();

                int choice;
                bool isNumber = int.TryParse(userInput, out choice);

                if (isNumber && choice >= 1 && choice <= question.AnswerOptions.Count)
                {
                    string selectedAnswer = question.AnswerOptions[choice - 1];

                    if (selectedAnswer == question.CorrectAnswer)
                    {
                        correctCount++;
                    }
                }

                Console.WriteLine();
            }

            if (questions.Count > 0)
            {
                Score = (correctCount * 100) / questions.Count;
            }
            else
            {
                Score = 0;
            }
        }
    }
}