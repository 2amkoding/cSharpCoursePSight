# Overview

- working with objects
- adding static memebrs
- exploring the interface
- writing unit tests

### working with objects

```c#
//<Variable type><VariableName> = mew <Class>(arg1, arg2)
Product product = new Product(123, "coffee")

product.UserProduct(); //invoke methods
product.Name = "cafe sua da" // change property
int number = product.UpdateStock(); // return a value from a method
```

objName = new object

- objName -> stack
- object -> heap
- reference _points_ to object
- pointers.. nice

New shorthand Syntax:

```c#
Product product = new (123);
```

### Constructor Chaining

```c#
public class Product
{
  public int Id { get; set;}
  public string Name { get; set; }
  public string Category { get; set; }

  public Product() : this(0, "unkown product", "general"){}
  public Product(int id) : this(id, "uknown proudct", "general")
  public Product(int id, string name) : this(id, name, "general")

  public Product(int id, string name, string category)
  {
    this.Id = id;
    this.Name = name;
    this.Category = category;
  }
}
```

```
new Product(1);

Product(1)
└── calls this(1, "unknown product", "general")
Product(1, "unkown product", "general")
└── this.Id = 1
└── this.Name = "unkown product"
└── this.Category = "general"
```

### Object Initialization

```c#
public class Product
{
  public int Id { get; set; }
  public string Name { get; set; }

  public Product(){}

}

---
Product p = new(){ Name = "eggs", Id= "1" }
```
