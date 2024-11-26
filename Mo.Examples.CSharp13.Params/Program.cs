//New C# 13: ParamsCollection
//Link: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#params-collections:~:text=params-,collections,-The%20params%20modifier

PrintHumanNames(new Human("Mo"), new Human("Elchin"), new Human("James"));

void PrintHumanNames(params List<Human> items)
{
    items.ForEach((Human item) => Console.WriteLine(item.Name));
}

record Human(string Name);