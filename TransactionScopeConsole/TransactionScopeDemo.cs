using Dapper;
using System;
using System.Data.SqlClient;
using System.Transactions;
using TransactionScopeConsole.Model;

namespace TransactionScopeConsole
{
  public class TransactionScopeDemo
  {
    public readonly string connString = "Server=localhost;Database=TransactionScopeDemo;Trusted_Connection=True;Integrated Security=True;";

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
          case "4":
            AddRelatedMulti();
            break;
          default:
            break;
        }
      }

    }

    private void AddRelatedMulti()
    {
      var query = @"INSERT INTO Delivery (SiteId, DeliveryDate, Content) VALUES (@SiteId, @DeliveryDate, @Content)";

      var site = new Site()
      {
        Address = "EF Site RelatedMulti"
      };


      try
      {
        using (var scope = new TransactionScope())
        {
          using (var context = new ApplicationDbContext())
          {
            context.Sites.Add(site);
            context.SaveChanges();
            Console.WriteLine("Added EF site.");
          }

          using (var conn = new SqlConnection(connString))
          {
            conn.Execute(query, new { site.SiteId, DeliveryDate = DateTime.Now, Content = "Some Product DP"});
            Console.WriteLine($"Added Dapper Delivery using SiteId: {site.SiteId}");
          }

          scope.Complete();
          Console.WriteLine("Scope Completed Successfully.");
        }
      }
      catch (Exception ex)
      {

        Console.WriteLine(ex.Message);
      }

      PrintMenu();

    }

    private void PrintMenu()
    {
      Console.WriteLine("-- -- -- Commands -- -- -- ");
      Console.WriteLine(Environment.NewLine);
      Console.WriteLine("[1] - Adds a single object using Entity Framework.");
      Console.WriteLine("[2] - Adds a single object using Dapper.");
      Console.WriteLine("[3] - Adds two objects. A Site using Execute (Dapper) and one using context.Sites.Add() (EF);");
      Console.WriteLine("[4] - Adds two related objects. A Site using context.Sites.Add() and a Delivery using Execute and the Site Id of the EF site.");
      Console.WriteLine(Environment.NewLine);
      Console.WriteLine("-- -- --   -- -- -- ");
      Console.WriteLine(Environment.NewLine);
      Console.WriteLine("'EXIT' - Closes the application ");
      Console.WriteLine(Environment.NewLine);
    }

    private void AddMulti()
    {
      var query = @"INSERT INTO Site (Address) VALUES (@Address)";

      var site = new Site()
      {
        Address = "EF Site Address"
      };


      try
      {
        using (var scope = new TransactionScope())
        {
          using (var context = new ApplicationDbContext())
          {
            context.Sites.Add(site);
            context.SaveChanges();
            Console.WriteLine("Added EF site.");
          }

          using (var conn = new SqlConnection(connString))
          {
            conn.Execute(query, new { Address = "DAPPER SITE ADDRESS" });
            Console.WriteLine("Added Dapper Site");
          }

          scope.Complete();
          Console.WriteLine("Scope Completed Successfully.");
        }
      }
      catch (Exception ex)
      {

        Console.WriteLine(ex.Message);
      }

      PrintMenu();
    }

    private void AddSingleDp()
    {
      try
      {
        var query = @" INSERT INTO Delivery (SiteId, DeliveryDate, Content) VALUES (@SiteId, @DeliveryDate, @Content)";

        using (var scope = new TransactionScope())
        {
          using (var conn = new SqlConnection(connString))
          {
            conn.Execute(query, new { SiteId = 9, DeliveryDate = DateTime.Now, Content = "Some Product" });
            Console.WriteLine("Query Complete!");
          }

          scope.Complete();
          Console.WriteLine("SUCCESS!");
        }
      }
      catch (Exception ex)
      {

        Console.WriteLine(ex.Message);
      }

      PrintMenu();
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
