using System;
using System.Collections.Generic;

namespace lists_example {
  class list_tools {

    public void printList<T>(ref List<T> lst) {
      foreach (T item in lst) {
        Console.WriteLine(item);
      }
    }
  }

  class program {

    static void Main(string[] args) {

      var listObject = new list_tools();

      // List<int> userAgentList = new List<int>();
      List<int> userAgentList = new List<int> {11, 21, 31, 41};

      // Add()
      userAgentList.Add(51);
      userAgentList.Add(61);

      // Count
      Console.WriteLine("Count: " + userAgentList.Count);

      // Insert()
      userAgentList.Insert(2, 51);

      // Remove()
      userAgentList.Remove(51);

      // RemoveAt()
      userAgentList.RemoveAt(3);

      // Contains()
      bool ans = userAgentList.Contains(51); // True
      Console.WriteLine(ans);
      ans = userAgentList.Contains(81); // False
      Console.WriteLine(ans);
      
      listObject.printList<int>(ref userAgentList);

      // Clear()
      userAgentList.Clear();
      Console.WriteLine("Clearing all");
      listObject.printList<int>(ref userAgentList);

    }

  }
}