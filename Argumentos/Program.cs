using System;

namespace Argumentos
{
  /// <summary>
  /// This is a really cool program!
  /// </summary>

  class Program
  {
    /// <summary>
    /// Program starts here.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    static void Main(string[] args)
    {
      for (int i = 0; i < args.Length; i++)
      {
        // This will write argument in console
        Console.WriteLine(args[i]);
      }
    }
  }
}