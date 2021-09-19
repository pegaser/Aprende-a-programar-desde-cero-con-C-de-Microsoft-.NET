using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Homework_B_Resolved
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presiona una tecla para comenzar decifrado.");
            Console.ReadKey();
            byte[] encryptedData = File.ReadAllBytes(@"c:\\temp\CipherText.txt");
            string containerName = "SecretContainer";
            CspParameters csp = new CspParameters() { KeyContainerName = containerName };
            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                decryptedData = RSA.Decrypt(encryptedData, false);
            }
            UnicodeEncoding TextConverter = new UnicodeEncoding();
            Console.WriteLine(TextConverter.GetString(decryptedData));
            Console.ReadKey();
        }
    }
}
