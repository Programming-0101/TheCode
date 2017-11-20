using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.O.Examples
{
    public class PhoneNumberFileAdapter
    {
        #region Read from a file
        public static List<PhoneNumber> LoadList(string filePath, FileFormat format)
        {
            List<PhoneNumber> data;
            if (format == FileFormat.CSV)
                data = LoadList(new CSVFileIO(filePath));
            else
                data = LoadList(new XMLFileIO<PhoneNumber>(filePath));
            return data;
        }

        private static List<PhoneNumber> LoadList(CSVFileIO reader)
        {
            List<PhoneNumber> data = new List<PhoneNumber>();
            List<string> lines = reader.ReadAllLines();
            foreach (string individualLine in lines)
            {
                // code specifics here..
                string[] fields = individualLine.Split(',');
                string firstName = fields[0], lastName = fields[1], number = fields[2];
                data.Add(new PhoneNumber(firstName, lastName, number));
            }
            return data;
        }

        private static List<PhoneNumber> LoadList(XMLFileIO<PhoneNumber> reader)
        {
            return reader.LoadAll();
        }
        #endregion

        #region Write to a file
        public static void SaveList(List<PhoneNumber> data, string fileName, FileFormat format, bool append)
        {
            if (format == FileFormat.CSV)
                SaveList(new CSVFileIO(fileName), data, append);
            else
                SaveList(new XMLFileIO<PhoneNumber>(fileName), data, append);
        }

        private static void SaveList(CSVFileIO writer, List<PhoneNumber> data, bool append)
        {
            List<string> lines = new List<string>();
            foreach (PhoneNumber item in data)
            {
                lines.Add(item.FirstName + "," + item.LastName + "," + item.Number);
            }
            writer.WriteAllLines(lines, append);
        }

        private static void SaveList(XMLFileIO<PhoneNumber> writer, List<PhoneNumber> data, bool append)
        {
            writer.SaveAll(data, append);
        }
        #endregion
    }

    public class PhoneNumber
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public PhoneNumber(string firstName, string lastName, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            Number = number;
        }
    }
}
