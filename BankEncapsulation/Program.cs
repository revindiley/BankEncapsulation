namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            Console.WriteLine("Enter amount you'd like to deposit");
            double amountToDeposit = double.Parse(Console.ReadLine());

            myAccount.Deposit(amountToDeposit);
            double userBalance = myAccount.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance,0:c}");
 
        }
    }
}
