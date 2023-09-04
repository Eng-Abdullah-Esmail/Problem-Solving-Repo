using System;
using System.Collections.Generic;
using System.Threading;

class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public int Answer { get; set; }
    public int TimeLimit { get; set; }

    public Question(string text, List<string> options, int answer, int timeLimit)
    {
        Text = text;
        Options = options;
        Answer = answer;
        TimeLimit = timeLimit;
    }

    public void PrintQuestion()
    {
        Console.WriteLine(Text);
        for (int i = 0; i < Options.Count; i++)
        {
            Console.WriteLine("{0}. {1}", i + 1, Options[i]);
        }
        Console.WriteLine();
    }

    public int TakeQuestion()
    {
        Console.WriteLine("You have {0} seconds to answer this question.", TimeLimit);
        Console.WriteLine();
        PrintQuestion();

        Thread.Sleep(TimeLimit * 1000);

        Console.Write("Enter your answer: ");
        int answer = int.Parse(Console.ReadLine());

        if (answer == Answer)
        {
            Console.WriteLine("Correct!");
            return 1;
        }
        else
        {
            Console.WriteLine("Incorrect.");
            return 0;
        }
    }
}

class Quiz
{
    private List<Question> questions;

    public Quiz()
    {
        questions = new List<Question>();
    }

    public void AddQuestion(Question question)
    {
        questions.Add(question);
        Console.WriteLine("Question added to the quiz.");
    }

    public void RemoveQuestion(Question question)
    {
        questions.Remove(question);
        Console.WriteLine("Question removed from the quiz.");
    }

    public void TakeQuiz()
    {
        int score = 0;
        int total = questions.Count;

        foreach (Question question in questions)
        {
            score += question.TakeQuestion();
        }

        Console.WriteLine("Quiz complete. You scored {0} out of {1}.", score, total);
    }

    public void PrintQuestions()
    {
        Console.WriteLine("Quiz Questions:");
        Console.WriteLine("------------------");

        foreach (Question question in questions)
        {
            question.PrintQuestion();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new quiz object
        Quiz quiz = new Quiz();

        // Add some questions to the quiz
        List<string> options1 = new List<string>() { "A", "B", "C", "D" };
        Question question1 = new Question("What is the capital of France?", options1, 3, 10);
        quiz.AddQuestion(question1);

        List<string> options2 = new List<string>() { "Red", "Green", "Blue", "Yellow" };
        Question question2 = new Question("What color is a stop sign?", options2, 1, 15);
        quiz.AddQuestion(question2);

        List<string> options3 = new List<string>() { "10", "20", "30", "40" };
        Question question3 = new Question("What is 5 x 4?", options3, 3, 20);
        quiz.AddQuestion(question3);

        // Print the quiz questions
        quiz.PrintQuestions();

        // Take the quiz
        quiz.TakeQuiz();

        // Remove a question and print the modified quiz questions
        quiz.RemoveQuestion(question2);
        quiz.PrintQuestions();



        Console.ReadKey();

    }
}