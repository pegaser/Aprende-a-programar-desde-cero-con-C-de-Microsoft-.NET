using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ManagingCertificates
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToSign = "Test paragraph";
            byte[] signature = Sign(textToSign, "cn = SergioPerez");
            // Uncomment this line to make the verification step fail
            signature[0] = 0;
            Console.WriteLine(Verify(textToSign, signature));
            Console.Read();
        }
        static byte[] Sign(string text, string certSubject)
        {
            X509Certificate2 cert = GetCertificate();
            var csp = cert.GetRSAPrivateKey();
            byte[] hash = HashData(text);
            return csp.SignHash(hash, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
        }
        static bool Verify(string text, byte[] signature)
        {
            X509Certificate2 cert = GetCertificate();
            var csp = cert.GetRSAPublicKey();
            byte[] hash = HashData(text);
            return csp.VerifyHash(hash, signature, HashAlgorithmName.SHA1, RSASignaturePadding.Pkcs1);
        }
        private static byte[] HashData(string text)
        {
            HashAlgorithm hashAlgorithm = new SHA1Managed();
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] data = encoding.GetBytes(text);
            byte[] hash = hashAlgorithm.ComputeHash(data);
            return hash;
        }
        private static X509Certificate2 GetCertificate()
        {
            X509Store my = new X509Store("testCertStore", StoreLocation.CurrentUser);
            my.Open(OpenFlags.ReadOnly);
            var certificate = my.Certificates[0];
            return certificate;
        }
    }
}

