using System;
using System.Globalization;
using System.IO;
using System.Xml;

namespace UsingStringWriterAsOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();
            Console.Write(xml);
            Console.ReadLine();

            var stringReader = new StringReader(xml);
            using (XmlReader reader = XmlReader.Create(stringReader))
            {
                reader.ReadToFollowing("price");
                decimal price = decimal.Parse(reader.ReadInnerXml(), new CultureInfo("es-MX"));
                Console.Write($"price = {price}");
            }

            Console.Read();

        }
    }
}
