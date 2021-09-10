using System;
using System.IO;
using System.Xml;
using System.Xml.XPath;

namespace ConsumingXml
{
    class Program
    {
        static void Main(string[] args)
        {
            using (XmlReader xmlReader = XmlReader.Create("people.xml", new XmlReaderSettings() { IgnoreWhitespace = true }))
            {
                xmlReader.MoveToContent();
                xmlReader.ReadStartElement("people");
                string firstName = xmlReader.GetAttribute("firstName");
                string lastName = xmlReader.GetAttribute("lastName");
                Console.WriteLine($"person: {firstName} {lastName}");

                xmlReader.ReadStartElement("person");
                Console.WriteLine("Contact Details:");
                xmlReader.ReadStartElement("contactdetails");

                string emailAddress = xmlReader.ReadString();
                Console.WriteLine($"Email address: {emailAddress}");
            }
            Console.ReadKey();

            StringWriter stream = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stream, new XmlWriterSettings() { Indent = true }))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("People");
                writer.WriteStartElement("Person");
                writer.WriteAttributeString("firstName", "Alejandro");
                writer.WriteAttributeString("lastName", "García");
                writer.WriteStartElement("ContactDetails");
                writer.WriteElementString("EmailAddress", "alex@unknown.com");
                writer.WriteEndElement();
                writer.WriteEndElement();
                writer.Flush();
            }
            Console.WriteLine(stream.ToString());
            Console.ReadKey();


            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText("people.xml"));
            XmlNodeList nodes = doc.GetElementsByTagName("Person");
            // Output the names of the people in the document
            foreach (XmlNode node in nodes)
            {
                string firstName = node.Attributes["firstName"].Value;
                string lastName = node.Attributes["lastName"].Value;
                Console.WriteLine($"Name: {firstName} {lastName}");
            }
            // Start creating a new node
            XmlNode newNode = doc.CreateNode(XmlNodeType.Element, "person", "");
            XmlAttribute firstNameAttribute = doc.CreateAttribute("firstName");
            firstNameAttribute.Value = "Foo";
            XmlAttribute lastNameAttribute = doc.CreateAttribute("lastName");
            lastNameAttribute.Value = "Bar";
            newNode.Attributes.Append(firstNameAttribute);
            newNode.Attributes.Append(lastNameAttribute);
            doc.DocumentElement.AppendChild(newNode);
            Console.WriteLine("Modified xml...");
            doc.Save(Console.Out);
            Console.ReadKey();


            XmlDocument doc = new XmlDocument();
            doc.LoadXml(File.ReadAllText("people.xml"));
            XPathNavigator nav = doc.CreateNavigator();
            string query = "//people/person[@firstName='Sergio']";
            XPathNodeIterator iterator = nav.Select(query);
            Console.WriteLine(iterator.Count);
            while (iterator.MoveNext())
            {
                string firstName = iterator.Current.GetAttribute("firstName", "");
                string lastName = iterator.Current.GetAttribute("lastName", "");
                Console.WriteLine($"Name: {firstName} {lastName}");
            }
            Console.ReadKey();
        }
    }
}
