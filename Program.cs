using System;
using bytebank;
using bytebank.MainAccountHolder;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, Welcome to ByteBank!");

            //CurrentAccount account1 = new CurrentAccount();

            //account1.accountHolder = "Paul Roger";
            //account1.account = "101023-x";
            //account1.branchNumber = 0101;
            //account1.branchName = "ByteBank Waterford";
            //account1.balance = 35000;

            //CurrentAccount account2 = new CurrentAccount();

            //account2.accountHolder = "Dhiulia Appolinario";
            //account2.account = "101055-x";
            //account2.branchNumber = 0102;
            //account2.branchName = "ByteBank Ferrybank";
            //account2.balance = 150000000;

            ////Console.WriteLine(account1.accountHolder+", see your details below");
            ////Console.WriteLine("Your account number is " + account1.account);
            ////Console.WriteLine("Your branch number is " + account1.branchNumber);
            ////Console.WriteLine("Your branch name is " + account1.branchName);
            ////Console.WriteLine("Your balance is " + account1.balance);

            //Console.WriteLine("Dhiulia balance before withdrawal is " +account2.balance);           
            //bool withdrawal = account2.Withdrawal(18950.78);

            //Console.WriteLine("Withdrawal completed: " + withdrawal);
            //Console.WriteLine("Dhiulia balance after withdrawal is " + account2.balance);
            //account2.Lodgement(54000);
            //Console.WriteLine("Dhiulia balance after lodgement is " + account2.balance);

            //bool transfer = account1.Transfer(1000, account2);
            //Console.WriteLine("tranfer completed: "+ transfer);

            //Console.WriteLine("Dhiulia current balance is " + account2.balance);
            //Console.WriteLine("Paul current balance is " + account1.balance);

            Customer customer = new Customer();

            customer.name = "John Paul";
            customer.pps = "1987890KI";
            customer.profession = "Software Developer";

            CurrentAccount account3 = new CurrentAccount();

            account3.accountHolder = customer;
            account3.account = "12345-x";
            account3.branchNumber = 1234567;
            account3.branchName = "Watergate";

            Console.WriteLine(customer.name);
            Console.WriteLine(account3.accountHolder.name);
        }
    }
}
