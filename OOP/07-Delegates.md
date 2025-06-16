# Overview

Delegates are custom defined types that can hold references to methods  
Delagates are type safe: compiler checks to ensure methods referred  
to by the delegate contain correct type and parameters defined by delegate

## Declaration and Instantiation

syntax:

```c#
public delegate void ExampleDelegate();
public delegate int Calculate(int a, int b);
```

Once a delegate has been declared, any method that has the same return  
and parameters can be used to instantiate a delegate. when a  
delegate is instantiated w a method that it references, it is  
known as a delegate object.

```c#
// Delegate declarations
public delegate void ExampleDelegate();
public delegate int Calculate(int a, int b);

static void ExampleMethod() { // Delegates can be both static or instance methods
  // Do some stuff
}

int Add(int x, int y) {
 // add x and y
}

int WrongArgNum(int g, int z, int t) {
 // Do something
}

int WrongArgType(int k, string m) {
 // Do Something
}

// Instantiate a delegate object like you would with any variable
ExampleDelegate example1 = ExampleMethod;
Calculate example2 = Add;

Calculate fail1 = ExampleMethod; // Won't work, Calculate delegate requires int return type but ExampleMethod is void return type.

Calculate fail2 = WrongArgNum; // Won't work, Calculate specifies 2 parameters of type int but WrongArgNum has 3

Calculate fail3 = WrongArgType; // Won't work, Calculate requires that both its parameters be of type int

example1(); // Performs ExampleMethod
example2(2, 2); // Performs Add(2, 2)

// Can be instantiated using anonymous method
ExampleDelegate anonFunc = delegate() {
  Console.WriteLine("anonymous delegate!");
};

// Can be instantiated using lambda function
ExampleDelegate lambdaFunc = () => {
  Console.WriteLine("lambda delegate!");
};
```

## Multicast Delegates and Usage

Delegate objects can be multicast when assigned multiple methods  
that match their signature. Delegate objects can also be combined  
with other delegate objects of the same type. When executed,  
they perform their methods in the order in which they were added.

```c#
// Declare delegate and method definitions
public delegate void ExampleDelegate();

public static void p1() {
 Console.Write("a");
}

public void p2() {
 Console.Write("b");
}

public void p3() {
 Console.Write("c");
}

// Instantiate delegate objects
ExampleDelegate ex1 = p1 + p2; // ab
ExampleDelegate ex2 = p2 + p3; // bc

ex1 -= p2; // a
ex1 += p3; // ac
ex1 += ex2; // abc
ex1 += p2 // abcb
ex1 -= p1; // bcb
```

_Most importantly_, delegate objects can be used as parameters to be  
passed into other methods. This essentially lets you pass in delegates  
as callback functions for other methods.

```c#
public delegate void SortDelegate(List<Book> books);

void SortByName(List<Book> books) {
  // Sort books by name
}

void SortByAuthor(List<Book> books) {
  // Sort books by author
}

void SortByGenre(List<Book> books) {
  // Sort books by genre
}

void SortBooks(SortDelegate sortingMethod) { // SortDelegate type for parameter
 // Sort books using specified method
}

// Instantiate delegate objects
SortDelegate s1 = SortByName;
SortDelegate s2 = SortByAuthor;
SortDelegate s3 = SortByGenre;

SortBooks(s1);
SortBooks(s2);
SortBooks(s3);

// SortBooks can sort by any of the specified sorting methods as they are all attached to SortDelegate objects.
```
