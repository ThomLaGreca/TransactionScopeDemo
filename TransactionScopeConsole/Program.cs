using System;

namespace TransactionScopeConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("This project is to simple test/show the validity of using Dapper and Ef in the same transaction scope.");

      TransactionScopeDemo demo = new TransactionScopeDemo();

      demo.Run();
    }
  }
}
