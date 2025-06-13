# Working w Exceptions

## Overview

- Understanding excetions in code
- Using a try / catch block
- Catching several types of exceptions
- Using finally

### try / catch / finally

- in c#, error handling code can be written separately

```c#
try
{
  // code here
}
catch (Exception ex)
{
  throw;
}

//if code works--carry on, else catch (exception), throw (error)
```

```c#
try
{
  string input = Console.ReadLine();
  int a = int.Parse(input);

}
catch (FormatException ex)
{
  throw;
}
```

[DOC: microsoft-.net-exception](https://learn.microsoft.com/en-us/dotnet/standard/exceptions/)

#### Exception Details

- are Objects w properties that contain detail for debugging
- properties:
  - Message
  - InnerException
  - StackTrace
  - HelpLink
- Inspecting the Exception Details

  - Log File ?

  ```c#
  try
  {
    string input = Console.ReadLine();
    int a = int.Parse(input);
  }
  catch (FormatException ex)
  {
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
  }
  ```

### Exception Hierarchy

```
Exception/
├── SystemException
│   └── FormatException
│   ├── ArithmeticException
│   │   └── DivideByZeroException
└── ...
└── Application Exception
└── ...
```

> [!NOTE]
> Custom Exceptions use the baseClass Exception, so it can be
> invoked if any exception is thrown, "catch all"

```c#
  try
  {
    string input = Console.ReadLine();
    int a = int.Parse(input);
  }
  catch (detailedExceptionA)
  {
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
  }
  catch (detailedExceptionB)
  {
    //do something
  }
  catch (generalException)
  {
    //a catch all
  }
  finally
  {
    //this code will always execute
  }

```
