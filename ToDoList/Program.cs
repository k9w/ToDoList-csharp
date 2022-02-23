using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List!\nWould you like to add an item or view your list? (Please type add or view)");
      string response = Console.ReadLine();
      bool add = response == "add";
      bool view = response == "view";
      if (add)
      {
        Console.WriteLine("Please enter the description of your new item.");
        string description = Console.ReadLine();
        List<Item> newList = new List<Item> {  };
        newList.Add(new Item(description));
        Console.WriteLine("'" + description + "'" + " has been added to your list.");
        Main();
      }
      else if (view)
      {
        List<Item> result = Item.GetAll();
        foreach (Item thisItem in result)
        {
          Console.WriteLine("Your list items: " + thisItem.Description);
        }
        Main();
      }
    }
  }
}

