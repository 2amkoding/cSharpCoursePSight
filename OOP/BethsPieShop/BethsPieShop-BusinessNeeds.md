## Concept Goals

- Abstraction
- Enums
- Records
- interface
- Delegates
- CLI

## Business Needs

- An application for inventory management of ingredients
- Used by Inventory Managers in the warehouse
- Inventory updates when product is used
- some products are per item, kilo, perBox, etc
- Which products are "low on stock"
- Inventory Managers can create new orders
- Dollar, or pounds
- Storage Capacity dashboard
- Inventory Managers can add New Products

```mermaid
classDiagram

class Product{
   description
   id
   maxItemsInStock
   name
   AmountInStock
   description
   Id
   IsBelowStockTreshold
   Name
   Price
   UnitType
   CreateSimplkeProductRepresentation
   DecreaseStock
   DisplayDetailsFull(+1 overloaded)
   DisplayDetailsShort()
   IncreaseStock(+overloaded)
   Log()
   Product(+overloaded)
   UpdateLowStock()
   UseProduct()
  }

class Price{
  Currency
  ItemPRice
  ToString()
  }

class Order{
  Fulfilled
  Id
  OrderFufillment
  OrderItems
  Order()
  ShowOrderDet()
  }

class OrderItem{
  AmountOrdered
  Id
  ProductId
  ProductName
  ToString()
  }


class Currency{
<<enum>>
Dollar
Euro
Pound
}

class UnitType{
  <<enum>>
  PerItem
  PerBox
  PerKg
  }

Product --|> Price
Price --> Currency
Product --> UnitType
Order --|> OrderItem
```

```c#
public class Products{}

```
