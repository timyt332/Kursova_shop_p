using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursovoi
{
    /*public struct Product
    {
        private string name;
        private int quantity;
        private decimal price;
        public string Name
        {
            get => name;
            set
            {
                if (value == null) name = "Страва";
                else name = value;
            }
        }
        public int Quantity
        {
            get => quantity;
            set
            {
                if (value <= 0) quantity = 1;
                else quantity = value;
            }
        }
        public decimal Price
        {
            get => price;
            set
            {
                if (value <= 0) price = 1;
                else price = value;
            }
        }
        public Product(string name, int quantity, decimal price)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Страва: {Name}, Кількість: {Quantity}, Ціна: {Price:C}";
        }
    }*/
    public struct Product
    {
        public int name;
        public int quantity;
        public decimal price;
        public Product(int name)
        {
            this.name = name;
            this.quantity = 1;
            this.price = 1;
        }
        public Product(int name, int quantity, decimal price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

    }
    public static class cor
    {
        public static int id;
        private static List<Product> products = new List<Product>();

        public static List<Product> Products { get => products; set => products = value; }
    }
}
    

