using ConsoleApp3;
using System.Security.Cryptography;

internal class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        string cvc = "";
        for (int i = 0; i < 3; i++)
        {
            int digit = random.Next(10);
            cvc += digit.ToString();
        }

        // User 1
        Guid id1 = Guid.NewGuid();
        DateTime ed1 = new DateTime(2027, 6, 5);
        bankcard bc1 = new bankcard(ed1, "4169738800049656", "4656", cvc, 100);
        client c1 = new client(id1, "Elgun", "Haqverdiyev", bc1);

        // User 2
        Guid id2 = Guid.NewGuid();
        DateTime ed2 = new DateTime(2027, 6, 5);
        bankcard bc2 = new bankcard(ed2, "4169738800049656", "4656", cvc, 0);
        client c2 = new client(id2, "Elgun", "Haqverdiyev", bc2);

        // User 3
        Guid id3 = Guid.NewGuid();
        DateTime ed3 = new DateTime(2027, 6, 5);
        bankcard bc3 = new bankcard(ed3, "4169738800049656", "4656", cvc, 0);
        client c3 = new client(id3, "Elgun", "Haqverdiyev", bc3);

        // User 4
        Guid id4 = Guid.NewGuid();
        DateTime ed4 = new DateTime(2027, 6, 5);
        bankcard bc4 = new bankcard(ed4, "4169738800049656", "4656", cvc, 0);
        client c4 = new client(id4, "Elgun", "Haqverdiyev", bc4);

        // User 5
        Guid id5 = Guid.NewGuid();
        DateTime ed5 = new DateTime(2027, 6, 5);
        bankcard bc5 = new bankcard(ed5, "4169738800049656", "4656", cvc, 0);
        client c5 = new client(id5, "Elgun", "Haqverdiyev", bc5);

        // List of users
        List<client> clients = new List<client> { c1, c2, c3, c4, c5 };

        // Bank object
        bank Bank = new bank(clients);
        Bank.ATM();
    }
}
