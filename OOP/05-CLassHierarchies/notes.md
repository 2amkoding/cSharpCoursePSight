# Overview

- Adding inheritance
- Working with polymorphism
- Exploring sealed and abstract classes
- Using extension methods

## Adding Inheritance

```
Product(parent class)
└── Boxed Product(child class) issa Product
└──   Fresh Boxed Product(child class) issa Boxed Product
```

C#: Can be multi-levels, but a class can have only 1 direct parent

```c#
public class Product
{
  public void UseProduct(int items){}
}

public class BoxedProduct : Product
{
  private int AmountInBox;
  public void UseBoxedProduct(int items){}

  get { return amountPerBox; }
  set { amountPerBox = value; }

  //constructor
}
```

### Inheritance and Constructor flow

Product bbl = new BoxedProduct(); \n
constructor flow: loads Product constructor -> then Boxed Product constructor
