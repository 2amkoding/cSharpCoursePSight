# Value types vs Reference types

- Values go to Stack
- Reference goes to Heap

## passing Parameters by Reference

```c#
int a = 33;
int b = 22; //b gets updated to 33+10 upon invoking AddTwoNumbers

AddTwoNumbers(a, ref b);


public int AddTwoNumbers(int a, ref int b) {
  b+= 10;
  int sum = a+b;
  return sum;
}
```

## out keyword

huh ?

## 5 Types in c

| Value Types(stack) | Reference Types(heap) |
| ------------------ | --------------------- |
| Enumerations       | Classes               |
| Structs            | Interfaces            |
|                    | Delgates              |

```
.NET Types/
├── Value Data Types
│   ├── Predefined Data Types
│   │   └── Integer
│   │   └── Boolean
│   ├── User Defined Types
│   │   └── Enumerations
│   │   └── Struct
├── Reference Data Types
│   ├── Predefined Data Types
│   │   └── string
│   │   └── Array
│   ├── User Defined Types
│   │   └── Class
│   │   └── Interface
```

## Namespace

- .NET has a library of classes and Types
  to help build stuff
- Namespaces are like ?Category names
  to organize code together. as certain classes may share the same name,
  having it referenced inside specific categories handles that.

```
- System/
└── - System.Web
└── - System.Collections
└── - System.Windows
├── - System.IO
│   └── - System.IO.FileSystem
│   └── - System.IO.Compression
```

## The using keyword

```c#
using System;
using System.IO;
FileInfo FileInfo1

= new FileInfo(@"D:\Myfile.txt"); //available through SystemIO namespace
```

- a using statement only brings the types within the specified namespace, not the ones in nested namespaces.

### Global Using Statements

- auto sets common Using statements on a global level

> [!NOTE]
> Explore dotnet-sos (a debugging extension)
> an alternate solution to 'Object Viewer' in CLI ?

## NuGet CLI Helper Tools

```c#
- dotnet-search
- dotnet-nuget-inspector
- dotnet-outdated
- NuGet.Trends.Tool
- nuget-license
```

1. NuGet CLI Reference  
   <https://learn.microsoft.com/en-us/nuget/reference/nuget-exe-cli-reference>

2. .NET CLI NuGet Commands  
   <https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-nuget>

## Using an Enumeration in C

- Names constants for improved readability
- Stored internally as a Value type
- emum keyword

```c#
enum EmployeeType {
Sales, //0
Manager,//1
Research,//2
Storemanager
}
```

## Struct

- Represents a custom data structure
- Value Type
- Can be "newed"

> [!summary]
> Types: Value type || Reference type
> .NET itself contains many types
> Classes are most commonly used for
> custom reference types
> Enums and structs: custom Value types
