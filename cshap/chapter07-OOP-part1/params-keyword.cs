using System;

using static System.Console;

class program {
  static public void PrintNames(params string[] names) {
    for (int i = 0; i < names.Length; i++) {
      Write(names[i] + " ");
    }
    WriteLine();
  }
  static void Main(string[] args) {
    PrintNames("Peter");
    PrintNames("Yvonne", "Jamie");
    PrintNames("Abigail", "Betty", "Carol", "David");
  }
}

// Output:
// Peter 
// Yvonne Jamie 
// Abigail Betty Carol David