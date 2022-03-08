namespace TransferenciaBanc
{
    public class Account
    {
        private AccountType accountType { get; set; }
        private double Balance { get; set; }
        private double Credit { get; set; }
        private string Name { get; set; }

        //Construct method: it's created in the moment that I create my object
        public Account(AccountType account_type, double account_balance, double credit, string name)
        {
            this.accountType = account_type;
            this.Balance = account_balance;
            this.Credit = credit;
            this.Name = name;
        }

        public bool Withdraw(double wdAmount)
        {
            //Balance validation:
            //Confirming if my balance + my credit is more than the amount I'm trying to withdraw
            if (this.Balance - wdAmount < (this.Credit * -1))
            {
                System.Console.WriteLine("Insufficient Balance.");
                return false;
            }

            this.Balance -= wdAmount;
            System.Console.WriteLine("Process Finished.");
            System.Console.WriteLine($"{this.Name}'s Current Balance: {this.Balance}");
            return true;
        }

        public void Deposit(double depositAmount)
        {
            this.Balance += depositAmount;

            System.Console.WriteLine("Process Finished.");
            System.Console.WriteLine($"{this.Name}'s Current Balance: {this.Balance}");
        }

        public void DisplayBalance()
        {
            System.Console.WriteLine($"{this.Name}'s Current Balance: {this.Balance}");
        }

        //Transfer Method (5:33)
    }

    
}