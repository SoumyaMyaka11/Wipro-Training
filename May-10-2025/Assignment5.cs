using System;

namespace ConsoleApp2
{
    class ChatBot
    {
        public void Respond(string greeting)
        {
            Console.WriteLine($"Hai , {greeting}");
        }

        public void Respond(string question , bool isCasual)
        {
            if(isCasual)
            {
                Console.WriteLine($"Let me help you with you question : {question}");
            }
            else
            {
                Console.WriteLine($"Okay I got your query : {question}");
            }
        }

        public void Respond(int num)
        {
            Console.WriteLine($"The solution  is : {num * num}");
        }
    }

    class Program
    {
        static void Main()
        {
            ChatBot bot = new ChatBot();
            bot.Respond("Good Morning");
            bot.Respond("expalin about collections in c#", true);
            bot.Respond(12);

       }
    }
}
