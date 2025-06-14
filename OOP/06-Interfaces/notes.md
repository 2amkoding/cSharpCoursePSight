# Overview

- Understanding interfaces
- Implementing and using interfaces
- Interfaces and polymorphism

## Understanding interfaces

Contract:  
All members of the interface must be implemented  
a Class can _implement_ multiple interfaces  
Name typically starts with "I"  
Members are Public by default

- Methods
- Properties
- Events
- Indexers

```c#
internal interface ISaveable
{
  string Save();
  bool CanSave  { get: set: }
  event EventHanlder SaveableChanged;
}
---

public class Order: ISaveable
{
  public string ConvertToStringForSaving()
  {
    return "order";
  }
}
```

### Implementing interfaces

All members must be implemented  
One or more interface can be implemented  
Interfaces can inherit from other interfaces  
_ALL members from entire hierarchy must receive an implementation_

#### Implementing Multiple Interfaces

```c#
public class Order: ISaveable, Iloggable
{
  public void Save()
  {
    ...
  }

  public void Log()
  {
    ...
  }
}
// explicit casting possible: public void ISaveable.Save(){...}
```

### .NET interfaces

IEnumerable, IDisposable, ICloneable, IComparable, IList/ICollection, ISerializable  
+MORE

## Polymorphism

You can use an interface reference to point to an object of a class that implements that interface  
On that reference you can invoke the methods defined in that interface  
thus enabling polymorphic behavior  
Product -> is-A -> iSaveable
