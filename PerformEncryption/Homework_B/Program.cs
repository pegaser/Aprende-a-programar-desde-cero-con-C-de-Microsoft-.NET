using System;
using System.Security.Cryptography;
using System.Text;

namespace Homework_B
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte[] encryptedData = File.ReadAllBytes(..
            string containerName = "SecretContainer";
            CspParameters csp = new CspParameters() { KeyContainerName = containerName };
            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                decryptedData = RSA.Decrypt(encryptedData, false);
            }

            UnicodeEncoding TextConverter = new UnicodeEncoding();
            //TextConverter.GetString(...
        }
    }
}
