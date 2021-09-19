using System;
using System.IO;
using static System.Console;


namespace file_handling {
  class Program {
    static void Main(string[] args) {
      string path = "./myFile.txt";
      using (StreamReader sr = new StreamReader(path)) {
        while (sr.EndOfStream != true) {
          WriteLine(sr.ReadLine());
        }
        sr.Close();
      }
    } // end main
  } // end class
} // end namespace