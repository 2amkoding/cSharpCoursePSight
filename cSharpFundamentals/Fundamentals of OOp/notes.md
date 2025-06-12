# Fundamentals of Object-Orientation-programming

## Overview

- Encapsulation
- inheritance
- polymorphism
- interfaces

- Parent and child
  - syntax

```c#
public class Employee {}

public class Manager: Employee {}
```

> [!IMPORTANT]
> access modifiers
> -public: derived class can access parents
> -private: derived cannot
> -protected: derived can access parents

```c#
internal class Manager(string firstName, string lastName) : Emplyee(firstName, lastName)
{
  //implicit constructor
  //addiontal members here

  public void AttendMeetings() => Console.WriteLine("we love meetings.");
}
```

#### inheritance

- The is-a relation
  - the manager is-a Employee
  - this is-a vibe // wrong
- has-a relation (composition)
  - Address class, Employee has Address as a field.

#### polymorphism

- override a base class method with a new implementation
- "poly" and "morph"
- keywords: virtual, override

```c#
public class Employee
{
  public virtual void PerformWork()
    {...}
```

```c#
public class Manager: Employee
{
  public override void PerformWork()
  {...}
}
//a manager Object will have its own PerformWork().
//a researcher(derived from employee) will use Employee's PerformWork()
//unless overridden.
```

> [!NOTE]
> I want a {bonus}!

#### interfaces

- define a contract to be implemented by classes that use it
- syntax

```c#
public interface Employee
{
  void PerformWork();
  int ReceiveBonus();
}
```

- Implementing an Interface:

```c#
public void Maanger: Employee
{
  public void MicroManage()
  {
    Console.WriteLine("null");
  }
}
```
