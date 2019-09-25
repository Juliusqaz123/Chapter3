using System;
using System.Security.Cryptography;
using System.Text;

namespace Chapter3
{
    static class Program
    {
        static void Main(string[] args)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes("My Secret Data!");

            string containerName = "SecretContainer";
            CspParameters csp = new CspParameters() { KeyContainerName = containerName };
            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                encryptedData = RSA.Encrypt(dataToEncrypt, false);
            }

            Console.WriteLine(encryptedData);
            Console.ReadLine();
        }
    }
}
