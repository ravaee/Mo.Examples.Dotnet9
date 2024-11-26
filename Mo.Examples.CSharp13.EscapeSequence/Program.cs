// new escape sequence 
//Link: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#params-collections:~:text=needs%20to%20change.-,New%20escape%20sequence,-You%20can%20use

for (int i = 0; i <= 100; i++)
{
    //New C# 13
    Console.Write($"\e[32mProgress: {i}%\e[0m\r");
    
    //Console.Write("\u001B[32mProgress: 50%\u001B[0m\r");
    Thread.Sleep(50); 
}

Console.WriteLine("\n\e[32mDone!\e[0m");

