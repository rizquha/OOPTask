using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace cartGenerator
{
    public class cartGenerate
    {
        private List<carts> mycarts = new List<carts>();
        public cartGenerate addItem(int price, int quantity = 1)
        {
            mycarts.Add(new carts(mycarts.Count + 1, price, quantity));
            return this;
        }
        public cartGenerate removeItem(int id)
        {
            mycarts.RemoveAll(u => u.id == id);
            return this;
        }
        public cartGenerate addDiscount(string disc)
        {
            discount = (double)Decimal.Parse(disc.Remove(disc.Length-1))/100; 
            return this;  
        }
        public int totalItems()
        {
            int total = mycarts.Count();
            return total;
        }
        public int totalQuantity()
        {
            int totalquantity = mycarts.Sum(u => u.quantity);
            return totalquantity;
        }
        public int totalPrice()
        {
            int totalPrice = mycarts.Sum(u => u.quantity*u.price);
            return totalPrice;
        }
        // public List<carts> showAll()
        // {
        //     foreach(int item in mycarts)
        //     {
        //         Console.WriteLine("item_id : "+item.id+"price : "+item.price+"quantity : "+item.quantity);
        //         Console.WriteLine("\n");
        //     }
        //     return mycarts;
        // }

        // public checkout()
        // {
        //     string path = Path.Combine(Environment.CurrentDirectory, $"Purchase {DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}.txt");
        //     if (!System.IO.File.Exists(path))
        //     {
        //         using (StreamWriter fs = File.CreateText(path))
        //         {
        //             fs.WriteLine("[Checkout Belanjaan]\n");
        //             foreach (var cart in mycarts)
        //             {
        //                 fs.WriteLine($"Purchase ID : {cart.purchase_id}\tPrice : {cart.price}\tQuantity : {cart.quantity} =>\t{cart.price*cart.quantity}");
        //             }
        //             fs.WriteLine($"\nTotal Belanjaan : \t\t\t\t{totalPrice()}");
        //         }
        //     }
        // }

    }
    class carts
    {
            public int id{ get; set;}
            public int price{get ;set ;}
            public int quantity{get; set;}
            public carts(int id, int price, int quantity)
            {
                this.id = id;
                this.price = price;
                this.quantity = quantity;
            }
    }

}
