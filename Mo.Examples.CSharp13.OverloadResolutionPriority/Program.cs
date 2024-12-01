
//Link: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-13.0/overload-resolution-priority#:~:text=Detailed%20Design-,Overload%20resolution%20priority,-We%20define%20a

using System.Runtime.CompilerServices;

var d = new C1();
int[] arr = [1, 2, 3];
d.M(arr); // Prints "Span"


class C1
{
    
    public void M(ReadOnlySpan<int> s) => Console.WriteLine("Span");
    // Default overload resolution priority

    [OverloadResolutionPriority(1)]
    public void M(int[] a) => Console.WriteLine("Array");
}