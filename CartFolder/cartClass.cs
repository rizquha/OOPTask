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
        public double discount;
        private List<carts> mycarts = new List<carts>();

        private StringBuilder _addFile = new StringBuilder();
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
            _addFile.Append("Total Item :" +" "+total + "\n");
            return total;
        }
        public int totalQuantity()
        {
            int totalquantity = mycarts.Sum(u => u.quantity);
            _addFile.Append("Total Quantity :" +" "+totalquantity + "\n");
            return totalquantity;
        }
        public double totalPrice()
        {
            
            double totalPrice = mycarts.Sum(u => u.quantity*u.price);
            totalPrice -= totalPrice * discount;
            _addFile.Append("Total Price :" +" "+totalPrice + "\n");
            return totalPrice;
        }
        public void showAll()
        {
            _addFile.Append("ITEM" + "  " + " PRICE" + "  " + "QUANTITY" + "\n");
            foreach(var i in mycarts)
            {
                carts mycarts = (carts)i;
                Console.WriteLine("{0}    {1}    {2}", mycarts.id,mycarts.price, mycarts.quantity);
                string items = Convert.ToString(mycarts.id);
                string quan = Convert.ToString(mycarts.quantity);
                string price = Convert.ToString(mycarts.price);
                _addFile.Append(items + "      " + price + "    " + quan + "\n");
            }
        }

        public void checkout()
        {
            string path = Path.Combine(Environment.CurrentDirectory, $"Purchase {DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}.txt");
            if (!System.IO.File.Exists(path))
            {
                using (StreamWriter fs = File.CreateText(path))
                {
                    string _filePath = "D://";
                    string fileName ="Cart.txt";
                    File.Delete(fileName);

                    File.AppendAllText(_filePath+fileName, _addFile.ToString());
                    _addFile.Clear();      
                }
            }
        }

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
