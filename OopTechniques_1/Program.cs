using OopTechniques_1.Logger;

namespace OopTechniques_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test BankAccount
            var account = new BankAccount(100);

            account.Deposit(50);
            account.Withdraw(30);
            Console.WriteLine($"Account Balance: {account.Balance}");

            // Test Car and Motorcycle
            var car = new Car { Make = "Toyota", Model = "Corolla" };
            car.StartEngine();

            var motorcycle = new Motorcycle { Make = "Honda", Model = "CBR" };
            motorcycle.StartEngine();

            // Test ConsoleLogger
            var consoleLogger = new ConsoleLogger();
            consoleLogger.WriteToConsole("This is a console log.");

            // Test FileLogger
            var fileLogger = new FileLogger();
            fileLogger.WriteToFile("This is a file log.");
        }
    }


}
