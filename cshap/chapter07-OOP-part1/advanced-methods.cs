using System;
using System.Collections.Generic;
using static System.Console;


class program {
  static public int[] ReturnUserInput() {
    int [] a = new int[3];

    for (int i = 0; i < a.Length; i++) {
      Write("Enter an integer: ");
      a[i] = Convert.ToInt32(ReadLine());
      WriteLine("Integer added to array.\n");
    }
    return a;
  }

  static public List<int> ReturnUserInputList() {
    List<int> a = new List<int>();
    int input;
    for (int i = 0; i < 3; i++) {
      Write("Enter an integer: ");
      input = Convert.ToInt32(ReadLine());
      WriteLine("Integer added to list.\n");
      a.Add(input);
    }
    return a;
  }
  static void Main(string[] args) {
    WriteLine("ARRAY");
    
    int[] myArray = ReturnUserInput();

    foreach (int item in myArray) {
      WriteLine(item);
    }

    WriteLine("\nLIST");

    List<int> myList = ReturnUserInputList();

    foreach (int item in myList) {
      WriteLine(item);
    }
  }
}