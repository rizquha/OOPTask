using System;
using cartGenerator;
using System.Collections.Generic; // untuk nambah List
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            cartGenerate cart = new cartGenerate();
            cart.addItem(30000,3)
            .addItem(100000)
            .addItem(5000,2)
            .removeItem(2)
            .addItem(400,6)
            .addDiscount("50%");
            Console.WriteLine("Total Item : "+cart.totalItems());
            Console.WriteLine("Total Quantity : "+cart.totalQuantity());
            Console.WriteLine("Total Price : "+cart.totalPrice());
            cart.showAll();
            cart.checkout();
        }
    }
}
