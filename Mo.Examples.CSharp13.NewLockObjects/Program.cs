// C# 13 New Lock Type
// link: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#params-collections:~:text=)%3B%0A%20%20%20%20%7D%0A%20%20%20%20Console.WriteLine()%3B%0A%7D-,New%20lock%20object,-The%20.NET%209

PassengersSecrurityWithNoLock();
//PassengersSecurityWithLock();
//PassengersSecurityWithCSharp13NewLockType();

void PassengersSecrurityWithNoLock()
{
    Console.WriteLine("Starting security check WITH LOCK...");

    Parallel.For(1, 11, (i) =>
    {
        Console.WriteLine($"Passenger {i} arrives at the scanner...");

        Thread.Sleep(new Random().Next(100, 300));

        Console.WriteLine($"Passenger {i} is going through the scanner...");

        Thread.Sleep(new Random().Next(100, 300));

        Console.WriteLine($"Passenger {i} exits the scanner.");
    });

    Console.WriteLine("Security check WITHOUT LOCK completed.");
}

//C# version < 13
void PassengersSecurityWithLock()
{
    Console.WriteLine("Starting security check WITH LOCK...");
    object lockObject = new object();

    Parallel.For(1, 11, (i) =>
    {
        lock (lockObject)
        {
            Console.WriteLine($"Passenger {i} arrives at the scanner...");

            Thread.Sleep(new Random().Next(100, 300));

            Console.WriteLine($"Passenger {i} is going through the scanner...");

            Thread.Sleep(new Random().Next(100, 300));

            Console.WriteLine($"Passenger {i} exits the scanner.");
        }
    });

    Console.WriteLine("Security check WITHOUT LOCK completed.");
}

//C# version = 13 Has dedicated Lock Type
void PassengersSecurityWithCSharp13NewLockType()
{
    Console.WriteLine("Starting security check WITH new LOCK Type...");
    Lock passengersLimitLock = new Lock();

    Parallel.For(1, 11, (i) =>
    {
        using (passengersLimitLock.EnterScope())
        {
            Console.WriteLine($"Passenger {i} arrives at the scanner...");

            Thread.Sleep(new Random().Next(100, 300));

            Console.WriteLine($"Passenger {i} is going through the scanner...");

            Thread.Sleep(new Random().Next(100, 300));

            Console.WriteLine($"Passenger {i} exits the scanner.");
        }

    });

    Console.WriteLine("Security check WITHOUT LOCK completed.");
}

