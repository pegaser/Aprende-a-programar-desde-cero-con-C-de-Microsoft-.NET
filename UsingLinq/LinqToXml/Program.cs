using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LinqToXml
{
    class Program
    {
        static void Main(string[] args)
        {
            String xml = @"<?xml version=""1.0"" encoding=""utf-8"" ?>
                    <people>
                      <person firstname=""Sergio"" lastname=""Pérez"">
                        <contactdetails>
                          <emailaddress>sergio@unknown.com</emailaddress>
                        </contactdetails>
                      </person>
                      <person firstname=""Alejandra"" lastname=""García"">
                        <contactdetails>
                          <emailaddress>alex@unknown.com</emailaddress>
                          <phonenumber>001122334455</phonenumber>
                        </contactdetails>
                      </person>
                    </people>";
            Console.WriteLine(xml);
            Console.ReadKey();

            XDocument doc = XDocument.Parse(xml);
            IEnumerable<string> personNames = from p in doc.Descendants("person")
                                              select (string)p.Attribute("firstname") + " " + (string)p.Attribute("lastname");
            foreach (string s in personNames)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();


            doc = XDocument.Parse(xml);
            personNames = from p in doc.Descendants("person")
                            where p.Descendants("phonenumber").Any()
                            let name = (string)p.Attribute("firstname") + " " + (string)p.Attribute("lastname")
                            orderby name
                            select name;
            foreach (string s in personNames)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();


            XElement root = new XElement("Root",
            new List<XElement>
            {
                new XElement("Child1"),
                new XElement("Child2"),
                new XElement("Child3")
            },
            new XAttribute("MyAttribute", 42));
            root.Save("test.xml");
            Console.WriteLine("Se creo archivo test.xml");
            Console.ReadKey();

            root = XElement.Parse(xml);
            foreach (XElement p in root.Descendants("person"))
            {
                string name = (string)p.Attribute("firstname") + (string)p.Attribute("lastname");
                p.Add(new XAttribute("IsMale", name.Contains("Sergio")));
                XElement contactDetails = p.Element("contactdetails");
                if (!contactDetails.Descendants("phonenumber").Any())
                {
                    contactDetails.Add(new XElement("phonenumber", "001122334455"));
                }
            }
            root.Save("test.xml");
            Console.WriteLine("Se modificó XML con código de procedimiento y se guardó en archivo test.xml");
            Console.ReadKey();


            root = XElement.Parse(xml);
            XElement newTree = new XElement
            (
                "people",
                from p in root.Descendants("person")
                let name = (string)p.Attribute("firstname") + (string)p.Attribute("lastname")
                let contactDetails = p.Element("contactdetails")
                select new XElement
                (
                    "person", new XAttribute("IsMale", name.Contains("Sergio")),
                    p.Attributes(),
                    new XElement
                    (
                        "ContactDetails", contactDetails.Element("emailaddress"), contactDetails.Element("phonenumber") ?? new XElement("phonepumber", "112233455")
                    )
                )
            );
            newTree.Save("test.xml");
            Console.WriteLine("Se modificó XML con Construcción Funcional y se guardó en archivo test.xml");
            Console.ReadKey();
        }
    }
}
