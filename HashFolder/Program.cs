using System;
using System.Security.Cryptography;
using System.Text;

namespace Hash
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "secret";
            using (MD5 md5Hash = MD5.Create())
            {
                string hashMD5 = GetMd5Hash(md5Hash, key);
                Console.WriteLine("MD5 :"+hashMD5);
            }
            using (SHA1 sha1Hash = SHA1.Create())
            {
                string hashSha1 = GetSha1Hash(sha1Hash,key);
                Console.WriteLine("Sha1 :"+hashSha1);
            }

            using (SHA256 sha256Hash = SHA256.Create())  
            {  
               string hashSha256 = GetSha256Hash(sha256Hash,key); 
               Console.WriteLine("Sha256 :"+hashSha256);
            } 

            using (SHA512 sha512Hash = SHA512.Create())
            {
                string hashSha512 = GetSha512Hash(sha512Hash,key);
                Console.WriteLine("Sha512 :"+hashSha512);
            }

        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }
            return sb.ToString();
        }
        static string GetSha1Hash(SHA1 sha1Hash, string input)
        {
            var hash = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sb = new StringBuilder(hash.Length * 2);
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("X2"));
            }
            var getsha1 = sb.ToString();
            return getsha1.ToLower();
        }
        
        static string GetSha256Hash(SHA256 sha256Hash, string input)
        {
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));  
            StringBuilder sb = new StringBuilder();  
            for (int i = 0; i < bytes.Length; i++)  
            {  
                sb.Append(bytes[i].ToString("x2"));  
            }  
            return sb.ToString();  
        }

        static string GetSha512Hash(SHA512 sha512Hash, string input)
        {
            var hashedInputBytes = sha512Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            var hashedInputStringBuilder = new System.Text.StringBuilder(128);
            foreach (var b in hashedInputBytes)
            hashedInputStringBuilder.Append(b.ToString("X2"));
            var gethash512 = hashedInputStringBuilder.ToString();
            return gethash512.ToLower();
        }
    }
}



