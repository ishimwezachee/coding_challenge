using System;

class QuizApplication {
    static void Main(string[] args) {
        string[] questions = {
            "What is the capital City of Rwanda?",
            "How many districts in Rwanda?",
            "How many sectors do we have Rwanda?",
            "What is the smallest country in the world?",
            "What is the tallest mountain in the world?"
        };

        string[][] options = {
            new [] { "Nyagatare", "Huye", "Kigali", "Kampala" },
            new [] { "ten", "twenty", "Thirty", "Fifty" },
            new [] { "Four hundred", "Two hundrend", "One hundred", "Four hundred and sixteen" },
            new [] { "Vatican City", "Monaco", "San Marino", "Liechtenstein" },
            new [] { "Mount Everest", "K2", "Kangchenjunga", "Lhotse" }
        };

        string[] answers = {
            "Kigali",
            "30",
            "Four hundred and sixteen",
            "Vatican City",
            "Mount Everest"
        };

        Random random = new Random();
        int score = 0;

        for (int i = 0; i < questions.Length; i++) {
            int index = random.Next(options[i].Length);
            Console.WriteLine(questions[i]);
            for (int j = 0; j < options[i].Length; j++) {
                Console.WriteLine($"{j + 1}. {options[i][(j + index) % options[i].Length]}");
            }

            Console.Write("Your answer: ");
            int answer = int.Parse(Console.ReadLine());

            if (options[i][(answer - 1 + index) % options[i].Length] == answers[i]) {
                score++;
            }
            Console.Clear();
        }

        Console.WriteLine($"Your final score is {score} out of {questions.Length}");
    }
}
