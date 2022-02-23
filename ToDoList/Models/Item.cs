using System;
using ToDoList;
namespace ToDoList
{
  public class ToDoList
  {
    public void CheckToDoList(string string1)
    {
      string reversedString;
      char[] charArray = string1.ToCharArray();
      Array.Reverse(charArray);
      reversedString = new string(charArray);
      bool isToDoList = string1.Equals(reversedString, StringComparison.OrdinalIgnoreCase);
      if (isToDoList == true)
      {
        Console.WriteLine(string1 + " is a ToDoList.");
      }
      else
      {
        Console.WriteLine(string1 + " is not a ToDoList.");
      }
    }
  }
}
