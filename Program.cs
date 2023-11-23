using lab1;
using System.Configuration;
using System.Web;

internal class Program
{
    private static void Main(string[] args)
    {
        PrintWelcomeUser();
        PrintWaitUser();
        PrintGoodByeUser();
    }

    private static void PrintWelcomeUser()
    {
        Console.WriteLine(Resource1.Welcome + ConfigurationManager.AppSettings.Get("Name"));
    }
    private static void PrintWaitUser()
    {
        Console.WriteLine(Resource1.Wait);
        Console.ReadLine();
    }
    
    private static void PrintGoodByeUser()
    {
        Console.WriteLine(Resource1.GoodBye + ConfigurationManager.AppSettings.Get("Name"));
    }
}