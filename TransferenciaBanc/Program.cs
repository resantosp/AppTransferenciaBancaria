using System;

namespace TransferenciaBanc
{
    class Program
    {
        static void Main (string[] args)
        {
            // Account myAccount = new Account(AccountType.NaturalPerson, 70, 490, "Renata dos Santos Pinto");System.Console.WriteLine(myAccount.ToString());

            string userOption = GeneralMenu();

            // while (userOption.ToUpper() != "X")
            // {
            //     switch (userOption)
            //     {
            //         case "1":
            //             AccountsList();
            //             break;
            //         case "2":
            //             CreateAccount();
            //             break;
            //         case "3":
            //             Withdraw();
            //             break;
            //         case "4":
            //             Deposit();
            //             break;
            //         case "5":
            //             Transfer();
            //             break;
            //         case "C":
            //             Console.Clear();
            //             break;
                    
            //         default:
            //             throw new ArgumentOutOfRangeException();
            //     }

            //     userOption = GeneralMenu();

            // }

            System.Console.WriteLine("Thank you for choosing our services.");
            Console.ReadLine();

        }

        //Criar um Menu para ADMIN e um para usuário
        private static string GeneralMenu()
        {
            System.Console.WriteLine("----------OCEAN BANK----------");
            System.Console.WriteLine("\nWelcome! What would you like to do?");

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