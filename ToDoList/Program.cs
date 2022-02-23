using System;
using ToDoList;
namespace ToDoListProgram
{
  public class Program
  {
    public static void Main(string[] args)
    {      
      string input;
      Console.WriteLine("Enter a word to check if it's a ToDoList.");
      input = Console.ReadLine();
      
      ToDoList ToDoList = new ToDoList();

      Console.WriteLine(ToDoList.CheckToDoList(input));

      
    }
  }
}

