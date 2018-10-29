using Dapper;
using System;
using System.Data.SqlClient;
using System.Transactions;
using TransactionScopeConsole.Model;

namespace TransactionScopeConsole
{
  public class TransactionScopeDemo
  {
    public readonly string connString = "Server=localhost;Database=TransactionScopeDemo;Trusted_Connection=True;Integrated Security=True;"

    public void Run()
    {
      string input = string.Empty;

      PrintMenu();



      while (input != "EXIT")
      {
        input = Console.ReadLine();

        switch (input)
        {
          case "1":
            AddSingleEF();
            break;
          case "2":
            AddSingleDp();
            break;
          case "3":
            AddMulti();
            break;
          default:
            break;
        }
      }

    }

    private void PrintMenu()
    {
      Console.WriteLine("-- -- -- Commands -- -- -- ");
      Console.WriteLine("[1] - Adds a single object using Entity Framework.");
      Console.WriteLine("[2] - Adds a single object using Dapper.");
      Console.WriteLine("[3] - Adds two objects. A Site using Dapper.Query<T> and Delivery using context.Deliveries.Add().");
      Console.WriteLine("-- -- --   -- -- -- ");
      Console.WriteLine("'EXIT' - Closes the application ");
    }

    private void AddMulti()
    {
      Console.WriteLine("NOT YET");
    }

    private void AddSingleDp()
    {
      var query = @" INSERT INTO Delivery (SiteId, DeliveryDate, Content) VALUES (@siteId, @DeliveryDate, @content)";

      var delivery = new Delivery()
      {
        SiteId = 9,
        DeliveryDate = DateTime.Now,
        Content = "Some Product"
      };

      using (var scope = new TransactionScope())
      {
        using (var conn = new SqlConnection(connString))
        {
          conn.Execute(query, new { SiteId = 9, DeliveryDate = DateTime.Now, Content = "Some Product" });
        }
      }

    }

    private void AddSingleEF()
    {
      try
      {
        var site = new Site()
        {
          Address = "1 Test Ave TESTVILLE, TST 6666"
        };
        using (var scope = new TransactionScope())
        {
          using (var context = new ApplicationDbContext())
          {
            context.Sites.Add(site);
            context.SaveChanges();
            Console.WriteLine($"Site Created: SiteId - {site.SiteId}");
          }

          scope.Complete();

          Console.WriteLine("SUCCESS!!");
        }
      }
      catch (Exception ex)
      {

        Console.WriteLine(ex.Message);
      }

      PrintMenu();
    }
  }
}
