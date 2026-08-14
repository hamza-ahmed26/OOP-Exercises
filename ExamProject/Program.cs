// Program.cs
using System;
using System.Collections.Generic;

namespace QuizProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Ahmed Ali", "ahmed@example.com", "12345");

            Quiz quiz1 = new Quiz("Football Quiz");

            List<string> options1 = new List<string>();
            options1.Add("Al Ahly");
            options1.Add("Zamalek");
            options1.Add("Al Ittihad");
            options1.Add("Pyramids");
            quiz1.CreateQuestion("Which club has won the most CAF Champions League titles?", options1, "Al Ahly");

            List<string> options2 = new List<string>();
            options2.Add("Red");
            options2.Add("White");
            options2.Add("Blue and White");
            options2.Add("Green");
            quiz1.CreateQuestion("What are the main colors of Zamalek's kit?", options2, "White");

            List<string> options3 = new List<string>();
            options3.Add("2018");
            options3.Add("2022");
            options3.Add("2026");
            options3.Add("2010");
            quiz1.CreateQuestion("In which year did Egypt host the AFCON tournament most recently before 2019?", options3, "2018");

            quiz1.TakeQuiz(quiz1.Questions);

            Console.WriteLine("Your score: " + quiz1.Score);
            Console.WriteLine();

            user1.TakenQuizzes.Add(quiz1);

            user1.ViewScores();
        }
    }
}