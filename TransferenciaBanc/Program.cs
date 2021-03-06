using System;

namespace TransferenciaBanc
{
    class Program
    {
        //Essa lista de contas vai sumir assim que o programa fechar
        static List<Account> listAccount = new List<Account>();
        static void Main (string[] args)
        {
            // Account myAccount = new Account(AccountType.NaturalPerson, 70, 490, "Renata dos Santos Pinto");System.Console.WriteLine(myAccount.ToString());

            string userOption = GeneralMenu();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        AccountsList();
                        break;
                    case "2":
                        CreateAccount();
                        break;
                    case "3":
                        WithdrawMethod();
                        break;
                    case "4":
                        DepositMethod();
                        break;
                    case "5":
                        TransferMethod();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = GeneralMenu();

            }

            System.Console.WriteLine("Thank you for choosing our services.");
            Console.ReadLine();

        }

        private static void WithdrawMethod()
        {
            System.Console.Write("Inform the Account Number: ");
            int accountIndex = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Inform the amount: ");
            double amountWithdraw = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine();
            listAccount[accountIndex].Withdraw(amountWithdraw);
            System.Console.WriteLine();
        }

        private static void DepositMethod()
        {
            System.Console.Write("Inform the Account Number: ");
            int accountIndex = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Inform the amount: ");
            double amountDeposit = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine();
            listAccount[accountIndex].Deposit(amountDeposit);
            System.Console.WriteLine();
        }

        private static void TransferMethod()
        {
            System.Console.Write("From (Account Number): ");
            int indexAccountFrom = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("To (Account Number): ");
            int indexAccountTo = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Inform the amount: ");
            double amountTransfer = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine();
            listAccount[indexAccountFrom].Transfer(amountTransfer, listAccount[indexAccountTo]);
            System.Console.WriteLine();

        }

        private static void AccountsList()
        {
            System.Console.WriteLine("----------ACCOUNTS LIST----------");

            System.Console.WriteLine();

            if (listAccount.Count == 0)
            {
                System.Console.WriteLine("Zero Accounts Activated");
                //Aqui o return vai fazer o programa sair do método sem nem ir para o for abaixo
                return;
            }

            //Percorrer a lista de contas
            for (int i = 0; i < listAccount.Count; i++)
            {
                //Criando um objeto e populando esse objeto
                //Ou seja, pegar o item i da lista e jogando no objeto account criado
                Account account = listAccount[i];
                Console.Write($"#{i} - ");
                Console.WriteLine(account);
            }

            System.Console.WriteLine();
        }

        private static void CreateAccount()
        {
            System.Console.WriteLine("----------CREATE NEW ACCOUNT----------");
            System.Console.WriteLine();

            //Pro futuro: incluir validação se o usuário digitou mesmo número ou não
            System.Console.Write("Insert [1] to Legal Person or [2] to Natural Person: ");
            int enterAccountType = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Insert the COMPLETE NAME of the client: ");
            string enterCustomerName = Console.ReadLine();

            System.Console.WriteLine("Insert the Account's Balance: ");
            double enterBalance = Convert.ToDouble(Console.ReadLine());

            System.Console.WriteLine("Insert the Account's Credit");
            double enterCredit = Convert.ToDouble(Console.ReadLine());

            //Criando um objeto para a nova conta
            Account newAccount = new Account(account_type: (AccountType)enterAccountType, 
                                            account_balance: enterBalance,
                                            name: enterCustomerName,
                                            credit: enterCredit);


            listAccount.Add(newAccount);
            
            System.Console.WriteLine();

        }

        //Criar um Menu para ADMIN e um para usuário
        private static string GeneralMenu()
        {
            System.Console.WriteLine("----------OCEAN BANK----------");
            System.Console.WriteLine("\nWelcome! What would you like to do?");
            System.Console.WriteLine();

            //Inserir as opção Listar Contas e Inserir Contas apenas para admins
            System.Console.WriteLine("[1] - Ativated Accounts List");
            System.Console.WriteLine("[2] - Creat New Account");
            System.Console.WriteLine("[3] - Withdraw");
            System.Console.WriteLine("[4] - Deposit");
            System.Console.WriteLine("[5] - Transfer");
            System.Console.WriteLine("[C] - Clean Screen");
            System.Console.WriteLine("[X] - Exit");

            System.Console.WriteLine();
            string userOption = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return userOption;
        }
    }
}