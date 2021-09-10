using System;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ConsumingJson
{
    class Program
    {
        static void Main(string[] args)
        {
            using (JsonDocument document = JsonDocument.Parse(File.ReadAllText("People.json")))
            {
                JsonElement root = document.RootElement;
                JsonElement peopleElement = root.GetProperty("People");
                JsonElement personElement = peopleElement.GetProperty("Person");
                foreach (JsonElement person in personElement.EnumerateArray())
                {
                    if (person.TryGetProperty("firstName", out JsonElement firstNameElement))
                    {
                        Console.WriteLine($"Primer nombre: {firstNameElement}");
                    }
                    if (person.TryGetProperty("lastName", out JsonElement secondNameElement))
                    {
                        Console.WriteLine($"Apellido: {secondNameElement}");
                    }
                }
                Console.ReadKey();

            }
            
            
            var options = new JsonWriterOptions
            {
                Indented = true
            };

            using var stream = new MemoryStream();
            using var writer = new Utf8JsonWriter(stream, options);

            writer.WriteStartObject();
            writer.WriteStartArray("Person");
            writer.WriteStartObject();
            writer.WriteString("firstName", "Sergio");
            writer.WriteString("firstName", "Perez");
            writer.WriteEndObject();
            writer.WriteStartObject();
            writer.WriteString("firstName", "Jose");
            writer.WriteString("firstName", "Garcia");
            writer.WriteEndObject();
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Flush();

            string json = Encoding.UTF8.GetString(stream.ToArray());
            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
