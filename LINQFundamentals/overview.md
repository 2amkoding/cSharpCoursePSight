# Overview

1. Advantages of using LINQ
2. Select and order data
3. Search for data
4. Extract subsets of data
5. What is in common within items in collections
6. Join and group data
7. Aggregate using: Min(), Max(), Sum(), etc.
8. Understand how deferred execution works

## Resources

<https://github.com/PaulDSherif/LINQFundamentalsCSharp12>  
<https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/>  
<https://docs.microsoft.com/en-us/samples/dotnet/try-samples/101-linq-samples/>

## What is LINQ?

- SQL like syntax in C#
- Query any type of collections that implement
  IEnumberable<t> or IQueryable<t>

### Common IEnumberable TYpes

- any array
- String
- List<T>
- HashSet<T>, Dictionary<TKey, TValue>, LinkedList<T>, etc.

### LINQ to Objects

- LINQ and Strings
- LINQ and Reflection
- LINQ and File Directories
- LINQ to Entities
- LINQ to datasets

### SQL vs LINQ

```c#
//SQL
SELECT * FROM Products
ORRDER BY Name DESC

//LINQ
from prod in Products
Orderby prod.Name
descending
select prod;
```

## Why use LINQ ?

- Unified approach for querying any type of objects
- Eliminate looping code
- Type-checking of Objects at Compile-time.

## LINQ Operations

basically, anything you can do in SQL
