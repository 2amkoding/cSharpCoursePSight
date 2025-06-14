namespace BethanysPieShop.InventoryManagement;

public class Product
{
   private int id;
   private string name = string.Empty; // default value 
   private string? description; // nullable

   private int maxItemsInStock = 0;
   
   private int amountInStock = 0;
   private bool isBelowStockThreshold = false;
   
}