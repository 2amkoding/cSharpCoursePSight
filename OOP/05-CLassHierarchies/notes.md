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

Product bbl = new BoxedProduct();  
constructor flow: loads Product constructor -> then Boxed Product constructor

Everything is an object

```
System.Object/
Product
└── BoxedProduct (has access to toString method, inherited from System.Object)
```

### Polymorphism

- Allow treating objects of derived class as a _base class_ object
  - customize an inherited method for a derived class
  - keywords: _virtual_, _override_
- Method Overloading (compile time Polymorphism)

#### Array of Products

- Implicit conversion
  Since boxedProduct issa Product, we can add all-types of Product into an Array.

#### Looping over an array of Product _References_

```
Product: virtual UseProduct()/
└── BoxedProduct: override UseProduct()
└── FreshProduct
```

```c#
Product product = new BoxedProduct();
product.UseBoxedProduct(); //error

public void SaveProduct(Product p)
{
  BoxedProduct bp = (BoxedProduct)p; // explicit cast :(
  if (p is BoxedProduct)
  {

  }
}

public static void SaveProduct(Product p)
{
  BoxedProduct? bp = p as BoxedProduct;
  if(bp != null)
  {

  }
}

public static void SaveProduct(object o)
{
  string p = o.ToString();
  // available methods restricted to from System.Object
}
```

### Exploring Abstract and Sealed classes

Abstract Class cant be instantiated but inherited  
Can define abstract methods, wo implementation  
Child classes can be abstract or instantiated

Making a Class _sealed_  
 Inheriting isn't allowed  
 Useful if creating libraries that you want to protect

### Extention Methods

Allows to "add" methods on any type, even part of .NET or sealed  
Must be static inside a static class and requires use of this  
Type is the type that will be extended

```c#
public sealed class Product
{

}

public static class ProductExtensions
{
  public static double RemoveProduct(this Product product)
  {

  }
}
```
