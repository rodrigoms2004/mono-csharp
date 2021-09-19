using System;
using System.IO;
using static System.Console;


namespace file_handling {
  class Program {
    static void Main(string[] args) {
      string path = "./myFileWrong.txt";
      try {
        using (StreamReader sr = new StreamReader(path)) {
          while (sr.EndOfStream != true) {
            WriteLine(sr.ReadLine());
          }
          sr.Close();
        }
      } catch (FileNotFoundException e) {
        WriteLine(e.Message);
      }

    } // end main
  } // end class
} // end namespace