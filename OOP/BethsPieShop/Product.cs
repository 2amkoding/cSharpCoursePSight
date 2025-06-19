using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace delegateEvents
{
    public class Product
    {
        private int id;
        private string name = string.Empty;
        private string? description;

        private int maxItemsInStock = 0;

        private UnitType unitType;
        private int amountInStock = 0;
        private bool isBelowStockThreshold = false;

        public void UseProduct(int items)
        {
            if (items <= amountInStock)
            {
                amountInStock -= items;
                UpdateLowStock();
                Log($"Amount in stock updated. Now {amountInStock} items in stock.");
            }
            else
            {
                Log($"Not enough items in stock for {CreateSimpleProductRepresentation()}. {amountInStock} available but {items} requested.");
            }
        }

        //price (come back to) 

        public void IncreaseStock()
        {
            amountInStock++;
        }

        private void DecreaseStock(int items, string reason)
        {
            if (items <= amountInStock)
            {
                amountInStock -= items;
            }
            else
            {
                amountInStock = 0;
            }

            updateStock();
            log(reason);
        }

        public string DisplayDetailsShort()
        {
            return $"{id}. {name} \n{amountInStock} items in stock";
        }

        public string DisplayDetailsLong()
        {
            StringBuilder sb = new();
            //ToDo: add price here too
            sb.Append($"{id} {name} \n{description}\n{amountInStock} item(s) in stock");

            if (isBelowStockTreshold)
            {
                sb.Append("\n!!STOCK LOW!!");
            }

            return sb.ToString();
        }

        public void UpdateLowStock()
        {
            if (amountInStock < 10)
            {
                isBelowStockThreshold = true;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public string CreateSimpleProductRepresentation()
        {
            return $"Product {id} ({name}";
        }
    }
}
