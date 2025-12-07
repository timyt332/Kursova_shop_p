using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovoi
{
    public class Product
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public Product(string name, int quantity, decimal price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

    }
    public static class cor
    {
        public static int id;
        //private static List<Product> products = new List<Product>();

        public static List<Tovare> Products = new List<Tovare>(); //{ get => products; set => products = value; }
    }
    public class kategoria
    {
        public int id { get; set; }
        public string name { get; set; }
        public kategoria(){}
        public kategoria( int id,string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    public class centures
    {
        public int id { get; set; }
        public string name { get; set; }
        public centures() { }
        public centures(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    public class Tovare
    {
        public int id { get ; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int kilkist { get; set; }
        public decimal summa{ get; set; }
        public Tovare() { }
        public Tovare(int id, string name, decimal price, int kilkist)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.kilkist = kilkist;
            this.summa = price* kilkist;
        }
    }
    public class spivrobitnik
    {
        public int id { get; set; }
        public string name { get; set; }
        public spivrobitnik() { }
        public spivrobitnik(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    public class postachalnik
    {
        public int id { get; set; }
        public string name { get; set; }
        public postachalnik() { }
        public postachalnik(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    public class prodag
    {
        public int id { get; set; }
        public string name { get; set; }
        public prodag() { }
        public prodag(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    public class spisok_prodag
    {
        public int id { get; set; }
        public string name { get; set; }
        public spisok_prodag() { }
        public spisok_prodag(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    public class nakladna
    {
        public int id { get; set; }
        public string name { get; set; }
        public nakladna() { }
        public nakladna(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    public class spisok_post
    {
        public int id { get; set; }
        public string name { get; set; }
        public spisok_post() { }
        public spisok_post(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
    //*/
}
    

