using System;
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan string :");
            string str = Console.ReadLine();


            Console.WriteLine("Masukkan key untuk Encrypted :");
            string key_input = Console.ReadLine();
            int key = Convert.ToInt32(key_input);
            Password(str,key); 
            Console.WriteLine("\n");
        }

        public static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
		    return ch;
            char cek = char.IsUpper(ch) ? 'A' : 'a';  
            return (char)((((ch + key) - cek) % 26) + cek);
        }
        public static string Encrypted(string input, int key) {  
            string output = string.Empty;  
            foreach (char ch in input)
            {
		    output += Cipher(ch, key);
            }
	        return output;
        }  

        public static string Decrypted(string output, int key)
        {
            return Encrypted(output, 26-key);
        }
        public static int Password(string str, int key)
        {
            int pass =3;
            if(key == pass)
            {
                Console.WriteLine("Encrypted String :");
                string EncryptedCharText = Encrypted(str, key);  
                Console.WriteLine(EncryptedCharText);  
                Console.Write("\n");

                Console.WriteLine("Masukkan key untuk Decrypted :");
                int dec_input = Convert.ToInt32(Console.ReadLine());
                if(dec_input == pass)
                {
                    Console.WriteLine("Decrypted String :");
                    string DecryptedCharText = Decrypted(EncryptedCharText, key);  
                    Console.WriteLine(DecryptedCharText);  
                    Console.Write("\n");
                }  
                else
                {
                    Console.WriteLine("Password salah");
                }
            } else
            {
                Console.WriteLine("Password salah");
            }
            return pass;
        }

    }
}
