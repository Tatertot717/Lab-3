using System;
using System.Collections.Generic;


class Program
{
    public static void Main(string[] args)
    {
        Quiz quiz = new Quiz();
        while (true)
        {
            quiz.user();
            Console.WriteLine("\n");
        }
    }
}

class Quiz
{
    public static List<Question> questionBank = new List<Question>();


    public Quiz() { }

    public void add_question() {
      Console.WriteLine("\nWhat is the question Text?");
                string a = Console.ReadLine();
                Console.WriteLine("What is the answer?");
                string b = Console.ReadLine();
                Console.WriteLine("How Difficult (1-3)?");
                int c = Convert.ToInt16(Console.ReadLine());


                Question questionToAdd = new Question(a, b, c);

                questionBank.Add(questionToAdd); }

    public void remove_question() { 
      if(questionBank.Count==0){
                  Console.WriteLine("There are no questions to remove!\n");
                }
      else{}
      Console.WriteLine("Choose the question to remove?\n");
                Int32 i = 1;
                foreach (Question question in questionBank)
                {
                    Console.WriteLine(i + ": " + question.questionText);
                    i++;
                }
                i = (Convert.ToInt16(Console.ReadLine()))-1;
      questionBank.RemoveAt(i);
      
      }

    public void modify_question() {
      if(questionBank.Count==0){
                  Console.WriteLine("There are no questions to modify!\n");
                  
                }
      else{
                Console.WriteLine("Choose the question to modify?\n");
                Int32 i = 1;
                foreach (Question question in questionBank)
                {
                    Console.WriteLine(i + ": " + question.questionText);
                    i++;
                }
                i = (Convert.ToInt16(Console.ReadLine()))-1;
                Console.WriteLine("\nWhat is the question Text?");
                questionBank[i].questionText = Console.ReadLine();
                Console.WriteLine("What is the answer?");
                questionBank[i].answer = Console.ReadLine();
                Console.WriteLine("How Difficult (1-3)?");
                questionBank[i].difficulty = Convert.ToInt16(Console.ReadLine());
    }}

    public void give_question() {
int correct = 0;
foreach (Question question in questionBank)
                {
                    Console.WriteLine(question.questionText+"\n");
                  if(question.questionText.Equals(Console.ReadLine()){
                    correct++;
                     Console.WriteLine("Correct!\n");
                  }
                  else{
                    Console.WriteLine("Incorrect!\n");
                  }
                }
Console.WriteLine("You got "+correct.ToString()+" out of "+questionBank.Count.ToString());
      
    }

    public void user()
    {
        Console.WriteLine("1. Add a question to the quiz\n2. Remove a question from the quiz\n3. Modify a question in the quiz\n4. Take the quiz\n5. Quit");
        int choice = Convert.ToInt16(Console.ReadLine());
        switch (choice)
        {
            default:
                System.Environment.Exit(0);
                break;

            case 1:
                add_question();
                break;

            case 2:
                remove_question();
                break;

            case 3:
                modify_question();
                break;

            case 4:
                give_question();
                break;


        }



    }

}

class Question
{
    private static int count = 0;
    private int id;
    public String questionText { get; set; }
    public String answer { get; set; }
    public int difficulty { get; set; }

    public Question(string questionText, string answer, int diffictulty)
    {
        id = count++;
        this.questionText = questionText;
        this.answer = answer;
        this.difficulty = diffictulty;
    }

}