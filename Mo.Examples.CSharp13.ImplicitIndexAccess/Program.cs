// ImplicitIndexAccess:

///New indexing makes code more readable. 
///Also, it eliminates the work to calculate and use reverse indexing. 
///You can define it with ^1 as the last index, ^2 as the second last, and so on. 
///You get rid of any intermediate steps for finding the index of the last element and defining indexes for each element.
//Link: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#:~:text=Implicit%20index%20access

List<string> logs = new(); 

logs[^1] = "Log 5: System started";       
logs[^2] = "Log 4: User logged in";       
logs[^3] = "Log 3: Data exported";       
logs[^4] = "Log 2: Report generated";    
logs[^5] = "Log 1: Database backup done"; 

Console.WriteLine("Latest Logs:");

foreach (var log in logs)
{
    Console.WriteLine(log);
}
