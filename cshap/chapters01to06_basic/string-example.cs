using System;

namespace string_code {

  class string_code {
    static void Main(string[] args) {
      string message = "Hello World..." + " an ordinary one";
      Console.WriteLine(message);
      Console.WriteLine("This is SCADA!!!".Length); // 16

      // Substring
      string newMessage = message.Substring(2, 5);
      Console.WriteLine(newMessage); // llo W
      Console.WriteLine("\n");

      // Equals()
      string firstString = "This is Jamie";
      string secondString = "Hello";

      Console.WriteLine(firstString.Equals("This is Jamie"));   // True
      Console.WriteLine(secondString.Equals("This is Jamie"));  // False
      Console.WriteLine("\n");

      // Split()
      string [] separator = {", ", "; "};
      string names = "Peter, John; Andy, , David";
      string [] substrings = names.Split(separator, StringSplitOptions.RemoveEmptyEntries); //StringSplitOptions.None);

      Console.WriteLine(substrings.Length);
      foreach (string str in substrings) {
        Console.WriteLine(str);
      }
      
      Console.WriteLine("\n");
    }
  }
}