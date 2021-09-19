using System;
using System.IO;
using static System.Console;


namespace file_handling {
  class Program {
    static void Main(string[] args) {
      string path = "./myFileWrong.txt";

      if (File.Exists(path)) {
        using (StreamReader sr = new StreamReader(path)) {
          while (sr.EndOfStream != true) {
            WriteLine(sr.ReadLine());
          }
          sr.Close();
        }
      } else {
        WriteLine("File not found!!!");
      }
    } // end main
  } // end class
} // end namespace