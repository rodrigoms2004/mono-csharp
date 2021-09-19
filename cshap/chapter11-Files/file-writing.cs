using System;
using System.IO;
using static System.Console;

namespace FileDemo {
  class Program {
    static void Main(string[] args) {
      // declaring the path to the file
      string path = "./myFile2.txt";

      // Writing to the file
      using(StreamWriter sw = new StreamWriter(path, true)) {
        sw.WriteLine("ABC");
        sw.WriteLine("DEF");
        sw.Close();
      }

      // Reading from the file
      if (File.Exists(path)) {
        using(StreamReader sr = new StreamReader(path)) {
          while (!sr.EndOfStream) {
            WriteLine(sr.ReadLine());
          }
          sr.Close();
        }
      }
      Read();
    } // end main
  } // end class
} // end namespace