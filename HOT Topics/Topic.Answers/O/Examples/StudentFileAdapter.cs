﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Topic.O.Examples
{
    public class StudentFileAdapter
    {
        #region Read from a file
        public static List<Student> LoadList(string filePath, FileFormat format)
        {
            List<Student> data;
            if (format == FileFormat.CSV)
                data = LoadList(new CSVFileIO(filePath));
            else
                data = LoadList(new XMLFileIO<Student>(filePath));
            return data;
        }

        private static List<Student> LoadList(CSVFileIO reader)
        {
            List<Student> data = new List<Student>();
            List<string> lines = reader.ReadAllLines();
            foreach (string individualLine in lines)
            {
                // code specifics here..
                string[] fields = individualLine.Split(',');
                int id = System.Convert.ToInt32(fields[0]);
                string name = fields[1];
                GenderType gender = (GenderType)System.Enum.Parse(typeof(GenderType), fields[2]);
                data.Add(new Student(name, gender, id));
            }
            return data;
        }

        private static List<Student> LoadList(XMLFileIO<Student> reader)
        {
            return reader.LoadAll();
        }
        #endregion

        #region Write to a file
        public static void SaveList(List<Student> data, string fileName, FileFormat format, bool append)
        {
            if (format == FileFormat.CSV)
                SaveList(new CSVFileIO(fileName), data, append);
            else
                SaveList(new XMLFileIO<Student>(fileName), data, append);
        }

        private static void SaveList(CSVFileIO writer, List<Student> data, bool append)
        {
            List<string> lines = new List<string>();
            foreach (Student item in data)
            {
                lines.Add(item.StudentId.ToString() + "," + item.Name + "," + item.Gender.ToString());
            }
            writer.WriteAllLines(lines, append);
        }

        private static void SaveList(XMLFileIO<Student> writer, List<Student> data, bool append)
        {
            writer.SaveAll(data, append);
        }
        #endregion
    }
    public enum GenderType
    {
        Male, Female
    }
    public class Student
    {
        public string Name { get; set; }
        public GenderType Gender { get; set; }
        public int StudentId { get; set; }
        public Student(string name, GenderType gender, int studentId)
        {
            Name = name;
            Gender = gender;
            StudentId = studentId;
        }
    }
}
