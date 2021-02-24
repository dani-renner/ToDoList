using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to the To Do List.");
      Console.WriteLine("Would you like to add an item to your list or view your list? (type add, view or remove)");
      string userInput = Console.ReadLine();

      if (userInput == "add")
      {
        Console.WriteLine("Please enter the description for the new item:");
        string userItem = Console.ReadLine();
        Item newItem1 = new Item(userItem);
        Main();
      }
      else if (userInput == "remove")
      {
        List<Item> result = Item.GetAll();
        Console.WriteLine("Please type the item description that you want to remove. Please type exact");
        string userRemove = Console.ReadLine();
        Item removedItem = null;
        foreach (Item thisItem in result)
        {
          if (thisItem.Description == userRemove)
          {
            removedItem = thisItem;
          }
        }
        result.Remove(removedItem);
        Main();
      }
      else if (userInput == "view")
      {
        List<Item> result = Item.GetAll();
        if (result.Count == 0)
        {
          Console.WriteLine("You haven't added anything to your To-Do List");
          Main();
        }
        else
        {
          foreach (Item thisItem in result)
          {
            Console.WriteLine(thisItem.Description);
          }
        }
      }
    }
  }
}