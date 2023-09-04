using System;
using System.Collections.Generic;

class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public int Answer { get; set; }

    public Question(string text, List<string> options, int answer)
    {
        Text = text;
        Options = options;
        Answer = answer;
    }

    public void PrintQuestion()
    {
        Console.WriteLine(Text);
        for (int i = 0; i < Options.Count; i++)
        {
            Console.WriteLine("{0}. {1}", i + 1, Options[i]);
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
            Console.WriteLine("Question {0}:", questions.IndexOf(question) + 1);
            question.PrintQuestion();
            Console.Write("Enter your answer: ");
            int answer = int.Parse(Console.ReadLine());

            if (answer == question.Answer)
            {
                score++;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }
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
            Console.WriteLine();
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
        Question question1 = new Question("What is the capital of France?", options1, 3);
        quiz.AddQuestion(question1);

        List<string> options2 = new List<string>() { "Red", "Green", "Blue", "Yellow" };
        Question question2 = new Question("What color is a stop sign?", options2, 1);
        quiz.AddQuestion(question2);

        List<string> options3 = new List<string>() { "10", "20", "30", "40" };
        Question question3 = new Question("What is 5 x 4?", options3, 3);
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