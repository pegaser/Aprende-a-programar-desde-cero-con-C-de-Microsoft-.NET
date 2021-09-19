using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Homework_A_Resoved
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porporcione texto a cifrar");
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] dataToEncrypt = ByteConverter.GetBytes(Console.ReadLine());
            string containerName = "SecretContainer";
            CspParameters csp = new CspParameters() { KeyContainerName = containerName };
            byte[] encryptedData2;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                encryptedData2 = RSA.Encrypt(dataToEncrypt, false);
            }
            File.WriteAllBytes(@"c:\\temp\CipherText.txt", encryptedData2);
        }
    }
}
