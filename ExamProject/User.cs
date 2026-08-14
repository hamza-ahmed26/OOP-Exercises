using System;
using System.Collections.Generic;

namespace QuizProject
{
    internal class User
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public List<Quiz> TakenQuizzes { get; private set; }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            TakenQuizzes = new List<Quiz>();
        }

        public void ViewScores()
        {
            Console.WriteLine("Scores for " + Name + ":");

            for (int i = 0; i < TakenQuizzes.Count; i++)
            {
                Quiz quiz = TakenQuizzes[i];
                Console.WriteLine(quiz.QuizName + " - Score: " + quiz.Score);
            }
        }
    }
}