# More with Classes and Objects

## Overview

### Creating namespaces

### intro static data

### Working with null

### Understanding garbage collection

### using a class library

### intro records

## namespaces

- keep class names separate
- a unique TYPE
  > [!example]

```c#
//traditional way
namespace bethanysPieShop.HR
{
public class Employee
{}
}

//File-scoped Namespaces (>= c#10)
namespace bethanysPieShop.HR;

public class Employee {}
```

## Static Data

- Static methods work with static data

## Working with Null

> [!example]
> Employee employee; -> (null) -> Stack
> employee = new Employee(); -> Stack -> Heap

## nullable Value types

```c#
int? a = 10;
int? b = nul;
if (b.HasValue) {
  Console.WriteLine("we have a value");
}
```

## garbage collection

automated feature that collects !referenced objects in Heap
to clear storage

### CLI diagnostic tools

- dotnet build --verbosity
- dotnet-counters: performance monitoring tool, collect performance counter data
- dotnet-trace: collect CPU usage and other diagnostic data
- dotnet-dump: collect and analyze core dumps of applications

## Using a class from External library

```
   dotnet add <PROJECT> reference <PATH_TO_DLL>
```

## Intro C# Records

- reference type
- can replace class
- aimed at "just" containing data ?
- comes w additional buil-in functionality
- DTOs

### advantages of Records

- Immutability
- Value-based equality
- concise

### Value-based equality

```c#
Employee emp1 = new Employee("Beth");
Employee emp2 = new Employee("Beth");

bool areEqual = emp1 == emp2; // true

logic:
  - Type definitions are the same
  - Values for thoes are equal

emp1 and emp2 are objects of same class and share same values
```

### Positional Records

public record (string accountNumber);
