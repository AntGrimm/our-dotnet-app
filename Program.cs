using System;

namespace our_dotnet_app
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to my program!");
      Console.Write("\n");

      Console.Write("What is your name? ");
      var name = Console.ReadLine();

      Console.WriteLine($"It is a pleasure to meet you, {name}.");
    }
  }
}
