using System;
Main();

void Main()
            {
                Console.WriteLine("Welcome to the Magic Moose!");


                while (true)
                {
                    MooseSays("Ask a question.");
                    string userQuestion = Console.ReadLine(); 

                if (userQuestion.Length == 0)
                {
                    break;
                }
                
                
                Random r = new Random();
                int genRandom = r.Next(0,20);

            string[] magicMooseResponse =
            {
                "As I see it, yes.",
                "Ask again later.",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don’t count on it.",
                "It is certain.",
                "It is decidedly so.",
                "Most likely.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Outlook good.",
                "Reply hazy, try again.",
                "Signs point to yes.",
                "Very doubtful.",
                "Without a doubt.",
                "Yes.",
                "Yes – definitely.",
                "You may rely on it."
                };
            

            string response = magicMooseResponse[genRandom];
            MooseSays(response);
        }}

        void MooseSays (string message)
        {Console.WriteLine ($@"{message}");}