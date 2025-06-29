using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace delegateEvents
{
    public class Product
    {
        private string name = string.Empty;
        private string? description;

        private int maxItemsInStock = 0;

        public int Id { get; private set; }

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

        public Price Price { get; set; }

        public Product(int id) : this(id, string.Empty)
        {
        }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Product(int id, string name, string? description, Price price, UnitType unitType, int maxAmountInStock)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            UnitType = unitType;

            maxItemsInStock = maxAmountInStock;

            UpdateLowStock();
        }

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


        public void IncreaseStock()
        {
            AmountInStock++;
        }

        public void IncreaseStock(int amount)
        {
            int newStock = AmountInStock + amount;

            if (newStock <= maxItemsInStock)
            {
                AmountInStock += amount;
            }
            else
            {
                AmountInStock = maxItemsInStock;
                Log($"{CreateSimpleProductRepresentation} stock overflow. {newStock - AmountInStock} items(s) ordered that couldn't be stored.");
            }
            if (AmountInStock > 10)
            {
                IsBelowStockThreshold = false;
            }
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
            return $"{Id}. {Name} \n{AmountInStock} items in stock";
        }

        public string DisplayDetailsLong()
        {
            // StringBuilder sb = new();
            // //ToDo: add price here too
            // sb.Append($"{Id} {name} \n{description}\n{AmountInStock} item(s) in stock");
            //
            // if (IsBelowStockTreshold)
            // {
            //     sb.Append("\n!!STOCK LOW!!");
            // }

            // return sb.ToString();
            return DisplayDetailsLong("");
        }

        public string DisplayDetailsLong(string extraDetails)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Id} {Name} \n{Description}\n{Price}\n{AmountInStock} item(s) in stock");
            sb.Append(extraDetails);
            if (IsBelowStockThreshold)
            {
                sb.Append("\n!!STOCK LOW!!");
            }
            return sb.ToString();
        }

        private void UpdateLowStock()
        {
            if (AmountInStock < 10)
            {
                IsBelowStockThreshold = true;
            }
        }

        private void Log(string message)
        {
            Console.WriteLine(message);
        }

        private string CreateSimpleProductRepresentation()
        {
            return $"Product {Id} ({name}";
        }
    }
}
