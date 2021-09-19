using System;

namespace array_test {
  class array_test {

    static void Main(string[] args) {
      
      int[] userAge = {21, 22, 23, 24, 25};
      int[] userAge2;
      userAge2 = new[]{21, 22, 23, 24, 25};
      userAge2[0] = 31;
      userAge2[2] += 20;


      // Length
      for (int i = 0; i < userAge2.Length; ++i) {
        Console.WriteLine(userAge2[i]);
      }

      Console.WriteLine("\n");

      // Copy()
      int [] source = {12, 1, 5, -2, 16, 14};
      int [] dest = {1, 2, 3, 4};

      Array.Copy(source, dest, 3);

      foreach (int i in dest) {
        Console.WriteLine(i);
      }

      Console.WriteLine("\n");

      // Sort()
      int [] numbers = {12, 1, 5, -2, 16, 14};

      Array.Sort(numbers);
      foreach (int i in numbers) {
        Console.WriteLine(i);
      }
      Console.WriteLine("\n");

      // IndexOf()
      int [] numbers1 = {10, 30, 44, 21, 51, 21, 61, 24, 14};

      int ans = Array.IndexOf(numbers1, 21); // 3
      Console.WriteLine(ans);

      ans = Array.IndexOf(numbers1, 100); // -1
      Console.WriteLine(ans);

    }
  }
}