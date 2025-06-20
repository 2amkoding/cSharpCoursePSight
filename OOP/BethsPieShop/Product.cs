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

        public int Id { get; set; }

        public string Name
        {
            get => name;
            set => name = value.Length > 50 ? value[..50] : value;
        }

        public string? Description
        {
            get => description;
            set
            {
                if (value == null)
                {
                    description = string.Empty;
                }
                else
                {
                    description = value.Length > 250 ? value[..250] : value;
                }

            }
        }

        public UnitType UnitType { get; set; }
        public int AmountInStock { get; private set; }
        public bool IsBelowStockThreshold { get; private set; }

        public void UseProduct(int items)
        {
            if (items <= AmountInStock)
            {
                AmountInStock -= items;
                UpdateLowStock();
                Log($"Amount in stock updated. Now {AmountInStock} items in stock.");
            }
            else
            {
                Log($"Not enough items in stock for {CreateSimpleProductRepresentation()}. {AmountInStock} available but {items} requested.");
            }
        }

        //price (come back to) 

        public void IncreaseStock()
        {
            AmountInStock++;
        }

        private void DecreaseStock(int items, string reason)
        {
            if (items <= AmountInStock)
            {
                AmountInStock -= items;
            }
            else
            {
                AmountInStock = 0;
            }

            updateStock();
            log(reason);
        }

        public string DisplayDetailsShort()
        {
            return $"{id}. {name} \n{AmountInStock} items in stock";
        }

        public string DisplayDetailsLong()
        {
            StringBuilder sb = new();
            //ToDo: add price here too
            sb.Append($"{id} {name} \n{description}\n{AmountInStock} item(s) in stock");

            if (IsBelowStockTreshold)
            {
                sb.Append("\n!!STOCK LOW!!");
            }

            return sb.ToString();
        }

        public void UpdateLowStock()
        {
            if (AmountInStock < 10)
            {
                IsBelowStockThreshold = true;
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
