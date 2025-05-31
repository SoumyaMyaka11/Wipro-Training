using System;
using System.Collections.Generic;

namespace ConsoleApp9
{
        class Question
        {
            public string Text { get; set; }
            public List<string> Options { get; set; }
            public int CorrectIndex { get; set; }

            public Question(string text, List<string> options, int correctIndex)
            {
                Text = text;
                Options = options;
                CorrectIndex = correctIndex;
            }

            public bool Ask()
            {
                Console.WriteLine(Text);
                for (int i = 0; i < Options.Count; i++)
                    Console.WriteLine($"{i + 1}. {Options[i]}");

                Console.Write("Your answer (1-4): ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice - 1 == CorrectIndex)
                    return true;
                return false;
            }
        }

        class Program
        {
            static void Main()
            {
                List<Question> questions = new List<Question>
            {
                new Question("What is the capital of India?", new List<string>{ "Berlin", "London", "New Delhi", "Rome" }, 2),
                new Question("Which planet is known as the Red Planet?", new List<string>{ "Earth", "Mars", "Jupiter", "Saturn" }, 1),
                new Question("Who wrote 'Hamlet'?", new List<string>{ "Shakespeare", "Homer", "Tolkien", "Dickens" }, 0),
            };

                var rand = new Random();
                int score = 0;

                foreach (var q in questions.OrderBy(_ => rand.Next()))
                {
                    if (q.Ask())
                    {
                        Console.WriteLine("Correct!\n");
                        score++;
                    }
                    else
                    {
                        Console.WriteLine(" Wrong!\n");
                    }
                }

                Console.WriteLine($"You scored {score} out of {questions.Count}.");
            }
        }
    }

