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

## Polymorphism + interface

You can use an interface reference to point to an object of a class that implements that interface  
On that reference you can invoke the methods defined in that interface  
thus enabling polymorphic behavior

Product -> issA -> iSaveable  
Product can now be addressed as an iSaveable Reference

```c#
//ProductRepository.cs
---

public SaveToFile(List<iSaveable> saveable) // List of ISaveables so it can reference any of the objects that impelment the interface
{
  StringBuilder sb = new StringBuilder(); //
  string path = $"{directory}{productsFileName}";

  foreach (var item in saveable)
  {
    sb.Append(item.ConvertToStringForSaving()); // this method is inherited from the interface
    sb.Append(Enviornment.NewLine);
  }


  File.WriteAllText(path, sb.ToString());

  Console.ForegroundColor - ConsoleColor.Green;
  Console.WriteLine("Saved items sucesffully");
  Console.ResetColor();
}
---

---
//Utilities.cs

private static void SaveAllData()
{
  ProductRepository productRepository = new (); // References Product objects which doesnt implement
    // SaveToFile method requires ISaveable objects.

  List<iSaveable> saveables = new List<ISaveable>(); //Creates a List of References that point
                                                     // towards the object that implement ISaveable

  foreach (var item in inventory)
  {
    if (item is ISaveable) // // if the objects in the inventory and heap implements ISaveable,
    {
      saveables..Add(item as iSaveable);
    }
  }

  ProductRepository.SaveToFIle(saveables);

  Console.ReadLine();
  ShowMainMenu();
}
```
