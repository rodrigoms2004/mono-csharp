using System;

using static System.Console;

class MethodDemo {
  public void PassByValue(int a) {
    a = 10;
    WriteLine("a inside method = {0}", a);
  }

  public void PassByReference(int[] b) {
    b[0] = 5;
    WriteLine("b[0] inside method = {0}", b[0]);
  }
}

class program {
  static void Main(string[] args) {
    int a = 2;
    int[] b = {1, 2, 3};
    MethodDemo obj = new MethodDemo();

    WriteLine("a before = {0}", a);
    obj.PassByValue(a);
    WriteLine("a after = {0}", a);

    WriteLine("\n\n");
    
    WriteLine("b[0] before = {0}", b[0]);
    obj.PassByReference(b);
    WriteLine("b[0] after = {0}", b[0]);
  }
}

// Output
// a before = 2
// a inside method = 10
// a after = 2



// b[0] before = 1
// b[0] inside method = 5
// b[0] after = 5