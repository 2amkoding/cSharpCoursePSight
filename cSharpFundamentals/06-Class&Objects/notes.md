# Class and Objects

## Overview

- Understanding classes
- Creating a Class
- Using Objects

### Classes

- models or entities == Custom types
  > [!EXAMPLE]
  > Employee
  > Customomer
  > Message
  > Transaction

#### Custom Types

- Class (Reference Types)
- Struct
- Record

##### Classes

- OOP like Java
- Fields
- Properties
- methods
- Events

```c#
public class MyClass{
  public int a;
  public string b;

  public void method () {
    System.WriteLine("wsup");
  }
```

}

### Objects

- creating a new Objects
  - Employee employee = new Employee("Beth", 35);
  - vartype varName create object
- Constructors
  - Default or Custom
- Shorthand: Employee employee = new ("him", 35)

#### C# 12

introduced a new syntax

- Primary Constructors

  - public class Employee(string name, int ageValue){

  }
