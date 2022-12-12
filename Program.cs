using System;

namespace ATM_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int bankCapacity = 10;  //indicate bankcapacity
            Person p1 = new Person();

            string pinCode = "9876";   // pincode of 4 digits
            string cardNumber = "12345789";
            int accountBalance = 250;   // initinal balance
            BankAccount tmpAccount = new BankAccount(p1, "Mohammaddawagreh@test.com", cardNumber, pinCode, accountBalance);


            Bank testBank = new Bank(bankCapacity);

            testBank.AddNewAccount(tmpAccount);

            testBank.Save();

            Bank newTestBank = new Bank();
            newTestBank.Load();
        }
    }
}
