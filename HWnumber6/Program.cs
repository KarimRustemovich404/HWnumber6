using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HWnumber6
{

    internal class Program
    {
        static void Lab_UPR_7_1()
        {
            BankAccount0 GetBankAccount0()
            {
                BankAccount0 account0 = new BankAccount0();

                account0.BankAccountID0 = 7549815065;
                account0.BankAccountBalance0 = 5500000;
                account0.BankAccountType0 = "saving";

                return account0;
            }

            void PrintabtBankAccount0(BankAccount0 account0)
            {
                Console.WriteLine("СОСтояние банковского счёта:");
                Console.WriteLine($"ID:{account0.BankAccountID0}\nБаланс счёта:{account0.BankAccountBalance0}\nТип банковского счёта:{account0.BankAccountType0}");

            }
            var BankAccount0 = GetBankAccount0();

            PrintabtBankAccount0(BankAccount0);

            void Lab_UPR_7_2()
            {
                BankAccount1 GetBankAccount1()
                {
                    BankAccount1 account1 = new BankAccount1();

                    account1.BankAccountID1 = 1;
                    account1.BankAccountBalance1 = 5500000;
                    account1.BankAccountType1 = "saving";

                    return account1;
                }
                void PrintabtBankAccount1(BankAccount1 account1)
                {
                    Console.WriteLine("СОСтояние банковского счёта:");
                    Console.WriteLine($"ID:{account1.BankAccountID1}\nБаланс счёта:{account1.BankAccountBalance1}\nТип банковского счёта:{account1.BankAccountType1}");

                }

            }
            var BankAccount1 = GetBankAccount1();

            PrintabtBankAccount1(BankAccount1);

            void Lab_UPR_7_3()
            {


                BankAccount1 GetBankAccount1()
                {
                    BankAccount1 account1 = new BankAccount1();

                    account1.BankAccountID1 = 7549815065;
                    account1.BankAccountBalance1 = 5500000;
                    account1.BankAccountType1 = "saving";

                    return account1;
                }

                void PrintabtBankAccount1(BankAccount1 account1)
                {
                    Console.WriteLine("СОСтояние банковского счёта:");
                    Console.WriteLine($"ID:{account1.BankAccountID1}\nБаланс счёта:{account1.BankAccountBalance1}\nТип банковского счёта:{account1.BankAccountType1}");

                }
                var BankAccount1 = GetBankAccount1();

                PrintabtBankAccount0(BankAccount1);
                void AddToBankAccount()
                {
                    Console.WriteLine("");
                    double value = double.Parse(Console.ReadLine());
                    bool yuan = double.TryParse(Console.ReadLine(), out double yuan);
                    if (yuan)
                    {
                        Console.WriteLine(BankAccountBalance1 + value);
                    }
                }
                void TakeOutOfBankAccount()
                {
                    Console.WriteLine("");
                    double value = double.Parse(Console.ReadLine());
                    bool yuan = double.TryParse(Console.ReadLine(), out double yuan);
                    if (yuan)
                    {
                        try
                        {
                            Console.WriteLine(BankAccountBalance1 - value);
                        }
                        catch ()
                        {

                        }
                    }

                }
                void Main(string[] args)
                {
                    Lab_UPR_7_1();
                    Lab_UPR_7_2();
                    Lab_UPR_7_3();

                    Console.ReadKey();
                }
            }
        }
    }
}


