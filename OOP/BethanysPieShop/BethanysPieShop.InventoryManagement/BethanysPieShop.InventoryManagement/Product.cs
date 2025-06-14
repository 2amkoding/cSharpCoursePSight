namespace BethanysPieShop.InventoryManagement;

public class Product
{
   private int id;
   private string name = string.Empty; // default value 
   private string? description; // nullable

   private int maxItemsInStock = 0;
   
   private int amountInStock = 0;
   private bool isBelowStockThreshold = false;
  
   public void UseProduct(int items)
   {
      if (items <= AmountInStock)
      {
         //use the items
         AmountInStock -= items;

         UpdateLowStock();

         Log($"Amount in stock updated. Now {AmountInStock} items in stock.");
      }
      else
      {
         Log($"Not enough items on stock for {CreateSimpleProductRepresentation()}. {AmountInStock} available but {items} requested.");
      }
   }

   public void IncreaseStock()
   {
      AmountInStock++;
   }
   
}
private void DecreaseStock(int items, string reason)
{
   if (items <= AmountInStock)
   {
      //decrease the stock with the specified number items
      AmountInStock -= items;
   }
   else
   {
      AmountInStock = 0;
   }

   UpdateLowStock();

   Log(reason);
}
public string DisplayDetailsShort()
{
   return $"{Id}. {Name} \n{AmountInStock} items in stock";
}

public string DisplayDetailsFull()
{
   StringBuilder sb = new StringBuilder();

   sb.Append($"{Id} {Name} \n{Description}\n{AmountInStock} item(s) in stock");

   if (IsBelowStockTreshold)
   {
      sb.Append("\n!!STOCK LOW!!");
 

      private void UpdateLowStock()
      {
         if (AmountInStock < 10)//for now a fixed value
         {
            IsBelowStockTreshold = true;
         }
      }

      private void Log(string message)
      {
         //this could be written to a file
         Console.WriteLine(message);
      }

      private string CreateSimpleProductRepresentation()
      {
         return $"Product {Id} ({Name})";
      }


   } 
}