using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;

namespace ConsoleApp3
{
    internal class bank
    {
        public List<client> clients { get; set; }

        // => Constructor for `bank` class
        public bank(List<client> clients)
        {
            this.clients = clients;
        }

        // => ATM
        public void ATM()
        {
            // => Asking for pin
            string? pin;
            while (true)
            {
                Console.Clear();
                Console.Write("Enter PIN: ");
                pin = Console.ReadLine();

                if (pin.Length != 4)
                {
                    Console.WriteLine("PIN must be contain 4 digits");
                    pin = null;
                    Thread.Sleep(3000);
                }
                else
                    break;
            }

            // => If pin is appropriate then checking if it exits in our bank
            int userindex = 0;
            bool userexist = false;
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].bankaccount.PIN == pin)
                {
                    userindex = i;
                    userexist = true;
                    break;
                }
            }


            if (userexist)
            {
                // => If user found then we ask to choose some option
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Welcome {clients[userindex].Name} {clients[userindex].Surname}");
                    Console.WriteLine("[1] Cash");
                    Console.WriteLine("[2] Balance");
                    Console.WriteLine("[3] Transfer Card");
                    Console.Write("Your choice here...");
                    ConsoleKeyInfo key = Console.ReadKey();

                    // => Cashing
                    if (key.Key == ConsoleKey.D1)
                    {
                        while (true)
                        {
                            // => Money choices for user
                            Console.Clear();
                            Console.WriteLine("[1] 10 azn");
                            Console.WriteLine("[2] 20 azn");
                            Console.WriteLine("[3] 50 azn");
                            Console.WriteLine("[4] 100 azn");
                            Console.WriteLine("[5] Other");
                            Console.WriteLine("[6] Back");

                            Console.Write("Choice here...");
                            ConsoleKeyInfo key_m = Console.ReadKey();

                            // => 10 azn
                            if (key_m.Key == ConsoleKey.D1)
                            {
                                if (clients[userindex].bankaccount.Balance >= 10)
                                {
                                    clients[userindex].bankaccount.Balance -= 10;
                                    Console.Clear();
                                    Console.WriteLine("Operation is succesful");
                                    Thread.Sleep(2000);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("There is no enough money in your balance");
                                    Thread.Sleep(3000);
                                }
                            }

                            // => 20 azn
                            else if (key_m.Key == ConsoleKey.D2)
                            {
                                if (clients[userindex].bankaccount.Balance >= 20)
                                {
                                    clients[userindex].bankaccount.Balance -= 20;
                                    Console.Clear();
                                    Console.WriteLine("Operation is succesful");
                                    Thread.Sleep(2000);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("There is no enough money in your balance");
                                    Thread.Sleep(3000);
                                }
                            }

                            // => 50 azn
                            else if (key_m.Key == ConsoleKey.D3)
                            {
                                if (clients[userindex].bankaccount.Balance >= 50)
                                {
                                    clients[userindex].bankaccount.Balance -= 50;
                                    Console.Clear();
                                    Console.WriteLine("Operation is succesful");
                                    Thread.Sleep(2000);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("There is no enough money in your balance");
                                    Thread.Sleep(3000);
                                }
                            }

                            // => 100 azn
                            else if (key_m.Key == ConsoleKey.D4)
                            {
                                if (clients[userindex].bankaccount.Balance >= 100)
                                {
                                    clients[userindex].bankaccount.Balance -= 100;
                                    Console.Clear();
                                    Console.WriteLine("Operation is succesful");
                                    Thread.Sleep(2000);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("There is no enough money in your balance");
                                    Thread.Sleep(3000);
                                }
                            }

                            // => Other 
                            else if (key_m.Key == ConsoleKey.D5)
                            {
                                double cash;
                                Console.Clear();
                                Console.Write("Enter Money: ");
                                cash = double.Parse(Console.ReadLine());

                                if (clients[userindex].bankaccount.Balance >= cash)
                                {
                                    clients[userindex].bankaccount.Balance -= cash;
                                    Console.Clear();
                                    Console.WriteLine("Operation is succesful");
                                    Thread.Sleep(2000);
                                    break;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("There is not enough in your balance");
                                    Thread.Sleep(3000);
                                }
                            }

                            // => Back
                            else if (key_m.Key == ConsoleKey.D6)
                            {
                                break;
                            }
                        }
                    }

                    // => Showing Balance
                    else if (key.Key == ConsoleKey.D2)
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine($"Balance: {clients[userindex].bankaccount.Balance}");
                            Console.WriteLine("[1] Back");
                            Console.WriteLine("Choice here...");
                            ConsoleKeyInfo key_back = Console.ReadKey();

                            if (key_back.Key == ConsoleKey.D1)
                            {
                                break;
                            }
                        }

                    }


                    // => Transfer to another bank account
                    else if (key.Key == ConsoleKey.D3)
                    {

                    }
                }
            }
            else
                Console.WriteLine("t");

        }


    }
}
