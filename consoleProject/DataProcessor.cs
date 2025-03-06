using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace consoleProject
{
    abstract class DataProcessor
    {
        public void Process(string filePath)
        {
            string rawData = ReadData(filePath);
            var data = ParseData(rawData);
            SaveData(data);
        }

        protected abstract string ReadData(string filePath);
        protected abstract List<Dictionary<string, string>> ParseData(string rawData);

        protected void SaveData(List<Dictionary<string, string>> data)
        {
            Console.WriteLine("Saving data...");
            foreach (var record in data)
            {
                Console.WriteLine(string.Join(", ", record));
            }
        }
    }

    class CsvProcessor : DataProcessor
    {
        protected override string ReadData(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        protected override List<Dictionary<string, string>> ParseData(string rawData)
        {
            var data = new List<Dictionary<string, string>>();
            var lines = rawData.Split('\n');
            if (lines.Length < 2) return data;

            var headers = lines[0].Trim().Split(',');

            for (int i = 1; i < lines.Length; i++)
            {
                var values = lines[i].Trim().Split(',');
                if (values.Length != headers.Length) continue;

                var record = new Dictionary<string, string>();
                for (int j = 0; j < headers.Length; j++)
                {
                    record[headers[j]] = values[j];
                }
                data.Add(record);
            }

            return data;
        }
    }

    class XmlProcessor : DataProcessor
    {
        protected override string ReadData(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        protected override List<Dictionary<string, string>> ParseData(string rawData)
        {
            var data = new List<Dictionary<string, string>>();
            var xDoc = XDocument.Parse(rawData);

            foreach (var element in xDoc.Root.Elements("Record"))
            {
                var record = new Dictionary<string, string>();
                foreach (var field in element.Elements())
                {
                    record[field.Name.LocalName] = field.Value;
                }
                data.Add(record);
            }

            return data;
        }
    }

    class JsonProcessor : DataProcessor
    {
        protected override string ReadData(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        protected override List<Dictionary<string, string>> ParseData(string rawData)
        {
            return JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(rawData);
        }
    }
}
