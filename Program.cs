using System.Diagnostics;



bool errorFlag = false;  
Trace.WriteIf(errorFlag, "Error in AppendData procedure.");  
Debug.WriteIf(errorFlag, "Transaction abandoned.");  
System.Diagnostics.Trace.Write("Invalid value for data request");

int IntegerDivide(int dividend, int divisor)
{
    Debug.Assert(divisor != 0, $"{nameof(divisor)} is 0 and will cause an exception.");

    return dividend / divisor;
}

int result = Fibonacci(6);
Console.WriteLine(result);


static int Fibonacci(int n)
{
    Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
    Debug.WriteLine($"We are looking for the {n}th number");
    int n1 = 0;
    int n2 = 1;
    int sum;

    for(int i =2; i <=n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
        Debug.WriteLineIf(sum == 1, $"sum is 1, n1 is {n1}, n2 is {n2}"); 
    }

    // If n2 is 5 continue, else break.
    Debug.Assert(n2 == 5, "The return value is not 5 and it should be.");
    return n == 0 ? n1 : n2;
}
