# Overview

- How to respond to runtime errors
- How to indicate an error occurred
- Errors represented by exception hierarchies
- How to rethrow and wrap exceptions
- Checking exception throwing code

## What are Exceptions ?

Theyre just objects inherited from System.Exception(baseclass).  
You can generate with the "throw" statement.  
Different Classes represent different errors and handled differently.

Exception definition sources:

- .NET
- external frameworks like NuGet
- Custom exceptions

## Understanding the Importance of Error Handling

### Exception Bubbling

Without handling exceptions, an error bubbles recursively up the callstack, resulting in a system/app crash.

```mermaid
sequenceDiagram

  MethodA->>MethodB: calls
  MethodB->>MethodC: calls
  MethodC-->>Exception: ERROR!
  MethodC-->>MethodB: Exception
  MethodB-->>MethodA: Exception
  MethodA-->>)System: System Cash
```

## Gettomg Started w Exceprtions

### how to create an exception & throw it

#### Try / Catch BLock

ex. methodC is called within a try/catch block inside methodB.  
This gives a "safetyNet" for it to be resolved in contained space.  
Basically, it's like giving an if/else statement for errors:  
"try" this code if it breaks,
"catch" the excception(s)

```c#
// Hierarchy of catch: Most specific --> Least specific
try
{
  //some operation(s)
}
catch(ArgumentNullException ex)
{
  //Handle ArgumentNullException
}
catch(ArgumentNullException ex)
{
  //Handle ArgumentNullException
}
catch
{
  //catch everything else
}
finally
{
  //always execute
  // ex. clean up code
}
```

### stack trace

chatgpt: why my code no work  
(jk)

## Understanding the Exception Class Hierarchy

<http://bit.ly/netexceptions>

```mermaid
flowchart LR
  Exception-->SystemException
  SystemException-->OutofMemoryException
  SystemException-->StackOverflowException
  SystemException-->ArgumentException
  ArgumentException-->ArgumentNullException
  ArgumentException-->ArgumentOutOfRangeException
  Exception-->ArithmeticException
  ArithmeticException-->DivideByZeroException
  ArithmeticException-->OverflowException
  Exception-->ApplicationException
  Exception-->customException
```

### System.Exception.Properties

Message, StackTrace, Data, InnerException, Source, HResult, HelpLink, TargetSite

### Constructors in the Exception Class

```c#
public Exception() // Default Message property + null InnerException

public Exception(
  string message // User defined message
)

public Exception(
  string message,
  Exception InnerException // Wrapped exception
)
```

### Exception Guidelines

```

"System.ApplicationException is a class that should not be part of the .NETFramework.
The original idea was that classes derived from SystemException would indicate
exceptions thrown from the CLR(orsystem) itself, whereas non-CLR exceptions would be
derived from ApplicationException.  However, a lot of exception classes didn't follow
this pattern."

  - Microsoft
```

- An ApplicationException should not be thrown by your code
- An ApplicationException exception should not be caught
  (unless you rethrow the orignal excpetion)
- Custom exceptions should not be derived from ApplicationException

## Catching, Throwing, and Rethrowing Exceptions

### Throwing Exceptions from Expressions

```c#
public class Calculator
{
  public int Calculate(int n1, int n2, string operation)
  {
    //ArgumentNullException.ThrowIfNull(operation);
    string nonNullOperation =
      operation ?? throw new ArgumentNullException(nameof(operation));

    if(nonNullOperation == "/")
    {
      return Divide(n1, n2);
    }
    else
    {
      throw new ArgumentOutOfRangeException(nameof(operation),
          "The mathematical operator is not supported."):
    }
  }
}

//switch expressions
public class Calculator
{
  public int Calculate(int n1, in2, string operation) => opeartion switch
  {
    "/" => Divide(n1, n2),
    "+" => Add(n1, n2),
  };

  private int Divide(int n, int divisor) => n/divisor;
  private int Add(int n1, int n2) => n1 + n2;
}
```

### Catching Different Exception Types w Multiple Catch Blocks

```c#
//Program.cs
//... omitted code
try
{
    var calculator = new Calculator();
    int result = calculator.Calculate(number1, number2, operation);
    DisplayResult(result);
}
catch (ArgumentNullException ex)
{
    // Log.Error(ex);
    WriteLine($"Operation was not provided. {ex}");
}
catch (ArgumentOutOfRangeException ex)
{
    // Log.Error(ex);
    WriteLine($"Operation is not supported. {ex}");
}
catch (Exception ex)
{
    WriteLine($"Sorry, something went wrong. {ex}");
}
```

### Understanding the Finally Block

### Rethrowing Exceptions and Preserving the Stack Trace

sometimes you want to catch an exception, perform some action, but continue  
the exception bubble up the stack.

```c#
// new syntax:just "throw;"
namespace ConsoleCalculator;

public class Calculator
{
    public int Calculate(int number1, int number2, string operation)
    {
        string nonNullOperation =
            operation ?? throw new ArgumentNullException(nameof(operation));

        if (nonNullOperation == "/")
        {
            try
            {
                return Divide(number1, number2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("...logging...");
                // Log.Error(ex);
                throw;
            }
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(operation),
                "The mathematical operator is not supported.");
        }
    }

    private int Divide(int number, int divisor) => number / divisor;
}
```

### Catchign and Wrapping Exceptions

```c#
        if (nonNullOperation == "/")
        {
            try
            {
                return Divide(number1, number2);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("...logging...");
                // Log.Error(ex);
                //throw;
                throw new ArithmeticException("An error occured during calculation.", ex);
            }
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(operation),
                "The mathematical operator is not supported.");
        }
    }
```

> [!NOTE]  
> ArithmeticException.DivideByZeroException  
> Inheritance and Catch TD Hierarchy of speicifc to least

```c#
try
{
  return Divide(n1, n2);
}
catch (DivideByZeroException ex)
{
  //logic
}
catch(ArithmeticException ex)
{
//logic
}
```

### Filtering Catch Blocks with Exception Filters

C#6 and up  
keyword: when

```c#
//Program.cs
try
{
    var calculator = new Calculator();
    int result = calculator.Calculate(number1, number2, operation);
    DisplayResult(result);
}
catch (ArgumentNullException ex) when (ex.ParamName == "operation")
{
    // Log.Error(ex);
    WriteLine($"Operation was not provided. {ex}");
}
catch (ArgumentNullException ex)
{
    // Log.Error(ex);
    WriteLine($"An argument was null. {ex}");
}
catch (ArgumentOutOfRangeException ex)
{
    // Log.Error(ex);
    WriteLine($"Operation is not supported. {ex}");
}
catch (Exception ex)
{
    WriteLine($"Sorry, something went wrong. {ex}");
}
finally
{
    WriteLine("...finally...");
}
```

### Global Unhandled Exception Handling

## Creating and Using Custom Exceptions

## Write Automated Tests for code that throws exceptions
